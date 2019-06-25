using PTApi.Methods;
using PTApi.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace PTApi.ViewModels
{
    public class DomainViewModel
    {
        public DomainViewModel()
        {
            Portfolios = new Collection<Portfolio>();
        }

        private static string CreateNewId(string domainId, int length)
        {
            GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
            return generatePublicId.PartId(domainId, 8);
        }

        public string DomainId { get; set; }
        public string DomainCode
        {
            get { return "DOM" + "-" + CreateNewId(DomainId, 8).ToUpper(); }
        }


        public string CompanyId { get; set; }

        public string BusinessUnitId { get; set; }
        public string DivisionOrDomainName { get; set; }
        public string HeadOfDomain { get; set; }

        public BusinessUnit BusinessUnit { get; set; }
        public Company Company { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }

        
    }
}