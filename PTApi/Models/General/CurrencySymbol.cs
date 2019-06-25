using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;


namespace PTApi.Models
{
    [Table("CurrencySymbols")]
    public class CurrencySymbol
    {
        [Key]
        public int CurrencySymbolId { get; set; }
        public string CompanyCurrencyLongName { get; set; }
        public string CompanyCurrencyShortName { get; set; }
        public string CompanyCurrencySymbol { get; set; }
    }
}