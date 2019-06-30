using System.ComponentModel.DataAnnotations;

namespace PTApi.ViewModels
{
    public class UsersViewModel
    {
        
        public string ResourceId { get; set; }
        public string ResourceNumber { get; set; }
        [Required]
        public string ResourceEmailAddress { get; set; }
        
        public string Location { get; set; }
        public string EmployeeJobTitle { get; set; }
        public string ResourceType { get; set; }
        public string EmployeeType { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public string ResourceManagerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public string ImageUrl { get; set; }
        public string ImageId { get; set; }
        public string DisplayName { get; set; }
        public string AppUserRole { get; set; }
        public bool IsAppUser { get; set; }


       
    }
}
