using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("CompanyRateCards")]
    public class CompanyRateCard: BaseEntity
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CompanyRateCardId { get; set; }
        public string CompanyRateCardCode { get; set; }
        [Required]
        public string CompanyId { get; set; }
        [Required]
        public string EmployeeJobTitleOrGradeOrBand { get; set; }
        [Required]
        public string LocationForGradeOnshoreOffShore { get; set; }
        public bool IsContractor { get; set; }
        [Required]
        public decimal DailyRate { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}