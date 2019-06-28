using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTApi.Data;
using PTApi.Models;
using System.Linq;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CurrencySymbolsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _appDbContext;

        public CurrencySymbolsController(UserManager<ApplicationUser> userManager, ApplicationDbContext appDbContext)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
        }



        // [HttpGet]
        // public IEnumerable<EmployeeType> Get()
        // {
        //    return _appDbContext.EmployeeTypes;
        // }

        [HttpGet("currency")]
        public CurrencySymbol[] Get()
        {
            var listofCurrencySymbols = _appDbContext.CurrencySymbols.ToList();
            return listofCurrencySymbols.ToArray();
        }
    }
}