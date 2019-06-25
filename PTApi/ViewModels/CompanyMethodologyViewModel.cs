using System.Collections.Generic;
using System.Collections.ObjectModel;
using PTApi.Models;

namespace PTApi.ViewModels
{
    public class CompanyMethodologyViewModel
    {
        public string CompanyMethodologyId { get; set; }
        public string CompanyId { get; set; }
        public string CompanyMethodologyStageNumber { get; set; }
        public string MethodologyName { get; set; }
        public string CompanyMethodologyStageName { get; set; }

        public string MethodologyNotes { get; set; }

        public ICollection<CompanyMethodologyStage> CompanyMethodologyStages { get; set; }

        public CompanyMethodologyViewModel()
        {
            CompanyMethodologyStages = new Collection<CompanyMethodologyStage>();
        }
    }
}