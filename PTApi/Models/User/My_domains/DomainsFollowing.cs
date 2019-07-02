using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PTApi.Models
{
    public class DomainsFollowing : BaseEntity
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
        public bool Following { get; set; }

        public ICollection<Resource> ResourcesPermitted { get; set; }

        public DomainsFollowing()
        {
            ResourcesPermitted = new Collection<Resource>();
        }

    }
}
