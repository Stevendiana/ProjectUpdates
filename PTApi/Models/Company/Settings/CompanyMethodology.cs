using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("CompanyMethodologies")]
    public class CompanyMethodology : BaseEntity
    {


        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CompanyMethodologyId { get; set; }

        [Required]
        [StringLength(255)]
        public string MethodologyName { get; set; }
        public string MethodologyNotes { get; set; }

        [Required]
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public ICollection<CompanyMethodologyStage> CompanyMethodologyStages { get; set; }

        public CompanyMethodology()
        {
            CompanyMethodologyStages = new Collection<CompanyMethodologyStage>();
        }
    }
}