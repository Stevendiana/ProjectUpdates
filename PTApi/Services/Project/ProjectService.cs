
using PTApi.Methods;
using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PTApi.Methods.GetIdsWithPartIdsMethod;
using static PTApi.Services.ProjectForecastService;

namespace PTApi.Services
{
    public class ProjectService : BaseEntity, IProjectService
    {
        private IProjectForecastService _dateTimeMethods;
        private IGetIdsWithPartIdsMethod _getIdsWithPartIdsMethod;
        private IGeneratePublicIdMethod _generatePublicIdMethod;
        private readonly List<Project> _projects;

        public ProjectService(IProjectForecastService dateTimeMethodsRepository, IGetIdsWithPartIdsMethod getIdsWithPartIdsMethod, IGeneratePublicIdMethod generatePublicIdMethod, IEnumerable<Project> projects)
        {
            _dateTimeMethods = dateTimeMethodsRepository ?? throw new ArgumentNullException(nameof(dateTimeMethodsRepository));
            _getIdsWithPartIdsMethod = getIdsWithPartIdsMethod ?? throw new ArgumentNullException(nameof(getIdsWithPartIdsMethod));
            _generatePublicIdMethod = generatePublicIdMethod ?? throw new ArgumentNullException(nameof(generatePublicIdMethod));
             if (projects == null) { throw new ArgumentNullException(nameof(projects)); }
            _projects = new List<Project>(projects);
        }


        public Task<Project> CreateAsync(Project project)
        {
            throw new NotSupportedException();
        }

        public async Task<bool> IsProjectExistsAsync(string projectId)
        {
            var project = await ReadOneAsync(projectId);
            return project != null;
        }

        public Task<IEnumerable<Project>> ReadAllAsync()
        {
            return Task.FromResult(_projects.AsEnumerable());
        }

        public Task<Project> ReadOneAsync(string projectId)
        {
            var project = _projects.FirstOrDefault(p => p.ProjectId == projectId);
            return Task.FromResult(project);
        }

        public Task<Project> UpdateAsync(Project project)
        {
            throw new NotSupportedException();
        }

        public Task<Project> DeleteAsync(string projectId)
        {
            throw new NotSupportedException();
        }

        public DaysPerMonth GetDaysPerMonth(int year, byte month)
        {
            return _dateTimeMethods.GetDaysPerMonth(year, month);
        }

        public  decimal GetLifetime(DateTime? projectStartDate, DateTime? projectEndDate)
        {
            return _dateTimeMethods.GetLifetime(projectStartDate, projectEndDate);
        }

        public  decimal GetMinActual(DateTime? minActualDate, DateTime? maxActualDate)
        {
            return _dateTimeMethods.GetMinActual(minActualDate, maxActualDate);
        }

        public  decimal GetMinActualNoForecast(DateTime? minActualDateDecActualNoForecast, DateTime? maxActualDateDecActualNoForecast)
        {
            return _dateTimeMethods.GetMinActualNoForecast(minActualDateDecActualNoForecast, maxActualDateDecActualNoForecast);
        }

        public  decimal GetPercentageComplete(decimal? projectlifetime, decimal? projectdayscompleted)
        {
            return _dateTimeMethods.GetPercentageComplete(projectlifetime, projectdayscompleted);
        }

        public  decimal GetPercentageCompleteDecActualNoForecast(decimal? projectlifetime, decimal? projectdayscompletedDecActualNoForecast)
        {
            return _dateTimeMethods.GetPercentageCompleteDecActualNoForecast(projectlifetime, projectdayscompletedDecActualNoForecast);
        }

        public GetForecastAndActualMinAndMaxDates GetForecastAndActual(string projectId, string companyId, int month)
        {
            return _dateTimeMethods.ForecastAndActual(projectId, companyId, month);
        }
        public GetForecastAndActualMinAndMaxDates GetSumForecastAndActual(GetForecastAndActualMinAndMaxDates _summaries)
        {
            return _dateTimeMethods.SumForecastAndActual(_summaries);
        }

        public DateTime GetlastDayOfPreviousMonth(DateTime currentMonthForecastStartDate, int month)
        {
            return _dateTimeMethods.GetlastDayOfPreviousMonth(currentMonthForecastStartDate, month);
        }

