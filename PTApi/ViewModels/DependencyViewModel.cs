using System;

namespace PTApi.ViewModels
{
    public class DependencyViewModel
    {
      public string DependencyId { get; set; }
      public string DependencyCode { get; set; }
      public string ProjectId { get; set; }
      public string CompanyId { get; set; }
      public int Year { get; set; }
      public DateTime? DateRaised { get; set; }
      public string Description { get; set; }
      public string Location { get; set; }
      public string Deliverables { get; set; }
      public string DeliveryDate { get; set; }
      public string Importance { get; set; }
      public string Status { get; set; }
      public DateTime? Dateclosed { get; set; }
      public string Latestupdate { get; set; }
      public DateTime? LatestupdateDate { get; set; }
      public bool Cascade { get; set; }
      public string Reviewstatus { get; set; }

    }
}