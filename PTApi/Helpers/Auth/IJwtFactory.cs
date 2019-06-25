using System.Security.Claims;
using System.Threading.Tasks;

namespace PTApi.Helpers
{
    public interface IJwtFactory
    {
        Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity(string userName, string id, string companyId, string appUserRole, string roleGroup,
                                              string firstname, string avatar, string lastname, string companyName, string email,
                                              string resourceId, string allowRec, string financeRepPeriod,  string financeRepYear,
                                              string repordingDay ,  string companyLogo, string freezeForecast,
                                              string standardDailyHrs,  string doEmployeesWorkWeekends,
                                              string currencyLongName, string currencyShortName, string currencySymbol);
    }
}
