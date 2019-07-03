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

namespace PTApi.Controllers.Resources
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ResourceHolidayController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public ResourceHolidayController(UserManager<ApplicationUser> userManager, IUserService userService, IProjectService projectService, IMapper mapper, IUnitOfWork unitOfWork, IGetIdsWithPartIdsMethod getIdsWithPartIds,
        IGeneratePublicIdMethod getpublicId)
        {
            _unitOfWork = unitOfWork;
            _getpublicId = getpublicId;
            _getIdsWithPartIds = getIdsWithPartIds;
            _userService = userService;
            _projectService = projectService;
            _userManager = userManager;
            _mapper = mapper;
        }

        private string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }


        public class EditResourceHolidayBookedData
        {
            public string ResourceHolidayBookedId { get; set; }
            public string HolidayBookingCode { get; set; }
            public string HolidayStatus { get; set; }
            public decimal? SundayHolidayHours { get; set; }
            public decimal? MondayHolidayHours { get; set; }
            public decimal? TuesdayHolidayHours { get; set; }
            public decimal? WednesdayHolidayHours { get; set; }
            public decimal? ThursdayHolidayHours { get; set; }
            public decimal? FridayHolidayHours { get; set; }
            public decimal? SaturdayHolidayHours { get; set; }

            public decimal? TotalHolidayHours { get; set; }

            public string ResourceFeedBackNote { get; set; }
            public string ApproverFeedBackNote { get; set; }
            public string CompanyId { get; set; }
            public Company Company { get; set; }
            
            [Required]
            public string ResourceId { get; set; }
            public Resource Resource { get; set; }
            
            [Required]
            public int TimesheetCalendarTsId { get; set; }

        }



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id)
        {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var holidayDb = _unitOfWork.ResourceHolidays.SingleOrDefault(b => (b.CompanyId == companyId) && (b.ResourceHolidayBookedId == id));

            if (holidayDb == null)
                return NotFound("Holiday not found");

            var holidayDbData = _mapper.Map<ResourceHolidayBooked, ResourceHolidayViewModel>(holidayDb);

            return Ok(holidayDbData);
        }


        [HttpGet("{resourceId}/{companyId}")]
        [Authorize(Policy = "Admin_Group")]
        public async Task<IEnumerable<ResourceHolidayViewModel>> GetResourceHolidays(string resourceId, string companyId)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup == "Admin_Group")
            {
                if (companyId == comp)
                {
                    var allholidays = _unitOfWork.ResourceHolidays.GetAllResourceHolidayBookings(comp, resourceId);

                    return allholidays.Select(Mapper.Map<ResourceHolidayBooked, ResourceHolidayViewModel>);
                }
                return await Task.FromResult<IEnumerable<ResourceHolidayViewModel>>(null);
            }
            return await Task.FromResult<IEnumerable<ResourceHolidayViewModel>>(null);
        }

        [HttpGet("{companyId}")]
        [Authorize(Policy = "Admin_Group")]
        public async Task<IEnumerable<ResourceHolidayViewModel>> GetCompanyHolidays(string companyId)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup == "Admin_Group")
            {
                if (companyId == comp)
                {
                    var allholidays = _unitOfWork.ResourceHolidays.GetAllCompanyHolidayBookings(comp);

                    return allholidays.Select(Mapper.Map<ResourceHolidayBooked, ResourceHolidayViewModel>);
                }
                return await Task.FromResult<IEnumerable<ResourceHolidayViewModel>>(null);
            }
            return await Task.FromResult<IEnumerable<ResourceHolidayViewModel>>(null);
        }


        [HttpGet("{projectId}/{companyId}")]
        [Authorize(Policy = "Admin_Group")]
        public async Task<IEnumerable<ResourceHolidayViewModel>> GetProjectHolidays(string projectId, string companyId)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup == "Admin_Group")
            {
                if (companyId == comp)
                {
                    var projectresources = _unitOfWork.LifetimeForecast.GetAllResourcesInProject(projectId, comp);
                   
                    List<ResourceHolidayViewModel> Holidays = new List<ResourceHolidayViewModel>();
                    foreach (var item in projectresources)
                    {
                        var allholidays = _unitOfWork.ResourceHolidays.GetAllResourceHolidayBookings(comp, item);
                        var holidayViewModel = _mapper.Map<IEnumerable<ResourceHolidayBooked>, IEnumerable<ResourceHolidayViewModel>>(allholidays);

                        Holidays.AddRange(holidayViewModel);
                        continue;
                    }

                    return await Task.FromResult<IEnumerable<ResourceHolidayViewModel>>(Holidays);
                }
                return await Task.FromResult<IEnumerable<ResourceHolidayViewModel>>(null);
            }
            return await Task.FromResult<IEnumerable<ResourceHolidayViewModel>>(null);
        }



        [HttpPost("holiday")]
        [Authorize(Policy = "Admin_Group")]
        public ActionResult Post([FromBody] EditResourceHolidayBookedData holidayData)
        {

            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (holidayData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup == "Admin_Group")
            {
                var companyId = comp;
                var holiday = _unitOfWork.ResourceHolidays.GetOneResourceHolidayBooking(holidayData.ResourceHolidayBookedId, comp);

                if (holiday == null)
                    return NotFound();

                _mapper.Map<EditResourceHolidayBookedData, ResourceHolidayBooked>(holidayData, holiday);

                
                holiday.HolidayBookingCode = "HOLIDAY" + "-" + CreateNewId(holiday.ResourceHolidayBookedId).ToUpper();
                holiday.CompanyId = comp;
                holiday.ResourceId= holiday.ResourceId;
                holiday.TimesheetCalendarTsId = holiday.TimesheetCalendarTsId;

                _unitOfWork.Complete();

                holiday = _unitOfWork.ResourceHolidays.GetOneResourceHolidayBooking(holidayData.ResourceHolidayBookedId, comp);

                var result = _mapper.Map<ResourceHolidayBooked, ResourceHolidayViewModel>(holiday);

                return Ok(result);
            }
            return BadRequest("You are not authorised to perform this action.");

        }


        [HttpPost]
        [Authorize(Policy = "Admin_Group")]
        public IActionResult PostPlatform([FromBody] EditResourceHolidayBookedData holidayData)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (holidayData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup == "Admin_Group")
            {
                var id = Guid.NewGuid().ToString();

                var holiday = _mapper.Map<EditResourceHolidayBookedData, ResourceHolidayBooked>(holidayData);

                holiday.HolidayBookingCode = "HOLIDAY" + "-" + CreateNewId(holiday.ResourceHolidayBookedId).ToUpper();
                holiday.CompanyId = comp;
                holiday.ResourceId = holiday.ResourceId;
                holiday.TimesheetCalendarTsId = holiday.TimesheetCalendarTsId;

                _unitOfWork.ResourceHolidays.Add(holiday);
                _unitOfWork.Complete();

                holiday = _unitOfWork.ResourceHolidays.GetOneResourceHolidayBooking(id, comp);

                var results = _mapper.Map<ResourceHolidayBooked, EditResourceHolidayBookedData>(holiday);

                return Ok(results);
            }
            return BadRequest("You are not authorised to perform this action.");
        }


        [HttpDelete("{companyId}/{id}")]
        [Authorize(Policy = "Admin_Group")]
        public IActionResult DeleteHoliday(string companyId, string id)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup == "Admin_Group")
            {

                // var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
                var company = comp;
                var holiday = _unitOfWork.ResourceHolidays.GetOneResourceHolidayBooking(id, comp);

                if (holiday == null)
                    return BadRequest("You are not authorised to perform this action.");

                _unitOfWork.ResourceHolidays.Remove(holiday);
                _unitOfWork.Complete();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }





    }
}


