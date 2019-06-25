using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("BusinessCustomers")]
    public class BusinessCustomer: BaseEntity
    {
        public BusinessCustomer()
        {

            Projects = new Collection<Project>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BusinessCustomerId { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public string BusinessCustomerName { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public string BusinessCustomerAddressI { get; set; }
        public string BusinessCustomerAddressII { get; set; }
        public string BusinessCustomerAddressIII { get; set; }
        public string BusinessCustomerAddressIV { get; set; }
        public string BusinessCustomerReg { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
}