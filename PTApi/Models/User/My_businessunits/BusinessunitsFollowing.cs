using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PTApi.Models
{
    public class BusinessunitsFollowing : BaseEntity
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
        public string BusinessUnitId { get; set; }
        public bool Following { get; set; }

        public ICollection<Resource> ResourcesPermitted { get; set; }

        public BusinessunitsFollowing()
        {
            ResourcesPermitted = new Collection<Resource>();
        }

    }
}
