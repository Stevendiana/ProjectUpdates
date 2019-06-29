using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        ApplicationUser GetOneUser(string id, string companyId);
        IEnumerable<ApplicationUser> GetAllUsersOnly(string companyId);
        bool CheckUserExist(string email);
    }
}



