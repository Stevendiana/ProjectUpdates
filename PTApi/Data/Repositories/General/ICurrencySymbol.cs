using PTApi.Models;
using System.Collections.Generic;

namespace PTApi.Data.Repositories
{
    public interface ICurrencySymbolRepository : IRepository<CurrencySymbol>
    {
        CurrencySymbol GetOneCurrency(int id);
        IEnumerable<CurrencySymbol> GetAllCurrencySymbols();
    }
}







