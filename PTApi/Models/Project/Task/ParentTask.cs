using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    public class ParentTask: BaseEntity
    {
        public ParentTask()
        {
            ForecastTasks = new Collection<ForecastTask>();
            
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ParentTaskId { get; set; }
        public Company Company { get; set; }
 
        [Required]
        public string ProjectId { get; set; }
        public Project Project { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public string TextTaskCostDescription { get; set; }

        //public byte? ForecastPeriodType { get; set; }

        public int? Order { get; set; }
        public decimal Progress { get; set; }
        public bool Open { get; set; }

        public DateTime? TaskEndDate { get; }
        public DateTime? TaskStartDate { get; }
        public decimal? Cost { get; }

    public ICollection<ForecastTask> ForecastTasks { get; set; }
    }
}
