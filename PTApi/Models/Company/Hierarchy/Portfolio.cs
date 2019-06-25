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
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioCode { get; set; }
        [Required]
        public string CompanyId { get; set; }
        public string UniquePortfolioRef { get; set; }
        public string NodeId { get; set; }
        public string DomainId { get; set; }
        public string HeadOfPortfolio { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public Domain Domain { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Programme> Programmes { get; set; }

    }
}