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
        public string Id { get; set; }
       
        public string UniqueProgrammeRef { get; set; }
        public string ProgrammeName { get; set; }
        public string ProgrammeCode { get; set; }
        public string ProgrammeLead { get; set; }
        public string NextYearIndicator { get; set; }

        public bool AuthorisedYesOrNo { get; set; }

        public string DeliveryDirectorId { get; set; }
        [ForeignKey("CompanyId,DeliveryDirectorId")]
        public Resource DeliveryDirector { get; set; }

        public string DeliveryManagerId { get; set; }
        [ForeignKey("CompanyId,DeliveryManagerId")]
        public Resource DeliveryManager { get; set; }

        public string ProgrammeManagerId { get; set; }
        [ForeignKey("CompanyId,ProgrammeManagerId")]
        public Resource ProgrammeManager { get; set; }

        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        
        public string SponsorId { get; set; }
        [ForeignKey("CompanyId,SponsorId")]
        public Resource Sponsor { get; set; }

        [Required]
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public string PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}