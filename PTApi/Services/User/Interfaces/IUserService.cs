namespace PTApi.Services
{
    public interface IUserService
    {
        string GetSecureUser();
        string GetSecureUserId();
        string GetSecureUserCompany();
        string GetSecureUserRole();
        string GetSecureResource();
        string UserRoleGroup();
        string GetAppResourceRole(string role);
        string GetSecureUserCompanyStandardHrs();
        int GetCurrentYear();
        string GetSecureUserCompanyReportingPeriod();
        string GetSecureUserCompanyReportingDay();
        string GetSecureUserCompanyReportingYear();
    }
}