
using static PTApi.Methods.GetIdsWithPartIdsMethod;

namespace PTApi.Methods
{
    public interface IGetIdsWithPartIdsMethod
    {
         string GetDisplayName( string thiscompanyId, string thisuserName);
         string GetActualCompanyId(string companyCode);
         string GetResourceDisplayName(string companyId, string userName);
         ResourceUtilization GetCompanyStandardDailyHours(string resourceId);
         ProjectCredentials GetProjectCredentials(string projectCode);
         string GetActualProjectId(string projectCode);
         string GetCompanyCode(string id);
         decimal? GetTotalAllocatedAmountFromReconcileActual(string actualId, string projectId);
         ActualStartAndEndDate GetMinAndMaxActualDates(string companyId, string forecastTaskId, byte month);
         ProjectStartAndEndDate GetProjectStartAndEndDates(string companyId, string projectId);


    }
}