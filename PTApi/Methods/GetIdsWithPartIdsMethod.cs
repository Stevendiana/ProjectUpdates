using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Methods;

namespace PTApi.Methods
{
    public class GetIdsWithPartIdsMethod : IGetIdsWithPartIdsMethod
    {
         private readonly ApplicationDbContext _appDbContext;

        public GetIdsWithPartIdsMethod(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public GetIdsWithPartIdsMethod()
        {

        }

        public class ResourceUtilization
        {
            public decimal? ResourceCompanyStandardHours { get; set; }
            public decimal? ResourceContractedEffortHours { get; set; }
        }

        public class ProjectCredentials
        {
            public string ProjectId { get; set; }
            public string ProjectName { get; set; }
        }


        public string GetDisplayName( string thiscompanyId, string thisuserName)
        {

            string companyId = thiscompanyId ?? "None provided";
            string userName = thisuserName ?? "None provided";

            if (companyId!="None provided"&&
                userName!="None provided")
            {
                 //GetIdsWithPartIds getIdsWithPartIds=new GetIdsWithPartIds();
                 // ApplicationDbContext _appDbContext=new ApplicationDbContext();
                  string resourceDb = _appDbContext.Resources.SingleOrDefault(b => (b.CompanyId == companyId)&& (b.ResourceId == userName)).FirstName;
                    //     var displayName = resourceDb?.ResourceSurname + ", " + resourceDb?.ResourceFirstName;
                    // return displayName;
                    return resourceDb;
                    //return resourceDb.ResourceFirstName;
                // var getUserDisplayName = _appDbContext.Users.Where(u => (u.CompanyId == companyId)
                //                         && (u.UserName == userName)).SingleOrDefault();
                // var getResourceDisplayName = _appDbContext.Resources.Where(u => (u.CompanyId == companyId)
                //                         && (u.ResourceEmailAddress == userName)).SingleOrDefault();
            }
            else
            {
                 return "None provided";
            }

                // var resourceFirstName =  getResourceDisplayName.ResourceFirstName??getResourceDisplayName.ResourceEmailAddress;
                // var resourceSurname =  getResourceDisplayName.ResourceSurname??getResourceDisplayName.ResourceEmailAddress;

                // string resourceFirstName =  getResourceDisplayName.ResourceFirstName??thisuserName;
                // string resourceSurname =  getResourceDisplayName?.ResourceSurname??thisuserName;


                // if (resourceFirstName==getResourceDisplayName.ResourceFirstName&&
                //     resourceSurname==getResourceDisplayName.ResourceSurname)
                // {
                //     var displayName = getResourceDisplayName?.ResourceSurname + ", " + getResourceDisplayName?.ResourceFirstName;
                //     return displayName;
                // }
                // else
                // {
                //      return thisuserName;
                // }
        }


        public string GetActualCompanyId(string companyCode)
        {
            var getActualCompanyId = _appDbContext.Companies.SingleOrDefault(c => c.CompanyCode == companyCode);
            return getActualCompanyId.CompanyId;
        }

        public string GetCompanyCode(string id)
        {
            var getCompanyCode = _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == id);
            return getCompanyCode.CompanyCode;
        }

        public string GetResourceDisplayName(string companyId, string userName)
        {
            //ProjectViewModel projectViewModel = new ProjectViewModel();

            string thiscompanyId = companyId ?? "None provided";
            string thisuserName = userName ?? "None provided";
            //ProjectViewModel projectViewModel = new ProjectViewModel();

            if (thisuserName == "None provided")
            {
                return "None provided";
            }
            else
            {
               return GetDisplayName(thiscompanyId, thisuserName );
            }

        }


        public ResourceUtilization GetCompanyStandardDailyHours(string resourceId)
        {
            var getResource = _appDbContext.Resources.Include(r => r.Company).SingleOrDefault(r => r.ResourceId == resourceId);
            decimal? resourceCompanyStandardHours = getResource.Company.StandardDailyHours;
            decimal? resourceContractedEffortHours = getResource.ResourceContractEffortInPercentage;

            var resourceUtilizationObj = new ResourceUtilization()
            {
                ResourceCompanyStandardHours = resourceCompanyStandardHours,
                ResourceContractedEffortHours = resourceContractedEffortHours,
            };
            return resourceUtilizationObj;
        }

        public string GetActualProjectId(string projectCode)
        {
            var getActualProjectId = _appDbContext.Projects.SingleOrDefault(p => p.ProjectRef == projectCode);
            //return getActualProjectId;
            return getActualProjectId.ProjectId.ToString();
        }

        public ProjectCredentials GetProjectCredentials(string projectCode)
        {
            var getProjectCredentials = _appDbContext.Projects.SingleOrDefault(p => p.ProjectRef == projectCode);
            string projectId = getProjectCredentials.ProjectId;
            string projectName = getProjectCredentials.ProjectName;


            var projectCredentialsObj = new ProjectCredentials()
            {
                ProjectId = projectId,
                ProjectName = projectName,
            };
            return projectCredentialsObj;
        }

        public decimal? GetTotalAllocatedAmountFromReconcileActual(string actualId, string projectId)
        {
            decimal? getTotalAllocatedAmountFromReconcileActual = _appDbContext.ReconciledActuals
              .Where(ra => (ra.ActualId == actualId)
               && (ra.ForecastTask.ProjectId == projectId))
              .Select(ra => ra.AllocatedAmount).Sum();

            return getTotalAllocatedAmountFromReconcileActual;
        }

        public ActualStartAndEndDate GetMinAndMaxActualDates(string companyId, string forecastTaskId, byte month)
        {
            var getMinAndMaxActualDates = _appDbContext.ReconciledActuals
              .Include(ra => ra.Actual)
              .Where(ra => (ra.CompanyId == companyId)
               && (ra.ForecastTaskId == forecastTaskId)
               && (ra.Actual.ActualMonth == month)).ToList();

            DateTime minForecastActualStartDate = getMinAndMaxActualDates.Where(f => (f.ForecastTaskId == forecastTaskId)).Select(ra => ra.ActualDateFrom).Min();
            DateTime maxForecastActualEndDate = getMinAndMaxActualDates.Where(f => (f.ForecastTaskId == forecastTaskId)).Select(ra => ra.ActualDateTo).Max();

            var actualDatesObj = new ActualStartAndEndDate()
            {
                MinForecastActualStartDate = minForecastActualStartDate,
                MaxForecastActualEndDate = maxForecastActualEndDate
            };

            return actualDatesObj;
        }

        public class ActualStartAndEndDate
        {
            public DateTime MinForecastActualStartDate { get; set; }
            public DateTime MaxForecastActualEndDate { get; set; }
        }

        public ProjectStartAndEndDate GetProjectStartAndEndDates(string companyId, string projectId)
        {

            var getProjectStartAndEndDates = _appDbContext.Projects
              .Where(p => (p.CompanyId == companyId)
               && (p.ProjectId == projectId)).SingleOrDefault();

            DateTime? projectStartDate = getProjectStartAndEndDates.ProjectStartDate;
            DateTime? projectEndDate = getProjectStartAndEndDates.ProjectEndDate;

            var projectDatesObj = new ProjectStartAndEndDate()
            {
                ProjectStartDate = projectStartDate,
                ProjectEndDate = projectEndDate

            };

            return projectDatesObj;
        }

        public class ProjectStartAndEndDate
        {
            public DateTime? ProjectStartDate { get; set; }
            public DateTime? ProjectEndDate { get; set; }
        }
    }
}