        public string GetDisplayName( string thiscompanyId, string thisuserName)
        {
            return _getIdsWithPartIdsMethod.GetDisplayName(thiscompanyId, thisuserName);
        }

        public string GetActualCompanyId(string companyCode)
        {
            return _getIdsWithPartIdsMethod.GetActualCompanyId(companyCode);
        }

        public string GetResourceDisplayName(string companyId, string userName)
        {
            return _getIdsWithPartIdsMethod.GetResourceDisplayName(companyId, userName);
        }

        public ResourceUtilization GetCompanyStandardDailyHours(string resourceId)
        {
            return _getIdsWithPartIdsMethod.GetCompanyStandardDailyHours(resourceId);
        }

        public string GetActualProjectId(string projectCode)
        {
            return _getIdsWithPartIdsMethod.GetActualProjectId(projectCode);
        }

         public decimal? GetTotalAllocatedAmountFromReconcileActual(string actualId, string projectId)
        {
            return _getIdsWithPartIdsMethod.GetTotalAllocatedAmountFromReconcileActual(actualId, projectId );
        }

        public ActualStartAndEndDate GetMinAndMaxActualDates(string companyId, string forecastTaskId, byte month)
        {
            return _getIdsWithPartIdsMethod.GetMinAndMaxActualDates(companyId, forecastTaskId, month );
        }
        public  ProjectStartAndEndDate GetProjectStartAndEndDates(string companyId, string projectId)
        {
            return _getIdsWithPartIdsMethod.GetProjectStartAndEndDates(companyId, projectId );
        }

        public  string CostCodeGeneration(string param, int length)
        {
            return _generatePublicIdMethod.CostCodeGeneration(param, length );
        }

        public  string PartId(string param, int length)
        {
            return _generatePublicIdMethod.PartId(param, length);
        }

        public  decimal Test(string companyId)
        {
             return _generatePublicIdMethod.Test(companyId);

        }

        public int ConvertMonthWordsToNumbers(string period)
        {
            string value = period;
            switch (value)
            {
                case "January":
                if (period == "January")
                {
                    return 1;
                }
                break;

                case "February":
                if (period == "February")
                {
                    return 2 ;
                }
                break;

                case "March":
                if (period == "March")
                {
                    return 3;
                }
                break;

                case "April":
                if (period == "April")
                {
                    return 4;
                }
                break;

                case "May":
                if (period == "May")
                {
                    return 5 ;
                }
                break;

                case "June":
                if (period == "June")
                {
                    return 6;
                }
                break;

                case "July":
                if (period == "July")
                {
                    return 7 ;
                }
                break;

                case "August":
                if (period == "August")
                {
                    return 8;
                }
                break;

                case "September":
                if (period == "September")
                {
                    return 9;
                }
                break;

                case "October":
                if (period == "October")
                {
                    return 10;
                }
                break;

                case "November":
                if (period == "November")
                {
                    return 11;
                }
                break;

                case "December":
                if (period == "December")
                {
                    return 12;
                }
                break;

                case null:
                if (period == null){
                    return 0;
                }
                break;

            }
            return 0;
        }



        // public string ProjectId { get; set; }
        // public string CompanyId { get; set; }
        // [ForeignKey("CompanyId")]
        // public Company Company { get; set; }
        // [Required]
        // public string ProjectName { get; set; }
        // public string ProjectRef { get; set; }
        // public string ProgrammeId { get; set; }
        // public string PortfolioId { get; set; }
        // public Portfolio Portfolios { get; set; }
        // public Programme Programmes { get; set; }
        // public string BusinessCustomerId { get; set; }
        // public BusinessCustomer BusinessCustomers { get; set; }
        // public string AccountingCode { get; set; }
        // public string CurrentStageGateStatus { get; set; }
        // public string ProjectLifecycleStage { get; set; }
        // public string ProjectStatus { get; set; }
        // public string RfqNumber { get; set; }
        // public string ProjectBudget { get; set; }
        // public string ProjectObjective { get; set; }
        // public string FinancialStatus { get; set; }
        // public string ProjectPrioritisation { get; set; }
        // public string Sponsor { get; set; }
        // public string ProjectCustomer { get; set; }
        // public string ProjectManagerUserName { get; set; }
        // public string ProjectManagerUserId { get; set; }
        // // public string ResourceCostCentreId { get; set; }
        // // [ForeignKey("ResourceCostCentreId")]
        // // public ResourceCostCentre ResourceCostCentre { get; set; }

