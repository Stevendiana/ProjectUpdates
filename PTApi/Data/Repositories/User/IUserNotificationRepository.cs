using PTApi.Models;
using PTApi.ViewModels;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IUserNotificationRepository : IRepository<UserNotification>
    {
        IEnumerable<UserNotification>  GetAllMyNotifications(string companyId, string userId);
    }
}



