using PTApi.Methods;
using System;


namespace PTApi.ViewModels
{
    public class ChangelogViewModel
    {
        public ChangelogViewModel()
        {

        }

        private static string CreateNewId(string changeId)
        {
            GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
            return generatePublicId.PartId(changeId, 8);
        }

        public int Id { get; set; }
        public string ChangeId { get; set; }
        public string ChangelogCode { get{ return "CHANGE" + "-" + CreateNewId(ChangeId).ToUpper(); } }
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