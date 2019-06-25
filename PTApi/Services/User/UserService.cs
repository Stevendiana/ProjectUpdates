using Microsoft.AspNetCore.Http;
using PTApi.Helpers;
using System;
using System.Linq;

namespace PTApi.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;


        public UserService (IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public UserService()
        {
        }

        public string GetAppResourceRole(string role)
        {
            var userRole = role;

            if (userRole == Constants.Strings.JwtClaims.AccountOwner
              ||userRole == Constants.Strings.JwtClaims.Admin ||
               userRole == Constants.Strings.JwtClaims.SuperAdmin)
            {
                return "Admin_Group";
            }

            if (userRole == Constants.Strings.JwtClaims.ProjectManager
              ||userRole == Constants.Strings.JwtClaims.SeniorProjectManager ||
               userRole == Constants.Strings.JwtClaims.PortfolioAdmin)
            {
                return "Portfolio_Group";
            }

            if (userRole == Constants.Strings.JwtClaims.FinanceAdmin
              ||userRole == Constants.Strings.JwtClaims.FinanceManager)
            {
                return "Finance_Group";
            }
            else
            {
                return "Other_Group";
            }
        }

        public string GetSecureUser()
        {
            // var user = _httpContextAccessor.HttpContext.User.Claims.Single(c=>c.Type=="name").Value;
            var user = _httpContextAccessor.HttpContext.User.Claims.Single(c=>c.Type=="email").Value;
            return user;
        }

        public string GetSecureResource()
        {
            var resource = _httpContextAccessor.HttpContext.User.Claims.Single(c=>c.Type=="resourceid").Value;
            return resource;
        }

        public string GetSecureUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.Claims.Single(c=>c.Type=="id").Value;
            return userId;
        }


        public string GetSecureUserCompany()
        {
            var comp = _httpContextAccessor.HttpContext.User.Claims.Single(c => c.Type == "comp").Value;

            return comp;
        }

        public string GetSecureUserCompanyStandardHrs()
        {
            var compStandardHrs = _httpContextAccessor.HttpContext.User.Claims.Single(c => c.Type == "standarddailyhrs").Value;

            return compStandardHrs;
        }

        public string GetSecureUserCompanyReportingPeriod()
        {
            var compReportingPeriod = _httpContextAccessor.HttpContext.User.Claims.Single(c => c.Type == "financerepperiod").Value;

            return compReportingPeriod;
        }

        public string GetSecureUserCompanyReportingDay()
        {
            var compReportingDay = _httpContextAccessor.HttpContext.User.Claims.Single(c => c.Type == "reportingday").Value;

            return compReportingDay;
        }

        public string GetSecureUserCompanyReportingYear()
        {
            var compReportingYear = _httpContextAccessor.HttpContext.User.Claims.Single(c => c.Type == "financerepyear").Value;

            return compReportingYear;
        }

        public string GetSecureUserRole()
        {
            var role = _httpContextAccessor.HttpContext.User.Claims.Single(c=>c.Type=="rol").Value;
            return role;
        }


        public string UserRoleGroup()
        {
            var userRole = GetSecureUserRole();

            if (userRole == Constants.Strings.JwtClaims.AccountOwner
              ||userRole == Constants.Strings.JwtClaims.Admin ||
               userRole == Constants.Strings.JwtClaims.SuperAdmin)
            {
                return "Admin_Group";
            }

            if (userRole == Constants.Strings.JwtClaims.ProjectManager
              ||userRole == Constants.Strings.JwtClaims.SeniorProjectManager ||
               userRole == Constants.Strings.JwtClaims.PortfolioAdmin)
            {
                return "Portfolio_Group";
            }

            if (userRole == Constants.Strings.JwtClaims.FinanceAdmin
              ||userRole == Constants.Strings.JwtClaims.FinanceManager)
            {
                return "Finance_Group";
            }
            else
            {
                return "Other_Group";
            }
        }

        public int GetCurrentYear()
        {
            var currentYear = DateTime.Now.Year;
            return currentYear;
        }


    }
}