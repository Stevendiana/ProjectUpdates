using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public string ResourceId { get; set; }
        [ForeignKey("CompanyId,ResourceId")]
        public Resource Resource { get; set; }
        public bool HasConfirmEmail { get; set; }

        // Extended Properties

        public ICollection<ProjectPermitted> ProjectsPermitted { get; set; }
        public ICollection<UserNotification> UserNotifications { get; set; }

        public ApplicationUser()
        {
            ProjectsPermitted = new Collection<ProjectPermitted>();
            UserNotifications = new Collection<UserNotification>();
        }

        public void Notify(Notification notification)
        {
            UserNotifications.Add(new UserNotification(this, notification));
        }
    }
}
