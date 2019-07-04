
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTApi.Data.Repositories;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Services;
using PTApi.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class DomainsController: Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IForecastService _forecastService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public DomainsController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IGetIdsWithPartIdsMethod getIdsWithPartIds,
            IGeneratePublicIdMethod getpublicId, IForecastService forecastService, IUserService userService, IProjectService projectService, IMapper mapper)
        {
            _userService = userService;
            _projectService = projectService;
            _forecastService = forecastService;
            _unitOfWork = unitOfWork;
            _getIdsWithPartIds = getIdsWithPartIds;
            _getpublicId = getpublicId;
            _userManager = userManager;
            _mapper = mapper;
        }
        




        public string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }


        public class EditDomainData
        {
            public string Id { get; set; }
            public string DomainCode { get; set; }
            public string DomainName { get; set; }
            [Required]
            public string CompanyId { get; set; }
            [Required]
            public string HeadOfDomainId { get; set; }
            
        }



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var domainDb = _unitOfWork.Domains.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.Id == id));

            if(domainDb == null)
            return NotFound("Business unit not found");

            var domainData = _mapper.Map<Domain, DomainViewModel>(domainDb);

            return Ok(domainData);
        }


        [HttpGet("{companyId}")]
        [Authorize(Policy="Admin_Group")]
        public async Task<IEnumerable<DomainViewModel>> GetDomains(string companyId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup=="Admin_Group")
            {
                if ( companyId == comp)
                {
                    var allDomains = _unitOfWork.Domains.GetAllDomainsOnly(comp);

                    return allDomains.Select(Mapper.Map<Domain, DomainViewModel>);
                }
                return await Task.FromResult<IEnumerable<DomainViewModel>>(null);
            }
            return  await Task.FromResult<IEnumerable<DomainViewModel>>(null);
        }



        [HttpPost("domain")]
        [Authorize(Policy="Admin_Group")]
        public ActionResult Post([FromBody] EditDomainData domainData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (domainData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup=="Admin_Group")
            {
                var companyId = comp;
                var domain = _unitOfWork.Domains.GetOneDomain(domainData.Id, comp);

                if (domain == null)
                    return NotFound();

                _mapper.Map<EditDomainData, Domain>(domainData, domain);

                domain.CompanyId = comp;
                domain.DomainName = domainData.DomainName ?? domain.DomainName;
                domain.HeadOfDomainId = domainData.HeadOfDomainId ?? domain.HeadOfDomainId;
                domain.DomainCode = "DOM" + "-" + CreateNewId(domain.Id).ToUpper();

                _unitOfWork.Complete();

                domain = _unitOfWork.Domains.GetOneDomain(domain.Id, comp);

                var result = _mapper.Map<Domain, DomainViewModel>(domain);

                return Ok(result);
            }
            return BadRequest("You are not authorised to perform this action.");

        }


        [HttpPost]
        [Authorize(Policy="Admin_Group")]
        public IActionResult PostDomain( [FromBody] EditDomainData domainData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (domainData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup=="Admin_Group")
            {
                var id = Guid.NewGuid().ToString();

                var domain = _mapper.Map<EditDomainData, Domain>(domainData);
                domain.CompanyId = comp;
                domain.Id = id;
                domain.DomainCode = "DOM" + "-" + CreateNewId(id).ToUpper();

                _unitOfWork.Domains.Add(domain);
                _unitOfWork.Complete();

                domain = _unitOfWork.Domains.GetOneDomain(id, comp);

                var results = _mapper.Map<Domain, EditDomainData>(domain);


                return Ok(results);
            }
            return BadRequest("You are not authorised to perform this action.");
        }


        [HttpDelete("{companyId}/{id}")]
        [Authorize(Policy="Admin_Group")]
        public IActionResult DeleteDomain(string companyId, string id)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup=="Admin_Group")
            {

                // var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
                var company = comp;
                var domain = _unitOfWork.Domains.GetOneDomain(id, comp);

                if (domain == null)
                return BadRequest("You are not authorised to perform this action.");

                _unitOfWork.Domains.Remove(domain);
                _unitOfWork.Complete();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }

    }
}