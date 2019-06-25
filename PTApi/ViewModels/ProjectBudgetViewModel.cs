using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PTApi.Models;

namespace PTApi.ViewModels
{
    public class ProjectBudgetViewModel: BaseEntity
    {

        public ProjectBudgetViewModel()
        {
            ReconciledActuals = new Collection<ReconciledActual>();
            // ResourceWorkTimesheets = new Collection<ResourceWorkTimesheet>();
        }


        public string ProjectBudgetId { get; set; }
        public string ProjectBudgetTrackerId { get; set; }
        public string BudgetBadgetStatus  { get; set; }
        public string BudgetBadgetVersion  { get; set; }
        public string CompanyId { get; set; }
        public string ProjectId { get; set; }

        public string ForecastTaskId { get; set; }
        public string TextTaskCostDescription { get; set; }
        public byte? ForecastPeriodType { get; set; }
        public int? Order { get; set; }
        public decimal Progress { get; set; }
        public bool Open { get; set; }
        public string Parent { get; set; }
        public int? Year { get; set; }
        public byte? Month { get; set; }
        public int? BaselinePeriod { get; set; }
        public string ForecastCode { get; set; }
        public string ProjectStageRefid { get; set; }
        public string ProjectStage { get; set; }
        public string CostType { get; set; }
        public string CostCat { get; set; }
        public string ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string VendorId { get; set; }
        public Supplier Supplier { get; set; }
        public Resource Resource { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? JanStartDate { get; set; }
        public DateTime? JanEndDate { get; set; }
        public decimal? ResourceRateJan { get; set; }
        public decimal? JanForecastPreciseDuration { get; set; }
        public decimal? JanAmount { get; set; }
        public DateTime? FebStartDate { get; set; }
        public DateTime? FebEndDate { get; set; }
        public decimal? ResourceRateFeb { get; set; }
        public decimal? FebForecastPreciseDuration { get; set; }
        public decimal? FebAmount { get; set; }
        public DateTime? MarStartDate { get; set; }
        public DateTime? MarEndDate { get; set; }
        public decimal? ResourceRateMar { get; set; }
        public decimal? MarForecastPreciseDuration { get; set; }
        public decimal? MarAmount { get; set; }
        public DateTime? AprStartDate { get; set; }
        public DateTime? AprEndDate { get; set; }
        public decimal? ResourceRateApr { get; set; }
        public decimal? AprForecastPreciseDuration { get; set; }
        public decimal? AprAmount { get; set; }
        public DateTime? MayStartDate { get; set; }
        public DateTime? MayEndDate { get; set; }
        public decimal? ResourceRateMay { get; set; }
        public decimal? MayForecastPreciseDuration { get; set; }
        public decimal? MayAmount { get; set; }
        public DateTime? JunStartDate { get; set; }
        public DateTime? JunEndDate { get; set; }
        public decimal? ResourceRateJun { get; set; }
        public decimal? JunForecastPreciseDuration { get; set; }
        public decimal? JunAmount { get; set; }
        public DateTime? JulStartDate { get; set; }
        public DateTime? JulEndDate { get; set; }
        public decimal? ResourceRateJul { get; set; }
        public decimal? JulForecastPreciseDuration { get; set; }
        public decimal? JulAmount { get; set; }
        public DateTime? AugStartDate { get; set; }
        public DateTime? AugEndDate { get; set; }
        public decimal? ResourceRateAug { get; set; }
        public decimal? AugForecastPreciseDuration { get; set; }
        public decimal? AugAmount { get; set; }
        public DateTime? SepStartDate { get; set; }
        public DateTime? SepEndDate { get; set; }
        public decimal? ResourceRateSep { get; set; }
        public decimal? SepForecastPreciseDuration { get; set; }
        public decimal? SepAmount { get; set; }
        public DateTime? OctEndDate { get; set; }
        public DateTime? OctStartDate { get; set; }
        public decimal? ResourceRateOct { get; set; }
        public decimal? OctForecastPreciseDuration { get; set; }
        public decimal? OctAmount { get; set; }
        public DateTime? NovStartDate { get; set; }
        public DateTime? NovEndDate { get; set; }
        public decimal? ResourceRateNov { get; set; }
        public decimal? NovForecastPreciseDuration { get; set; }
        public decimal? NovAmount { get; set; }
        public DateTime? DecStartDate { get; set; }
        public DateTime? DecEndDate { get; set; }
        public decimal? ResourceRateDec { get; set; }
        public decimal? DecForecastPreciseDuration { get; set; }
        public decimal? DecAmount { get; set; }
        public decimal? TotalForecastPreciseDuration { get; set; }
        public decimal? TotalAmount { get; set; }

        public string CostSubCategory { get; set; }
        public string ResourcePerCost { get; set; }
        public decimal? MaterialQuantityJan { get; set; }
        public decimal? MaterialUnitCostJan { get; set; }

        public decimal? MaterialQuantityFeb { get; set; }
        public decimal? MaterialUnitCostFeb { get; set; }
        public decimal? MaterialQuantityMar { get; set; }
        public decimal? MaterialUnitCostMar { get; set; }
        public decimal? MaterialQuantityApr { get; set; }
        public decimal? MaterialUnitCostApr { get; set; }
        public decimal? MaterialQuantityMay { get; set; }
        public decimal? MaterialUnitCostMay { get; set; }
        public decimal? MaterialQuantityJun { get; set; }
        public decimal? MaterialUnitCostJun { get; set; }
        public decimal? MaterialQuantityJul { get; set; }
        public decimal? MaterialUnitCostJul { get; set; }
        public decimal? MaterialQuantityAug { get; set; }
        public decimal? MaterialUnitCostAug { get; set; }
        public decimal? MaterialQuantitySep { get; set; }
        public decimal? MaterialUnitCostSep { get; set; }
        public decimal? MaterialQuantityOct { get; set; }
        public decimal? MaterialUnitCostOct { get; set; }
        public decimal? MaterialQuantityNov { get; set; }
        public decimal? MaterialUnitCostNov { get; set; }
        public decimal? MaterialQuantityDec { get; set; }
        public decimal? MaterialUnitCostDec { get; set; }

        public ICollection<ReconciledActual> ReconciledActuals { get; set; }


    }
}