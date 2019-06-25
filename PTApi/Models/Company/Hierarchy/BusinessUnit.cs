using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("BusinessUnits")]
    public class BusinessUnit : BaseEntity
    {
        public BusinessUnit()
        {
            Domains = new Collection<Domain>();

        }


        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string BusinessUnitCode { get; set; }
        public string BusinessUnitName { get; set; }
        [Required]
        public string CompanyId { get; set; }
        public string HeadOfBusinessUnit { get; set; }
        public string NodeId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public ICollection<Domain> Domains { get; set; }

    }
}