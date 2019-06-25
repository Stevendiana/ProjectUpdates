using PTApi.Methods;
using PTApi.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PTApi.ViewModels
{
    public class BusinessCustomerViewModel
    {
        public BusinessCustomerViewModel()
        {
           
            Projects = new Collection<Project>();
        }

        private static string CreateNewId(string businessCustomerId, int length)
        {
            GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
            return generatePublicId.PartId(businessCustomerId, 8);
        }

        public string BusinessCustomerId { get; set; }
        public string BusinessCustomerCode
        {
            get { return "BUC" + "-" + CreateNewId(BusinessCustomerId, 8).ToUpper(); }
        }

        
        public string CompanyId { get; set; }
        public string BusinessCustomerName { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public string BusinessCustomerAddressI { get; set; }
        public string BusinessCustomerAddressII { get; set; }
        public string BusinessCustomerAddressIII { get; set; }
        public string BusinessCustomerAddressIV { get; set; }
        public string BusinessCustomerReg { get; set; }
        public Company Company { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}