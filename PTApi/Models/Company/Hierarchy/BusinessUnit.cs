using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("BusinessUnits")]
    public class BusinessUnit : BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public string BusinessunitCode { get; set; }
        public string BusinessunitName { get; set; }

        public string HeadOfBusinessunitId { get; set; }
        [ForeignKey("CompanyId,HeadOfBusinessunitId")]
        public Resource HeadOfBusinessunit { get; set; }

        public string DomainId { get; set; }
        public Domain Domain { get; set; }

        [Required]
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public ICollection<Portfolio> Portfolios { get; set; }
        public ICollection<Programme> Programmes { get; set; }
        public ICollection<Project> Projects { get; set; }



        public BusinessUnit()
        {
            Portfolios = new Collection<Portfolio>();
            Programmes = new Collection<Programme>();
            Projects = new Collection<Project>();
        }

    }
}