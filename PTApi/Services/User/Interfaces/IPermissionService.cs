
using PTApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using static PTApi.Services.PermissionService;

namespace PTApi.Services
{
    public interface IPermissionService
    {
        Task<Totals> GetAllTotals( string resourceId, string companyId);
        Task<Totals> GetPermittedTotals( string resourceId, string companyId);
        Task<ICollection<Project>> GetAllProjectsPermitted(string resourceId,string companyId, string rolGroup);
    }
}