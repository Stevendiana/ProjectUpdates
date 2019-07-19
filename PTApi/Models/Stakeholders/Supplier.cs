using PTApi.Methods;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    [Table("Suppliers")]
    public class Supplier
    {
        private static string CreateNewId(string supplierId, int length)
        {
            GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
            return generatePublicId.PartId(supplierId, 8);
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SupplierId { get; set; }
        public string SupplierNumber { get; set; }
        //public string SupplierCode
        //{
        //    get { return "SUP" + "-" + CreateNewId(SupplierId, 8).ToUpper(); }
        //}

        [Required]
        public string CompanyId { get; set; }
        public string SupplierName { get; set; }
        public string Services { get; set; }
        public string ContactTelephone { get; set; }
        public string ContactEmail { get; set; }
        public string ExternalVendorNumber { get; set; }
        public string WorkOrderNumber { get; set; }
        public string WorkOrderOwner { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public ICollection<Resource> Resources { get; set; }


        public Supplier()
        {

            Resources = new Collection<Resource>();
        }
    }

    public enum SupplierServices
    {
        Resources,
        Hardware,
        Software,

        [Description("IT Services")]
        ITServices
    }
}