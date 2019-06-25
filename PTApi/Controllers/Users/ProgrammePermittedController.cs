using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCentreBackend.Core.Interfaces;
using ProjectCentreBackend.Models;
using ProjectCentreBackend.Models.Entities;
using ProjectCentreBackend.Persistence;
using ProjectCentreBackend.ViewModels;

namespace ProjectCentreBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProgrammePermittedController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public ProgrammePermittedController(UserManager<AppUser> userManager, IMapper mapper, ProjectCentreDbContext appDbContext, IUserService userService)
        {
            _userManager = userManager;
            _userManager = userManager;
            _mapper = mapper;
            _userService = userService;
            _appDbContext = appDbContext;
        }

        public class DbItems
        {
            public string Id { get; set; }
            public string ParentId { get; set; }
        }

        public class NewProjectPermittedItems : BaseEntity
        {

            public string Id { get; set; }
            public string ProjectId { get; set; }
            public Project Project { get; set; }
            public bool ReadWritePermission { get; set; }
            [Required]
            public string ResourceId { get; set; }
            public Resource Resource { get; set; }
            [Required]
            public string CompanyId { get; set; }
            public Company Company { get; set; }
            public ICollection<string> ResourcesPermitted { get; set; }


            public NewProjectPermittedItems()
            {
                ResourcesPermitted = new Collection<string>();
            }
        }



        //Get All resources' projects permitted.
        [Authorize]
        [HttpGet("programmespermitted/{companyId}/{resourceId}")]
        public async Task<IEnumerable<ProgrammePermittedViewModel>> GetProgrammesPermitted(string companyId, string resourceId)
        {
            if (!string.IsNullOrEmpty(companyId) && !string.IsNullOrEmpty(resourceId))
            {
                if (_userService.UserRoleGroup() == "Admin_Group")
                {
                    var allProgrammesPermittedAdmin = await _appDbContext.Programmes.Where(b => (b.CompanyId == companyId)).ToListAsync();
                    return Mapper.Map<List<Programme>, List<ProgrammePermittedViewModel>>(allProgrammesPermittedAdmin);
                }

                var allProgrammesPermittedNon_Admin = await _appDbContext.ProgrammePermitted
                            .Where(b => (b.CompanyId == companyId) && (b.ResourceId == resourceId)).Include(b => b.Programme).ToListAsync();

                return Mapper.Map<List<ProgrammePermitted>, List<ProgrammePermittedViewModel>>(allProgrammesPermittedNon_Admin);

            }
            return await Task.FromResult<IEnumerable<ProgrammePermittedViewModel>>(null);
        }

        [HttpPost]
        [Authorize(Policy ="Admin_Group")]
        public async Task<IActionResult> CreateProgrammePermission([FromBody] ProgrammePermittedViewModel model)
        {
            var comp = _userService.GetSecureUserCompany();
            var projects = _appDbContext.Projects.Where(p => (p.CompanyId == comp)).ToList();
                                                 //.Select(row => new Project { Id = row.Id, ProgrammeId = row.ProgrammeId });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var permission = _mapper.Map<ProgrammePermittedViewModel, ProgrammePermitted>(model);
            permission.CompanyId = comp;
            permission.ProgrammeId = model.ProgrammeId;
            permission.ResourceId = model.ResourceId;
            permission.CompanyId = comp;
            permission.CompanyId = comp;

            _appDbContext.ProgrammePermitted.Add(permission);


            var programmesPermitted = new HashSet<string>(_appDbContext.ProgrammePermitted.Where(b => (b.CompanyId == model.CompanyId) && b.ResourceId == model.ResourceId).Select(p => p.ProgrammeId));
            var programmeProjects = projects.Where(p => programmesPermitted.Contains(p.ProgrammeId)).ToList();


            foreach (var project in programmeProjects)
            {
                bool dBProjectPermissions = _appDbContext.ProjectPermitted.Any(x => x.ProjectId == project.ProjectId);
                if (dBProjectPermissions)
                    continue;
                {
                    NewProjectPermittedItems newProjectPermissionItem = new NewProjectPermittedItems();
                    var newProjectPermission = _mapper.Map<NewProjectPermittedItems, ProjectPermitted>(newProjectPermissionItem);

                    newProjectPermission.CompanyId = comp;
                    newProjectPermission.ProjectId = project.ProjectId;
                    newProjectPermission.ResourceId = model.ResourceId;

                    _appDbContext.ProjectPermitted.Add(newProjectPermission);
                }

            }

            // var CurrentlyPermittedProjects =  _appDbContext.ProjectPermitted.Where(b => (b.CompanyId == model.CompanyId) && b.ResourceId == model.ResourceId);

            // var projectsPermitted = new HashSet<string>(CurrentlyPermittedProjects.Select(p => p.ProjectId));



            // var Projectprojects = projects.Where(p => projectsPermitted.Contains(p.Id)).ToList();

            // var dict = Projectprojects.ToDictionary(p => new DbItems {Id = p.Id, ParentId = p.ParentId });

            // List<DbItems> programmeProjectslist = new List<DbItems>(programmeProjects);
            // List<DbItems> Projectprojectslist = new List<DbItems>(Projectprojects);
            // List<DbItems> newlist = Projectprojectslist.Union(programmeProjectslist).ToList();

            // _appDbContext.ProjectPermitted.RemoveRange(CurrentlyPermittedProjects);

            await _appDbContext.SaveChangesAsync();
            return Ok(GetAllProgrammeResourcePermitted(comp, permission.ProgrammeId));
        }

        public async Task<IEnumerable<ProgrammePermittedViewModel>> GetAllProgrammeResourcePermitted(string companyId, string id)
        {
            var allprogrammePermittedDb = await _appDbContext.ProgrammePermitted.Where(b => (b.CompanyId == companyId) && (b.ProgrammeId == id)).Include(b => b.Programme).Include(b => b.Resource).ToListAsync();

            return  Mapper.Map<List<ProgrammePermitted>, List<ProgrammePermittedViewModel>>(allprogrammePermittedDb);;
        }

        ProgrammePermitted GetprogrammePermitted(string companyId, string id)
        {
            var programmePermittedDb = _appDbContext.ProgrammePermitted.SingleOrDefault(pp => (pp.CompanyId == companyId) && (pp.ProgrammeId == id));
            return programmePermittedDb;
        }
    }
}