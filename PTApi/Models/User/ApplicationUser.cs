using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public string AppUserRole { get; set; }

        public DateTime? DateCreated { get; set; }
        public string UserCreatedId { get; set; }
        public string UserCreatedResourceId { get; set; }
        public string UserCreatedEmail { get; set; }
        public string UserCreatedFirstName { get; set; }
        public string UserCreatedLastName { get; set; }
        public string UserCreatedAvatar { get; set; }

        public DateTime? DateModified { get; set; }
        public string UserModifiedId { get; set; }
        public string UserModifiedEmail { get; set; }
        public string UserModifiedResourceId { get; set; }
        public string UserModifiedFirstName { get; set; }
        public string UserModifiedLastName { get; set; }
        public string UserModifiedAvartar { get; set; }

        // Extended Properties

        public ICollection<ProjectsFollowing> ProjectsIamFollowing { get; set; }
        public ICollection<ProjectsPermitted> ProjectsIamPermitted { get; set; }
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
