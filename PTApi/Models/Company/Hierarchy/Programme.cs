using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("Programmes")]
    public class Programme: BaseEntity
    {
        public Programme()
        {
            Projects = new Collection<Project>();
        }


        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public string UniqueProgrammeRef { get; set; }
        public string ProgrammeName { get; set; }
        public string ProgrammeCode { get; set; }
        public string ProgrammeLead { get; set; }
        public string NextYearIndicator { get; set; }
        public bool AuthorisedYesOrNo { get; set; }
        public string DeliveryDirector { get; set; }
        public string DeliveryManager { get; set; }
        public string ProgrammeManager { get; set; }
        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public string NodeId { get; set; }
        public string Sponsor { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public string PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}