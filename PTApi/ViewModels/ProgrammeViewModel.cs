using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PTApi.ViewModels
{
    public class ProgrammeViewModel: BaseEntity
    {
        public ProgrammeViewModel()
        {
            Projects = new Collection<Project>();
        }


       
        public string Id { get; set; }

        public string UniqueProgrammeRef { get; set; }
        public string ProgrammeName { get; set; }
        public string ProgrammeCode { get; set; }
        public string ProgrammeLead { get; set; }
        public string NextYearIndicator { get; set; }

        public bool AuthorisedYesOrNo { get; set; }

        public string DeliveryDirectorId { get; set; }
        public Resource DeliveryDirector { get; set; }

        public string DeliveryManagerId { get; set; }
        public Resource DeliveryManager { get; set; }

        public string ProgrammeManagerId { get; set; }
        public Resource ProgrammeManager { get; set; }

        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }

        public string SponsorId { get; set; }
        public Resource Sponsor { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public Company Company { get; set; }

        public string PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}