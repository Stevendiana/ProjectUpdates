using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Models;
using PTApi.Services;
using System.Collections.Generic;
using System.Linq;

namespace PTApi.Repositories
{
    public class CurrencySymbolRepository : Repository<CurrencySymbol>, ICurrencySymbolRepository
    {
        public CurrencySymbolRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public CurrencySymbol GetOneCurrency(int id)
        {
            return ApplicationDbContext.CurrencySymbols.SingleOrDefault(d => d.CurrencySymbolId == id);
        }



        public IEnumerable<CurrencySymbol> GetAllCurrencySymbols()
        {
            return ApplicationDbContext.CurrencySymbols.OrderByDescending(d => d.CompanyCurrencyLongName).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
