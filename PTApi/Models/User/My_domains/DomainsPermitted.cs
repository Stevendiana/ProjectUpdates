using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("DomainsPermitted")]
    public class DomainsPermitted: BaseEntity
    {

        [Key]
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Key]
        [Required]
        public string ResourceId { get; set; }
        public Resource Resource { get; set; }
        [Key]
        [Required]
        public string CompanyId { get; set; }
        [Key]
        [Required]
        public string DomainId { get; set; }
        public Domain Domain { get; set; }

        public bool CanEdit { get; set; }

        public ICollection<Resource> ResourcesPermitted { get; set; }

        public DomainsPermitted()
        {
            ResourcesPermitted = new Collection<Resource>();
        }




    }
}