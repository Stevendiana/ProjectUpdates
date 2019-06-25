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
            Portfolios = new Collection<Portfolio>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public string DomainCode { get; set; }
        public string BusinessUnitId { get; set; }
        public string DivisionOrDomainName { get; set; }
        public string HeadOfDomain { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public string NodeId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }
    }
}