using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTApi.Data;
using PTApi.Models;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/CurrencySymbols")]
    public class CurrencySymbolController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _appDbContext;

        public CurrencySymbolController(UserManager<ApplicationUser> userManager, ApplicationDbContext appDbContext)
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