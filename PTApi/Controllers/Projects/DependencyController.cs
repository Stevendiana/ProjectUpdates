using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectCentreBackend.Models;
using ProjectCentreBackend.Models.Entities;
using ProjectCentreBackend.Models.Methods;
using ProjectCentreBackend.Persistence;
using ProjectCentreBackend.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ProjectCentreBackend.Core.Interfaces;

namespace ProjectCentreBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/dependencies")]
    //[Authorize(Policy = "ApiUser")]
    public class DependencyController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;


        public DependencyController(UserManager<AppUser> userManager, IUserService userService, IProjectService projectService, ProjectCentreDbContext appDbContext, IMapper mapper)
        {
            _userService = userService;
            _projectService = projectService;
            _userManager = userManager;
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        private static string CreateNewId(string id)
        {
            GeneratePublicId generatePublicId = new GeneratePublicId();
            return generatePublicId.PartId(id, 8);
        }

        public static string WriteMonthInWords(int period){

           ConvertPeriodNumbersToWords convertPeriodNumbersToWords = new ConvertPeriodNumbersToWords();
           return convertPeriodNumbersToWords.ConvertMonthNumbersToWords(period);
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
            var dependencyDb = _appDbContext.Dependencies.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.DependencyId == id));

            if(dependencyDb == null)
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

            var alldependency = await _appDbContext.Dependencies.Where(p => (p.CompanyId == companyId) && (p.ProjectId == projectId)).ToListAsync();

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

            var project = Getproject(comp, dependencyData.ProjectId);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var companyId = comp;
            var dependency = Getdependency(companyId, dependencyData.DependencyId);

            if (dependency == null)
                return NotFound();

            _mapper.Map<EditDependencyData, Dependency>(dependencyData, dependency);

            dependency.CompanyId = comp;
            dependency.DependencyCode = "ASSUMP" + "-" + CreateNewId(dependency.DependencyId).ToUpper();


            _appDbContext.SaveChanges();

            dependency = Getdependency(comp, dependency.DependencyId);

            var result = _mapper.Map<Dependency, DependencyViewModel>(dependency);

            return Ok(result);

        }


        Company GetSecureUserCompany()
        {
            var id = HttpContext.User.Claims.Single(c => c.Type == "id").Value;
            var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

            return _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == comp);
        }



        Dependency Getdependency(string companyId, string id)
        {
            var dependencyDb =  _appDbContext.Dependencies.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.DependencyId == id));
            return dependencyDb;
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

            var project = Getproject(comp, dependencyData.ProjectId);

            if (project==null) // return validation error if client side validation is not passed.
            {
                return BadRequest(ModelState);
            }

            var id = Guid.NewGuid().ToString();

            var dependency = _mapper.Map<EditDependencyData, Dependency>(dependencyData);
            dependency.CompanyId = comp;
            dependency.DependencyId = id;

            dependency.DependencyCode = "ASSUMP" + "-" + CreateNewId(dependency.DependencyId).ToUpper();

            var newdependency = _appDbContext.Dependencies.Add(dependency).Entity;
            _appDbContext.SaveChanges();

            dependency = Getdependency(comp, id);

            var results = _mapper.Map<Dependency, DependencyViewModel>(dependency);

            return Ok(results);
        }

        Project Getproject(string companyId, string projectId)
        {
            var projectDb = _appDbContext.Projects.SingleOrDefault(r => (r.CompanyId == companyId)&& (r.ProjectId == projectId));
            return projectDb;
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
            var dependency = Getdependency(company, id);

            if (dependency == null)
            return BadRequest("You are not authorised to perform this action.");

            _appDbContext.Remove(dependency);
            _appDbContext.SaveChanges();

            return Json("Success");
        }

    }

}