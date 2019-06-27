using Microsoft.EntityFrameworkCore;
using PTApi.Data;
using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Services
{
    public class ProjectForecastService : Repository<Project>, IProjectForecastService
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly IUserService _userService;
        

        public ProjectForecastService(ApplicationDbContext appDbContext, IUserService userService)
             : base(appDbContext)
        {
            _appDbContext = appDbContext ;
            _userService = userService ;
        }

        public class DaysPerMonth
        {
           public decimal? WorkingdaysInMonth { get; set; }
           public decimal? DaysInMonth { get; set; }
        }

        public class GetForecastAndActualMinAndMaxDates
        {
            public DateTime? MinActualDate { get; set; }
            public DateTime? MaxActualDate { get; set; }
            public DateTime? MinForecastDate { get; set; }
            public DateTime? MaxForecastDate { get; set; }

            public DateTime? ProjectStartDate { get; set; }
            public DateTime? ProjectEndDate { get; set; }

            public int? ProjectForecastMaxYear { get; set; }
            public int? ProjectForecastMinYear { get; set; }


            public decimal? Projectlifetime { get; set; }
            public decimal? Projectdayscompleted { get; set; }
            public decimal? Percentagecomplete { get; set; }


            public decimal? SumpastyearsActuals { get; set; }
            public decimal? Sumcurrentyearactualjan { get; set; }
            public decimal? Sumcurrentyearactualfeb { get; set; }
            public decimal? Sumcurrentyearactualmar { get; set; }
            public decimal? Sumcurrentyearactualapr { get; set; }
            public decimal? Sumcurrentyearactualmay { get; set; }
            public decimal? Sumcurrentyearactualjun { get; set; }
            public decimal? Sumcurrentyearactualjul { get; set; }
            public decimal? Sumcurrentyearactualaug { get; set; }
            public decimal? Sumcurrentyearactualsep { get; set; }
            public decimal? Sumcurrentyearactualoct { get; set; }
            public decimal? Sumcurrentyearactualnov { get; set; }
            public decimal? Sumcurrentyearactualdec { get; set; }

            public decimal? Sumcurrentyearforecastjan { get; set; }
            public decimal? Sumcurrentyearforecastfeb { get; set; }
            public decimal? Sumcurrentyearforecastmar { get; set; }
            public decimal? Sumcurrentyearforecastapr { get; set; }
            public decimal? Sumcurrentyearforecastmay { get; set; }
            public decimal? Sumcurrentyearforecastjun { get; set; }
            public decimal? Sumcurrentyearforecastjul { get; set; }
            public decimal? Sumcurrentyearforecastaug { get; set; }
            public decimal? Sumcurrentyearforecastsep { get; set; }
            public decimal? Sumcurrentyearforecastoct { get; set; }
            public decimal? Sumcurrentyearforecastnov { get; set; }
            public decimal? Sumcurrentyearforecastdec { get; set; }


            public decimal? SumfutureyearsForecastsjan { get; set; }
            public decimal? SumfutureyearsForecastsfeb { get; set; }
            public decimal? SumfutureyearsForecastsmar { get; set; }
            public decimal? SumfutureyearsForecastsapr { get; set; }
            public decimal? SumfutureyearsForecastsmay { get; set; }
            public decimal? SumfutureyearsForecastsjun { get; set; }
            public decimal? SumfutureyearsForecastsjul { get; set; }
            public decimal? SumfutureyearsForecastsaug { get; set; }
            public decimal? SumfutureyearsForecastssep { get; set; }
            public decimal? SumfutureyearsForecastsoct { get; set; }
            public decimal? SumfutureyearsForecastsnov { get; set; }
            public decimal? SumfutureyearsForecastsdec { get; set; }

            public decimal? Sumallfutureforecast { get; set; }

            public decimal? Projectlifetimetotalforjanrec { get; set; }
            public decimal? Projectlifetimetotalforfebrec { get; set; }
            public decimal? Projectlifetimetotalformarrec { get; set; }
            public decimal? Projectlifetimetotalforaprrec { get; set; }
            public decimal? Projectlifetimetotalformayrec { get; set; }
            public decimal? Projectlifetimetotalforjunrec { get; set; }
            public decimal? Projectlifetimetotalforjulrec { get; set; }
            public decimal? Projectlifetimetotalforaugrec { get; set; }
            public decimal? Projectlifetimetotalforseprec { get; set; }
            public decimal? Projectlifetimetotalforoctrec { get; set; }
            public decimal? Projectlifetimetotalfornovrec { get; set; }
            public decimal? Projectlifetimetotalfordecrec { get; set; }
            public decimal? Projectlifetimetotalfordecactualsyearendrec { get; set; }
            public decimal? SumcurrentyearfullActuals { get; set; }
            public decimal? SumpastyearActualsToCurrentFullYearActual { get; set; }
            public decimal? PercentagecompleteDecActualNoForecast { get; set; }
            public List<ForecastTask> Futureyearfullyearforecastforallperiods { get; set; }
            public List<ForecastTask> Fullyearforecastforallperiods { get; set; }
            public List<ForecastTask> Lifetimeforecast { get; set; }
            public List<ReconciledActual> PastyearActuals { get; set; }
            public List<ReconciledActual> PastyearActualsToCurrentFullYearActual { get; set; }


        }

        public class Forecast
        {
            public ForecastTask ForecastTasks { get; set; }
            public Actual Actuals { get; set; }
            public string AssociatedActualForecast { get; set; }
            public string ForecastTaskId { get; set; }
            public string ActualId { get; set; }
            public decimal? AllocatedAmount { get; set; }
            public DateTime ActualDateFrom { get; set; }
            public DateTime ActualDateTo { get; set; }


        }

        public class TimeSeriesForecast
        {
            public ICollection<Forecast> Lifetimeforecastwithactuals { get; set; }
            public ICollection<Forecast> Futureyearfullyearforecastforallperiods { get; set; }
            public ICollection<Forecast> PastyearActuals { get; set; }
            public ICollection<Forecast> PastyearActualsToCurrentFullYearActual { get; set; }
            public ICollection<Forecast> CurrentyearfullActuals { get; set; }
            public ICollection<Forecast> Currentyearfullyearforecastbyperiodsforjan { get; set; }
            public ICollection<Forecast> Lifetimeforecast { get; set; }
            public TimeSeriesForecast()
            {
                Lifetimeforecastwithactuals = new Collection<Forecast>();
                Futureyearfullyearforecastforallperiods = new Collection<Forecast>();
                PastyearActuals = new Collection<Forecast>();
                PastyearActualsToCurrentFullYearActual = new Collection<Forecast>();
                CurrentyearfullActuals = new Collection<Forecast>();
                Currentyearfullyearforecastbyperiodsforjan = new Collection<Forecast>();
                Lifetimeforecast = new Collection<Forecast>();

            }

        }

        public DaysPerMonth GetDaysPerMonth(int year, byte month)
        {
             //Monday to Friday are business days.
             var weekends = new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday };

            //  //Represents January.
            //  int month = 1;
            //  int year = 2011;

             //Fetch the amount of days in your given month.
             int daysInMonth = DateTime.DaysInMonth(year, month);

             //Here we create an enumerable from 1 to daysInMonth,
            //and ask whether the DateTime object we create belongs to a weekend day,
            //if it doesn't, add it to our IEnumerable<int> collection of days.
            IEnumerable<int> businessDaysInMonth = Enumerable.Range(1, daysInMonth)
                                       .Where(d => !weekends.Contains(new DateTime(year, month, d).DayOfWeek));

             decimal? workingdaysInMonth  = businessDaysInMonth.Count();

            var workingdaysInMonthObj = new DaysPerMonth() {
            WorkingdaysInMonth=workingdaysInMonth,
            DaysInMonth=daysInMonth,

            };

           return workingdaysInMonthObj;
        }

        public decimal GetLifetime(DateTime? projectStartDate, DateTime? projectEndDate)
        {
            DateTime thisProjectStartDate = projectStartDate ?? DateTime.MinValue;
            DateTime thisProjectEndDate = projectEndDate ?? DateTime.MinValue;


            decimal lifetime = Convert.ToDecimal((thisProjectEndDate.Date- thisProjectStartDate.Date).TotalDays);
            return lifetime;

        }

        public decimal GetMinActual(DateTime? minActualDate, DateTime? maxActualDate)
        {
            DateTime thisminActualDate = minActualDate ?? DateTime.MinValue;
            DateTime thismaxActualDate = maxActualDate ?? DateTime.MinValue;

            decimal projectdayscompleted = Convert.ToDecimal((thismaxActualDate.Date - thisminActualDate.Date).TotalDays);
            return projectdayscompleted;

        }

        public decimal GetMinActualNoForecast(DateTime? minActualDateDecActualNoForecast, DateTime? maxActualDateDecActualNoForecast)
        {
            DateTime thisminActualDateDecActualNoForecast = minActualDateDecActualNoForecast ?? DateTime.MinValue;
            DateTime thismaxActualDateDecActualNoForecast = maxActualDateDecActualNoForecast ?? DateTime.MinValue;

            decimal projectdayscompletedDecActualNoForecast = Convert.ToDecimal((thismaxActualDateDecActualNoForecast.Date - thisminActualDateDecActualNoForecast.Date).TotalDays);
            return projectdayscompletedDecActualNoForecast;

        }

        public decimal GetPercentageComplete(decimal? projectlifetime, decimal? projectdayscompleted)
        {
            decimal thisprojectlifetime = projectlifetime ?? 0;
            decimal thisprojectdayscompleted = projectdayscompleted ?? 0;


            if (thisprojectlifetime==0||thisprojectdayscompleted==0)
            {
                return 0;

            }
            else
            {
                return thisprojectdayscompleted/thisprojectlifetime;
            }
        }

        public decimal GetPercentageCompleteDecActualNoForecast(decimal? projectlifetime, decimal? projectdayscompletedDecActualNoForecast)
        {
            decimal thisprojectlifetime = projectlifetime ?? 0;
            decimal thisprojectdayscompletedDecActualNoForecast = projectdayscompletedDecActualNoForecast ?? 0;

            if (thisprojectlifetime==0|thisprojectdayscompletedDecActualNoForecast==0)
            {
                return 0;
            }
            else
            {
                return thisprojectdayscompletedDecActualNoForecast/thisprojectlifetime;
            }
        }

        public DateTime GetlastDayOfPreviousMonth(DateTime currentMonthForecastStartDate, int month)
        {
            DateTime lastDayOfPreviousMonth = new DateTime(currentMonthForecastStartDate.Year, month, 1).AddDays(-1);
            // if (month<12)
            // {
            //     DateTime lastDayOfPreviousMonth = new DateTime(currentMonthForecastStartDate.Year,currentMonthForecastStartDate.Month+1,1).AddDays(-1);
            //     return lastDayOfPreviousMonth;
            // }
            // else
            // {
            //     if (month==12)
            //     {
            //         DateTime lastDayOfPreviousMonth = new DateTime(currentMonthForecastStartDate.Year+1,1,1).AddDays(-1);
            //         return lastDayOfPreviousMonth;
            //     }
            //     else
            //     {
            //         DateTime lastDayOfPreviousMonth = new DateTime(currentMonthForecastStartDate.Year+1,1,1).AddDays(-1);
            //         return lastDayOfPreviousMonth;
            //     }
            // }
            return lastDayOfPreviousMonth;

        }

        public async Task<IEnumerable<Forecast>> GetLifetimeforecastwithactuals(string projectId, string companyId)
        {

            var fullyearforecastforallperiods = _appDbContext?.ForecastTasks.Where(f => (f.ProjectId == projectId) && (f.CompanyId == companyId)).ToList();


            if (fullyearforecastforallperiods.Count()>0)
            {
                 //LifeTime Forecast & Actuals.

                var lifetimeforecastwithactuals = fullyearforecastforallperiods?
                                    .Join(_appDbContext.ReconciledActuals,
                                    f => f.ForecastTaskId,
                                    ra => ra.ForecastTaskId, (f, ra) => new Forecast {
                                        ForecastTasks = f,
                                        Actuals = ra.Actual,
                                        AssociatedActualForecast = ra.ForecastTaskId,
                                        ActualDateFrom = ra.ActualDateFrom,
                                        ActualDateTo = ra.ActualDateTo,
                                        ForecastTaskId = ra.ForecastTaskId,
                                        ActualId = ra.ActualId,
                                        AllocatedAmount = ra.AllocatedAmount

                                    }).DefaultIfEmpty();


               return lifetimeforecastwithactuals;
            }

            return  await Task.FromResult<IEnumerable<Forecast>>(null);
        }

        public async Task<IEnumerable<Forecast>> GetFutureyearfullyearforecastforallperiods(string projectId, string companyId)
        {
            int? currentYear = Convert.ToInt32(_userService.GetSecureUserCompanyReportingYear());
            var lifetimeforecastwithactuals = GetLifetimeforecastwithactuals(projectId, companyId).Result.ToAsyncEnumerable();

            var futureyearfullyearforecastforallperiods = lifetimeforecastwithactuals?.Where(f => (f.ForecastTasks.Year !=null && (f.ForecastTasks.Year > currentYear))).ToList();
            if (futureyearfullyearforecastforallperiods!=null)
            {
                return await futureyearfullyearforecastforallperiods;
            }

            return  await Task.FromResult<IEnumerable<Forecast>>(null);
        }

        public async Task<IEnumerable<Forecast>> GetPastyearActuals(string projectId, string companyId, int month)
        {
            DateTime currentMonthForecastStartDate = new DateTime(Convert.ToInt32(_userService.GetSecureUserCompanyReportingYear()), month, 1);
            // DateTime lastDayOfPreviousMonth = new DateTime(currentMonthForecastStartDate.Year,currentMonthForecastStartDate.Month+1,1).AddDays(-1);
            DateTime lastDayOfPreviousMonth = GetlastDayOfPreviousMonth(currentMonthForecastStartDate, month);

            var lifetimeforecastwithactuals = GetLifetimeforecastwithactuals(projectId, companyId).Result.ToAsyncEnumerable();


            //Previous Years Actual List.

            var pastyearActuals = lifetimeforecastwithactuals?.Where(ra => (ra.ActualDateTo <= lastDayOfPreviousMonth)).ToList();
            if (pastyearActuals!=null)
            {
                return await pastyearActuals;
            }

            return  await Task.FromResult<IEnumerable<Forecast>>(null);
        }

        public async Task<IEnumerable<Forecast>> GetPastyearActualsToCurrentFullYearActual(string projectId, string companyId, int month)
        {
            DateTime currentMonthEndDate = new DateTime(Convert.ToInt32(_userService.GetSecureUserCompanyReportingYear()), month, 1).AddMonths(1).AddDays(-1);

            var lifetimeforecastwithactuals = GetLifetimeforecastwithactuals(projectId, companyId).Result.ToAsyncEnumerable();
            //Previous Years Actuals To Current FullYear Actual List.

            var pastyearActualsToCurrentFullYearActual = lifetimeforecastwithactuals?.Where(ra => (ra.ActualDateTo <= currentMonthEndDate)).ToList();

            if (pastyearActualsToCurrentFullYearActual!=null)
            {
                return await pastyearActualsToCurrentFullYearActual;
            }

            return  await Task.FromResult<IEnumerable<Forecast>>(null);
        }

        public async Task<IEnumerable<Forecast>> GetCurrentyearfullActuals(string projectId, string companyId)
        {
            int? currentYear = Convert.ToInt32(_userService.GetSecureUserCompanyReportingYear());

            var lifetimeforecastwithactuals = GetLifetimeforecastwithactuals(projectId, companyId).Result.ToAsyncEnumerable();
            //Current Year Actual List.

            var currentyearfullActuals = lifetimeforecastwithactuals?.Where(ra => (ra.ActualDateTo.Date.Year == currentYear)).ToList();

            if (currentyearfullActuals!=null)
            {
                return await currentyearfullActuals;
            }

            return  await Task.FromResult<IEnumerable<Forecast>>(null);
        }

        public async Task<IEnumerable<Forecast>> GetCurrentyearfullyearforecastbyperiodsforjan(string projectId, string companyId)
        {
            int? currentYear = Convert.ToInt32(_userService.GetSecureUserCompanyReportingYear());

            var lifetimeforecastwithactuals = GetLifetimeforecastwithactuals(projectId, companyId).Result.ToAsyncEnumerable();
            //CurrentYear Actual/Forecast - Jan.
            var currentyearfullyearforecastbyperiodsforjan = lifetimeforecastwithactuals?.Where(f => (f.ForecastTasks.Year == currentYear)).ToList();
            if (currentyearfullyearforecastbyperiodsforjan!=null)
            {
                return await currentyearfullyearforecastbyperiodsforjan;
            }

            return  await Task.FromResult<IEnumerable<Forecast>>(null);
        }

        public async Task<IEnumerable<Forecast>> GetLifetimeforecast(string projectId, string companyId, int month)
        {
            int? currentYear = Convert.ToInt32(_userService.GetSecureUserCompanyReportingYear());
            DateTime currentMonthForecastStartDate = new DateTime(currentYear.Value, month, 1);
            DateTime lastDayOfPreviousMonth = GetlastDayOfPreviousMonth(currentMonthForecastStartDate, month);

            var lifetimeforecastwithactuals = GetLifetimeforecastwithactuals(projectId, companyId).Result.ToAsyncEnumerable();
            //Lifetime forecast Lists.
            var lifetimeforecast = lifetimeforecastwithactuals?
                                                                .Where(f => (f.ForecastTasks.Year >= currentYear)
                                                                || (f.ActualDateTo <= lastDayOfPreviousMonth)
                                                                && ((f.ForecastTasks.JanStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.FebStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.MarStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.AprStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.MayStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.JunStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.JulStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.AugStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.SepStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.OctStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.NovStartDate >= currentMonthForecastStartDate)
                                                                ||(f.ForecastTasks.DecStartDate >= currentMonthForecastStartDate)
                                                                )).ToList();
            if (lifetimeforecast!=null)
            {
                return await lifetimeforecast;
            }

            return  await Task.FromResult<IEnumerable<Forecast>>(null);
        }

        public GetForecastAndActualMinAndMaxDates SumForecastAndActual(GetForecastAndActualMinAndMaxDates _summaries){

            int? currentYear = Convert.ToInt32(_userService.GetSecureUserCompanyReportingYear());

            var lifetimeforecast = _summaries.Lifetimeforecast;

            var sumpastyearsActuals = _summaries.SumpastyearsActuals;
            var sumcurrentyearfullActuals = _summaries.SumcurrentyearfullActuals;
            var futureyearfullyearforecastforallperiods = _summaries.Futureyearfullyearforecastforallperiods;


            //CurrentYear Monthly Totals - Actuals only.

            decimal? sumcurrentyearactualjan =  lifetimeforecast?.Select(f=> f.JanActualsReconciled).Sum();
            decimal? sumcurrentyearactualfeb =  lifetimeforecast?.Select(f=> f.FebActualsReconciled).Sum();
            decimal? sumcurrentyearactualmar =  lifetimeforecast?.Select(f=> f.MarActualsReconciled).Sum();
            decimal? sumcurrentyearactualapr =  lifetimeforecast?.Select(f=> f.AprActualsReconciled).Sum();
            decimal? sumcurrentyearactualmay =  lifetimeforecast?.Select(f=> f.MayActualsReconciled).Sum();
            decimal? sumcurrentyearactualjun =  lifetimeforecast?.Select(f=> f.JunActualsReconciled).Sum();
            decimal? sumcurrentyearactualjul =  lifetimeforecast?.Select(f=> f.JulActualsReconciled).Sum();
            decimal? sumcurrentyearactualaug =  lifetimeforecast?.Select(f=> f.AugActualsReconciled).Sum();
            decimal? sumcurrentyearactualsep =  lifetimeforecast?.Select(f=> f.SepActualsReconciled).Sum();
            decimal? sumcurrentyearactualoct =  lifetimeforecast?.Select(f=> f.OctActualsReconciled).Sum();
            decimal? sumcurrentyearactualnov =  lifetimeforecast?.Select(f=> f.NovActualsReconciled).Sum();
            decimal? sumcurrentyearactualdec =  lifetimeforecast?.Select(f=> f.DecActualsReconciled).Sum();


            //CurrentYear Monthly Totals - Forecasts only.

            decimal? sumcurrentyearforecastjan =  lifetimeforecast?.Select(f=> f.JanForecastAmount).Sum();
            decimal? sumcurrentyearforecastfeb =  lifetimeforecast?.Select(f=> f.FebForecastAmount).Sum();
            decimal? sumcurrentyearforecastmar =  lifetimeforecast?.Select(f=> f.MarForecastAmount).Sum();
            decimal? sumcurrentyearforecastapr =  lifetimeforecast?.Select(f=> f.AprForecastAmount).Sum();
            decimal? sumcurrentyearforecastmay =  lifetimeforecast?.Select(f=> f.MayForecastAmount).Sum();
            decimal? sumcurrentyearforecastjun =  lifetimeforecast?.Select(f=> f.JunForecastAmount).Sum();
            decimal? sumcurrentyearforecastjul =  lifetimeforecast?.Select(f=> f.JulForecastAmount).Sum();
            decimal? sumcurrentyearforecastaug =  lifetimeforecast?.Select(f=> f.AugForecastAmount).Sum();
            decimal? sumcurrentyearforecastsep =  lifetimeforecast?.Select(f=> f.SepForecastAmount).Sum();
            decimal? sumcurrentyearforecastoct =  lifetimeforecast?.Select(f=> f.OctForecastAmount).Sum();
            decimal? sumcurrentyearforecastnov =  lifetimeforecast?.Select(f=> f.NovForecastAmount).Sum();
            decimal? sumcurrentyearforecastdec =  lifetimeforecast?.Select(f=> f.DecForecastAmount).Sum();


            //Future CurrentYear+ Forecast Sum - Future Forecast only.

            decimal? sumfutureyearsForecastsjan =  futureyearfullyearforecastforallperiods?.Select(f=> f.JanForecastAmount).Sum();
            decimal? sumfutureyearsForecastsfeb =  futureyearfullyearforecastforallperiods?.Select(f=> f.FebForecastAmount).Sum();
            decimal? sumfutureyearsForecastsmar =  futureyearfullyearforecastforallperiods?.Select(f=> f.MarForecastAmount).Sum();
            decimal? sumfutureyearsForecastsapr =  futureyearfullyearforecastforallperiods?.Select(f=> f.AprForecastAmount).Sum();
            decimal? sumfutureyearsForecastsmay =  futureyearfullyearforecastforallperiods?.Select(f=> f.MayForecastAmount).Sum();
            decimal? sumfutureyearsForecastsjun =  futureyearfullyearforecastforallperiods?.Select(f=> f.JunForecastAmount).Sum();
            decimal? sumfutureyearsForecastsjul =  futureyearfullyearforecastforallperiods?.Select(f=> f.JulForecastAmount).Sum();
            decimal? sumfutureyearsForecastsaug =  futureyearfullyearforecastforallperiods?.Select(f=> f.AugForecastAmount).Sum();
            decimal? sumfutureyearsForecastssep =  futureyearfullyearforecastforallperiods?.Select(f=> f.SepForecastAmount).Sum();
            decimal? sumfutureyearsForecastsoct =  futureyearfullyearforecastforallperiods?.Select(f=> f.OctForecastAmount).Sum();
            decimal? sumfutureyearsForecastsnov =  futureyearfullyearforecastforallperiods?.Select(f=> f.NovForecastAmount).Sum();
            decimal? sumfutureyearsForecastsdec =  futureyearfullyearforecastforallperiods?.Select(f=> f.DecForecastAmount).Sum();


            //Future CurrentYear+ Forecast Grand Sum Total - Future Forecast only.
            decimal? sumallfutureforecast = sumfutureyearsForecastsjan + sumfutureyearsForecastsfeb + sumfutureyearsForecastsmar + sumfutureyearsForecastsapr + sumfutureyearsForecastsmay + sumfutureyearsForecastsjun
                                    + sumfutureyearsForecastsjul + sumfutureyearsForecastsaug + sumfutureyearsForecastssep + sumfutureyearsForecastsoct + sumfutureyearsForecastsnov + sumfutureyearsForecastsdec;


            //Lifetime Actual/Forecast Totals - Jan.
            decimal? projectlifetimetotalforjanrec =  sumpastyearsActuals + sumcurrentyearforecastjan + sumcurrentyearforecastfeb +  sumcurrentyearforecastmar +  sumcurrentyearforecastapr
                                        + sumcurrentyearforecastmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                        + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

            //Lifetime Actual/Forecast Totals - Feb.
            decimal? projectlifetimetotalforfebrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearforecastfeb +  sumcurrentyearforecastmar +  sumcurrentyearforecastapr
                                        + sumcurrentyearforecastmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                        + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;


            //Lifetime Actual/Forecast Totals - Mar.
            decimal? projectlifetimetotalformarrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearforecastmar +  sumcurrentyearforecastapr
                                        + sumcurrentyearforecastmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                        + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

            //Lifetime Actual/Forecast Totals - Apr.
            decimal? projectlifetimetotalforaprrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearforecastapr
                                        + sumcurrentyearforecastmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                        + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;


            //Lifetime Actual/Forecast Totals - May.
            decimal? projectlifetimetotalformayrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                        + sumcurrentyearforecastmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                        + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

            //Lifetime Actual/Forecast Totals - Jun.
            decimal? projectlifetimetotalforjunrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                        + sumcurrentyearactualmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                        + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;


            //Lifetime Actual/Forecast Totals - Jul.
            decimal? projectlifetimetotalforjulrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                        + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                        + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

            //Lifetime Actual/Forecast Totals - Aug.
            decimal? projectlifetimetotalforaugrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                        + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearactualjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                        + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

            //Lifetime Actual/Forecast Totals - Sep.
            decimal? projectlifetimetotalforseprec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                        + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearactualjul + sumcurrentyearactualaug + sumcurrentyearforecastsep
                                        + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

            //Lifetime Actual/Forecast Totals - Oct.
            decimal? projectlifetimetotalforoctrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                        + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearactualjul + sumcurrentyearactualaug + sumcurrentyearactualsep
                                        + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

            //Lifetime Actual/Forecast Totals - Nov.
            decimal? projectlifetimetotalfornovrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                        + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearactualjul + sumcurrentyearactualaug + sumcurrentyearactualsep
                                        + sumcurrentyearactualoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

            //Lifetime Actual/Forecast Totals - Dec.
            decimal? projectlifetimetotalfordecrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                        + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearactualjul + sumcurrentyearactualaug + sumcurrentyearactualsep
                                        + sumcurrentyearactualoct + sumcurrentyearactualnov + sumcurrentyearforecastdec + sumallfutureforecast;

            //Lifetime Actual/Forecast Totals - Yearend.
            decimal? projectlifetimetotalfordecactualsyearendrec =  sumpastyearsActuals + sumcurrentyearfullActuals + sumallfutureforecast;


            //    decimal? allProjectActualToDate = getAllReconciledTotals.Select(ra => ra.AllocatedAmount).Sum();



            // decimal projectlifetime = GetLifetime(minForecastDate, maxForecastDate);

            // decimal projectdayscompleted = GetMinActual(minActualDate, maxActualDate);
            // decimal projectdayscompletedDecActualNoForecast = GetMinActualNoForecast(minActualDateDecActualNoForecast, maxActualDateDecActualNoForecast);


            // decimal? percentagecomplete = GetPercentageComplete(projectlifetime, projectdayscompleted);
            // decimal? percentagecompleteDecActualNoForecast =  GetPercentageCompleteDecActualNoForecast(projectlifetime, projectdayscompletedDecActualNoForecast);


            var forecastAndActualMinandMaxDateObj = new GetForecastAndActualMinAndMaxDates()
            {

                SumpastyearsActuals = sumpastyearsActuals,
                Futureyearfullyearforecastforallperiods = futureyearfullyearforecastforallperiods,
                Lifetimeforecast = lifetimeforecast,


                Sumcurrentyearactualjan =  sumcurrentyearactualjan,
                Sumcurrentyearactualfeb =  sumcurrentyearactualfeb,
                Sumcurrentyearactualmar =  sumcurrentyearactualmar,
                Sumcurrentyearactualapr =  sumcurrentyearactualapr,
                Sumcurrentyearactualmay =  sumcurrentyearactualmay,
                Sumcurrentyearactualjun =  sumcurrentyearactualjun,
                Sumcurrentyearactualjul =  sumcurrentyearactualjul,
                Sumcurrentyearactualaug =  sumcurrentyearactualaug,
                Sumcurrentyearactualsep =  sumcurrentyearactualsep,
                Sumcurrentyearactualoct =  sumcurrentyearactualoct,
                Sumcurrentyearactualnov =  sumcurrentyearactualnov,
                Sumcurrentyearactualdec =  sumcurrentyearactualdec,

                Sumcurrentyearforecastjan =  sumcurrentyearforecastjan,
                Sumcurrentyearforecastfeb =  sumcurrentyearforecastfeb,
                Sumcurrentyearforecastmar =  sumcurrentyearforecastmar,
                Sumcurrentyearforecastapr =  sumcurrentyearforecastapr,
                Sumcurrentyearforecastmay =  sumcurrentyearforecastmay,
                Sumcurrentyearforecastjun =  sumcurrentyearforecastjun,
                Sumcurrentyearforecastjul =  sumcurrentyearforecastjul,
                Sumcurrentyearforecastaug =  sumcurrentyearforecastaug,
                Sumcurrentyearforecastsep =  sumcurrentyearforecastsep,
                Sumcurrentyearforecastoct =  sumcurrentyearforecastoct,
                Sumcurrentyearforecastnov =  sumcurrentyearforecastnov,
                Sumcurrentyearforecastdec =  sumcurrentyearforecastdec,

                SumfutureyearsForecastsjan =  sumfutureyearsForecastsjan,
                SumfutureyearsForecastsfeb =  sumfutureyearsForecastsfeb,
                SumfutureyearsForecastsmar =  sumfutureyearsForecastsmar,
                SumfutureyearsForecastsapr =  sumfutureyearsForecastsapr,
                SumfutureyearsForecastsmay =  sumfutureyearsForecastsmay,
                SumfutureyearsForecastsjun =  sumfutureyearsForecastsjun,
                SumfutureyearsForecastsjul =  sumfutureyearsForecastsjul,
                SumfutureyearsForecastsaug =  sumfutureyearsForecastsaug,
                SumfutureyearsForecastssep =  sumfutureyearsForecastssep,
                SumfutureyearsForecastsoct =  sumfutureyearsForecastsoct,
                SumfutureyearsForecastsnov =  sumfutureyearsForecastsnov,
                SumfutureyearsForecastsdec =  sumfutureyearsForecastsdec,



                Sumallfutureforecast = sumallfutureforecast,

                Projectlifetimetotalforjanrec =  projectlifetimetotalforjanrec,
                Projectlifetimetotalforfebrec =  projectlifetimetotalforfebrec,
                Projectlifetimetotalformarrec=projectlifetimetotalformarrec,
                Projectlifetimetotalforaprrec=projectlifetimetotalforaprrec,
                Projectlifetimetotalformayrec=projectlifetimetotalformayrec,
                Projectlifetimetotalforjunrec=projectlifetimetotalforjunrec,
                Projectlifetimetotalforjulrec=projectlifetimetotalforjulrec,
                Projectlifetimetotalforaugrec=projectlifetimetotalforaugrec,
                Projectlifetimetotalforseprec=projectlifetimetotalforseprec,
                Projectlifetimetotalforoctrec=projectlifetimetotalforoctrec,
                Projectlifetimetotalfornovrec=projectlifetimetotalfornovrec,
                Projectlifetimetotalfordecrec=projectlifetimetotalfordecrec,
                Projectlifetimetotalfordecactualsyearendrec=projectlifetimetotalfordecactualsyearendrec,
                SumcurrentyearfullActuals=sumcurrentyearfullActuals,


            };

            return forecastAndActualMinandMaxDateObj;
        }

        public GetForecastAndActualMinAndMaxDates ForecastAndActual(string projectId, string companyId, int month){

           string thiscompanyId = companyId ?? "0";
           string thisprojectId = projectId ?? "0";


           int? currentYear = Convert.ToInt32(_userService.GetSecureUserCompanyReportingYear());
           DateTime currentMonthForecastStartDate = new DateTime(currentYear.Value, month, 1);
           DateTime currentMonthEndDate = new DateTime(currentYear.Value, month, 1).AddMonths(1).AddDays(-1);
          // DateTime lastDayOfPreviousMonth = new DateTime(currentMonthForecastStartDate.Year,currentMonthForecastStartDate.Month+1,1).AddDays(-1);
           DateTime lastDayOfPreviousMonth = GetlastDayOfPreviousMonth(currentMonthForecastStartDate, month);

            var daysInMonth = DateTime.DaysInMonth(currentYear.Value, month);
             //All Project Forecast - Past,Current & Future.

            var fullyearforecastforallperiods = _appDbContext?.ForecastTasks.Include(f=>f.ReconciledActuals)
                                  .Where(f => (f.ProjectId == projectId)
                                  && (f.CompanyId == companyId)).ToList();
            var reconciledactualsforallperiods = _appDbContext?.ReconciledActuals.Include(f=>f.ForecastTask)
                                  .Where(f => (f.ProjectId == projectId)
                                  && (f.CompanyId == companyId)).ToList();


            // var fullyearforecastforallperiods = allforecast;




            if (fullyearforecastforallperiods.Count()>0)
            {
                 //LifeTime Forecast & Actuals

                //Future CurrentYear+ Forecast List.

                var futureyearfullyearforecastforallperiods = fullyearforecastforallperiods?.Where(f => (f.Year !=null && (f.Year > currentYear))).ToList();
                // var futureyearfullyearforecastforallperiods = lifetimeforecastwithactuals?.Where(f => (f.ForecastTasks.Year !=null && (f.ForecastTasks.Year > currentYear))).ToList();


                //Previous Years Actual List.

                var pastyearActuals = reconciledactualsforallperiods.Where(r => (r.ActualDateTo <= lastDayOfPreviousMonth)).ToList();
                // var pastyearActuals = lifetimeforecastwithactuals.Where(ra => (ra.ActualDateTo <= lastDayOfPreviousMonth)).ToList();

                //Previous Years Actuals To Current FullYear Actual List.

                var pastyearActualsToCurrentFullYearActual = reconciledactualsforallperiods?.Where(ra => (ra.ActualDateTo <= currentMonthEndDate)).ToList();
                // var pastyearActualsToCurrentFullYearActual = lifetimeforecastwithactuals?.Where(ra => (ra.ActualDateTo <= currentMonthEndDate)).ToList();

                //Previous Years Actuals To Current FullYear Actual Sum.

                var sumpastyearActualsToCurrentFullYearActual = pastyearActualsToCurrentFullYearActual?.Select(ra => ra.AllocatedAmount).Sum();

                //Current Year Actual List.

                var currentyearfullActuals = reconciledactualsforallperiods?.Where(ra => (ra.ActualDateTo.Date.Year == currentYear)).ToList();

                //Current Year Actual Sum.

                decimal? sumcurrentyearfullActuals = currentyearfullActuals?.Select(ra => ra.AllocatedAmount).Sum();

                //Previous Years Actual Sum.

                decimal? sumpastyearsActuals = pastyearActuals?.Select(ra => ra.AllocatedAmount).Sum();

                //CurrentYear Actual/Forecast - Jan.
                var currentyearfullyearforecastbyperiodsforjan = fullyearforecastforallperiods?.Where(f => (f.Year == currentYear)).ToList();

                //Lifetime forecast Lists.
                var lifetimeforecast = fullyearforecastforallperiods;


                decimal? sumcurrentyearactualjan =  lifetimeforecast?.Select(f=> f.JanActualsReconciled).Sum();
                decimal? sumcurrentyearactualfeb =  lifetimeforecast?.Select(f=> f.FebActualsReconciled).Sum();
                decimal? sumcurrentyearactualmar =  lifetimeforecast?.Select(f=> f.MarActualsReconciled).Sum();
                decimal? sumcurrentyearactualapr =  lifetimeforecast?.Select(f=> f.AprActualsReconciled).Sum();
                decimal? sumcurrentyearactualmay =  lifetimeforecast?.Select(f=> f.MayActualsReconciled).Sum();
                decimal? sumcurrentyearactualjun =  lifetimeforecast?.Select(f=> f.JunActualsReconciled).Sum();
                decimal? sumcurrentyearactualjul =  lifetimeforecast?.Select(f=> f.JulActualsReconciled).Sum();
                decimal? sumcurrentyearactualaug =  lifetimeforecast?.Select(f=> f.AugActualsReconciled).Sum();
                decimal? sumcurrentyearactualsep =  lifetimeforecast?.Select(f=> f.SepActualsReconciled).Sum();
                decimal? sumcurrentyearactualoct =  lifetimeforecast?.Select(f=> f.OctActualsReconciled).Sum();
                decimal? sumcurrentyearactualnov =  lifetimeforecast?.Select(f=> f.NovActualsReconciled).Sum();
                decimal? sumcurrentyearactualdec =  lifetimeforecast?.Select(f=> f.DecActualsReconciled).Sum();


                //CurrentYear Monthly Totals - Forecasts only.

                decimal? sumcurrentyearforecastjan =  lifetimeforecast?.Select(f=> f.JanForecastAmount).Sum();
                decimal? sumcurrentyearforecastfeb =  lifetimeforecast?.Select(f=> f.FebForecastAmount).Sum();
                decimal? sumcurrentyearforecastmar =  lifetimeforecast?.Select(f=> f.MarForecastAmount).Sum();
                decimal? sumcurrentyearforecastapr =  lifetimeforecast?.Select(f=> f.AprForecastAmount).Sum();
                decimal? sumcurrentyearforecastmay =  lifetimeforecast?.Select(f=> f.MayForecastAmount).Sum();
                decimal? sumcurrentyearforecastjun =  lifetimeforecast?.Select(f=> f.JunForecastAmount).Sum();
                decimal? sumcurrentyearforecastjul =  lifetimeforecast?.Select(f=> f.JulForecastAmount).Sum();
                decimal? sumcurrentyearforecastaug =  lifetimeforecast?.Select(f=> f.AugForecastAmount).Sum();
                decimal? sumcurrentyearforecastsep =  lifetimeforecast?.Select(f=> f.SepForecastAmount).Sum();
                decimal? sumcurrentyearforecastoct =  lifetimeforecast?.Select(f=> f.OctForecastAmount).Sum();
                decimal? sumcurrentyearforecastnov =  lifetimeforecast?.Select(f=> f.NovForecastAmount).Sum();
                decimal? sumcurrentyearforecastdec =  lifetimeforecast?.Select(f=> f.DecForecastAmount).Sum();


                //Future CurrentYear+ Forecast Sum - Future Forecast only.

                decimal? sumfutureyearsForecastsjan =  futureyearfullyearforecastforallperiods?.Select(f=> f.JanForecastAmount).Sum();
                decimal? sumfutureyearsForecastsfeb =  futureyearfullyearforecastforallperiods?.Select(f=> f.FebForecastAmount).Sum();
                decimal? sumfutureyearsForecastsmar =  futureyearfullyearforecastforallperiods?.Select(f=> f.MarForecastAmount).Sum();
                decimal? sumfutureyearsForecastsapr =  futureyearfullyearforecastforallperiods?.Select(f=> f.AprForecastAmount).Sum();
                decimal? sumfutureyearsForecastsmay =  futureyearfullyearforecastforallperiods?.Select(f=> f.MayForecastAmount).Sum();
                decimal? sumfutureyearsForecastsjun =  futureyearfullyearforecastforallperiods?.Select(f=> f.JunForecastAmount).Sum();
                decimal? sumfutureyearsForecastsjul =  futureyearfullyearforecastforallperiods?.Select(f=> f.JulForecastAmount).Sum();
                decimal? sumfutureyearsForecastsaug =  futureyearfullyearforecastforallperiods?.Select(f=> f.AugForecastAmount).Sum();
                decimal? sumfutureyearsForecastssep =  futureyearfullyearforecastforallperiods?.Select(f=> f.SepForecastAmount).Sum();
                decimal? sumfutureyearsForecastsoct =  futureyearfullyearforecastforallperiods?.Select(f=> f.OctForecastAmount).Sum();
                decimal? sumfutureyearsForecastsnov =  futureyearfullyearforecastforallperiods?.Select(f=> f.NovForecastAmount).Sum();
                decimal? sumfutureyearsForecastsdec =  futureyearfullyearforecastforallperiods?.Select(f=> f.DecForecastAmount).Sum();


                //Future CurrentYear+ Forecast Grand Sum Total - Future Forecast only.
                decimal? sumallfutureforecast = sumfutureyearsForecastsjan + sumfutureyearsForecastsfeb + sumfutureyearsForecastsmar + sumfutureyearsForecastsapr + sumfutureyearsForecastsmay + sumfutureyearsForecastsjun
                                        + sumfutureyearsForecastsjul + sumfutureyearsForecastsaug + sumfutureyearsForecastssep + sumfutureyearsForecastsoct + sumfutureyearsForecastsnov + sumfutureyearsForecastsdec;


                //Lifetime Actual/Forecast Totals - Jan.
                decimal? projectlifetimetotalforjanrec =  sumpastyearsActuals + sumcurrentyearforecastjan + sumcurrentyearforecastfeb +  sumcurrentyearforecastmar +  sumcurrentyearforecastapr
                                            + sumcurrentyearforecastmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                            + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

                //Lifetime Actual/Forecast Totals - Feb.
                decimal? projectlifetimetotalforfebrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearforecastfeb +  sumcurrentyearforecastmar +  sumcurrentyearforecastapr
                                            + sumcurrentyearforecastmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                            + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;


                //Lifetime Actual/Forecast Totals - Mar.
                decimal? projectlifetimetotalformarrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearforecastmar +  sumcurrentyearforecastapr
                                            + sumcurrentyearforecastmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                            + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

                //Lifetime Actual/Forecast Totals - Apr.
                decimal? projectlifetimetotalforaprrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearforecastapr
                                            + sumcurrentyearforecastmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                            + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;


                //Lifetime Actual/Forecast Totals - May.
                decimal? projectlifetimetotalformayrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                            + sumcurrentyearforecastmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                            + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

                //Lifetime Actual/Forecast Totals - Jun.
                decimal? projectlifetimetotalforjunrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                            + sumcurrentyearactualmay + sumcurrentyearforecastjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                            + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;


                //Lifetime Actual/Forecast Totals - Jul.
                decimal? projectlifetimetotalforjulrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                            + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearforecastjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                            + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

                //Lifetime Actual/Forecast Totals - Aug.
                decimal? projectlifetimetotalforaugrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                            + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearactualjul + sumcurrentyearforecastaug + sumcurrentyearforecastsep
                                            + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

                //Lifetime Actual/Forecast Totals - Sep.
                decimal? projectlifetimetotalforseprec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                            + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearactualjul + sumcurrentyearactualaug + sumcurrentyearforecastsep
                                            + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

                //Lifetime Actual/Forecast Totals - Oct.
                decimal? projectlifetimetotalforoctrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                            + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearactualjul + sumcurrentyearactualaug + sumcurrentyearactualsep
                                            + sumcurrentyearforecastoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

                //Lifetime Actual/Forecast Totals - Nov.
                decimal? projectlifetimetotalfornovrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                            + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearactualjul + sumcurrentyearactualaug + sumcurrentyearactualsep
                                            + sumcurrentyearactualoct + sumcurrentyearforecastnov + sumcurrentyearforecastdec + sumallfutureforecast;

                //Lifetime Actual/Forecast Totals - Dec.
                decimal? projectlifetimetotalfordecrec =  sumpastyearsActuals + sumcurrentyearactualjan + sumcurrentyearactualfeb +  sumcurrentyearactualmar +  sumcurrentyearactualapr
                                            + sumcurrentyearactualmay + sumcurrentyearactualjun + sumcurrentyearactualjul + sumcurrentyearactualaug + sumcurrentyearactualsep
                                            + sumcurrentyearactualoct + sumcurrentyearactualnov + sumcurrentyearforecastdec + sumallfutureforecast;

                //Lifetime Actual/Forecast Totals - Yearend.
                decimal? projectlifetimetotalfordecactualsyearendrec =  sumpastyearsActuals + sumcurrentyearfullActuals + sumallfutureforecast;


                //    decimal? allProjectActualToDate = getAllReconciledTotals.Select(ra => ra.AllocatedAmount).Sum();



                // decimal projectlifetime = GetLifetime(minForecastDate, maxForecastDate);

                // decimal projectdayscompleted = GetMinActual(minActualDate, maxActualDate);
                // decimal projectdayscompletedDecActualNoForecast = GetMinActualNoForecast(minActualDateDecActualNoForecast, maxActualDateDecActualNoForecast);


                // decimal? percentagecomplete = GetPercentageComplete(projectlifetime, projectdayscompleted);
                // decimal? percentagecompleteDecActualNoForecast =  GetPercentageCompleteDecActualNoForecast(projectlifetime, projectdayscompletedDecActualNoForecast);


                var forecastAndActualMinandMaxDateObj = new GetForecastAndActualMinAndMaxDates()
                {

                    // MinActualDate=minActualDate,
                    // MaxActualDate=maxActualDate,
                    // MinForecastDate=minForecastDate,
                    // MaxForecastDate=maxForecastDate,

                    // ProjectForecastMaxYear=projectForecastMaxYear,
                    // ProjectForecastMinYear=projectForecastMinYear,

                    // Projectlifetime=projectlifetime,
                    // Projectdayscompleted=projectdayscompleted,
                    // Percentagecomplete=percentagecomplete,


                    SumpastyearsActuals = sumpastyearsActuals,
                    Futureyearfullyearforecastforallperiods = futureyearfullyearforecastforallperiods,
                    Lifetimeforecast = lifetimeforecast,
                    PastyearActuals = pastyearActuals,
                    PastyearActualsToCurrentFullYearActual = pastyearActualsToCurrentFullYearActual,



                    Sumcurrentyearactualjan =  sumcurrentyearactualjan,
                    Sumcurrentyearactualfeb =  sumcurrentyearactualfeb,
                    Sumcurrentyearactualmar =  sumcurrentyearactualmar,
                    Sumcurrentyearactualapr =  sumcurrentyearactualapr,
                    Sumcurrentyearactualmay =  sumcurrentyearactualmay,
                    Sumcurrentyearactualjun =  sumcurrentyearactualjun,
                    Sumcurrentyearactualjul =  sumcurrentyearactualjul,
                    Sumcurrentyearactualaug =  sumcurrentyearactualaug,
                    Sumcurrentyearactualsep =  sumcurrentyearactualsep,
                    Sumcurrentyearactualoct =  sumcurrentyearactualoct,
                    Sumcurrentyearactualnov =  sumcurrentyearactualnov,
                    Sumcurrentyearactualdec =  sumcurrentyearactualdec,

                    Sumcurrentyearforecastjan =  sumcurrentyearforecastjan,
                    Sumcurrentyearforecastfeb =  sumcurrentyearforecastfeb,
                    Sumcurrentyearforecastmar =  sumcurrentyearforecastmar,
                    Sumcurrentyearforecastapr =  sumcurrentyearforecastapr,
                    Sumcurrentyearforecastmay =  sumcurrentyearforecastmay,
                    Sumcurrentyearforecastjun =  sumcurrentyearforecastjun,
                    Sumcurrentyearforecastjul =  sumcurrentyearforecastjul,
                    Sumcurrentyearforecastaug =  sumcurrentyearforecastaug,
                    Sumcurrentyearforecastsep =  sumcurrentyearforecastsep,
                    Sumcurrentyearforecastoct =  sumcurrentyearforecastoct,
                    Sumcurrentyearforecastnov =  sumcurrentyearforecastnov,
                    Sumcurrentyearforecastdec =  sumcurrentyearforecastdec,

                    SumfutureyearsForecastsjan =  sumfutureyearsForecastsjan,
                    SumfutureyearsForecastsfeb =  sumfutureyearsForecastsfeb,
                    SumfutureyearsForecastsmar =  sumfutureyearsForecastsmar,
                    SumfutureyearsForecastsapr =  sumfutureyearsForecastsapr,
                    SumfutureyearsForecastsmay =  sumfutureyearsForecastsmay,
                    SumfutureyearsForecastsjun =  sumfutureyearsForecastsjun,
                    SumfutureyearsForecastsjul =  sumfutureyearsForecastsjul,
                    SumfutureyearsForecastsaug =  sumfutureyearsForecastsaug,
                    SumfutureyearsForecastssep =  sumfutureyearsForecastssep,
                    SumfutureyearsForecastsoct =  sumfutureyearsForecastsoct,
                    SumfutureyearsForecastsnov =  sumfutureyearsForecastsnov,
                    SumfutureyearsForecastsdec =  sumfutureyearsForecastsdec,



                    Sumallfutureforecast = sumallfutureforecast,

                    Projectlifetimetotalforjanrec =  projectlifetimetotalforjanrec,
                    Projectlifetimetotalforfebrec =  projectlifetimetotalforfebrec,
                    Projectlifetimetotalformarrec=projectlifetimetotalformarrec,
                    Projectlifetimetotalforaprrec=projectlifetimetotalforaprrec,
                    Projectlifetimetotalformayrec=projectlifetimetotalformayrec,
                    Projectlifetimetotalforjunrec=projectlifetimetotalforjunrec,
                    Projectlifetimetotalforjulrec=projectlifetimetotalforjulrec,
                    Projectlifetimetotalforaugrec=projectlifetimetotalforaugrec,
                    Projectlifetimetotalforseprec=projectlifetimetotalforseprec,
                    Projectlifetimetotalforoctrec=projectlifetimetotalforoctrec,
                    Projectlifetimetotalfornovrec=projectlifetimetotalfornovrec,
                    Projectlifetimetotalfordecrec=projectlifetimetotalfordecrec,
                    Projectlifetimetotalfordecactualsyearendrec=projectlifetimetotalfordecactualsyearendrec,
                    SumcurrentyearfullActuals=sumcurrentyearfullActuals,
                    SumpastyearActualsToCurrentFullYearActual=sumpastyearActualsToCurrentFullYearActual,
                    // PercentagecompleteDecActualNoForecast=percentagecompleteDecActualNoForecast

                };

                return forecastAndActualMinandMaxDateObj;
            }
            return null;
        }

    }
}