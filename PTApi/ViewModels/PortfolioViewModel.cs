using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;



namespace PTApi.ViewModels
{
    public class PortfolioViewModel: BaseEntity
    {
        public PortfolioViewModel()
        {

            Projects = new Collection<Project>();
            Programmes = new Collection<Programme>();
        }

        
        public string Id { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioCode { get; set; }

        public string UniquePortfolioRef { get; set; }
        
        public string DomainId { get; set; }
        public Domain Domain { get; set; }

        [Required]
        public string BusinessunitId { get; set; }
        
        public BusinessUnit BusinessUnit { get; set; }

        public string HeadOfPortfolioId { get; set; }
        
        public Resource HeadOfPortfolio { get; set; }

        public DateTime? PortfolioStartDate { get; set; }
        public DateTime? PortfolioEndDate { get; set; }

        [Required]
        public string CompanyId { get; set; }
        
        public Company Company { get; set; }


        public ICollection<Project> Projects { get; set; }
        public ICollection<Programme> Programmes { get; set; }
    }
}