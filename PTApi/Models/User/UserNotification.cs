using System;
using System.ComponentModel.DataAnnotations;


namespace PTApi.Models
{
    public class UserNotification
    {
        // private ApplicationUser applicationUser;

        [Key]
        public string UserId { get; private set; }

        [Key]
        public int NotificationId { get; private set; }
       // public string CompanyId { get; private set; }

        public ApplicationUser User { get; private set; }

        public Notification Notification { get; private set; }

        public bool IsRead { get; private set; }

        protected UserNotification()
        {
        }

        public UserNotification(ApplicationUser user, Notification notification)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            if (notification == null)
                throw new ArgumentNullException("notification");

            User = user;
            Notification = notification;
        }

        public void Read()
        {
            IsRead = true;
        }
    }
}