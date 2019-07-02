using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("Portfolios")]
    public class Portfolio : BaseEntity
    {
        public Portfolio()
        {

            Projects = new Collection<Project>();
            Programmes = new Collection<Programme>();
        }

        [Key]
        public string Id { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioCode { get; set; }
        
        public string UniquePortfolioRef { get; set; }

        [Required]
        public string BusinessunitId { get; set; }
        [ForeignKey("BusinessunitId")]
        public BusinessUnit BusinessUnit { get; set; }

        public string HeadOfPortfolioId { get; set; }
        [ForeignKey("CompanyId,HeadOfPortfolioId")]
        public Resource HeadOfPortfolio { get; set; }

        public DateTime? PortfolioStartDate { get; set; }
        public DateTime? PortfolioEndDate { get; set; }

        [Required]
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
       

        public ICollection<Project> Projects { get; set; }
        public ICollection<Programme> Programmes { get; set; }

    }
}