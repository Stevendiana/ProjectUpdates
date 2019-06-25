using PTApi.Methods;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("Actuals")]
    public class Actual : BaseEntity
    {

        public Actual()
        {
            ReconciledActuals = new Collection<ReconciledActual>();

        }



        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ActualId { get; set; }
        public string UploadBatchNumber { get; set; }

        [Display(Name = "Project Code")]
        [Required]
        public string ActualProjectCode { get; set; }

        [Display(Name = "Company Code")]
        public string CompanyCode { get; set; }
        public string CompanyId { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ActualCostCategory { get; set; }
        public string ProjectCostCode { get; set; }
        public string AccountingCode { get; set; }
        [Required]
        public long ActualYear { get; set; }
        [Required]
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
        [Required]
        public string TransactionCurrency { get; set; }
        public string DocumentDate { get; set; }
        public string MiAccountDescription { get; set; }
        [Required]
        public decimal? TransactionAmount { get; set; }
        public string ReportingCurrency { get; set; }

        [Required]
        public decimal? ReportingAmount { get; set; }
        [Display(Name = "Actual Code")]

        public string ActualCode {get ; set;}
        // public string ActualCode {get { return "ACT" + "-" + CreateNewId(ActualId).ToUpper();}}
        [NotMapped]
        public decimal? TotalAllocatedAmount {  get; }
        [NotMapped]
        public decimal? UnAllocatedAmount {  get; }
        [NotMapped]
        public bool FullyReconciledYesOrNo {  get; }


        // [NotMapped]
        // public decimal? UnAllocatedAmount
        // {
        //     get { return Amount - TotalAllocatedAmount; }private set { }
        // }

        // // // if UnAllocatedAmount = 0 return "Yes" else return "No"
        // // //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        // [NotMapped]
        // public bool FullyReconciledYesOrNo
        // {
        //     get
        //     {
        //         if (TotalAllocatedAmount != Amount)
        //             return false;

        //         return true;
        //     }
        //     private set { }
        // }

        public static string CreateNewId(string CompanyId){

           GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
           return generatePublicId.PartId(CompanyId,8);
        }



        public Company Company { get; set; }
        public Project Project { get; set; }
        public ICollection<ReconciledActual> ReconciledActuals { get; set; }

    }
}