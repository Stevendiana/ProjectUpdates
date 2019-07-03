using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IResourceHolidayBookedRepository : IRepository<ResourceHolidayBooked>
    {
        ResourceHolidayBooked GetOneResourceHolidayBooking(string resourceId, string companyId);
        IEnumerable<ResourceHolidayBooked> GetAllCompanyHolidayBookings(string companyId);
        IEnumerable<ResourceHolidayBooked> GetAllResourceHolidayBookings(string companyId, string id);
    }
}




