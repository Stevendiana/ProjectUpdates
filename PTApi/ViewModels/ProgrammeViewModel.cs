using PTApi.Methods;
using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace PTApi.ViewModels
{
    public class ProgrammeViewModel: BaseEntity
    {
        public ProgrammeViewModel()
        {
            Projects = new Collection<Project>();

        }

        private static string CreateNewId(string programmeId, int length)
        {
            GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
            return generatePublicId.PartId(programmeId, 8);
        }


        public string ProgrammeId { get; set; }
        public string ProgrammeCode
        {
            get { return "PROG" + "-" + CreateNewId(ProgrammeId, 8).ToUpper(); }
        }


        public string PortfolioId { get; set; }
        public string CompanyId { get; set; }
        public string UniqueProgrammeRef { get; set; }
        public string ProgrammeName { get; set; }
        public string ProgrammeLead { get; set; }
        public string NextYearIndicator { get; set; }
        public bool AuthorisedYesOrNo { get; set; }
        public string DeliveryDirector { get; set; }
        public string DeliveryManager { get; set; }
        public string ProgrammeManager { get; set; }
        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public string Sponsor { get; set; }
        public Company Company { get; set; }
        public Portfolio Portfolio { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}