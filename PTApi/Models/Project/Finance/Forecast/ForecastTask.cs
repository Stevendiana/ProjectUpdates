using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{
    [Table("ForecastTasks")]
    public class ForecastTask: BaseEntity
    {
        public ForecastTask()
        {
            ReconciledActuals = new Collection<ReconciledActual>();
            ResourceTimesheets = new Collection<ResourceWorkTimesheet>();
        }


        [Key]
        public string ForecastTaskId { get; set; }

        [Required]
        public string ParentTaskId { get; set; }
        public ParentTask ParentTask { get; set; }
        public int? Year { get; set; }
        //public byte? Month { get; set; }
        //public int? BaselinePeriod { get; set; }
        public string ForecastCode { get; set; }
        //public string ProjectStageRefid { get; set; }
        //public string ProjectStage { get; set; }

        public decimal? VAT { get; set; }

        public string CostType { get; set; }
        public string CostCat { get; set; }
        public string ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string VendorId { get; set; }
        public Supplier Supplier { get; set; }
        public Resource Resource { get; set; }
        public string OrderNumber { get; set; }
        
        [Required]
        public string ProjectId { get; set; }
        public Project Project { get; set; }
  
        [Required]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
        public DateTime? JanStartDate { get; set; }
        public DateTime? JanEndDate { get; set; }
        
        public decimal? ResourceRateJan { get; set; }
        public decimal? JanForecastPreciseDuration { get; set; }
        public decimal? JanForecastAmount { get; set; }
        public DateTime? FebStartDate { get; set; }
        public DateTime? FebEndDate { get; set; }
        public decimal? ResourceRateFeb { get; set; }
        public decimal? FebForecastPreciseDuration { get; set; }

        public decimal? FebForecastNet { get; set; }
        public decimal? FebForecastVat { get; set; }
        public decimal? FebForecastAmount { get; set; }
        public decimal? FebForecastIrrecoverableVat { get; set; }
        public decimal? FebForecastRecoverableVat { get; set; }

        public DateTime? MarStartDate { get; set; }
        public DateTime? MarEndDate { get; set; }
        public decimal? ResourceRateMar { get; set; }
        public decimal? MarForecastPreciseDuration { get; set; }
        public decimal? MarForecastAmount { get; set; }
        public DateTime? AprStartDate { get; set; }
        public DateTime? AprEndDate { get; set; }
        public decimal? ResourceRateApr { get; set; }
        public decimal? AprForecastPreciseDuration { get; set; }
        public decimal? AprForecastAmount { get; set; }
        public DateTime? MayStartDate { get; set; }
        public DateTime? MayEndDate { get; set; }
        public decimal? ResourceRateMay { get; set; }
        public decimal? MayForecastPreciseDuration { get; set; }
        public decimal? MayForecastAmount { get; set; }
        public DateTime? JunStartDate { get; set; }
        public DateTime? JunEndDate { get; set; }
        public decimal? ResourceRateJun { get; set; }
        public decimal? JunForecastPreciseDuration { get; set; }
        public decimal? JunForecastAmount { get; set; }
        public DateTime? JulStartDate { get; set; }
        public DateTime? JulEndDate { get; set; }
        public decimal? ResourceRateJul { get; set; }
        public decimal? JulForecastPreciseDuration { get; set; }
        public decimal? JulForecastAmount { get; set; }
        public DateTime? AugStartDate { get; set; }
        public DateTime? AugEndDate { get; set; }
        public decimal? ResourceRateAug { get; set; }
        public decimal? AugForecastPreciseDuration { get; set; }
        public decimal? AugForecastAmount { get; set; }
        public DateTime? SepStartDate { get; set; }
        public DateTime? SepEndDate { get; set; }
        public decimal? ResourceRateSep { get; set; }
        public decimal? SepForecastPreciseDuration { get; set; }
        public decimal? SepForecastAmount { get; set; }
        public DateTime? OctEndDate { get; set; }
        public DateTime? OctStartDate { get; set; }
        public decimal? ResourceRateOct { get; set; }
        public decimal? OctForecastPreciseDuration { get; set; }
        public decimal? OctForecastAmount { get; set; }
        public DateTime? NovStartDate { get; set; }
        public DateTime? NovEndDate { get; set; }
        public decimal? ResourceRateNov { get; set; }
        public decimal? NovForecastPreciseDuration { get; set; }
        public decimal? NovForecastAmount { get; set; }
        public DateTime? DecStartDate { get; set; }
        public DateTime? DecEndDate { get; set; }
        public DateTime? TaskEarliestStartDate { get; set; }
        public DateTime? TaskLatestndEDate { get; set; }
        public decimal? ResourceRateDec { get; set; }
        public decimal? DecForecastPreciseDuration { get; set; }
        public decimal? DecForecastAmount { get; set; }
        [NotMapped]
        public decimal? QoneForecastAmount { get{return JanForecastAmount + FebForecastAmount + MarForecastAmount  ;} }
        [NotMapped]
        public decimal? QtwoForecastAmount { get{return AprForecastAmount + MayForecastAmount + JunForecastAmount  ;} }
        [NotMapped]
        public decimal? QthreeForecastAmount { get{return JulForecastAmount + AugForecastAmount + SepForecastAmount  ;} }
        [NotMapped]
        public decimal? QfourForecastAmount { get{return OctForecastAmount + NovForecastAmount + DecForecastAmount  ;} }

        public decimal? TotalForecastAmount { get; set; }

        public string CostSubCategory { get; set; }
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

        [NotMapped]
        public int? TotalCountPortfoliosPermitted { get; }
        public decimal? JanActualsReconciled { get; set; }
        public decimal? FebActualsReconciled { get; set; }
        public decimal? MarActualsReconciled { get; set; }
        public decimal? AprActualsReconciled { get; set; }
        public decimal? MayActualsReconciled { get; set; }
        public decimal? JunActualsReconciled  { get; set; }
        public decimal? JulActualsReconciled { get; set; }
        public decimal? AugActualsReconciled { get; set; }
        public decimal? SepActualsReconciled { get; set; }
        public decimal? OctActualsReconciled { get; set; }
        public decimal? NovActualsReconciled { get; set; }
        public decimal? DecActualsReconciled { get; set; }
        // [NotMapped]
        // public decimal? JanActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 1);} }
        // [NotMapped]
        // public decimal? FebActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 2);} }
        // [NotMapped]
        // public decimal? MarActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 3);} }
        // [NotMapped]
        // public decimal? AprActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 4);} }
        // [NotMapped]
        // public decimal? MayActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 5);} }
        // [NotMapped]
        // public decimal? JunActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 6);} }
        // [NotMapped]
        // public decimal? JulActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 7);} }
        // [NotMapped]
        // public decimal? AugActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 8);} }
        // [NotMapped]
        // public decimal? SepActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 9);} }
        // [NotMapped]
        // public decimal? OctActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 10);} }
        // [NotMapped]
        // public decimal? NovActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 11);} }
        // [NotMapped]
        // public decimal? DecActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 12);} }
        [NotMapped]
        public decimal? TotalActualsReconciled { get { { return
        JanActualsReconciled + FebActualsReconciled + MarActualsReconciled + AprActualsReconciled + MayActualsReconciled + JunActualsReconciled +
        JulActualsReconciled + AugActualsReconciled + SepActualsReconciled + OctActualsReconciled + NovActualsReconciled + DecActualsReconciled;
        };}}

        [NotMapped]
        public decimal? JanForecastDaysUnits { get{ {return Convert.ToDecimal((JanEndDate?.Date - JanStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? FebForecastDaysUnits { get{ {return Convert.ToDecimal((FebEndDate?.Date - FebStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? MarForecastDaysUnits { get{ {return Convert.ToDecimal((MarEndDate?.Date - MarStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? AprForecastDaysUnits { get{ {return Convert.ToDecimal((AprEndDate?.Date - AprStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? MayForecastDaysUnits { get{ {return Convert.ToDecimal((MayEndDate?.Date - MayStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? JunForecastDaysUnits { get{ {return Convert.ToDecimal((JunEndDate?.Date - JunStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? JulForecastDaysUnits { get{ {return Convert.ToDecimal((JulEndDate?.Date - JulStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? AugForecastDaysUnits { get{ {return Convert.ToDecimal((AugEndDate?.Date - AugStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? SepForecastDaysUnits { get{ {return Convert.ToDecimal((SepEndDate?.Date - SepStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? OctForecastDaysUnits { get{ {return Convert.ToDecimal((OctEndDate?.Date - OctStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? NovForecastDaysUnits { get{ {return Convert.ToDecimal((NovEndDate?.Date - NovStartDate?.Date)?.TotalDays);};} }
        [NotMapped]
        public decimal? DecForecastDaysUnits { get{ {return Convert.ToDecimal((DecEndDate?.Date - DecStartDate?.Date)?.TotalDays);};} }

        [NotMapped]
        public decimal? TotalForecastDaysUnits { get { { return
        JanForecastDaysUnits + JunForecastDaysUnits + FebForecastDaysUnits + MarForecastDaysUnits + AprForecastDaysUnits + MayForecastDaysUnits +
        JulForecastDaysUnits + AugForecastDaysUnits + SepForecastDaysUnits + OctForecastDaysUnits + NovForecastDaysUnits + DecForecastDaysUnits;
        };}}





        // public decimal? JanActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 1);} }
        // public decimal? FebActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 2);} }
        // public decimal? MarActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 3);} }
        // public decimal? AprActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 4);} }
        // public decimal? MayActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 5);} }
        // public decimal? JunActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 6);} }
        // public decimal? JulActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 7);} }
        // public decimal? AugActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 8);} }
        // public decimal? SepActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 9);} }
        // public decimal? OctActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 10);} }
        // public decimal? NovActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 11);} }
        // public decimal? DecActualsReconciled { get{return SumReconciledActualsByForecast(CompanyId,ProjectId, ForecastTaskId, Year, 12);} }

        // public decimal? TotalActualsReconciled { get { { return
        // JanActualsReconciled + FebActualsReconciled + MarActualsReconciled + AprActualsReconciled + MayActualsReconciled + JunActualsReconciled +
        // JulActualsReconciled + AugActualsReconciled + SepActualsReconciled + OctActualsReconciled + NovActualsReconciled + DecActualsReconciled;
        // };}}

        // public decimal? JanForecastDaysUnits { get{ {return Convert.ToDecimal((JanEndDate?.Date - JanStartDate?.Date)?.TotalDays);};} }
        // public decimal? FebForecastDaysUnits { get{ {return Convert.ToDecimal((FebEndDate?.Date - FebStartDate?.Date)?.TotalDays);};} }
        // public decimal? MarForecastDaysUnits { get{ {return Convert.ToDecimal((MarEndDate?.Date - MarStartDate?.Date)?.TotalDays);};} }
        // public decimal? AprForecastDaysUnits { get{ {return Convert.ToDecimal((AprEndDate?.Date - AprStartDate?.Date)?.TotalDays);};} }
        // public decimal? MayForecastDaysUnits { get{ {return Convert.ToDecimal((MayEndDate?.Date - MayStartDate?.Date)?.TotalDays);};} }
        // public decimal? JunForecastDaysUnits { get{ {return Convert.ToDecimal((JunEndDate?.Date - JunStartDate?.Date)?.TotalDays);};} }
        // public decimal? JulForecastDaysUnits { get{ {return Convert.ToDecimal((JulEndDate?.Date - JulStartDate?.Date)?.TotalDays);};} }
        // public decimal? AugForecastDaysUnits { get{ {return Convert.ToDecimal((AugEndDate?.Date - AugStartDate?.Date)?.TotalDays);};} }
        // public decimal? SepForecastDaysUnits { get{ {return Convert.ToDecimal((SepEndDate?.Date - SepStartDate?.Date)?.TotalDays);};} }
        // public decimal? OctForecastDaysUnits { get{ {return Convert.ToDecimal((OctEndDate?.Date - OctStartDate?.Date)?.TotalDays);};} }
        // public decimal? NovForecastDaysUnits { get{ {return Convert.ToDecimal((NovEndDate?.Date - NovStartDate?.Date)?.TotalDays);};} }
        // public decimal? DecForecastDaysUnits { get{ {return Convert.ToDecimal((DecEndDate?.Date - DecStartDate?.Date)?.TotalDays);};} }


        // public decimal? TotalForecastDaysUnits { get { { return
        // JanForecastDaysUnits + JunForecastDaysUnits + FebForecastDaysUnits + MarForecastDaysUnits + AprForecastDaysUnits + MayForecastDaysUnits +
        // JulForecastDaysUnits + AugForecastDaysUnits + SepForecastDaysUnits + OctForecastDaysUnits + NovForecastDaysUnits + DecForecastDaysUnits;
        // };}}


        public ICollection<ReconciledActual> ReconciledActuals { get; set; }
        public ICollection<ResourceWorkTimesheet> ResourceTimesheets { get; set; }

    }
}