using PTApi.Models;

namespace PTApi.ViewModels
{
    public class PortfolioPermittedViewModel
    {
        public string PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
        public string NodeId { get; set; } ="portfolio";
        public string ResourceId { get; set; }
        public string CompanyId { get; set; }
    }
}