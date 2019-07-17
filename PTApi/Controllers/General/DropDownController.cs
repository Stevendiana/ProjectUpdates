using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTApi.Data.Repositories;
using PTApi.Helpers;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static PTApi.Helpers.Constants.Strings;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class DropDownController: Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;

        public DropDownController(UserManager<ApplicationUser> userManager, IUserService userService,
            IMapper mapper, IGeneratePublicIdMethod getpublicId, IGetIdsWithPartIdsMethod getIdsWithPartIds, IUnitOfWork unitOfWork)
        {
            _userService = userService;
            _getIdsWithPartIds = getIdsWithPartIds;
            _getpublicId = getpublicId;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }


        public class EnumValue
        {
            public string Name { get; set; }
            public int? Value { get; set; }
        }

        public static class EnumExtensions
        {
            public static List<EnumValue> GetValues<T>()
            {
                List<EnumValue> values = new List<EnumValue>();
                foreach (var itemType in Enum.GetValues(typeof(T)))
                {
                    //For each value of this enumeration, add a new EnumValue instance
                    values.Add(new EnumValue()
                    {
                        Name = Enum.GetName(typeof(T), itemType),
                        Value = (int)itemType
                    });
                }
                return values;
            }
        }

        [HttpGet]
        [Route("giveaccess")]
        public IActionResult GetCanGiveAccess()
        {
            var rol = HttpContext.User.Claims.Single(c => c.Type == "rol").Value;

            if(rol == Constants.Strings.JwtClaims.AccountOwner )
            {
                return Ok(EnumExtensions.GetValues<AccountOwnerCanGiveAccess>());
            }
            if (rol == Constants.Strings.JwtClaims.SuperAdmin)
            {
                return Ok(EnumExtensions.GetValues<SuperAdminCanGiveAccess>());

            }
            if (rol == Constants.Strings.JwtClaims.Admin)
            {
                return Ok(EnumExtensions.GetValues<AdminCanGiveAccess>());
            }
            else
            {
                return BadRequest("You are not authorized.");
            }

        }

        [HttpGet]
        [Route("costcategory")]
        public IActionResult GetCostCategory()
        {
            return Ok(EnumExtensions.GetValues<CostCategory>());
        }

        [HttpGet]
        [Route("projectstatus")]
        public IActionResult GetProjectStatus()
        {
            return Ok(EnumExtensions.GetValues<ProjectOperationalStatus>());
        }

        [HttpGet]
        [Route("costtype")]
        public IActionResult GetCostType()
        {
            return Ok(EnumExtensions.GetValues<CostType>());
        }

        [HttpGet]
        [Route("costsubcategory")]
        public IActionResult GetCostSubCategory()
        {
            return Ok(EnumExtensions.GetValues<CostSubCategory>());
        }


        [HttpGet]
        [Route("reportingperiod")]
        public IActionResult GetReportingPeriod()
        {
            return Ok(EnumExtensions.GetValues<ReportingPeriod>());
        }



        [HttpGet]
        [Route("employeetypes")]
        public IActionResult GetEmployeeTypes()
        {
            return Ok(EnumExtensions.GetValues<EmployeeTypes>());
        }

        [HttpGet]
        [Route("resourcetypes")]
        public IActionResult GetResourceTypes()
        {
            return Ok(EnumExtensions.GetValues<ResourceTypes>());
        }

        [HttpGet]
        [Route("statusworkflows")]
        public IActionResult GetStatusWorkFlows()
        {
            return Ok(EnumExtensions.GetValues<StatusWorkFlows>());
        }

        [HttpGet]
        [Route("ragstatus")]
        public IActionResult GetRagStatus()
        {
            return Ok(EnumExtensions.GetValues<RagStatus>());
        }


        [HttpGet]
        [Route("standardfulltimeeffort")]
        public IActionResult GetStandardFullTimeEffort()
        {
            return Ok(EnumExtensions.GetValues<StandardFullTimeEffort>());
        }

        [HttpGet]
        [Route("futurereportingyear")]
        public IActionResult FutureReportingYear()
        {
             Dictionary<string, int?> ReportingYear = new Dictionary()
             {
                //  {GetCurrentYear().Current_Year+5},

                ["Current_Year"] = GetCurrentYear().Current_Year ,
                ["Current_Year+1"] = GetCurrentYear().Current_Year+1 ,
                ["Current_Year+2"] = GetCurrentYear().Current_Year+2 ,
                ["Current_Year+3"] = GetCurrentYear().Current_Year+3 ,
                ["Current_Year+4"] = GetCurrentYear().Current_Year+4 ,
                ["Current_Year+5"] = GetCurrentYear().Current_Year+5 ,
            };

            List<AppYears> appYearsList = new List<AppYears>();


            foreach(string item in ReportingYear.Keys)
            {
                AppYears appYears = new AppYears();
                appYears.Year = ReportingYear[item];

                appYearsList.Add(appYears);
                continue;
            }

            // Console.WriteLine(ReportingYear[GetCurrentYear().Current_Year]);
            return Ok(appYearsList);
        }

        [HttpGet]
        [Route("pastreportingyear")]
        public IActionResult PastReportingYear()
        {
             Dictionary<string, int?> ReportingYear = new Dictionary()
             {
                //  {GetCurrentYear().Current_Year+5},

                ["Current_Year"] = GetCurrentYear().Current_Year ,
                ["Current_Year+1"] = GetCurrentYear().Current_Year-1 ,
                ["Current_Year+2"] = GetCurrentYear().Current_Year-2 ,
                ["Current_Year+3"] = GetCurrentYear().Current_Year-3 ,
                ["Current_Year+4"] = GetCurrentYear().Current_Year-4 ,
                ["Current_Year+5"] = GetCurrentYear().Current_Year-5 ,
            };

            List<AppYears> appYearsList = new List<AppYears>();

            foreach(var item in ReportingYear.Keys)
            {
                AppYears appYears = new AppYears();
                appYears.Year = ReportingYear[item];

                appYearsList.Add(appYears);
                continue;
            }

            // Console.WriteLine(ReportingYear[GetCurrentYear().Current_Year]);
            return Ok(appYearsList);
        }

        public class AppYears
        {
            //public string Name { get; set; }
            public int? Year { get; set; }
        }
        public class CurrentYear
        {
            public int? Current_Year { get; set; }

        }

        public CurrentYear GetCurrentYear()
        {
            int? currentYear = DateTime.Now.Year;
            return  new CurrentYear(){
            Current_Year = currentYear
            };
        }


    }

    internal class Dictionary : Dictionary<string, int?>
    {
    }
}