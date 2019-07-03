using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("Platforms")]
    public class Platform : BaseEntity
    {
        public Platform()
        {
            //Resources = new Collection<Resource>();
        }

        [Key]
        public string PlatformId { get; set; }
        public string PlatformCode { get; set; }

        [Required]
        public string PlatformName { get; set; }

        [Required]
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public string HeadOfPlatformId { get; set; }
        [ForeignKey("CompanyId, HeadOfPlatformId")]
        public Resource HeadOfPlatform { get; set; }

        //public ICollection<Resource> Resources { get; set; }
    }
}