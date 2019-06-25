using PTApi.Models;

namespace PTApi.ViewModels
{
    public class DomainPermittedViewModel
    {
        public string DomainId { get; set; }
        public Domain Domain { get; set; }
        public string ResourceId { get; set; }
        public string CompanyId { get; set; }

    }
}