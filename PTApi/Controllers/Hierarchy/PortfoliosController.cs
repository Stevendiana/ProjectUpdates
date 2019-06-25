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

namespace ProjectCentreBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PortfoliosController: Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;

        public PortfoliosController(UserManager<ApplicationUser> userManager, IUserService userService,
            IMapper mapper, IGeneratePublicIdMethod getpublicId, IGetIdsWithPartIdsMethod getIdsWithPartIds, IUnitOfWork unitOfWork)
        {
            _getIdsWithPartIds = getIdsWithPartIds;
            _getpublicId = getpublicId;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }


        public string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }


        public class EditPortfolioData
        {
            public string PortfolioId { get; set; }
            [Required]
            public string PortfolioName { get; set; }

            public string CompanyId { get; set; }
            public string UniquePortfolioRef { get; set; }
            public string NodeId { get; set; }
            public string DomainId { get; set; }
            public string HeadOfPortfolio { get; set; }

        }



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var portfolioDb = _unitOfWork.Portfolios.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.Id == id));

            if(portfolioDb == null)
            return NotFound("Portfolio not found");

            var portfolioData = _mapper.Map<Portfolio, PortfolioViewModel>(portfolioDb);

            return Ok(portfolioData);
        }


        [HttpGet("{companyId}")]
        [Authorize(Policy="Admin_Group")]
        public async Task<IEnumerable<PortfolioViewModel>> GetPortfolios(string companyId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup=="Admin_Group")
            {
                if ( companyId == comp)
                {
                    var allPortfolios = _unitOfWork.Portfolios.GetAllPortfoliosWithProjectsWithProgrammeAndDomain(comp);

                    return allPortfolios.Select(Mapper.Map<Portfolio, PortfolioViewModel>);
                }
                return await Task.FromResult<IEnumerable<PortfolioViewModel>>(null);
            }
            return  await Task.FromResult<IEnumerable<PortfolioViewModel>>(null);
        }



        [HttpPost("portfolio")]
        [Authorize(Policy="Admin_Group")]
        public ActionResult Post([FromBody] EditPortfolioData portfolioData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (portfolioData.CompanyId != comp)
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
                var portfolio = _unitOfWork.Portfolios.GetOnePortfolio(portfolioData.PortfolioId, comp);

                if (portfolio == null)
                    return NotFound();

                _mapper.Map<EditPortfolioData, Portfolio>(portfolioData, portfolio);

                portfolio.CompanyId = comp;
                portfolio.PortfolioName = portfolioData.PortfolioName ?? portfolio.PortfolioName;
                portfolio.HeadOfPortfolio = portfolioData.HeadOfPortfolio ?? portfolio.HeadOfPortfolio;
                portfolio.DomainId = portfolioData.DomainId ?? portfolio.DomainId;
                portfolio.PortfolioCode = "PORT" + "-" + CreateNewId(portfolio.Id).ToUpper();

                _unitOfWork.Complete();

                portfolio = _unitOfWork.Portfolios.GetOnePortfolio(portfolio.Id, comp);

                var result = _mapper.Map<Portfolio, PortfolioViewModel>(portfolio);

                return Ok(result);
            }
            return BadRequest("You are not authorised to perform this action.");

        }



        [HttpPost]
        [Authorize(Policy="Admin_Group")]
        public IActionResult PostPortfolio( [FromBody] EditPortfolioData portfolioData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (portfolioData.CompanyId != comp)
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

                var portfolio = _mapper.Map<EditPortfolioData, Portfolio>(portfolioData);
                portfolio.CompanyId = comp;
                portfolio.Id = id;
                portfolio.PortfolioCode = "PORT" + "-" + CreateNewId(id).ToUpper();

                _unitOfWork.Portfolios.Add(portfolio);
                _unitOfWork.Complete();

                portfolio = _unitOfWork.Portfolios.GetOnePortfolio(id, comp);

                var results = _mapper.Map<Portfolio, EditPortfolioData>(portfolio);


                return Ok(results);
            }
            return BadRequest("You are not authorised to perform this action.");
        }


        [HttpDelete("{companyId}/{id}")]
        [Authorize(Policy="Admin_Group")]
        public IActionResult DeletePortfolio(string companyId, string id)
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
                var portfolio = _unitOfWork.Portfolios.GetOnePortfolio(id, comp);

                if (portfolio == null)
                return BadRequest("You are not authorised to perform this action.");

                _unitOfWork.Portfolios.Remove(portfolio);
                _unitOfWork.Complete();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }
    }
}