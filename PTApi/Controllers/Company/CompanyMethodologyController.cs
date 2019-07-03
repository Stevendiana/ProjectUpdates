using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTApi.Data.Repositories;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Services;
using PTApi.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PTApi.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CompanyMethodologiesController: Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;

        public CompanyMethodologiesController(UserManager<ApplicationUser> userManager, IUserService userService,
            IMapper mapper, IGeneratePublicIdMethod getpublicId, IGetIdsWithPartIdsMethod getIdsWithPartIds, IUnitOfWork unitOfWork)
        {
            _userService = userService;
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

        public class EditCompanyMethodologyStagesData
        {
            public string CompanyMethodologyStageId { get; set; }
            public string CompanyMethodologyId { get; set; }
            public string CompanyId { get; set; }
            public string CompanyMethodologyStageNumber { get; set; }
            public string MethodologyName { get; set; }
            public string CompanyMethodologyStageName { get; set; }
            public string MethodologyStageNotes { get; set; }
        }

        public class NewCompanyMethodologyData
        {
            public string CompanyMethodologyId { get; set; }
            public string CompanyId { get; set; }
            public string MethodologyName { get; set; }
            public string MethodologyNotes { get; set; }


            public ICollection<CompanyMethodologyStage> Stages { get; set; }

            public NewCompanyMethodologyData()
            {
                Stages = new Collection<CompanyMethodologyStage>();
            }
        }

        public class EditCompanyMethodologyData
        {
            public string CompanyMethodologyId { get; set; }
            public string CompanyId { get; set; }
            public string MethodologyName { get; set; }
            public string MethodologyNotes { get; set; }
        }

        public class NewCompanyMethodologyStagesData
        {
            public string CompanyMethodologyId { get; set; }
            public string CompanyId { get; set; }
            public string CompanyMethodologyStageNumber { get; set; }
            public string MethodologyName { get; set; }
            public string CompanyMethodologyStageName { get; set; }
            public string MethodologyStageNotes { get; set; }
        }


        [Authorize]
        [HttpGet("{companyId}/{id}")]
        public ActionResult Get(string companyId, string id) {
            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            var companymethodologyDb = _unitOfWork.CompanyMethodologies.GetCompanyMethodologyWithCompanyMethodologyStages(id, comp);

            if(companymethodologyDb == null)
            return NotFound("Methodology not found");

            var companymethodologyData = _mapper.Map<CompanyMethodology, CompanyMethodologyViewModel>(companymethodologyDb);

            return Ok(companymethodologyData);
        }



        //[Authorize]
        [HttpPost("companymethodology")]
        public ActionResult Edit([FromBody] IEnumerable<EditCompanyMethodologyStagesData> companyMethodologyStages, EditCompanyMethodologyData editCompanyMethodologyData)
        {
            var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
            var roleGroup =_userService.UserRoleGroup();

            if (editCompanyMethodologyData.CompanyId != comp)
            {
                return BadRequest("You are not authorised to perform this action.");

            }
            // return validation error if email already exists
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var companymethodology = _unitOfWork.CompanyMethodologies.GetCompanyMethodology( editCompanyMethodologyData.CompanyMethodologyId, comp);
                if (companymethodology!=null)
                {
                    companymethodology.MethodologyName = editCompanyMethodologyData.MethodologyName ?? companymethodology.MethodologyName;
                    companymethodology.MethodologyNotes = editCompanyMethodologyData.MethodologyNotes ?? companymethodology.MethodologyNotes;
                    companymethodology.CompanyId = comp;

                    foreach (var item in companyMethodologyStages)
                    {
                        var companymethodologystage = _unitOfWork.CompanyMethodologyStages.GetOneCompanyMethodologyStage(item.CompanyMethodologyStageId, comp );

                        companymethodologystage.CompanyMethodologyStageNumber = item.CompanyMethodologyStageNumber ?? companymethodologystage.CompanyMethodologyStageNumber;
                        companymethodologystage.CompanyId = comp;
                        companymethodologystage.CompanyMethodologyId = item.CompanyMethodologyId ?? companymethodologystage.CompanyMethodologyId;
                        companymethodologystage.CompanyMethodologyStageName = item.CompanyMethodologyStageName ?? companymethodologystage.CompanyMethodologyStageName;
                        companymethodologystage.MethodologyStageNotes = item.MethodologyStageNotes ?? companymethodologystage.MethodologyStageNotes;

                        continue;
                    }

                    _unitOfWork.Complete();

                    var all = _unitOfWork.CompanyMethodologies.GetCompanyMethodologyWithCompanyMethodologyStages(companymethodology.CompanyMethodologyId, comp);
                    var allmethod = _mapper.Map<CompanyMethodology, CompanyMethodologyViewModel>(all);

                    return Ok(allmethod);

                }
                return NotFound();
            }
        }



        [HttpPost("new")]
        [Authorize]
        // public IActionResult PostCompanyMethodology([FromBody] NewCompanyMethodologyData newCompanyMethodology)
        public IActionResult PostCompanyMethodology([FromBody] List<NewCompanyMethodologyStagesData> companyMethodologyStage, NewCompanyMethodologyData newCompanyMethodology)
        {
            var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

            // return validation error if email already exists
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var CompanyMethodology = new CompanyMethodology
                {
                    CompanyId = comp,
                    MethodologyName = newCompanyMethodology.MethodologyName,
                    MethodologyNotes = newCompanyMethodology.MethodologyNotes,
                };

                _unitOfWork.CompanyMethodologies.Add(CompanyMethodology);

                var methid =CompanyMethodology.CompanyMethodologyId;

                // foreach (var item in companyMethodologyStage)
                foreach (var item in companyMethodologyStage)
                {
                    var CompanyMethodologyStages =
                    new CompanyMethodologyStage {

                    CompanyId = comp,
                    CompanyMethodologyStageNumber = item.CompanyMethodologyStageNumber,
                    CompanyMethodologyStageName = item.CompanyMethodologyStageName,
                    MethodologyStageNotes = item.MethodologyStageNotes,
                    CompanyMethodologyId = methid

                    };

                    _unitOfWork.CompanyMethodologyStages.Add(CompanyMethodologyStages);
                    continue;
                }

                _unitOfWork.Complete();

                var all = _unitOfWork.CompanyMethodologies.GetCompanyMethodologyWithCompanyMethodologyStages(methid, comp);
                var allmethod = _mapper.Map<CompanyMethodology, CompanyMethodologyViewModel>(all);
                return Ok(allmethod);
            }
        }
    }
}