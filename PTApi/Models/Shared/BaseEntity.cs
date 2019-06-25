using System;

namespace PTApi.Models
{
    public class BaseEntity
    {
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

    }
    public class ChangeLog
    {
        public int Id { get; set; }
        public string ChangeId { get; set; }
        public string EntityName { get; set; }
        // public string PropertyName { get; set; }
        public string PrimaryKeyValue { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public string UserCompanyId { get; set; }
        public string UserModifiedId { get; set; }
        public string UserModifiedEmail { get; set; }
        public string UserModifiedResourceId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public DateTime DateChanged { get; set; }
    }
}