        // public string ProjectReportedToUserName { get; set; }
        // public string ProjectPrimaryContactUsername { get; set; }
        // public string ProjectFinanceContactUsername { get; set; }
        // public string ProjectOwnerUserName { get; set; }


        // [DataType(DataType.MultilineText)]
        // public string ProjectStrategy { get; set; }

        // [DataType(DataType.MultilineText)]
        // public string BusinessStrategy { get; set; }
        // public string ProjectAlignment { get; set; }
        // public string BusinessAlignment { get; set; }


        // public DateTime? ProjectStartDate { get; set; }
        // public DateTime? ProjectEndDate { get; set; }

        // public int? BenefitsStartYear { get; set; }
        // public int? BenefitsDurationInYears { get; set; }
        // public decimal? GrandTotalOpexImpact { get; set; }
        // public decimal? GrandTotalBenefitsForecast { get; set; }
        // public decimal? GrandTotalBenefitsAchieved { get; set; }
        // public decimal? GrandTotalBenefitsExpected { get; set; }
        // public decimal? PlanGrandTotalCapex { get; set; }
        // public decimal? PlanGrandTotalRevex { get; set; }
        // public decimal? PlanGrandTotalOpex { get; set; }
        // public decimal? GrandTotalBudgetSubmitted { get; set; }
        // public decimal? GrandTotalBudgetApproved { get; set; }

        // public string ProjectManagerDisplayName { get { return GetResourceDisplayName(CompanyId, ProjectManagerUserId); } }
        // public string ProjectReportedToDisplayname { get { return GetResourceDisplayName(CompanyId, ProjectReportedToUserName); } }
        // public string ProjectPrimaryContactDisplayName { get { return GetResourceDisplayName(CompanyId, ProjectPrimaryContactUsername); } }
        // public string ProjectFinanceContactDisplayName { get { return GetResourceDisplayName(CompanyId, ProjectFinanceContactUsername); } }
        // public string ProjectOwnerDisplayName { get { return GetResourceDisplayName(CompanyId, ProjectOwnerUserName); } }
        // public string Projectlignment { get; set; }

        // public string RevexCostCode
        // {
        //     get { return "30" + CostCodeGeneration(ProjectId, 7).ToString(); }
        // }

        // public string CapexCostCode
        // {
        //     get { return "40" + CostCodeGeneration(ProjectId, 7).ToString(); }
        // }

        // public string OpexCostCode
        // {
        //     get { return "50" + CostCodeGeneration(ProjectId, 7).ToString(); }
        // }


        // //Planned Value(PV) - All previous years spend(Actual) + current year forecast
        // public decimal? NoActualJanForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 1, ProjectStartDate, ProjectEndDate).Projectlifetimetotalfordecactualsyearendrec; } }
        // public decimal? JanActualFebForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 2, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforjanrec; } }
        // public decimal? FebActualMarForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 3, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforfebrec; } }
        // public decimal? MarActualAprForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 4, ProjectStartDate, ProjectEndDate).Projectlifetimetotalformarrec; } }
        // public decimal? AprActualMayForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 5, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforaprrec; } }
        // public decimal? MayActualJunForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 6, ProjectStartDate, ProjectEndDate).Projectlifetimetotalformayrec; } }
        // public decimal? JunActualJulForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 7, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforjunrec; } }
        // public decimal? JulActualAugForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 8, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforjulrec; } }
        // public decimal? AugActualSepForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 9, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforaugrec; } }
        // public decimal? SepActualOctForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 10, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforseprec; } }
        // public decimal? OctActualNovForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 11, ProjectStartDate, ProjectEndDate).Projectlifetimetotalforoctrec; } }
        // public decimal? NovActualDecForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 12, ProjectStartDate, ProjectEndDate).Projectlifetimetotalfornovrec; } }
        // public decimal? DecActualNoForecastTotal { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 12, ProjectStartDate, ProjectEndDate).Projectlifetimetotalfordecrec; } }

