using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTApi.Controllers.Resources;
using PTApi.Data.Repositories;
using PTApi.Methods;
using PTApi.Models;
using PTApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Actuals")]
    //[Authorize(Policy = "ApiUser")]
    public class ActualController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;

        public ActualController(UserManager<ApplicationUser> userManager, IMapper mapper, IGeneratePublicIdMethod getpublicId, IGetIdsWithPartIdsMethod getIdsWithPartIds, IUnitOfWork unitOfWork)
        {
            _getIdsWithPartIds = getIdsWithPartIds;
            _getpublicId = getpublicId;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }


        public string CreateNewId(string ActualId, int length){

           return _getpublicId.PartId(ActualId,8);
        }


        [Authorize]
        [HttpGet("{companyId}")]
        public ActionResult Get(string companyId)
        {
            var list = _unitOfWork.Actuals.GetAllCompanyActuals(companyId);
            return Ok(list);
        }


        [Authorize]
        [HttpGet("{companyId}/{projectId}")]
        public async Task<IEnumerable<ActualViewModel>> GetProjectActuals(string companyId, string projectId)
        {

            if (!string.IsNullOrEmpty(companyId) && !string.IsNullOrEmpty(projectId))
            {
                 var actuals = _unitOfWork.Actuals.GetAllProjectActuals(companyId, projectId);

                return Mapper.Map<IEnumerable<Actual>, IEnumerable<ActualViewModel>>(actuals);

            }
            return await Task.FromResult<IEnumerable<ActualViewModel>>(null);
        }


        [HttpPost]
        public IActionResult PostActual(string companyId, [FromBody] SaveActualResource anactual)
        {
            if (ModelState.IsValid)
            {
                var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
                if (companyId==comp)
                {
                    var uploadBatchNumber = Guid.NewGuid().ToString();

                    var oneactual = _mapper.Map<SaveActualResource, Actual>(anactual);

                    oneactual.ProjectId = _getIdsWithPartIds.GetProjectCredentials(anactual.ActualProjectCode).ProjectId.ToString();
                    oneactual.ProjectName = _getIdsWithPartIds.GetProjectCredentials(anactual.ActualProjectCode).ProjectName.ToString();
                    oneactual.CompanyId = companyId;
                    oneactual.UploadBatchNumber = uploadBatchNumber;


                    _unitOfWork.Actuals.Add(oneactual);
                    oneactual.ActualCode = "ACT" + "-" + CreateNewId(anactual.ActualId,8).ToUpper();

                    _unitOfWork.Complete();

                    oneactual = _unitOfWork.Actuals.GetActual(oneactual.ActualId).Result;

                    var result = _mapper.Map<Actual, ActualViewModel>(oneactual);
                    // result.TotalAllocatedAmount = _getIdsWithPartIds.GetTotalAllocatedAmountFromReconcileActual(oneactual.ActualId, oneactual.ProjectId);

                    return Ok(result);
                }
                return BadRequest("You dont have the right permission to perform this action.");
            }
            return BadRequest(ModelState);
        }

        [HttpPost("{companyId}")]
        public async Task <IActionResult> PostActuals(string companyId, [FromBody]IEnumerable<SaveActualResource> aList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
                if (companyId==comp)
                {
                    var uploadBatchNumber = Guid.NewGuid().ToString();

                    foreach (var item in aList)
                    {

                        var actual = _mapper.Map<SaveActualResource, Actual>(item);

                        actual.ProjectId = _getIdsWithPartIds.GetProjectCredentials(item.ActualProjectCode).ProjectId.ToString();
                        actual.ProjectName = _getIdsWithPartIds.GetProjectCredentials(item.ActualProjectCode).ProjectName.ToString();
                        actual.CompanyId = companyId;
                        actual.UploadBatchNumber = uploadBatchNumber;


                        _unitOfWork.Actuals.Add(actual);
                        actual.ActualCode = "ACT" + "-" + CreateNewId(item.ActualId,8).ToUpper();
                        continue;
                    };

                    _unitOfWork.Complete();
                    var result = await _unitOfWork.Actuals.GetRecentlyUploadedActuals(comp, uploadBatchNumber);

                    List<ActualViewModel> actuals = new List<ActualViewModel>();
                    foreach (var item in result)
                    {
                        var actualViewModel = _mapper.Map<Actual, ActualViewModel>(item);
                        // actualViewModel.TotalAllocatedAmount =_getIdsWithPartIds.GetTotalAllocatedAmountFromReconcileActual(item.ActualId, item.ProjectId);

                        actuals.Add(actualViewModel);
                        continue;
                    }

                    return Ok(actuals);
                }

                return BadRequest("You dont have the right permission to perform this action.");
            }
        }
    }

}