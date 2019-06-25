
using PTApi.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace PTApi.ViewModels
{
    public class CompanyViewModel : BaseEntity
    {
        public CompanyViewModel()
        {
            Users = new Collection<ApplicationUser>();
        }


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
        public string AllowReconciliation { get; set; }
        public string FinanceReportingPeriod { get; set; }
        public bool FreezeForecast { get; set; }
        public byte? StandardDailyHours { get; set; }
        public string DoEmployeesWorkWeekends { get; set; }
        public string CompanyShortName { get; set; }
        public string CompanyLongName { get; set; }
        public int FinanceReportingYear { get; set; }
        public string CompanyCurrentShortName { get; set; }
        public string CompanyCurrentLongName { get; set; }
        public byte[] CompanyLogo { get; set; }
        public string LogoUrl { get; set; }
        public CurrencySymbol CurrencySymbol { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }

    }
}