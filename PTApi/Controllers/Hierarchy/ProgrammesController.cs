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
    public class ProgrammesController: Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;

        public ProgrammesController(UserManager<ApplicationUser> userManager, IUserService userService,
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


        public class EditProgrammeData
        {
            public string ProgrammeId { get; set; }
            public string CompanyId { get; set; }
            public string UniqueProgrammeRef { get; set; }
            [Required]
            public string ProgrammeName { get; set; }
            public string ProgrammeLead { get; set; }
            public string NextYearIndicator { get; set; }
            public bool AuthorisedYesOrNo { get; set; }
            public string DeliveryDirector { get; set; }
            public string DeliveryManager { get; set; }
            public string ProgrammeManager { get; set; }
            public DateTime? ProgramStartDate { get; set; }
            public DateTime? ProgramEndDate { get; set; }
            public string NodeId { get; set; }
            public string Sponsor { get; set; }
            public string PortfolioId { get; set; }

        }



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var programmeDb = _unitOfWork.Programmes.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.Id == id));

            if(programmeDb == null)
            return NotFound("Business unit not found");

            var programmeData = _mapper.Map<Programme, ProgrammeViewModel>(programmeDb);

            return Ok(programmeData);
        }


        [HttpGet("{companyId}")]
        [Authorize(Policy="Admin_Group")]
        public async Task<IEnumerable<ProgrammeViewModel>> GetProgrammes(string companyId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup=="Admin_Group")
            {
                if ( companyId == comp)
                {
                    var allProgrammes =  _unitOfWork.Programmes.GetAllProgrammeWithProjectsThenPortfolios(comp);

                    return allProgrammes.Select(Mapper.Map<Programme, ProgrammeViewModel>);
                }
                return await Task.FromResult<IEnumerable<ProgrammeViewModel>>(null);
            }
            return  await Task.FromResult<IEnumerable<ProgrammeViewModel>>(null);
        }



        [HttpPost("programme")]
        [Authorize(Policy="Admin_Group")]
        public ActionResult Post([FromBody] EditProgrammeData programmeData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (programmeData.CompanyId != comp)
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
                var programme = _unitOfWork.Programmes.GetOneProgramme(programmeData.ProgrammeId, comp);

                if (programme == null)
                    return NotFound();

                _mapper.Map<EditProgrammeData, Programme>(programmeData, programme);

                programme.CompanyId = comp;
                programme.ProgrammeName = programmeData.ProgrammeName ?? programme.ProgrammeName;
                programme.AuthorisedYesOrNo = programmeData.AuthorisedYesOrNo;
                programme.DeliveryDirector = programmeData.DeliveryDirector ?? programme.DeliveryDirector;
                programme.DeliveryManager = programmeData.DeliveryManager ?? programme.DeliveryManager;
                programme.NextYearIndicator = programmeData.NextYearIndicator ?? programme.NextYearIndicator;
                programme.ProgramEndDate = programmeData.ProgramEndDate ?? programme.ProgramEndDate;
                programme.ProgramStartDate = programmeData.ProgramStartDate ?? programme.ProgramStartDate;
                programme.ProgramEndDate = programmeData.ProgramEndDate;
                programme.ProgrammeLead = programmeData.ProgrammeLead ?? programme.ProgrammeLead;
                programme.ProgrammeManager = programmeData.ProgrammeManager ?? programme.ProgrammeManager;
                programme.UniqueProgrammeRef = programmeData.UniqueProgrammeRef ?? programme.UniqueProgrammeRef;

                programme.ProgrammeCode = "PROG" + "-" + CreateNewId(programme.Id).ToUpper();

                _unitOfWork.Complete();

                programme = _unitOfWork.Programmes.GetOneProgramme(programme.Id, comp);

                var result = _mapper.Map<Programme, ProgrammeViewModel>(programme);

                return Ok(result);
            }
            return BadRequest("You are not authorised to perform this action.");

        }



        [HttpPost]
        [Authorize(Policy="Admin_Group")]
        public IActionResult PostProgramme( [FromBody] EditProgrammeData programmeData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (programmeData.CompanyId != comp)
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

                var programme = _mapper.Map<EditProgrammeData, Programme>(programmeData);
                programme.CompanyId = comp;
                programme.Id = id;
                programme.ProgrammeCode = "PROG" + "-" + CreateNewId(id).ToUpper();

                _unitOfWork.Programmes.Add(programme);
                _unitOfWork.Complete();

                programme = _unitOfWork.Programmes.GetOneProgramme(id, comp);

                var results = _mapper.Map<Programme, EditProgrammeData>(programme);


                return Ok(results);
            }
            return BadRequest("You are not authorised to perform this action.");
        }


        [HttpDelete("{companyId}/{id}")]
        [Authorize(Policy="Admin_Group")]
        public IActionResult DeleteProgramme(string companyId, string id)
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
                var programme = _unitOfWork.Programmes.GetOneProgramme(id, company);

                if (programme == null)
                return BadRequest("You are not authorised to perform this action.");

                _unitOfWork.Programmes.Remove(programme);
                _unitOfWork.Complete();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }

    }
}