using Microsoft.AspNetCore.Mvc;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using static PTApi.Repositories.ResourceTimesheetRepository;

namespace PTApi.Controllers.Timesheet
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetSummaryController : ControllerBase
    {

        private readonly IResourceTimesheetRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;

        public TimesheetSummaryController(IResourceTimesheetRepository repository, IUnitOfWork unitOfWork, IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userService = userService;
            //this.mapper = mapper;
        }


        // GET: api/TimesheetSummary
        
        [HttpGet]
        public ActionResult <IEnumerable<TimesheetTotals>> Get()
        {
            return Ok(_unitOfWork.ResourceTimesheets.GetAllResourceTimesheetsToDate("8a52f6e0-045b-4cc1-ae8c-b4f1975c5bef", "f1ee55c4-d930-43e5-8c91-e14c3a550168"));
        
        }

        [HttpGet("{resourceId}/{companyId}")]
        public IEnumerable<ForecastTask> GetTimesheet(string resourceId, string companyId)
        {
            return _unitOfWork.ResourceTimesheets.GetOneResourceTimeForecast("8a52f6e0-045b-4cc1-ae8c-b4f1975c5bef", "f1ee55c4-d930-43e5-8c91-e14c3a550168");
            //return _unitOfWork.ResourceTimesheets.GetAllTimesheetDatesToDate();
            //return _repository.GetAllTimesheetDatesToDate();
        }

        //public async Task<QueryResultResource<VehicleResource>> GetVehicles(VehicleQueryResource filterResource)
        //{
        //    var filter = mapper.Map<VehicleQueryResource, VehicleQuery>(filterResource);
        //    var queryResult = await repository.GetVehicles(filter);

        //    return mapper.Map<QueryResult<Vehicle>, QueryResultResource<VehicleResource>>(queryResult);
        //}

        // GET: api/TimesheetSummary/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TimesheetSummary
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TimesheetSummary/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
