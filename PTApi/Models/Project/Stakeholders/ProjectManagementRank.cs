using PTApi.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("ProjectManagementRanks")]
    public class ProjectManagementRank: BaseEntity
    {
        private readonly IUserService _userService;
        private readonly IResourceService _resourceService;

        public ProjectManagementRank()
        {

        }
        public ProjectManagementRank(IUserService userService, IResourceService resourceService)
        {
            _userService = userService;
            _resourceService = resourceService;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ProjectManagementRankId { get; set; }
        [Required]
        public string ProjectId { get; set; }
        [Required]
        public string ProjectManagerUserId { get; set; }
        public string ProjectSeniorManagerUserId { get; set; }
        public string ProjectPrimaryContactUserId { get; set; }
        public string ProjectFinanceContactUserId { get; set; }
        public string ProjectOwnerUserId { get; set; }
        [ForeignKey("ProjectManagerUserId")]
        public ApplicationUser ProjectManager { get; set; }
        [ForeignKey("ProjectSeniorManagerUserId")]
        public ApplicationUser ProjectSeniorManager { get; set; }
        [ForeignKey("ProjectPrimaryContactUserId")]
        public ApplicationUser ProjectPrmiaryContact { get; set; }
        [ForeignKey("ProjectFinanceContactUserId")]
        public ApplicationUser ProjectFinanceContact { get; set; }
        [ForeignKey("ProjectOwnerUserId")]
        public ApplicationUser ProjectOwner { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }


        public void UpdateProjectManagementRank( string projectManagerUserId, string projectSeniorManagerUserId, string projectPrimaryContactUserId,
        string projectFinanceContactUserId, string projectOwnerUserId)
        {
            var currentuser = _userService.GetSecureUserId();
            var loggedInResourceId = _resourceService.GetLoggedInUserResource().ResourceId;

            if (projectManagerUserId != ProjectManagerUserId  ||
                projectSeniorManagerUserId != ProjectSeniorManagerUserId  ||
                projectPrimaryContactUserId != ProjectPrimaryContactUserId  ||
                projectFinanceContactUserId != ProjectFinanceContactUserId  ||
                projectOwnerUserId != ProjectOwnerUserId)
            {
                var notifications = Notification.ProjectManagementRankUpdated(Project,projectManagerUserId, projectSeniorManagerUserId,
                projectPrimaryContactUserId,projectFinanceContactUserId,projectOwnerUserId, _userService.GetSecureUserId(), loggedInResourceId);

                foreach (var notification in notifications)
                {
                    if (ProjectManager != null)
                    ProjectManager.Notify(notification);
                    if (ProjectSeniorManager != null)
                    ProjectSeniorManager.Notify(notification);
                    if (ProjectPrmiaryContact != null)
                    ProjectPrmiaryContact.Notify(notification);
                    if (ProjectFinanceContact != null)
                    ProjectFinanceContact.Notify(notification);
                    if (ProjectOwner != null)
                    ProjectOwner.Notify(notification);
                }
            }
           return;
        }

    }
}