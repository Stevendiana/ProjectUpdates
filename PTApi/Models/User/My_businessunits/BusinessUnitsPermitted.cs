using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("BusinessUnitsPermitted")]
    public class BusinessUnitsPermitted: BaseEntity
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
        public BusinessUnit BusinessUnit { get; set; }

        public bool CanEdit { get; set; }

        public ICollection<Resource> ResourcesPermitted { get; set; }

        public BusinessUnitsPermitted()
        {
            ResourcesPermitted = new Collection<Resource>();
        }





    }

}