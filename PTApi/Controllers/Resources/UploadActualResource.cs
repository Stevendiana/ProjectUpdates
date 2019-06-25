using PTApi.Models;
using System;

namespace PTApi.Controllers.Resources
{
    public class UploadActualResource: BaseEntity
    {
         public string ActualId { get; set; }
        public string ActualCode { get; set; }
        public string ActualProjectCode { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ActualCostCategory { get; set; }
        public string ProjectCostCode { get; set; }
        public string AccountingCode { get; set; }
        public long ActualYear { get; set; }
        public byte ActualMonth { get; set; }
        public string Description { get; set; }
        public string JournalComments { get; set; }
        public string InvoiceNumber { get; set; }
        public string Source { get; set; }
        public string ExpenditureType { get; set; }
        public string ExpenditureClass { get; set; }
        public string VendorName { get; set; }
        public string ExternalVendorNumber { get; set; }
        public string ActualResourceName { get; set; }
        public string PurchaseOrderDetail { get; set; }
        public string TransactionCurrency { get; set; }
        public string DocumentDate { get; set; }
        public string MiAccountDescription { get; set; }
        public double Amount { get; set; }

    }
}