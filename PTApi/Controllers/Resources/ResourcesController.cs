
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using AutoMapper;
using ProjectCentreBackend.Auth;
using ProjectCentreBackend.Helpers;
using ProjectCentreBackend.Models;
using ProjectCentreBackend.Models.Entities;
using ProjectCentreBackend.Models.Methods;
using ProjectCentreBackend.Persistence;
using ProjectCentreBackend.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using ProjectCentreBackend.Core.Interfaces;
using System.Globalization;
using System.Collections.ObjectModel;

namespace ProjectCentreBackend.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ResourcesController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IForecastService _forecastService;
        private readonly IResourceService _resourceService;
        private readonly IPermissionsMethods _permissionsMethods;
        private readonly IMapper _mapper;


        public ResourcesController(UserManager<AppUser> userManager, IUserService userService, IPermissionsMethods permissionsMethods, IForecastService forecastService, IResourceService resourceService, ProjectCentreDbContext appDbContext, IMapper mapper)
        {
            _userService = userService;
            _userManager = userManager;
            _permissionsMethods = permissionsMethods;
            _appDbContext = appDbContext;
            _forecastService = forecastService;
            _resourceService = resourceService;
            _mapper = mapper;
        }

        private static string CreateNewId(string businessUnitId)
        {
            GeneratePublicId generatePublicId = new GeneratePublicId();
            return generatePublicId.PartId(businessUnitId, 8);
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

            public DateTime? ResourceStartDate { get; set; }

            public DateTime? ResourceEndDate { get; set; }

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



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id)
        {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var resourceDb = _appDbContext.Resources.Include(p=>p.CompanyRateCard).SingleOrDefault(b => (b.CompanyId == companyId) && (b.ResourceId == id));

            if (resourceDb == null)
                return NotFound("Resource not found");

            // var convertedimage = ConvertImage(GetInMemoryPhoto(resourceDb.ImageName));
            // var convertedimage = ConvertImage(resourceDb.AvatarImage);

            var resourceData = _mapper.Map<Resource, ResourceViewModel>(resourceDb);
            // resourceData.AvatarImage = convertedimage;

            return Ok(resourceData);
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
                    var allResources = await _appDbContext.Resources?.Include(p=>p.CompanyRateCard).Where(p => p.CompanyId == companyId).ToListAsync();

                    // foreach (var item in allResources)
                    // {
                    //     var resourceVM = _mapper.Map<Resource, ResourceAdminViewModel>(item);
                    //     // var convertedimage = ConvertImage(GetInMemoryPhoto(item.ImageName));

                    //     // resourceVM.AvatarImage =  convertedimage;
                    //     resources.Add(resourceVM);
                    //     continue;
                    // }
                    // return await Task.FromResult<IEnumerable<ResourceAdminViewModel>>(resources);
                    return allResources.Select(Mapper.Map<Resource, ResourceAdminViewModel>);
                }
                return await Task.FromResult<IEnumerable<ResourceAdminViewModel>>(null);
            }
            return  await Task.FromResult<IEnumerable<ResourceAdminViewModel>>(null);
        }

        [HttpGet("sums/{companyId}")]
        [Authorize(Policy = "Admin_Group")]
        public async Task<IEnumerable<ResourceAdminViewModel>> GetResourcesAndTheirSums(string companyId)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            var userreportingyear = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepyear).Value;
            var userstandarddailyhrs = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Standarddailyhrs).Value;


            int i = 0;
            int j = 0;
            string s = userreportingyear;
            string h = userstandarddailyhrs;
            i =int.Parse(s);
            j =int.Parse(h);
            i = Convert.ToInt32(s);
            j = Convert.ToInt32(h);

            if (roleGroup == "Admin_Group")
            {
                if (companyId == comp)
                {
                    var allResources = await _appDbContext.Resources?.Include(p=>p.CompanyRateCard).Where(p => p.CompanyId == companyId).ToListAsync();

                    List<ResourceAdminViewModel> resources = new List<ResourceAdminViewModel>();

                    foreach (var item in allResources)
                    {
                        var resourceVM = _mapper.Map<Resource, ResourceAdminViewModel>(item);

                        decimal? resourcecontracthours = (item.ResourceContractEffortInPercentage??100)/100 * j;
                        // var convertedimage = ConvertImage(GetInMemoryPhoto(item.ImageName));

                        // resourceVM.AvatarImage =  convertedimage;
                        resourceVM.JanAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 1)*(resourcecontracthours/j);
                        resourceVM.FebAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 2)*(resourcecontracthours/j);
                        resourceVM.MarAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 3)*(resourcecontracthours/j);
                        resourceVM.AprAvailabilityBeforeHolidaysInDays = _resourceService.GetNumberOfWorkingDaysInMonth(i, 4)*(resourcecontracthours/j);
                        resourceVM.MayAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 5)*(resourcecontracthours/j);
                        resourceVM.JunAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 6)*(resourcecontracthours/j);
                        resourceVM.JulAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 7)*(resourcecontracthours/j);
                        resourceVM.AugAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 8)*(resourcecontracthours/j);
                        resourceVM.SepAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 9)*(resourcecontracthours/j);
                        resourceVM.OctAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 10)*(resourcecontracthours/j);
                        resourceVM.NovAvailabilityBeforeHolidaysInDays = _resourceService.GetNumberOfWorkingDaysInMonth(i, 11)*(resourcecontracthours/j);
                        resourceVM.DecAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 12)*(resourcecontracthours/j);


                        resources.Add(resourceVM);
                        continue;
                    }
                    return await Task.FromResult<IEnumerable<ResourceAdminViewModel>>(resources);
                }
                return await Task.FromResult<IEnumerable<ResourceAdminViewModel>>(null);
            }
            return await Task.FromResult<IEnumerable<ResourceAdminViewModel>>(null);
        }



        [HttpPost("resource")]
        [Authorize(Policy = "Admin_Group")]
        public ActionResult Post([FromBody] EditResourceData resourceData)
        {

            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            var userreportingyear = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepyear).Value;
            var userstandarddailyhrs = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Standarddailyhrs).Value;

            int i = 0;
            int j = 0;
            string s = userreportingyear;
            string h = userstandarddailyhrs;
            i =int.Parse(s);
            j =int.Parse(h);
            i = Convert.ToInt32(s);
            j = Convert.ToInt32(h);


           // var email = HttpContext.User.Claims.Single(c => c.Type == "email").Value;
            // return validation error if email already exists


            if (resourceData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (string.IsNullOrEmpty(resourceData.ResourceEmailAddress)) // if emial field is empty or null.
            {
                ModelState.AddModelError("email", string.Format("The resource email field cannot be null.", resourceData.ResourceEmailAddress));
                return BadRequest(ModelState);
            }
            // return validation error if required fields aren't filled in
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (roleGroup == "Admin_Group")
            {
                var resource = Getresource(resourceData.CompanyId, resourceData.ResourceId);
                var resourcerole = resource.AppUserRole;

                decimal? resourcecontracthours = (resource.ResourceContractEffortInPercentage??100)/100 * j;

                if (resource != null)
                {
                    var incomingrole = resourceData.AppUserRole;
                    _mapper.Map<EditResourceData, Resource>(resourceData, resource);

                    if (incomingrole == Constants.Strings.JwtClaims.AccountOwner ||
                        incomingrole == Constants.Strings.JwtClaims.SuperAdmin ||
                        incomingrole == Constants.Strings.JwtClaims.Admin ||
                        incomingrole == Constants.Strings.JwtClaims.ProjectManager ||
                        incomingrole == Constants.Strings.JwtClaims.SeniorProjectManager ||
                        incomingrole == Constants.Strings.JwtClaims.PortfolioAdmin ||
                        incomingrole == Constants.Strings.JwtClaims.FinanceAdmin ||
                        incomingrole == Constants.Strings.JwtClaims.FinanceManager ||
                        incomingrole == Constants.Strings.JwtClaims.ReadOnly ||
                        incomingrole == Constants.Strings.JwtClaims.ResourceOnly ||
                        incomingrole == Constants.Strings.JwtClaims.ReadWriteTimesheetOnly)
                    {
                        resource.Agency = resourceData.Agency ?? resource.Agency;
                        resource.Billable = resourceData.Billable;
                        resource.Gender = resourceData.Gender ?? resource.Gender;
                        resource.ContractedHours = resourceData.ContractedHours ?? resource.ContractedHours;
                        resource.ResourceRateCardId = resourceData.ResourceRateCardId ?? resource.ResourceRateCardId;
                        resource.EmployeeJobTitle = resourceData.EmployeeJobTitle ?? resource.EmployeeJobTitle;
                        resource.EmployeeRef = resourceData.EmployeeRef ?? resource.EmployeeRef;
                        resource.EmployeeType = resourceData.EmployeeType ?? resource.EmployeeType;
                        resource.Location = resourceData.Location ?? resource.Location;
                        resource.LocationName = resourceData.LocationName ?? resource.LocationName;

                        resource.PlatformId = resourceData.PlatformId ?? resource.PlatformId;
                        resource.ResourceContractEffortInPercentage = resourceData.ResourceContractEffortInPercentage ?? resource.ResourceContractEffortInPercentage;
                        resource.ResourceEndDate = resourceData.ResourceEndDate ?? resource.ResourceEndDate;
                        resource.ResourceManagerId = resourceData.ResourceManagerId ?? resource.ResourceManagerId;


                        resource.ResourceStartDate = resourceData.ResourceStartDate ?? resource.ResourceStartDate;
                        // resource.ResourceStartDate = DateTime.ParseExact(resourceData.ResourceStartDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)?? resource.ResourceStartDate;
                        resource.ResourceType = resourceData.ResourceType ?? resource.ResourceType;
                        resource.ResourceNumber = resourceData.ResourceNumber ?? resource.ResourceNumber;

                        resource.CompanyId = resourceData.CompanyId ?? resource.CompanyId;
                        //resource.ProjectId = resourceData.ProjectId ?? resource.ProjectId;
                        resource.ResourceId = resource.ResourceId;


                        resource.JanAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 1)*(resourcecontracthours/j);
                        resource.FebAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 2)*(resourcecontracthours/j);
                        resource.MarAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 3)*(resourcecontracthours/j);
                        resource.AprAvailabilityBeforeHolidaysInDays = _resourceService.GetNumberOfWorkingDaysInMonth(i, 4)*(resourcecontracthours/j);
                        resource.MayAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 5)*(resourcecontracthours/j);
                        resource.JunAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 6)*(resourcecontracthours/j);
                        resource.JulAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 7)*(resourcecontracthours/j);
                        resource.AugAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 8)*(resourcecontracthours/j);
                        resource.SepAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 9)*(resourcecontracthours/j);
                        resource.OctAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 10)*(resourcecontracthours/j);
                        resource.NovAvailabilityBeforeHolidaysInDays = _resourceService.GetNumberOfWorkingDaysInMonth(i, 11)*(resourcecontracthours/j);
                        resource.DecAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 12)*(resourcecontracthours/j);

                        resource.TotalAvailabilityBeforeHolidaysInDays = resource.JanAvailabilityBeforeHolidaysInDays + resource.FebAvailabilityBeforeHolidaysInDays + resource.MarAvailabilityBeforeHolidaysInDays + resource.AprAvailabilityBeforeHolidaysInDays
                     + resource.MayAvailabilityBeforeHolidaysInDays + resource.JunAvailabilityBeforeHolidaysInDays +  resource.JulAvailabilityBeforeHolidaysInDays + resource.AugAvailabilityBeforeHolidaysInDays
                     + resource.SepAvailabilityBeforeHolidaysInDays + resource.OctAvailabilityBeforeHolidaysInDays +  resource.NovAvailabilityBeforeHolidaysInDays + resource.DecAvailabilityBeforeHolidaysInDays;


                        if (resourcerole == resourceData.AppUserRole)
                        {
                            resource.AppUserRole = resourceData.AppUserRole;
                            resource.ResourceEmailAddress = resourceData.ResourceEmailAddress ?? resource.ResourceEmailAddress;
                        }
                        if (resourcerole == Constants.Strings.JwtClaims.ResourceOnly && resourceData.AppUserRole!=Constants.Strings.JwtClaims.ResourceOnly )
                        {
                            // Go create a user

                            var userIdentity =
                            new AppUser
                            {
                                UserName = resourceData.ResourceEmailAddress,
                                Email = resourceData.ResourceEmailAddress,
                            };

                            var result = _userManager.CreateAsync(userIdentity, "Password4:1");
                            userIdentity.CompanyId = resource.CompanyId;
                            resource.IdentityId = userIdentity.Id;

                            resource.AppUserRole = resourceData.AppUserRole;
                            resource.ResourceEmailAddress = resourceData.ResourceEmailAddress ?? resource.ResourceEmailAddress;
                        }

                        resource.ResourceEmailAddress = resourceData.ResourceEmailAddress ?? resource.ResourceEmailAddress;
                        resource.AppUserRole = resourceData.AppUserRole;

                        _appDbContext.SaveChanges();

                        resource = Getresource(comp, resource.ResourceId); ;

                        var editedResource = _mapper.Map<Resource, ResourceViewModel>(resource);
                        return Ok(editedResource);
                    }

                    ModelState.AddModelError("appUserRole", string.Format("{0} is not recognized as a valid role. Please use one of the roles available to you based on your permission level. ", resourceData.AppUserRole));
                    return BadRequest(ModelState);
                }
                else
                {
                    return NotFound();
                }
            }
            return BadRequest("You are not authorised to perform this action.");
        }

        // AppUser GetSecureUser()
        // {

        //     //var id = HttpContext.User.Claims.First().Value;
        //    var id = User.Claims.Single(c=>c.Type=="id").Value;
        //     return _appDbContext.Users.SingleOrDefault(u => u.Id == id);
        // }

        [HttpPost]
        [Authorize(Policy="Admin_Group")]
        public async Task<IActionResult> PostResource([FromBody] EditResourceData resourceData)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();
            // var email = _userService.GetSecureUser();
            var userreportingyear = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepyear).Value;
            var userstandarddailyhrs = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Standarddailyhrs).Value;

            AppUser user = GetSecureUser();
            var email = user.Email;

            int i = 0;
            int j = 0;
            string s = userreportingyear;
            string h = userstandarddailyhrs;
            i =int.Parse(s);
            j =int.Parse(h);
            i = Convert.ToInt32(s);
            j = Convert.ToInt32(h);

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
                Resource existingPerson = _appDbContext.Resources
                                    .Where(r => r.ResourceEmailAddress == resourceData.ResourceEmailAddress).FirstOrDefault();

                if (existingPerson != null) // if id is NOT null,then email already exists.
                {
                    ModelState.AddModelError("email", string.Format("Woops! It appears {0} is already listed in the database as your company resource. Duplicate entries are not allowed.", resourceData.ResourceEmailAddress));
                    return BadRequest(ModelState);
                }

                var newresource = _mapper.Map<EditResourceData, Resource>(resourceData);

                decimal? resourcecontracthours = (newresource.ResourceContractEffortInPercentage??100)/100 * j;

                newresource =
                new Resource {

                    AppUserRole = "Resource_Only",
                    FirstName = resourceData.FirstName,
                    AddedBy = user.Email,
                    IsDisabled = false,
                    ResourceEmailAddress = resourceData.ResourceEmailAddress,
                    UserCreatedEmail = user.Email,
                    UserModifiedEmail = user.Email,
                    DateCreated =  DateTime.UtcNow,
                    DateModified =  DateTime.UtcNow,

                    ResourceNumber =  resourceData.ResourceNumber,

                    EmployeeRef =  resourceData.EmployeeRef,
                    ResourceStartDate =  resourceData.ResourceStartDate,
                    ResourceEndDate =  resourceData.ResourceEndDate,
                    Agency =  resourceData.Agency,
                    Vendor =  resourceData.Vendor,
                    Gender = resourceData.Gender,
                    LocationName =  resourceData.LocationName,
                    Location =  resourceData.Location,

                    // ResourceRateCardId =  resourceData.ResourceRateCardId,
                    // ResourceManagerId =  resourceData.ResourceManagerId,
                    ContractedHours =  resourceData.ContractedHours,
                    ResourceContractEffortInPercentage =  resourceData.ResourceContractEffortInPercentage,
                    ResourceType =  resourceData.ResourceType,
                    EmployeeType = resourceData.EmployeeType,

                    LastName =  resourceData.LastName,


                    Identity = new AppUser{

                        UserName = resourceData.ResourceEmailAddress,
                        Email = resourceData.ResourceEmailAddress,
                    },

                };

                var userIdentity = newresource.Identity;

                var result = await _userManager.CreateAsync(newresource.Identity, "Psalm91&&:1");

                if (result.Succeeded)
                {
                        //_appDbContext.Resources.Add(newresource).Entity;
                    _appDbContext.Add(newresource);

                    userIdentity.CompanyId = comp;
                    newresource.CompanyId = comp;
                    newresource.IdentityId = newresource.Identity.Id;
                    userIdentity.Resource = newresource;

                    // newresource.PlatformId =  resourceData?.PlatformId;
                    newresource.Identity =  newresource.Identity;




                    var resourceId = Guid.NewGuid().ToString();
                    newresource.ResourceId = resourceId;
                    userIdentity.ResourceId = resourceId;
                    newresource.ResourceNumber = "RES" + "-" + CreateNewId(resourceId).ToUpper();

                    newresource.ResourceId = resourceId;
                    userIdentity.ResourceId = resourceId;

                    newresource.UserCreatedId = user.Id;
                    newresource.UserCreatedResourceId = user.ResourceId;
                    newresource.UserModifiedResourceId = user.ResourceId;
                    newresource.UserModifiedId = user.Id;


                    newresource.Billable = true;
                    newresource.CompanyId = comp;
                    newresource.ResourceManagerId = resourceData.ResourceManagerId;
                    newresource.ResourceRateCardId = resourceData.ResourceRateCardId;


                    newresource.JanAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 1)*(resourcecontracthours/j);
                    newresource.FebAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 2)*(resourcecontracthours/j);
                    newresource.MarAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 3)*(resourcecontracthours/j);
                    newresource.AprAvailabilityBeforeHolidaysInDays = _resourceService.GetNumberOfWorkingDaysInMonth(i, 4)*(resourcecontracthours/j);
                    newresource.MayAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 5)*(resourcecontracthours/j);
                    newresource.JunAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 6)*(resourcecontracthours/j);
                    newresource.JulAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 7)*(resourcecontracthours/j);
                    newresource.AugAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 8)*(resourcecontracthours/j);
                    newresource.SepAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 9)*(resourcecontracthours/j);
                    newresource.OctAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 10)*(resourcecontracthours/j);
                    newresource.NovAvailabilityBeforeHolidaysInDays = _resourceService.GetNumberOfWorkingDaysInMonth(i, 11)*(resourcecontracthours/j);
                    newresource.DecAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 12)*(resourcecontracthours/j);

                    newresource.TotalAvailabilityBeforeHolidaysInDays = newresource.JanAvailabilityBeforeHolidaysInDays + newresource.FebAvailabilityBeforeHolidaysInDays + newresource.MarAvailabilityBeforeHolidaysInDays + newresource.AprAvailabilityBeforeHolidaysInDays
                    + newresource.MayAvailabilityBeforeHolidaysInDays + newresource.JunAvailabilityBeforeHolidaysInDays +  newresource.JulAvailabilityBeforeHolidaysInDays + newresource.AugAvailabilityBeforeHolidaysInDays
                    + newresource.SepAvailabilityBeforeHolidaysInDays + newresource.OctAvailabilityBeforeHolidaysInDays +  newresource.NovAvailabilityBeforeHolidaysInDays + newresource.DecAvailabilityBeforeHolidaysInDays;

                    // var newResource = _appDbContext.Resources.Add(newresource).Entity;

                    await _appDbContext.SaveChangesAsync();

                    newresource = Getresource(comp, resourceId);

                    var objresult = _mapper.Map<Resource, ResourceViewModel>(newresource);
                    return Ok(objresult);

                }
                return BadRequest();
            }

            return BadRequest("You are not authorised to perform this action.");
        }

        // [HttpPost("resourceaccess")]
        // [Authorize(Policy = "Admin_Group")]
        // public async Task<IActionResult> PostResourceAccess([FromBody] EditResourceData resourceData)
        // {

        //     var roleGroup = _userService.UserRoleGroup();
        //     var comp = _userService.GetSecureUserCompany();
        //     var userreportingyear = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Financerepyear).Value;
        //     var userstandarddailyhrs = HttpContext.User.Claims.Single(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Standarddailyhrs).Value;

        //     int i = 0;
        //     int j = 0;
        //     string s = userreportingyear;
        //     string h = userstandarddailyhrs;
        //     i =int.Parse(s);
        //     j =int.Parse(h);
        //     i = Convert.ToInt32(s);
        //     j = Convert.ToInt32(h);


        //     var email = HttpContext.User.Claims.Single(c => c.Type == "email").Value;
        //     // return validation error if email already exists


        //     if (resourceData.CompanyId != comp)
        //     {
        //         return BadRequest("You are not authorised to perform this action.");

        //     }
        //     if (string.IsNullOrEmpty(resourceData.ResourceEmailAddress)) // if emial field is empty or null.
        //     {
        //         ModelState.AddModelError("email", string.Format("The resource email field cannot be null.", resourceData.ResourceEmailAddress));
        //         return BadRequest(ModelState);
        //     }
        //     // return validation error if required fields aren't filled in
        //     if (!ModelState.IsValid) // return validation error if client side validation is not passed.
        //     {
        //         return BadRequest(ModelState);
        //     }
        //     if (roleGroup == "Admin_Group")
        //     {
        //         Resource existingPerson = _appDbContext.Resources
        //                             .Where(r => r.ResourceEmailAddress == resourceData.ResourceEmailAddress).FirstOrDefault();

        //         if (existingPerson != null) // if id is NOT null,then email already exists.
        //         {
        //             ModelState.AddModelError("email", string.Format("Woops! It appears {0} is already listed in the database as your company resource. Duplicate entries are not allowed.", resourceData.ResourceEmailAddress));
        //             return BadRequest(ModelState);
        //         }


        //         var newresource = _mapper.Map<EditResourceData, Resource>(resourceData);

        //         decimal? resourcecontracthours = (newresource.ResourceContractEffortInPercentage??100)/100 * j;

        //         // var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

        //         var resourceId = Guid.NewGuid().ToString();
        //         newresource.ResourceId = resourceId;
        //         newresource.AddedBy = email;
        //         newresource.Billable = true;
        //         newresource.CompanyId = comp;
        //         // newresource.AppUserRole = "None_User";
        //         newresource.ResourceNumber = "RES" + "-" + CreateNewId(resourceId).ToUpper();
        //         newresource.IsDisabled = false;
        //         newresource.ResourceManagerId = resourceData.ResourceManagerId;
        //         newresource.ResourceRateCardId = resourceData.ResourceRateCardId;

        //         if (newresource.AppUserRole == Constants.Strings.JwtClaims.AccountOwner ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.SuperAdmin ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.Admin ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.ProjectManager ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.SeniorProjectManager ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.PortfolioAdmin ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.FinanceAdmin ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.FinanceManager ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.ReadOnly ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.ReadWriteTimesheetOnly)
        //         {
        //             newresource.Identity = new AppUser{

        //                 UserName = newresource.ResourceEmailAddress,
        //                 Email = newresource.ResourceEmailAddress,
        //             };

        //             await _userManager.CreateAsync(newresource.Identity, "Psalm91:1");
        //         }

        //         // var resourceIdentity = newresource.Identity;
        //         // var createusingresource = await _userManager.CreateAsync(resourceIdentity, "Psalm91:1");


        //         // newresource.Identity = new AppUser{

        //         //     UserName = newresource.ResourceEmailAddress,
        //         //     Email = newresource.ResourceEmailAddress,
        //         // };

        //         // var resourceIdentity = newresource.Identity;

        //         // var createusingresource = await _userManager.CreateAsync(resourceIdentity, "Psalm91:1");
        //         _appDbContext.Resources.Add(newresource);

        //         if (newresource.AppUserRole == Constants.Strings.JwtClaims.AccountOwner ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.SuperAdmin ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.Admin ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.ProjectManager ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.SeniorProjectManager ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.PortfolioAdmin ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.FinanceAdmin ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.FinanceManager ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.ReadOnly ||
        //             newresource.AppUserRole == Constants.Strings.JwtClaims.ReadWriteTimesheetOnly)
        //         {
        //             newresource.Identity.Resource = newresource;
        //             newresource.Identity.CompanyId = comp;
        //             newresource.Identity.ResourceId = resourceId;
        //             newresource.IdentityId = newresource.Identity.Id;
        //         }

        //         // newresource.IdentityId = newresource.Identity.Id;

        //         newresource.JanAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 1)*(resourcecontracthours/j);
        //         newresource.FebAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 2)*(resourcecontracthours/j);
        //         newresource.MarAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 3)*(resourcecontracthours/j);
        //         newresource.AprAvailabilityBeforeHolidaysInDays = _resourceService.GetNumberOfWorkingDaysInMonth(i, 4)*(resourcecontracthours/j);
        //         newresource.MayAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 5)*(resourcecontracthours/j);
        //         newresource.JunAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 6)*(resourcecontracthours/j);
        //         newresource.JulAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 7)*(resourcecontracthours/j);
        //         newresource.AugAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 8)*(resourcecontracthours/j);
        //         newresource.SepAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 9)*(resourcecontracthours/j);
        //         newresource.OctAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 10)*(resourcecontracthours/j);
        //         newresource.NovAvailabilityBeforeHolidaysInDays = _resourceService.GetNumberOfWorkingDaysInMonth(i, 11)*(resourcecontracthours/j);
        //         newresource.DecAvailabilityBeforeHolidaysInDays =  _resourceService.GetNumberOfWorkingDaysInMonth(i, 12)*(resourcecontracthours/j);

        //         newresource.TotalAvailabilityBeforeHolidaysInDays = newresource.JanAvailabilityBeforeHolidaysInDays + newresource.FebAvailabilityBeforeHolidaysInDays + newresource.MarAvailabilityBeforeHolidaysInDays + newresource.AprAvailabilityBeforeHolidaysInDays
        //         + newresource.MayAvailabilityBeforeHolidaysInDays + newresource.JunAvailabilityBeforeHolidaysInDays +  newresource.JulAvailabilityBeforeHolidaysInDays + newresource.AugAvailabilityBeforeHolidaysInDays
        //         + newresource.SepAvailabilityBeforeHolidaysInDays + newresource.OctAvailabilityBeforeHolidaysInDays +  newresource.NovAvailabilityBeforeHolidaysInDays + newresource.DecAvailabilityBeforeHolidaysInDays;


        //         _appDbContext.SaveChanges();

        //         newresource = Getresource(comp, resourceId);

        //         var result = _mapper.Map<Resource, ResourceViewModel>(newresource);
        //         return Ok(result);
        //     }

        //     return BadRequest("You are not authorised to perform this action.");
        // }

        Company GetSecureUserCompany()
        {
            var id = HttpContext.User.Claims.Single(c => c.Type == "id").Value;
            var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

            return _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == comp);
        }


        Resource Getresource(string companyId, string id)
        {
            var resourceDb = _appDbContext.Resources.SingleOrDefault(b => (b.CompanyId == companyId) && (b.ResourceId == id));
            return resourceDb;
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
                var resource = Getresource(company, id);

                if (resource == null)
                    return BadRequest("You are not authorised to perform this action.");

                _appDbContext.Remove(resource);
                _appDbContext.SaveChanges();

                return Json("Success");
            }
            return BadRequest("You are not authorised to perform this action.");
        }
        AppUser GetSecureUser()
        {
            //var id = HttpContext.User.Claims.First().Value;
            var id = HttpContext.User.Claims.Single(c => c.Type == "id").Value;
            return _appDbContext.Users.SingleOrDefault(u => u.Id == id);
        }

        public GetResourceHolidaysTotalsByResource GetResourceHolidayTotals(List<ResourceHolidayBooked>  holidays, string resourceId, int year)
        {

         var getAllResourceHolidaysTotals =  holidays?
             .Where(rh => (rh.ResourceId == resourceId)
              &&((rh.TimesheetCalendar.SaturdayYear == year)  || (rh.TimesheetCalendar.SundayYear == year))).ToList();


            decimal? sumJanResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 1) || (g.TimesheetCalendar.SundayPeriod == 1))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumFebResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 2) || (g.TimesheetCalendar.SundayPeriod == 2))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumMarResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 3) || (g.TimesheetCalendar.SundayPeriod == 3))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumAprResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 4) || (g.TimesheetCalendar.SundayPeriod == 4))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumMayResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 5) || (g.TimesheetCalendar.SundayPeriod == 5))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumJunResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 6) || (g.TimesheetCalendar.SundayPeriod == 6))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumJulResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 7) || (g.TimesheetCalendar.SundayPeriod == 7))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumAugResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 8) || (g.TimesheetCalendar.SundayPeriod == 8))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumSepResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 9) || (g.TimesheetCalendar.SundayPeriod == 9))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumOctResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 10) || (g.TimesheetCalendar.SundayPeriod == 10))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumNovResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 11) || (g.TimesheetCalendar.SundayPeriod == 11))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();
            decimal? sumDecResourceTotalHolidayHours =  getAllResourceHolidaysTotals?
                                                 .Where(g => (g.TimesheetCalendar.SaturdayPeriod == 12) || (g.TimesheetCalendar.SundayPeriod == 12))
                                                 .Select(rh => rh.TotalHolidayHours).Sum();


            var holidayObj = new GetResourceHolidaysTotalsByResource() {

                SumJanResourceTotalHolidayHours=sumJanResourceTotalHolidayHours??0,
                SumFebResourceTotalHolidayHours=sumFebResourceTotalHolidayHours??0,
                SumMarResourceTotalHolidayHours=sumMarResourceTotalHolidayHours??0,
                SumAprResourceTotalHolidayHours=sumAprResourceTotalHolidayHours??0,
                SumMayResourceTotalHolidayHours=sumMayResourceTotalHolidayHours??0,
                SumJunResourceTotalHolidayHours=sumJunResourceTotalHolidayHours??0,
                SumJulResourceTotalHolidayHours=sumJulResourceTotalHolidayHours??0,
                SumAugResourceTotalHolidayHours=sumAugResourceTotalHolidayHours??0,
                SumSepResourceTotalHolidayHours=sumSepResourceTotalHolidayHours??0,
                SumOctResourceTotalHolidayHours=sumOctResourceTotalHolidayHours??0,
                SumNovResourceTotalHolidayHours=sumNovResourceTotalHolidayHours??0,
                SumDecResourceTotalHolidayHours=sumDecResourceTotalHolidayHours??0,

            };


          return holidayObj;
        }



        // [HttpPost]
        // [Authorize(Policy="Admin_Group")]
        // public async Task<IActionResult> Post([FromBody] EditResourceData resourceData)
        // {

        //     var roleGroup =_userService.UserRoleGroup();
        //     var comp = _userService.GetSecureUserCompany();

        //     var email = HttpContext.User.Claims.Single(c => c.Type == "name").Value;
        //     // return validation error if email already exists


        //     if (resourceData.CompanyId != comp)
        //     {
        //         return BadRequest("You are not authorised to perform this action.");

        //     }
        //     if (string.IsNullOrEmpty(resourceData.ResourceEmailAddress)) // if emial field is empty or null.
        //     {
        //         ModelState.AddModelError("email", string.Format("The resource email field cannot be null.", resourceData.ResourceEmailAddress));
        //         return BadRequest(ModelState);
        //     }
        //     // return validation error if required fields aren't filled in
        //     if (!ModelState.IsValid) // return validation error if client side validation is not passed.
        //     {
        //         return BadRequest(ModelState);
        //     }
        //     if (roleGroup=="Admin_Group")
        //     {
        //        // var companyId = comp;
        //         if (string.IsNullOrEmpty(resourceData.ResourceId)) // if id is null,then create new resource.
        //         {

        //             var newresource = _mapper.Map<EditResourceData, Resource>(resourceData);

        //             // var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

        //             var resourceId = Guid.NewGuid().ToString();
        //             newresource.ResourceId = resourceId;
        //             newresource.AddedBy = email;
        //             newresource.Billable = true;
        //             newresource.CompanyId = comp;
        //             newresource.AppUserRole = "None_User";
        //             newresource.ResourceNumber = "RES" + "-" + CreateNewId(resourceId).ToUpper();
        //             newresource.IsDisabled = false;
        //             newresource.UserCreatedEmail =  email;
        //             newresource.UserModifiedEmail =  email;
        //             newresource.DateCreated =  DateTime.UtcNow;
        //             newresource.DateModified =  DateTime.UtcNow;
        //             _appDbContext.Resources.Add(newresource);

        //             await  _appDbContext.SaveChangesAsync();

        //             newresource = Getresource(comp, resourceId);;

        //             var result = _mapper.Map<Resource, ResourceViewModel>(newresource);
        //                 return Ok(result);

        //         }
        //         else
        //         {
        //             Resource existingPerson = _appDbContext.Resources
        //                             .Where(r => r.ResourceEmailAddress == resourceData.ResourceEmailAddress).FirstOrDefault();

        //             if (existingPerson != null) // if id is NOT null,then email already exists.
        //             {
        //                 ModelState.AddModelError("email", string.Format("Woops! It appears {0} is already listed in the database as your company resource. Duplicate entries are not allowed.", resourceData.ResourceEmailAddress));
        //                 return BadRequest(ModelState);
        //             }
        //             var resource = Getresource(resourceData.CompanyId, resourceData.ResourceId);
        //             var resourcerole = resource.AppUserRole;

        //             if (resource != null)
        //             {
        //                 var incomingrole = resourceData.AppUserRole;

        //                 if (incomingrole!=Constants.Strings.JwtClaims.AccountOwner ||
        //                     incomingrole!=Constants.Strings.JwtClaims.SuperAdmin ||
        //                     incomingrole!=Constants.Strings.JwtClaims.Admin ||
        //                     incomingrole!=Constants.Strings.JwtClaims.ProjectManager ||
        //                     incomingrole!=Constants.Strings.JwtClaims.SeniorProjectManager ||
        //                     incomingrole!=Constants.Strings.JwtClaims.PortfolioAdmin ||
        //                     incomingrole!=Constants.Strings.JwtClaims.FinanceAdmin ||
        //                     incomingrole!=Constants.Strings.JwtClaims.FinanceManager ||
        //                     incomingrole!=Constants.Strings.JwtClaims.ReadOnly ||
        //                     incomingrole!=Constants.Strings.JwtClaims.ReadWriteTimesheetOnly)
        //                 {
        //                     ModelState.AddModelError("appUserRole", string.Format("{0} is not recognized as a valid role. Please use one of the roles available to you based on your permission level. ", resourceData.AppUserRole));
        //                     return BadRequest(ModelState);
        //                 }

        //                 resource.Agency = resourceData.Agency ?? resource.Agency;
        //                 resource.Billable =  resourceData.Billable;
        //                 resource.ContractedHours = resourceData.ContractedHours ?? resource.ContractedHours;
        //                 resource.ResourceRateCardId = resourceData.ResourceRateCardId ?? resource.ResourceRateCardId;
        //                 resource.EmployeeJobTitle = resourceData.EmployeeJobTitle ?? resource.EmployeeJobTitle;
        //                 resource.EmployeeRef = resourceData.EmployeeRef ?? resource.EmployeeRef;
        //                 resource.EmployeeType = resourceData.EmployeeType ?? resource.EmployeeType;
        //                 resource.Location = resourceData.Location ?? resource.Location;
        //                 resource.LocationName = resourceData.LocationName ?? resource.LocationName;

        //                 resource.PlatformId = resourceData.PlatformId ?? resource.PlatformId;
        //                 resource.ResourceContractEffortInPercentage = resourceData.ResourceContractEffortInPercentage ?? resource.ResourceContractEffortInPercentage;
        //                 resource.ResourceEndDate = resourceData.ResourceEndDate ?? resource.ResourceEndDate;
        //                 resource.ResourceManagerId = resourceData.ResourceManagerId ?? resource.ResourceManagerId;

        //                 resource.ResourceStartDate = resourceData.ResourceStartDate ?? resource.ResourceStartDate;
        //                 resource.ResourceType = resourceData.ResourceType ?? resource.ResourceType;
        //                 resource.ResourceNumber = resourceData.ResourceNumber ?? resource.ResourceNumber;

        //                 resource.CompanyId = resourceData.CompanyId ?? resource.CompanyId;
        //                 //resource.ProjectId = resourceData.ProjectId ?? resource.ProjectId;
        //                 resource.ResourceId = resource.ResourceId;


        //                 if (resource.AppUserRole == resourceData.AppUserRole)
        //                 {
        //                     resource.AppUserRole = resourceData.AppUserRole;
        //                     resource.ResourceEmailAddress = resourceData.ResourceEmailAddress ?? resource.ResourceEmailAddress;
        //                 }
        //                 else
        //                 {
        //                     if (resourcerole=="None_User")
        //                     {
        //                         // Go create a user

        //                         var userIdentity =
        //                         new AppUser
        //                         {
        //                             UserName = resourceData.ResourceEmailAddress,
        //                             Email = resourceData.ResourceEmailAddress,
        //                         };

        //                         var result = await _userManager.CreateAsync(userIdentity, "Password4:1");
        //                         userIdentity.CompanyId = resource.CompanyId;
        //                         resource.IdentityId = userIdentity.Id;

        //                         resource.AppUserRole = resourceData.AppUserRole;
        //                         resource.ResourceEmailAddress = resourceData.ResourceEmailAddress ?? resource.ResourceEmailAddress;
        //                     }
        //                     else
        //                     {
        //                         if (resourcerole==Constants.Strings.JwtClaims.AccountOwner) //Can not change AccountOwner role.
        //                         {
        //                             ModelState.AddModelError("appUserRole", string.Format("{0} is a protected user, changing their role is not allowed. ", resource.ResourceEmailAddress));
        //                             return BadRequest(ModelState);
        //                         }
        //                         if (resource.ResourceEmailAddress != resourceData.ResourceEmailAddress) //Can not change existing user email.
        //                         {
        //                             ModelState.AddModelError("resourceEmailAddress", string.Format("{0} is a protected user, changing their email address is not allowed. ", resource.ResourceEmailAddress));
        //                             return BadRequest(ModelState);
        //                         }
        //                         resource.ResourceEmailAddress = resourceData.ResourceEmailAddress ?? resource.ResourceEmailAddress;
        //                         resource.AppUserRole = resourceData.AppUserRole;
        //                     }
        //                 }
        //             }
        //             else
        //             {
        //                 return NotFound();
        //             }

        //             _appDbContext.SaveChanges();

        //             resource = Getresource(comp, resource.ResourceId);;

        //             var editedResource = _mapper.Map<Resource, ResourceViewModel>(resource);
        //             return Ok(editedResource);
        //         }
        //     }

        //     return BadRequest("You are not authorised to perform this action.");
        // }

    }
}