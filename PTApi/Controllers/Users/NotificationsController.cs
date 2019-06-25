using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCentreBackend.Core.Interfaces;
using ProjectCentreBackend.Models;
using ProjectCentreBackend.Models.Entities;
using ProjectCentreBackend.Persistence;

namespace ProjectCentreBackend.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Notifications")]
    public class NotificationsController: Controller
    {
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public NotificationsController(IUserService userService,ProjectCentreDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<SummarisedNotification> GetNotifications()
        {
            var userId = _userService.GetSecureUserId();
            var companyId = _userService.GetSecureUserCompany();
            var notifications = _appDbContext.UserNotifications
                .Where(un => (un.UserId == userId) && (un.User.CompanyId == companyId) && (!un.IsRead))
                .Include(un => un.Notification)
                .Include(un => un.Notification.Project)
                .Include(un => un.Notification.UpdatedByResource)
                .Select(un => un.Notification)
                .ToList();

            return notifications.Select(_mapper.Map<Notification, SummarisedNotification>);
        }

        public class SummarisedNotification
        {
            public string Id { get; private set; }
            public DateTime ActionDateTime { get; private set; }
            public string UpdatedByResourceId { get; private set; }
            // public string UpdatedByUserCompanyId { get; private set; }
            public string NotificationType { get; private set; }
            public DateTime? OriginalDateTimeCreated { get; private set; }
            public DateTime? LastDateTimeModified { get; private set; }
            public string OriginalResourceCreatedId { get; private set; }
            public string LastResourceModifiedId { get; private set; }
            public string OldUpdate { get; set; }
            public string NewUpdate { get; set; }
            [ForeignKey("OriginalResourceCreatedId")]
            public ResourceData CreatedByUser { get; private set; }
            [ForeignKey("LastResourceModifiedId")]
            public ResourceData ModifiedByUser { get; private set; }

            public string Status { get; private set; }
            [ForeignKey("UpdatedByResourceId")]
            public ResourceData UpdatedByUser { get; private set; }
            [Required]
            public ProjectData Project { get; private set; }
            public string ProjectId { get; private set; }
        }

        public class ResourceData
        {
            public string Id { get; private set; }
            public string Email { get; private set; }
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [NotMapped]
            public string DisplayName
            {
                get { return LastName + "," + " " + FirstName; }
            }
        }

        public class ProjectData
        {
            public string Id { get; private set; }
            public string ProjectName { get; private set; }

        }

        // Resource GetResource(string user, string resource)
        // {
        //     return _userService.GetResourceById(user,resource);
        // }



        [HttpPost]
        public IActionResult MarkAsRead()
        {
            var userId = _userService.GetSecureUserId();
            var notifications = _appDbContext.UserNotifications
                .Where(un => un.UserId == userId && !un.IsRead)
                .ToList();

            notifications.ForEach(n => n.Read());

            _appDbContext.SaveChanges();

            return Ok();
        }

    }
}