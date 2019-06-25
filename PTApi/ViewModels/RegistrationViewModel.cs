

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PTApi.ViewModels
{


    public class RegistrationViewModel
    {
            [Required]
            [DataType(DataType.EmailAddress)]
            [Remote("ValidateEmailAddress","Auth")]
            public string Email { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            public string Location { get; set; }
            [Required]
            public string CompanyName { get; set; }
    }
}
