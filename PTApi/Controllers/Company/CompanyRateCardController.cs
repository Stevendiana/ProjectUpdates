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
    [Route("api/companyratecards")]
    //[Authorize(Policy = "ApiUser")]
    public class CompanyRateCardController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;

        public CompanyRateCardController(UserManager<ApplicationUser> userManager, IUserService userService, 
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

       
        public class EditCompanyRateCard
        {
            public string CompanyRateCardId { get; set; }
            [Required]
            public string CompanyId { get; set; }
            public string CompanyRateCardCode { get; set; }
            [Required]
            public string EmployeeJobTitleOrGradeOrBand { get; set; }
            [Required]
            public string LocationForGradeOnshoreOffShore { get; set; }
            public bool IsContractor { get; set; }
            [Required]
            public decimal DailyRate { get; set; }
        }


        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var companyRateCardDb = _unitOfWork.CompanyRateCards.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.CompanyRateCardId == id));

            if(companyRateCardDb == null)
            return NotFound("Business unit not found");

            var companyRateCardData = _mapper.Map<CompanyRateCard, CompanyRateCardViewModel>(companyRateCardDb);

            return Ok(companyRateCardData);
        }


        [HttpGet("{companyId}")]
        [Authorize(Policy="Admin_Group")]
        public async Task<IEnumerable<CompanyRateCardViewModel>> GetCompanyRateCards(string companyId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup=="Admin_Group")
            {
                if ( companyId == comp)
                {
                    var allCompanyRateCards =  _unitOfWork.CompanyRateCards.GetAllCompanyRateCardsOnly(comp);

                    return allCompanyRateCards.Select(Mapper.Map<CompanyRateCard, CompanyRateCardViewModel>);
                }
                return await Task.FromResult<IEnumerable<CompanyRateCardViewModel>>(null);
            }
            return  await Task.FromResult<IEnumerable<CompanyRateCardViewModel>>(null);
        }



        [HttpPost("companyratecard")]
        [Authorize(Policy="Admin_Group")]
        public ActionResult Post([FromBody] EditCompanyRateCard companyRateCardData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (companyRateCardData.CompanyId != comp)
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
                var companyRateCard = _unitOfWork.CompanyRateCards.GetOneCompanyRateCard(companyId, companyRateCardData.CompanyRateCardId);

                if (companyRateCard == null)
                    return NotFound();

                _mapper.Map<EditCompanyRateCard, CompanyRateCard>(companyRateCardData, companyRateCard);


                companyRateCard.CompanyId = comp;
                companyRateCard.EmployeeJobTitleOrGradeOrBand = companyRateCardData.EmployeeJobTitleOrGradeOrBand ?? companyRateCard.EmployeeJobTitleOrGradeOrBand;
                companyRateCard.LocationForGradeOnshoreOffShore = companyRateCardData.LocationForGradeOnshoreOffShore ?? companyRateCard.LocationForGradeOnshoreOffShore;
                companyRateCard.DailyRate = companyRateCardData.DailyRate;
                companyRateCard.CompanyRateCardCode = "RCARD" + "-" + CreateNewId(companyRateCard.CompanyRateCardId).ToUpper();


                _unitOfWork.Complete();

                companyRateCard = _unitOfWork.CompanyRateCards.GetOneCompanyRateCard(comp, companyRateCard.CompanyRateCardId);

                var result = _mapper.Map<CompanyRateCard, CompanyRateCardViewModel>(companyRateCard);

                return Ok(result);
            }
            return BadRequest("You are not authorised to perform this action.");

        }



        [HttpPost]
        [Authorize(Policy="Admin_Group")]
        public IActionResult PostCompanyRateCard( [FromBody] EditCompanyRateCard companyRateCardData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (companyRateCardData.CompanyId != comp)
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

                var companyRateCard = _mapper.Map<EditCompanyRateCard, CompanyRateCard>(companyRateCardData);
                companyRateCard.CompanyId = comp;
                companyRateCard.CompanyRateCardId = id;
                companyRateCard.CompanyRateCardCode = "RCARD" + "-" + CreateNewId(companyRateCard.CompanyRateCardId).ToUpper();

                _unitOfWork.CompanyRateCards.Add(companyRateCard);
                _unitOfWork.Complete();

                companyRateCard = _unitOfWork.CompanyRateCards.GetOneCompanyRateCard(comp, id);

                var results = _mapper.Map<CompanyRateCard, EditCompanyRateCard>(companyRateCard);


                return Ok(results);
            }
            return BadRequest("You are not authorised to perform this action.");
        }


        [HttpDelete("{companyId}/{id}")]
        [Authorize(Policy="Admin_Group")]
        public IActionResult DeleteCompanyRateCard(string companyId, string id)
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
                var companyRateCard = _unitOfWork.CompanyRateCards.GetOneCompanyRateCard(company, id);

                if (companyRateCard == null)
                return BadRequest("You are not authorised to perform this action.");

                _unitOfWork.CompanyRateCards.Remove(companyRateCard);
                _unitOfWork.Complete();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }

    }

}