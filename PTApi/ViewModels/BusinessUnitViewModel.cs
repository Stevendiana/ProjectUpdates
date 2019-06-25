using PTApi.Methods;
using PTApi.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace PTApi.ViewModels
{
    public class BusinessUnitViewModel
    {
        public BusinessUnitViewModel()
        {
            Domains = new Collection<Domain>();
           
        }

        private static string CreateNewId(string businessUnitId)
        {
            GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
            return generatePublicId.PartId(businessUnitId, 8);
        }

        public string BusinessUnitId { get; set; }
        public string BusinessUnitCode { get{ return "BUU" + "-" + CreateNewId(BusinessUnitId).ToUpper(); } }
        public string BusinessUnitName { get; set; }
        public string CompanyId { get; set; }
        public string HeadOfBusinessUnit { get; set; }
        public ICollection<Domain> Domains { get; set; }
      
    }
}