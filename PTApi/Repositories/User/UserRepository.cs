using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using PTApi.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public bool CheckUserExist(string email)
        {
            return ApplicationDbContext.Users.Any(d => d.UserName == email);
            
        }


        public ApplicationUser GetOneUser(string id, string companyId)
        {
            return ApplicationDbContext.Users.SingleOrDefault(d => d.Id == id && d.CompanyId == companyId);
        }

        public IEnumerable<ApplicationUser> GetAllUsersOnly(string companyId)
        {
            return ApplicationDbContext.Users
                .Include(r=>r.Resource)
                .Where(r => r.CompanyId == companyId)
                .OrderByDescending(d => d.Resource.FirstName).ThenBy(r => r.Resource.ResourceType).ToList();
        }

        public IEnumerable<UsersViewModel> GetAllCompanyUserFromResourceList(string companyId)
        {
            return ApplicationDbContext.Resources
                .Where(p => p.CompanyId == companyId)
                .Join(ApplicationDbContext.Users,
                r => r.IdentityId,
                u => u.Id,
                (resource, user) =>
                new UsersViewModel
                {
                    ResourceId = resource.ResourceId,
                    ResourceNumber = resource.ResourceNumber,
                    ResourceEmailAddress = resource.ResourceEmailAddress,
                    Location = resource.Location,
                    EmployeeJobTitle = resource.EmployeeJobTitle,
                    ResourceType = resource.ResourceType,
                    EmployeeType = resource.EmployeeType,
                    CompanyId = resource.CompanyId,
                    ResourceManagerId = resource.ResourceManagerId,
                    FirstName = resource.FirstName,
                    LastName = resource.LastName,
                    ImageUrl = resource.ImageUrl,
                    ImageId = resource.ImageId,
                    DisplayName = resource.DisplayName,
                    AppUserRole = user.AppUserRole,
                    IsAppUser = resource.IsAppUser,
                })
                .ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
