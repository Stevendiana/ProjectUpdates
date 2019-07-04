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
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[Authorize(Policy = "ApiUser")]
    public class DependenciesController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IForecastService _forecastService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public DependenciesController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IGetIdsWithPartIdsMethod getIdsWithPartIds,
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


        private string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }

       

        public class EditDependencyData
        {
            public string DependencyId { get; set; }
            public string DependencyCode { get; set; }
            public string ProjectId { get; set; }
            public string CompanyId { get; set; }
            public int Year { get; set; }
            public DateTime? DateRaised { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public string Deliverables { get; set; }
            public string DeliveryDate { get; set; }
            public string Importance { get; set; }
            public string Status { get; set; }
            public DateTime? Dateclosed { get; set; }
            public string Latestupdate { get; set; }
            public DateTime? LatestupdateDate { get; set; }
            public bool Cascade { get; set; }
            public string Reviewstatus { get; set; }
        }



        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {

            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var dependencyDb = _unitOfWork.Dependencies.SingleOrDefault(b => (b.CompanyId == companyId) && (b.DependencyId == id));

            if (dependencyDb == null)
            return NotFound("dependency not found");

            var dependencyData = _mapper.Map<Dependency, DependencyViewModel>(dependencyDb);

            return Ok(dependencyData);
        }


        [HttpGet("getdependencies/{companyId}/{projectId}")]
        [Authorize]
        public async Task<IEnumerable<DependencyViewModel>> Getdependencies(string companyId, string projectId)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return  await Task.FromResult<IEnumerable<DependencyViewModel>>(null);

            }

            var alldependency = _unitOfWork.Dependencies.GetAllDependenciesOnly(projectId, comp);

            return alldependency.Select(Mapper.Map<Dependency, DependencyViewModel>);
        }



        [HttpPost("dependency")]
        [Authorize]
        public ActionResult Post([FromBody] EditDependencyData dependencyData)
        {

            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (dependencyData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = _unitOfWork.Projects.GetOneProject(dependencyData.ProjectId, comp);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var companyId = comp;
            var dependency = _unitOfWork.Dependencies.GetOneDependency(dependencyData.DependencyId, comp);

            if (dependency == null)
                return NotFound();

            _mapper.Map(dependencyData, dependency);

            dependency.CompanyId = comp;
            dependency.DependencyCode = "DEPEND" + "-" + CreateNewId(dependency.DependencyId).ToUpper();


            _unitOfWork.Complete();

            dependency = _unitOfWork.Dependencies.GetOneDependency(dependencyData.DependencyId, comp);

            var result = _mapper.Map<Dependency, DependencyViewModel>(dependency);

            return Ok(result);

        }


        

        [HttpPost]
        [Authorize]
        public IActionResult Postdependency( [FromBody] EditDependencyData dependencyData)
        {
            var roleGroup =_userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (dependencyData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            if (!ModelState.IsValid) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }
            if (dependencyData.ProjectId==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var project = _unitOfWork.Projects.GetOneProject(dependencyData.ProjectId, comp);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var id = Guid.NewGuid().ToString();

            var dependency = _mapper.Map<EditDependencyData, Dependency>(dependencyData);
            dependency.CompanyId = comp;
            dependency.DependencyId = id;

            dependency.DependencyCode = "ASSUMP" + "-" + CreateNewId(dependency.DependencyId).ToUpper();

            _unitOfWork.Dependencies.Add(dependency);
            _unitOfWork.Complete();

            dependency = _unitOfWork.Dependencies.GetOneDependency(id, comp);

            var results = _mapper.Map<Dependency, DependencyViewModel>(dependency);

            return Ok(results);
        }



        [HttpDelete("{companyId}/{id}")]
        [Authorize]
        public IActionResult Deletedependency(string companyId, string id)
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
            // var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
            var company = comp;
            var dependency = _unitOfWork.Dependencies.GetOneDependency(id, comp);

            if (dependency == null)
            return BadRequest("You are not authorised to perform this action.");

            _unitOfWork.Dependencies.Remove(dependency);
            _unitOfWork.Complete();

            return Json("Success");
        }

    }

}