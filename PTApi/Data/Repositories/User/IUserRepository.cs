using PTApi.Models;
using PTApi.ViewModels;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        ApplicationUser GetOneUser(string id, string companyId);
        IEnumerable<ApplicationUser> GetAllUsersOnly(string companyId);
        IEnumerable<UsersViewModel> GetAllCompanyUserFromResourceList(string companyId);
        bool CheckUserExist(string email);
    }
}



