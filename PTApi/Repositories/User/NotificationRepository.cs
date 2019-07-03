
using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class UserNotificationRepository : Repository<UserNotification>, IUserNotificationRepository
    {
        public UserNotificationRepository(ApplicationDbContext context)
            : base(context)
        {
        }


       
        //public IEnumerable<Notification> GetAllMyNotifications(string companyId, string userId)
        //{
        //    return ApplicationDbContext.UserNotifications
        //        .Where(un => (un.UserId == userId) && (un.User.CompanyId == companyId) && (!un.IsRead))
        //        .Include(un => un.Notification)
        //        .Include(un => un.Notification.Project)
        //        .Include(un => un.Notification.UpdatedByResource)
        //        .Select(un => un.Notification)
        //        .ToList();
        //}

        public IEnumerable<UserNotification> GetAllMyNotifications(string companyId, string userId)
        {
            return ApplicationDbContext.UserNotifications.ToList().Where(un => un.UserId == userId && un.User.CompanyId == companyId  && !un.IsRead);
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
