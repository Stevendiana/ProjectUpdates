using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{

    public class Company : BaseEntity
    {
        public Company()
        {
           // Users = new Collection<AppUser>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CompanyId { get; set; }
        public string CompanyAccountName { get; set; }
        public string CompanyRef { get; set; }
        public string CompanyContactEmail { get; set; }
        public string CompanyCode { get {return CompanyRef;}}
        public string CompanyAddress { get; set; }
        public string CompanyReg { get; set; }
        public string VatReg { get; set; }
        public string ReportingCurrency { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public string Country { get; set; }
        public int? CompanyCurrencyId { get; set; }
        public bool AllowReconciliation { get; set; }
        public string FinanceReportingPeriod { get; set; }
        public int FinanceReportingYear { get; set; }
        public int RecurringReportingDay { get; set; }
        public bool FreezeForecast { get; set; }
        public byte? StandardDailyHours { get; set; }
        public bool DoEmployeesWorkWeekends { get; set; }
        public string CompanyCurrentShortName { get; set; }
        public string CompanyCurrentLongName { get; set; }
        public byte[] CompanyLogo { get; set; }
        public string LogoUrl { get; set; }
        public string LogoName { get; set; }
        public string LogoId { get; set; }
        // public CurrencySymbol CurrencySymbol { get; set; }

       // public ICollection<AppUser> Users { get; set; }

    }

}