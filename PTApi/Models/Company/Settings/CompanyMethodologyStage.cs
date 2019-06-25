using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("CompanyMethodologyStages")]
    public class CompanyMethodologyStage : BaseEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CompanyMethodologyStageId { get; set; }

        [Display(Name = "Stage Number")]
        [Required]
        public string CompanyMethodologyStageNumber { get; set; }
        [Required]
        public string CompanyMethodologyId { get; set; }
        public CompanyMethodology CompanyMethodology { get; set; }

        [Display(Name = "Stage Name")]
        [Required]
        public string CompanyMethodologyStageName { get; set; }
        public string MethodologyStageNotes { get; set; }
        [Required]
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }

}