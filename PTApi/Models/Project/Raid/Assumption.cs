using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;



namespace PTApi.Models
{
    [Table("Assumptions")]
    public class Assumption
    {
      [Key]
      public string AssumptionId { get; set; }
      public string AssumptionCode { get; set; }
      public string ProjectId { get; set; }
      public string CompanyId { get; set; }
      public int Year { get; set; }
      public DateTime? DateRaised { get; set; }
      public string Description { get; set; }
      public string Reason { get; set; }
      public string Actiontovalidate { get; set; }
      public string Impactifassumptionfails { get; set; }
      public string Status { get; set; }
      public string Latestupdate { get; set; }
      public DateTime? LatestupdateDate { get; set; }
      public bool Cascade { get; set; }
      public string Reviewstatus { get; set; }


    }
}