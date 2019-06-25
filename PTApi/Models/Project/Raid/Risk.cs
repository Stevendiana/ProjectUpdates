using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;



namespace PTApi.Models
{
    [Table("Risks")]
    public class Risk
    {
      [Key]
      public string RiskId { get; set; }
      public string RiskCode { get; set; }
      public string ProjectId { get; set; }
      public string CompanyId { get; set; }
      public int Year { get; set; }
      public DateTime? DateRaised { get; set; }
      public string Description { get; set; }
      public string Impact { get; set; }
      public string Severity { get; set; }
      public string Likelihood { get; set; }
      public string Owner { get; set; }
      public string Status { get; set; }
      public DateTime? Dateclosed { get; set; }
      public string Latestupdate { get; set; }
      public DateTime? LatestupdateDate { get; set; }
      public bool Cascade { get; set; }
      public string Reviewstatus { get; set; }

    }
}