using PTApi.Methods;
using PTApi.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;



namespace PTApi.ViewModels
{
    public class PortfolioViewModel: BaseEntity
    {
         public PortfolioViewModel()
        {

            Projects = new Collection<Project>();
            Programmes = new Collection<Programme>();
        }

        private static string CreateNewId(string portfolioId, int length)
        {
            GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
            return generatePublicId.PartId(portfolioId, 8);
        }


        public string PortfolioId { get; set; }
        public string PortfolioCode
        {
            get { return "PORT" + "-" + CreateNewId(PortfolioId, 8).ToUpper(); }
        }


        [Display(Name = "Portfolio")]
        public string PortfolioName { get; set; }

        public string CompanyId { get; set; }

        public string UniquePortfolioRef { get; set; }
        public string DomainId { get; set; }
        public string HeadOfPortfolio { get; set; }
        public Company Company { get; set; }
        public Domain Domains { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Programme> Programmes { get; set; }
    }
}