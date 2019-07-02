using PTApi.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace PTApi.ViewModels
{
    public class BusinessUnitViewModel
    {
        public string Id { get; set; }
        public string BusinessunitCode { get; set; }
        public string BusinessunitName { get; set; }

        public string HeadOfBusinessunitId { get; set; }
       
        public Resource HeadOfBusinessunit { get; set; }

        public string DomainId { get; set; }
        public Domain Domain { get; set; }

       
        public string CompanyId { get; set; }
        
        public Company Company { get; set; }

        public ICollection<Portfolio> Portfolios { get; set; }
        public ICollection<Programme> Programmes { get; set; }
        public ICollection<Project> Projects { get; set; }



        public BusinessUnitViewModel()
        {
            Portfolios = new Collection<Portfolio>();
            Programmes = new Collection<Programme>();
            Projects = new Collection<Project>();
        }

    }
}