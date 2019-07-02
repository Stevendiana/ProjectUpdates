using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("Domains")]
    public class Domain: BaseEntity
    {
        public Domain()
        {
            Businessunits = new Collection<BusinessUnit>();
            Portfolios = new Collection<Portfolio>();
            Programmes = new Collection<Programme>();
            Projects = new Collection<Project>();
        }

        [Key]
        public string Id { get; set; }
        public string DomainCode { get; set; }
        public string DomainName { get; set; }

        [Required]
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public string HeadOfDomainId { get; set; }
        [ForeignKey("CompanyId,HeadOfDomainId")]
        public Resource HeadOfDomain { get; set; }

        public ICollection<BusinessUnit> Businessunits { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }
        public ICollection<Programme> Programmes { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}