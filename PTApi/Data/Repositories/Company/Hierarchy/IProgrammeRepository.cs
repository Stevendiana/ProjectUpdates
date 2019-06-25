using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface IProgrammeRepository : IRepository<Programme>
    {
        Programme GetOneProgramme(string id, string companyId);
        Programme GetOneProgrammeWithPortfolio(string id, string companyId);
        Programme GetOneProgrammeWithProjects(string id, string companyId);
        Programme GetOneProgrammeWithProjectsThenPortfolios(string id, string companyId);

        IEnumerable<Programme> GetAllProgrammesOnly(string companyId);
        IEnumerable<Programme> GetAllProgrammeWithProjectsThenPortfolios(string companyId);
    }
}
