using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers.Resources
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ResourceHolidayController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IForecastService _forecastService;
        private readonly IResourceService _resourceService;
        private readonly IPermissionsMethods _permissionsMethods;
        private readonly IMapper _mapper;


        public ResourceHolidayController(UserManager<AppUser> userManager, IUserService userService, IPermissionsMethods permissionsMethods, IForecastService forecastService, IResourceService resourceService, ProjectCentreDbContext appDbContext, IMapper mapper)
        {
            _userService = userService;
            _userManager = userManager;
            _permissionsMethods = permissionsMethods;
            _appDbContext = appDbContext;
            _forecastService = forecastService;
            _resourceService = resourceService;
            _mapper = mapper;
        }

        private static string CreateNewId(string Id)
        {
            GeneratePublicId generatePublicId = new GeneratePublicId();
            return generatePublicId.PartId(Id, 8);
        }

        [Authorize]
        [HttpGet("{companyId}/{resourceid}/{id}")]
        public ActionResult GetResourceHolidays(string companyId, string resourceid, string id)
        {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }

            var holidayInDb = _appDbContext.ResourceHolidays.Where(b => (b.CompanyId == companyId) && (b.ResourceId == resourceid)).SingleOrDefault(b => (b.ResourceHolidayBookedId == id));


            if (holidayInDb == null)
                return NotFound();

            var holidayData = _mapper.Map<ResourceHolidayBooked, ResourceHolidayViewModel>(holidayInDb);

            return Ok(holidayData);
        }


        [HttpGet("{companyId}/{id}")]
        [Authorize(Policy = "Admin_Group")]
        public async Task<IEnumerable<ResourceHolidayViewModel>> GetResources(string companyId, string id)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (roleGroup=="Admin_Group")
            {
                if ( companyId == comp)
                {
                    var resourceHolidays = await _appDbContext.ResourceHolidays.Where(b => (b.CompanyId == companyId) && (b.ResourceId == id)).ToListAsync();

                    return resourceHolidays.Select(Mapper.Map<ResourceHolidayBooked, ResourceHolidayViewModel>);
                }
                return await Task.FromResult<IEnumerable<ResourceHolidayViewModel>>(null);
            }
            return  await Task.FromResult<IEnumerable<ResourceHolidayViewModel>>(null);
        }





    }
}


