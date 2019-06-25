using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTApi.Models
{
    public class Notification
    {
        // [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public DateTime ActionDateTime { get; private set; }
        public string UpdatedByUserId { get; private set; }
        public string UpdatedByResourceId { get; private set; }
        public string UpdatedByUserCompanyId { get; private set; }
        public NotificationType Type { get; private set; }
        public DateTime? OriginalDateTimeCreated { get; private set; }
        public DateTime? LastDateTimeModified { get; private set; }
        public string OriginalUserCreatedId { get; private set; }
        public string OriginalResourceCreatedId { get; private set; }
        public string OldUpdate { get; private set; }
        public string NewUpdate { get; private set; }
        public string LastUserModifiedId { get; private set; }
        public string LastResourceModifiedId { get; private set; }
        public string Status { get; private set; }

        [ForeignKey("UpdatedByUserCompanyId,UpdatedByResourceId")]
        [Required]
        public Resource UpdatedByResource { get; private set; }
        [ForeignKey("UpdatedByUserCompanyId,OriginalResourceCreatedId")]
        public Resource CreatedByResource { get; private set; }
        [ForeignKey("UpdatedByUserCompanyId,LastResourceModifiedId")]
        public Resource ModifiedByResource { get; private set; }
        [Required]
        public string ProjectId { get; private set; }

        [ForeignKey("ProjectId")]
        [Required]
        public Project Project { get; private set; }

        protected Notification()
        {
        }

        private Notification(NotificationType type, Project project, string user, string resource )
        {
            if (project == null)
            throw new ArgumentNullException("project");

            if (user == null)
            throw new ArgumentNullException("user");

            Type = type;
            Project = project;
            UpdatedByUserCompanyId =  project.CompanyId;
            ActionDateTime = DateTime.Now;
            UpdatedByUserId = user;
            UpdatedByResourceId = resource;

        }

        public static Notification ProjectCreated(Project project, string user, string resource)
        {
            var notification = new Notification(NotificationType.ProjectCreated, project, user, resource);
            notification.UpdatedByUserId = user;
            notification.UpdatedByResourceId = resource;
            notification.OriginalDateTimeCreated = project.DateCreated;
            notification.LastDateTimeModified = project.DateModified;
            notification.OriginalUserCreatedId = project.UserCreatedId;
            notification.LastUserModifiedId = project.UserModifiedId;

            notification.OriginalResourceCreatedId = project.UserCreatedResourceId;
            notification.LastResourceModifiedId = project.UserModifiedResourceId;
            notification.OldUpdate = "Newly_Created_Project";
            notification.NewUpdate = "Project_Created";

            notification.Status = "Project_Created";

            return notification;
        }

        public static Notification ProjectStatusUpdated(Project project, string user, string newStatus, string resource)
        {
            var notification = new Notification(NotificationType.ProjectCreated, project, user, resource);
            notification.UpdatedByUserId = user;
            notification.UpdatedByResourceId = resource;
            notification.OriginalDateTimeCreated = project.DateCreated;
            notification.LastDateTimeModified = project.DateModified;
            notification.OriginalUserCreatedId = project.UserCreatedId;
            notification.LastUserModifiedId = project.UserModifiedId;
            notification.OldUpdate = project.ProjectStatus;
            notification.NewUpdate = newStatus;

            notification.OriginalResourceCreatedId = project.UserCreatedResourceId;
            notification.LastResourceModifiedId = project.UserModifiedResourceId;

            notification.Status = "Project_Status_Updated";

            return notification;
        }

        public static List<Notification> ProjectManagementRankUpdated(Project currentData, string projectManagerUserId, string projectSeniorManagerUserId, string projectPrimaryContactUserId,
        string projectFinanceContactUserId, string projectOwnerUserId, string user, string resource)
        {
            List<Notification> notifications = new List<Notification>();

            var PM = currentData.ProjectManagementRank.ProjectManagerUserId;
            var SPM = currentData.ProjectManagementRank.ProjectSeniorManagerUserId;
            var PC = currentData.ProjectManagementRank.ProjectPrimaryContactUserId;
            var FM = currentData.ProjectManagementRank.ProjectFinanceContactUserId;
            var PO = currentData.ProjectManagementRank.ProjectOwnerUserId;

            if (PM != projectManagerUserId)
            {
                var notification = new Notification(NotificationType.ProjectManagerUpdated, currentData, user, resource);
                notification.UpdatedByUserId = user;
                notification.UpdatedByResourceId = resource;
                notification.OriginalDateTimeCreated = currentData.DateCreated;
                notification.LastDateTimeModified = currentData.DateModified;
                notification.OriginalUserCreatedId = currentData.UserCreatedId;
                notification.LastUserModifiedId = currentData.UserModifiedId;

                notification.OriginalResourceCreatedId = currentData.UserCreatedResourceId;
                notification.LastResourceModifiedId = currentData.UserModifiedResourceId;

                notification.OldUpdate = PM;
                notification.NewUpdate = projectManagerUserId;

                notification.Status = "Project_Manager_Updated";
                notifications.Add(notification);
            }
            if (SPM != projectSeniorManagerUserId)
            {
                var notification = new Notification(NotificationType.ProjectSeniorManagerUpdated, currentData, user, resource);
                notification.UpdatedByUserId = user;
                notification.UpdatedByResourceId = resource;
                notification.OriginalDateTimeCreated = currentData.DateCreated;
                notification.LastDateTimeModified = currentData.DateModified;
                notification.OriginalUserCreatedId = currentData.UserCreatedId;
                notification.LastUserModifiedId = currentData.UserModifiedId;

                notification.OriginalResourceCreatedId = currentData.UserCreatedResourceId;
                notification.LastResourceModifiedId = currentData.UserModifiedResourceId;

                notification.OldUpdate = SPM;
                notification.NewUpdate = projectSeniorManagerUserId;
                notification.Status = "Project_Senior_Manager_Updated";
                notifications.Add(notification);
            }
            if (PC != projectPrimaryContactUserId)
            {
                var notification = new Notification(NotificationType.ProjectPrimaryContactUpdated, currentData, user, resource);
                notification.UpdatedByUserId = user;
                notification.UpdatedByResourceId = resource;
                notification.OriginalDateTimeCreated = currentData.DateCreated;
                notification.LastDateTimeModified = currentData.DateModified;
                notification.OriginalUserCreatedId = currentData.UserCreatedId;
                notification.LastUserModifiedId = currentData.UserModifiedId;

                notification.OriginalResourceCreatedId = currentData.UserCreatedResourceId;
                notification.LastResourceModifiedId = currentData.UserModifiedResourceId;

                notification.OldUpdate = PC;
                notification.NewUpdate = projectPrimaryContactUserId;
                notification.Status = "Project_Primary_Contact_Updated";
                notifications.Add(notification);
            }
            if (FM != projectFinanceContactUserId)
            {
                var notification = new Notification(NotificationType.ProjectFinanceManagerUpdated, currentData, user, resource);
                notification.UpdatedByUserId = user;
                notification.UpdatedByResourceId = resource;
                notification.OriginalDateTimeCreated = currentData.DateCreated;
                notification.LastDateTimeModified = currentData.DateModified;
                notification.OriginalUserCreatedId = currentData.UserCreatedId;
                notification.LastUserModifiedId = currentData.UserModifiedId;

                notification.OriginalResourceCreatedId = currentData.UserCreatedResourceId;
                notification.LastResourceModifiedId = currentData.UserModifiedResourceId;

                notification.OldUpdate = FM;
                notification.NewUpdate = projectFinanceContactUserId;
                notification.Status = "Project_Finance_Manager_Updated";
                notifications.Add(notification);
            }
            if (PO != projectOwnerUserId)
            {
                var notification = new Notification(NotificationType.ProjectOwnerUpdated, currentData, user, resource);
                notification.UpdatedByUserId = user;
                notification.UpdatedByResourceId = resource;
                notification.OriginalDateTimeCreated = currentData.DateCreated;
                notification.LastDateTimeModified = currentData.DateModified;
                notification.OriginalUserCreatedId = currentData.UserCreatedId;
                notification.LastUserModifiedId = currentData.UserModifiedId;

                notification.OriginalResourceCreatedId = currentData.UserCreatedResourceId;
                notification.LastResourceModifiedId = currentData.UserModifiedResourceId;

                notification.OldUpdate = PO;
                notification.NewUpdate = projectOwnerUserId;
                notification.Status = "Project_Owner_Updated";
                notifications.Add(notification);
            }

            return notifications;
        }

        public static Notification ProjectCanceled(Project project, string user, string resource)
        {
            var notification = new Notification(NotificationType.ProjectCanceled, project, user, resource);
            notification.UpdatedByUserId = user;
            notification.UpdatedByResourceId = resource;
            notification.OriginalDateTimeCreated = project.DateCreated;
            notification.LastDateTimeModified = project.DateModified;
            notification.OriginalUserCreatedId = project.UserCreatedId;
            notification.LastUserModifiedId = project.UserModifiedId;

            notification.OriginalResourceCreatedId = project.UserCreatedResourceId;
            notification.LastResourceModifiedId = project.UserModifiedResourceId;

            notification.Status = "Project_Canceled";

            return notification;
        }

        public static Notification ProjectInfoUpdated(Project project, string user, string resource)
        {
            var notification = new Notification(NotificationType.ProjectUpdated, project, user, resource);
            notification.UpdatedByUserId = user;
            notification.UpdatedByResourceId = resource;
            notification.OriginalDateTimeCreated = project.DateCreated;
            notification.LastDateTimeModified = project.DateModified;
            notification.OriginalUserCreatedId = project.UserCreatedId;
            notification.LastUserModifiedId = project.UserModifiedId;

            notification.OriginalResourceCreatedId = project.UserCreatedResourceId;
            notification.LastResourceModifiedId = project.UserModifiedResourceId;
            notification.Status = "Project_Info_Updated";

            return notification;
        }
    }
}