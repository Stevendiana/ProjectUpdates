using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Repositories
{
    public class ActualRepository : Repository<Actual>, IActualRepository
    {
        public ActualRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public async Task<Actual> GetActual(string id)
        {
            return await ApplicationDbContext.Actuals.FindAsync(id);
        }

        public async Task<IEnumerable<Actual>> GetRecentlyUploadedActuals(string companyId, string id)
        {
            return await ApplicationDbContext.Actuals.Where(p => (p.UploadBatchNumber == id) && p.CompanyId == companyId).ToListAsync();
        }


        //public void Add(Actual actual)
        //{
        //    //Controllers.UploadActualsController.ActualToUpload aTUpload = new Controllers.UploadActualsController.ActualToUpload();
        //    ApplicationDbContext.Actuals.Add(actual);
        //}

        //public void Remove(Actual actual)
        //{
        //    ApplicationDbContext.Remove(actual);
        //}

        public IEnumerable<Actual> GetAllCompanyActuals(string companyId)
        {
            return ApplicationDbContext.Actuals.Where(d => d.CompanyId == companyId).ToList();
        }

        public Actual GetOneProjectActual(string id, string companyId)
        {
            return ApplicationDbContext.Actuals.SingleOrDefault(d => d.ActualId == id && d.CompanyId == companyId);
        }


        public IEnumerable<Actual> GetAllProjectActuals(string id, string companyId)
        {
            return ApplicationDbContext.Actuals.Where(d => d.ProjectId == id && d.CompanyId == companyId).OrderByDescending(d => d.TransactionDate).ToList();
        }

        public IEnumerable<ReconciledActual> GetAllProjectReconciledActuals(string id, string companyId)
        {
            return ApplicationDbContext.ReconciledActuals
                 .Include(d => d.ForecastTask)
                 .ThenInclude(d => d.ParentTask)
                 .Include(d => d.Actual)
                 .Where(d => d.ProjectId == id && d.CompanyId == companyId).ToList()
                 .OrderByDescending(d => d.ActualDateFrom);
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
