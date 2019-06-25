namespace PTApi.Controllers.Resources
{
    public class ReconciledActualResource
    {
        public int ActualId { get; set; }
        public int ForecastTaskId { get; set; }
        public decimal? AllocatedAmount { get; set; }

    }
}