        // //Actual Cost to Date(AC)
        // public decimal? JanAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 1, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? FebAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 2, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? MarAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 3, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? AprAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 4, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? MayAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 5, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? JunAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 6, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? JulAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 7, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? AugAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 8, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? SepAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 9, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? OctAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 10, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? NovAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 11, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? DecAllActualToDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 12, ProjectStartDate, ProjectEndDate).SumpastyearsActuals; } }
        // public decimal? DecAllActualToDecEndDate { get { return GetActualMinAndMaxDates(ProjectId, CompanyId, 12, ProjectStartDate, ProjectEndDate).SumpastyearActualsToCurrentFullYearActual; } }

        // //Earned Value (EV) = Total plan * %complete of the project.

        // public decimal? NoActualJanForecastTotalEarnedValue { get { return NoActualJanForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 1, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? JanActualFebForecastTotalEarnedValue { get { return JanActualFebForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 2, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? FebActualMarForecastTotalEarnedValue { get { return FebActualMarForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 3, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? MarActualAprForecastTotalEarnedValue { get { return MarActualAprForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 4, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? AprActualMayForecastTotalEarnedValue { get { return AprActualMayForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 5, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? MayActualJunForecastTotalEarnedValue { get { return MayActualJunForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 6, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? JunActualJulForecastTotalEarnedValue { get { return JunActualJulForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 7, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? JulActualAugForecastTotalEarnedValue { get { return JulActualAugForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 8, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? AugActualSepForecastTotalEarnedValue { get { return AugActualSepForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 9, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? SepActualOctForecastTotalEarnedValue { get { return SepActualOctForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 10, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? OctActualNovForecastTotalEarnedValue { get { return OctActualNovForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 11, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? NovActualDecForecastTotalEarnedValue { get { return NovActualDecForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 12, ProjectStartDate, ProjectEndDate).Percentagecomplete; } }
        // public decimal? DecActualNoForecastTotalEarnedValue { get { return DecActualNoForecastTotal * GetActualMinAndMaxDates(ProjectId, CompanyId, 12, ProjectStartDate, ProjectEndDate).PercentagecompleteDecActualNoForecast; } }


        // //Schedule Performance Index (SPI) calculation: SPI = EV/PV
        // //SPI measures progress achieved against progress planned. An SPI value < 1.0 indicates less work was completed than was planned. SPI > 1.0 indicates that more work was completed than was planned.
        // public decimal? NoActualJanForecastTotalSPI { get { return NoActualJanForecastTotalEarnedValue / NoActualJanForecastTotal; } }
        // public decimal? JanActualFebForecastTotalSPI { get { return JanActualFebForecastTotalEarnedValue / JanActualFebForecastTotal; } }
        // public decimal? FebActualMarForecastTotalSPI { get { return FebActualMarForecastTotalEarnedValue / FebActualMarForecastTotal; } }
        // public decimal? MarActualAprForecastTotalSPI { get { return MarActualAprForecastTotalEarnedValue / MarActualAprForecastTotal; } }
        // public decimal? AprActualMayForecastTotalSPI { get { return AprActualMayForecastTotalEarnedValue / AprActualMayForecastTotal; } }
        // public decimal? MayActualJunForecastTotalSPI { get { return MayActualJunForecastTotalEarnedValue / MayActualJunForecastTotal; } }
        // public decimal? JunActualJulForecastTotalSPI { get { return JunActualJulForecastTotalEarnedValue / JunActualJulForecastTotal; } }
        // public decimal? JulActualAugForecastTotalSPI { get { return JulActualAugForecastTotalEarnedValue / JulActualAugForecastTotal; } }
        // public decimal? AugActualSepForecastTotalSPI { get { return AugActualSepForecastTotalEarnedValue / AugActualSepForecastTotal; } }
        // public decimal? SepActualOctForecastTotalSPI { get { return SepActualOctForecastTotalEarnedValue / SepActualOctForecastTotal; } }
        // public decimal? OctActualNovForecastTotalSPI { get { return OctActualNovForecastTotalEarnedValue / OctActualNovForecastTotal; } }
        // public decimal? NovActualDecForecastTotalSPI { get { return NoActualJanForecastTotalEarnedValue / NovActualDecForecastTotal; } }
        // public decimal? DecActualNoForecastTotalSPI { get { return DecActualNoForecastTotalEarnedValue / DecActualNoForecastTotal; } }


