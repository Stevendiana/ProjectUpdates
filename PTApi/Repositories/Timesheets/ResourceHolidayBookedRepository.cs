

using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class ResourceHolidayBookedRepository : Repository<ResourceHolidayBooked>, IResourceHolidayBookedRepository
    {
        public ResourceHolidayBookedRepository(ApplicationDbContext context)
            : base(context)
        {
        }


        public ResourceHolidayBooked GetOneResourceHolidayBooking(string resourceId, string companyId)
        {
            return ApplicationDbContext.ResourceHolidays.SingleOrDefault(d => d.ResourceId == resourceId && d.CompanyId == companyId);
        }


        public IEnumerable<ResourceHolidayBooked> GetAllResourceHolidayBookings(string companyId, string id)
        {
            return ApplicationDbContext.ResourceHolidays
                .Include(r => r.TimesheetCalendar)
                .Include(r => r.Resource)
                .Where(r => r.CompanyId == companyId && r.ResourceId == id)
                .OrderByDescending(d => d.Resource.FirstName).ThenBy(r => r.Resource.LastName).ToList();
        }

        public IEnumerable<ResourceHolidayBooked> GetAllCompanyHolidayBookings(string companyId)
        {
            return ApplicationDbContext.ResourceHolidays
                .Include(r => r.TimesheetCalendar)
                .Include(r => r.Resource)
                .Where(r => r.CompanyId == companyId)
                .OrderByDescending(d => d.Resource.FirstName).ThenBy(r => r.Resource.LastName).ToList();
        }

       

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}

