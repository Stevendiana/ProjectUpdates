

using PTApi.Models;
using System.ComponentModel.DataAnnotations;


namespace PTApi.ViewModels
{
    public class ProjectsFollowingViewModel
    {

        [Required]
        public string ResourceId { get; set; }

        [Required]
        public string CompanyId { get; set; }

        [Required]
        public string ProjectId { get; set; }
        public bool CanEdit { get; set; }
        public Project Project { get; set; }



    }
}
