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
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ResourcesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IForecastService _forecastService;
        private readonly IResourceService _resourceService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public ResourcesController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IGetIdsWithPartIdsMethod getIdsWithPartIds, IResourceService resourceService,
        IGeneratePublicIdMethod getpublicId, IForecastService forecastService, IUserService userService, IProjectService projectService, IMapper mapper)
        {
            _userService = userService;
            _resourceService = resourceService;
            _projectService = projectService;
            _forecastService = forecastService;
            _unitOfWork = unitOfWork;
            _getIdsWithPartIds = getIdsWithPartIds;
            _getpublicId = getpublicId;
            _userManager = userManager;
            _mapper = mapper;
        }

        private string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }

        public string ConvertImage(byte[] image)
        {
            if (image != null)
            {
                return System.Convert.ToBase64String(image);
            }

            return null;
        }

        public byte[] GetInMemoryPhoto(string imagename)
        {
            if (imagename != null)
            {
                var reportsFolder = "Images";
                var photopath = $"~/{reportsFolder}/{imagename}";

                byte[] bytes = System.IO.File.ReadAllBytes(photopath);

                if (photopath != null)
                {
                    return bytes;
                    // return File(bytes, "image/jpeg");

                }
                return null;

            }
            return null;
        }



        public class EditResourceData
        {

            public EditResourceData()
            {
                ResourceEffortSummaries = new Collection<ResourceEffortSummary>();

            }

            public string ResourceId { get; set; }
            public string ResourceNumber { get; set; }
            [Required]
            public string ResourceEmailAddress { get; set; }
            public string EmployeeRef { get; set; }

            public DateTime ResourceStartDate { get; set; }

            public DateTime ResourceEndDate { get; set; }

            public string Agency { get; set; }
            public string Vendor { get; set; }
            public string Gender { get; set; }
            public string LocationName { get; set; }
            public string Location { get; set; }
            public bool Billable { get; set; }
            public bool IsDisabled { get; set; }

            public string EmployeeJobTitle { get; set; }

            public string ResourceRateCardId { get; set; }
            public string ResourceManagerId { get; set; }
            public string PlatformId { get; set; }


            public decimal? ContractedHours { get; set; }
            public decimal? ResourceContractEffortInPercentage { get; set; }

            public string ResourceType { get; set; }
            public string EmployeeType { get; set; }

            [Required]
            public string CompanyId { get; set; }
            public string ProjectId { get; set; }
            public string AppUserRole { get; set; }
            public string IdentityId { get; set; }
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }

            public ICollection<ResourceEffortSummary> ResourceEffortSummaries { get; set; }

        }

        public class GetAllResourceUtilizationByMonth
        {
            public decimal? GetJanResourceUtilizationByMonth { get; set; }
            public decimal? GetFebResourceUtilizationByMonth { get; set; }
            public decimal? GetMarResourceUtilizationByMonth { get; set; }
            public decimal? GetAprResourceUtilizationByMonth { get; set; }
            public decimal? GetMayResourceUtilizationByMonth { get; set; }
            public decimal? GetJunResourceUtilizationByMonth { get; set; }
            public decimal? GetJulResourceUtilizationByMonth { get; set; }
            public decimal? GetAugResourceUtilizationByMonth { get; set; }
            public decimal? GetSepResourceUtilizationByMonth { get; set; }
            public decimal? GetOctResourceUtilizationByMonth { get; set; }
            public decimal? GetNovResourceUtilizationByMonth { get; set; }
            public decimal? GetDecResourceUtilizationByMonth { get; set; }


        }

        public class GetResourceHolidaysTotalsByResource
        {
            public decimal? SumJanResourceTotalHolidayHours { get; set; }
            public decimal? SumFebResourceTotalHolidayHours { get; set; }
            public decimal? SumMarResourceTotalHolidayHours { get; set; }
            public decimal? SumAprResourceTotalHolidayHours { get; set; }
            public decimal? SumMayResourceTotalHolidayHours { get; set; }
            public decimal? SumJunResourceTotalHolidayHours { get; set; }
            public decimal? SumJulResourceTotalHolidayHours { get; set; }
            public decimal? SumAugResourceTotalHolidayHours { get; set; }
            public decimal? SumSepResourceTotalHolidayHours { get; set; }
            public decimal? SumOctResourceTotalHolidayHours { get; set; }
            public decimal? SumNovResourceTotalHolidayHours { get; set; }
            public decimal? SumDecResourceTotalHolidayHours { get; set; }


        }

        public List<int> GetYears(DateTime dtStart, DateTime dtEnd)
        {
            List<int> Years = new List<int>();
            while (dtStart <= dtEnd)
            {
                Years.Add(Convert.ToInt32(dtStart.ToString("yyyy")));
                dtStart = dtStart.AddYears(1);
            }

            return Years;
        }

        public decimal? GetAllResourceHolidaysTotalsByMonth(string companyId, string resourceId, int? year, int? month)
        {
            return _resourceService.GetResourceHolidaysTotals(companyId, resourceId, year, month).SumResourceTotalHolidayHours;
        }

        public decimal? GetNumberOfWorkingDaysInMonth(int year, byte month)
        {
            return _projectService.GetDaysPerMonth(year, month).WorkingdaysInMonth;
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
            var resourceDb = _unitOfWork.Resources.GetOneResouce(id, comp);

            if (resourceDb == null)
                return NotFound("Resource not found");

            // var convertedimage = ConvertImage(GetInMemoryPhoto(resourceDb.ImageName));
            // var convertedimage = ConvertImage(resourceDb.AvatarImage);

            var resourceData = _mapper.Map<Resource, ResourceViewModel>(resourceDb);
            // resourceData.AvatarImage = convertedimage;

            return Ok(resourceData);
        }

        [HttpGet("{companyId}")]
        [Authorize(Policy = "Admin_Group")]
        public async Task<IEnumerable<ResourceAdminViewModel>> GetResources(string companyId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            // List<ResourceAdminViewModel> resources = new List<ResourceAdminViewModel>();

            if (roleGroup=="Admin_Group")
            {
                if ( companyId == comp)
                {
                    var allResources =  _unitOfWork.Resources.GetAllResources(comp);

                   
                    return allResources.Select(Mapper.Map<Resource, ResourceAdminViewModel>);
                }
                return await Task.FromResult<IEnumerable<ResourceAdminViewModel>>(null);
            }
            return  await Task.FromResult<IEnumerable<ResourceAdminViewModel>>(null);
        }

        [HttpPost("resource")]
        [Authorize(Policy = "Admin_Group")]
        public ActionResult EditResource([FromBody] EditResourceData resourceData)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            var userId = _userService.GetSecureUserId();
            int CompanyStandardHrs = Convert.ToInt32(_userService.GetSecureUserCompanyStandardHrs());
            int j = CompanyStandardHrs;


            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (resourceData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (string.IsNullOrEmpty(resourceData.ResourceEmailAddress)) // if emial field is empty or null.
            {
                ModelState.AddModelError("email", string.Format("The resource email field cannot be null.", resourceData.ResourceEmailAddress));
                return BadRequest(ModelState);
            }
           
            if (roleGroup == "Admin_Group")
            {
                var resource = _unitOfWork.Resources.GetOneResouce(resourceData.ResourceId, resourceData.CompanyId);

                //decimal? resourcecontracthours = (resource.ResourceContractEffortInPercentage??100)/100 * j;

                if (resource != null)
                {
                    if (resourceData.ResourceStartDate != resource.ResourceStartDate || resourceData.ResourceEndDate != resource.ResourceEndDate)
                    {
                        var Years =  GetYears(resourceData.ResourceStartDate, resourceData.ResourceEndDate);
                        var resid = resource.ResourceId;
                        var resourceStandardHrs = (resource.ResourceContractEffortInPercentage ?? 100) / 100 * j; 

                        foreach (var year in Years)
                        {
                            var utilityid = Guid.NewGuid().ToString();

                            var Utility = new ResourceUtilizationSummary
                            {
                                Year = year,
                                CompanyId = comp,
                                ResourceId = resid,
                            };

                            _unitOfWork.ResourceUtilizations.Add(Utility);

                            Utility = _resourceService.CalculateResourceUtilAvail(Utility, resid, comp, year, resourceStandardHrs, CompanyStandardHrs);

                            Utility.ResourceUtilizationSummaryId = utilityid;
                           
                            continue;
                        }
                    }

                    _mapper.Map<EditResourceData, Resource>(resourceData, resource);

                    resource.CompanyId = comp;
                    resource.ContractedHours = (resource.ResourceContractEffortInPercentage ?? 100) / 100 * j;
                    resource.ResourceEmailAddress = resource.ResourceEmailAddress;
                    resource.ResourceId = resource.ResourceId;
                    resource.ResourceNumber = "RESOURCE" + "-" + CreateNewId(resource.ResourceId).ToUpper();

                    _unitOfWork.Complete();

                    resource = _unitOfWork.Resources.GetOneResouce(resourceData.ResourceId, resourceData.CompanyId);

                    var result = _mapper.Map<Resource, ResourceViewModel>(resource);

                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            return BadRequest("You are not authorised to perform this action.");
        }


        [HttpPost]
        [Authorize(Policy="Admin_Group")]
        public IActionResult CreateResource([FromBody] EditResourceData resourceData)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            var email = _userService.GetSecureUserEmail();
            var adminres= _userService.GetSecureResource();
            var userId = _userService.GetSecureUserId();
            int CompanyStandardHrs = Convert.ToInt32(_userService.GetSecureUserCompanyStandardHrs());
            int j = CompanyStandardHrs;

            if (resourceData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup=="Admin_Group")
            {
                Resource existingPerson = _unitOfWork.Resources.SingleOrDefault(r => r.ResourceEmailAddress == resourceData.ResourceEmailAddress);

                if (existingPerson != null) // if id is NOT null,then email already exists.
                {
                    ModelState.AddModelError("email", string.Format("Woops! It appears {0} is already listed in the database as your company resource. Duplicate entries are not allowed.", resourceData.ResourceEmailAddress));
                    return BadRequest(ModelState);
                }

                var id = Guid.NewGuid().ToString();

                var newresource = _mapper.Map<EditResourceData, Resource>(resourceData);

                //decimal? resourcecontracthours = (newresource.ResourceContractEffortInPercentage??100)/100 * j;

                newresource.FirstName = resourceData.FirstName;
                newresource.UserCreatedEmail = email;
                newresource.UserModifiedEmail = email;
                newresource.DateCreated = DateTime.UtcNow;
                newresource.DateModified = DateTime.UtcNow;
                newresource.FirstName = resourceData.FirstName;

                newresource.ResourceId = id;
                newresource.ResourceNumber = "RESOURCE" + "-" + CreateNewId(id).ToUpper();
                newresource.UserCreatedId = email;
                newresource.UserCreatedResourceId = adminres;
                newresource.UserModifiedResourceId = adminres;
                newresource.UserModifiedId = userId;

                newresource.Billable = true;
                newresource.CompanyId = comp;
                
                newresource.ResourceManagerId = resourceData.ResourceManagerId;
                newresource.ResourceRateCardId = resourceData.ResourceRateCardId;


                var Years = GetYears(resourceData.ResourceStartDate, resourceData.ResourceEndDate);
                var resid = id;
                var resourceStandardHrs = (newresource.ResourceContractEffortInPercentage ?? 100) / 100 * j;
                newresource.ContractedHours = resourceStandardHrs;

                foreach (var year in Years)
                {
                    var utilityid = Guid.NewGuid().ToString();

                    var Utility = new ResourceUtilizationSummary
                    {
                        Year = year,
                        CompanyId = comp,
                        ResourceId = resid,
                    };

                    _unitOfWork.ResourceUtilizations.Add(Utility);

                    Utility = _resourceService.CalculateResourceUtilAvail(Utility, resid, comp, year, resourceStandardHrs, CompanyStandardHrs);

                    Utility.ResourceUtilizationSummaryId = utilityid;
                   
                    continue;
                }

                _unitOfWork.Resources.Add(newresource);
                _unitOfWork.Complete();

                newresource = _unitOfWork.Resources.GetOneResouce(id, comp);

                var objresult = _mapper.Map<Resource, ResourceViewModel>(newresource);
                return Ok(objresult);
            }

            return BadRequest("You are not authorised to perform this action.");
        }

        [HttpDelete("{companyId}/{id}")]
        [Authorize(Policy = "Admin_Group")]
        public IActionResult DeleteResource(string companyId, string id)
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
                var resource = _unitOfWork.Resources.GetOneResouce(id, comp);

                if (resource == null)
                    return BadRequest("You are not authorised to perform this action.");

                if (_unitOfWork.LifetimeForecast.CheckForecastExistForResource(id, comp))
                    return BadRequest("This resource has a forecast record. Please delete associated forecast first, then try again.");

                _unitOfWork.Resources.Remove(resource);
                _unitOfWork.Complete();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }

        //public GetResourceHolidaysTotalsByResource GetResourceHolidayTotals(List<ResourceHolidayBooked>  holidays, string resourceId, int year)
        //{

        // var getAllResourceHolidaysTotals =  holidays?
        //     .Where(rh => (rh.ResourceId == resourceId)
        //      &&((rh.TimesheetCalendar.SaturdayYear == year)  || (rh.TimesheetCalendar.SundayYear == year))).ToList();


        //    decimal? sumJanResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 1) || (g.TimesheetCalendar.SundayPeriod == 1))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumFebResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 2) || (g.TimesheetCalendar.SundayPeriod == 2))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumMarResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 3) || (g.TimesheetCalendar.SundayPeriod == 3))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumAprResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 4) || (g.TimesheetCalendar.SundayPeriod == 4))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumMayResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 5) || (g.TimesheetCalendar.SundayPeriod == 5))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumJunResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 6) || (g.TimesheetCalendar.SundayPeriod == 6))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumJulResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 7) || (g.TimesheetCalendar.SundayPeriod == 7))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumAugResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 8) || (g.TimesheetCalendar.SundayPeriod == 8))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumSepResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 9) || (g.TimesheetCalendar.SundayPeriod == 9))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumOctResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 10) || (g.TimesheetCalendar.SundayPeriod == 10))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumNovResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 11) || (g.TimesheetCalendar.SundayPeriod == 11))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();
        //    decimal? sumDecResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
        //                                         .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 12) || (g.TimesheetCalendar.SundayPeriod == 12))
        //                                         .Select(rh => rh.TotalHolidayHours).Sum();


        //    var holidayObj = new GetResourceHolidaysTotalsByResource() {

        //        SumJanResourceTotalHolidayHours=sumJanResourceTotalHolidayHours??0,
        //        SumFebResourceTotalHolidayHours=sumFebResourceTotalHolidayHours??0,
        //        SumMarResourceTotalHolidayHours=sumMarResourceTotalHolidayHours??0,
        //        SumAprResourceTotalHolidayHours=sumAprResourceTotalHolidayHours??0,
        //        SumMayResourceTotalHolidayHours=sumMayResourceTotalHolidayHours??0,
        //        SumJunResourceTotalHolidayHours=sumJunResourceTotalHolidayHours??0,
        //        SumJulResourceTotalHolidayHours=sumJulResourceTotalHolidayHours??0,
        //        SumAugResourceTotalHolidayHours=sumAugResourceTotalHolidayHours??0,
        //        SumSepResourceTotalHolidayHours=sumSepResourceTotalHolidayHours??0,
        //        SumOctResourceTotalHolidayHours=sumOctResourceTotalHolidayHours??0,
        //        SumNovResourceTotalHolidayHours=sumNovResourceTotalHolidayHours??0,
        //        SumDecResourceTotalHolidayHours=sumDecResourceTotalHolidayHours??0,

        //    };


        //  return holidayObj;
        //}

       
        

        

    }
}