        // //Cost Performance Index (CPI) calculation: CPI = EV/AC
        // //CPI measures the value of work completed against the actual cost. A CPI value < 1.0 indicates that costs were higher than budgeted. CPI > 1.0 indicates that costs were less than budgeted.

        // public decimal? NoActualJanForecastTotalCPI { get { return NoActualJanForecastTotalEarnedValue / JanAllActualToDate; } }
        // public decimal? JanActualFebForecastTotalCPI { get { return JanActualFebForecastTotalEarnedValue / FebAllActualToDate; } }
        // public decimal? FebActualMarForecastTotalCPI { get { return FebActualMarForecastTotalEarnedValue / MarAllActualToDate; } }
        // public decimal? MarActualAprForecastTotalCPI { get { return MarActualAprForecastTotalEarnedValue / AprAllActualToDate; } }
        // public decimal? AprActualMayForecastTotalCPI { get { return MayActualJunForecastTotalEarnedValue / MayAllActualToDate; } }
        // public decimal? MayActualJunForecastTotalCPI { get { return MayActualJunForecastTotalEarnedValue / JunAllActualToDate; } }
        // public decimal? JunActualJulForecastTotalCPI { get { return JunActualJulForecastTotalEarnedValue / JulAllActualToDate; } }
        // public decimal? JulActualAugForecastTotalCPI { get { return JulActualAugForecastTotalEarnedValue / AugAllActualToDate; } }
        // public decimal? AugActualSepForecastTotalCPI { get { return AugActualSepForecastTotalEarnedValue / SepAllActualToDate; } }
        // public decimal? SepActualOctForecastTotalCPI { get { return SepActualOctForecastTotalEarnedValue / OctAllActualToDate; } }
        // public decimal? OctActualNovForecastTotalCPI { get { return OctActualNovForecastTotalEarnedValue / NovAllActualToDate; } }
        // public decimal? NovActualDecForecastTotalCPI { get { return NoActualJanForecastTotalEarnedValue / DecAllActualToDate; } }
        // public decimal? DecActualNoForecastTotalCPI { get { return DecActualNoForecastTotalEarnedValue / DecAllActualToDecEndDate; } }

        // //Estimated at Completion (EAC) calculation: EAC = (Total Project Budget) / CPI
        // //EAC is a forecast of how much the total project will cost.

        // public decimal? NoActualJanForecastTotalEAC { get { return NoActualJanForecastTotal / NoActualJanForecastTotalCPI; } }
        // public decimal? JanActualFebForecastTotalEAC { get { return JanActualFebForecastTotal / JanActualFebForecastTotalCPI; } }
        // public decimal? FebActualMarForecastTotalEAC { get { return FebActualMarForecastTotal / FebActualMarForecastTotalCPI; } }
        // public decimal? MarActualAprForecastTotalEAC { get { return MarActualAprForecastTotal / MarActualAprForecastTotalCPI; } }
        // public decimal? AprActualMayForecastTotalEAC { get { return AprActualMayForecastTotal / AprActualMayForecastTotalCPI; } }
        // public decimal? MayActualJunForecastTotalEAC { get { return MayActualJunForecastTotal / MayActualJunForecastTotalCPI; } }
        // public decimal? JunActualJulForecastTotalEAC { get { return JunActualJulForecastTotal / JunActualJulForecastTotalCPI; } }
        // public decimal? JulActualAugForecastTotalEAC { get { return JulActualAugForecastTotal / JulActualAugForecastTotalCPI; } }
        // public decimal? AugActualSepForecastTotalEAC { get { return AugActualSepForecastTotal / AugActualSepForecastTotalCPI; } }
        // public decimal? SepActualOctForecastTotalEAC { get { return SepActualOctForecastTotal / SepActualOctForecastTotalCPI; } }
        // public decimal? OctActualNovForecastTotalEAC { get { return OctActualNovForecastTotal / OctActualNovForecastTotalCPI; } }
        // public decimal? NovActualDecForecastTotalEAC { get { return NovActualDecForecastTotal / NovActualDecForecastTotalCPI; } }
        // public decimal? DecActualNoForecastTotalEAC { get { return DecActualNoForecastTotal / DecActualNoForecastTotalCPI; } }

   }
}