using System;
using System.ComponentModel.DataAnnotations;
using static PTApi.Controllers.ForecastTasksController;

namespace PTApi.CustomValidation
{
    public class CustomValidation
    {

        [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
        public sealed class ValidStartAndEndDateAttribute : ValidationAttribute
        {

            private string _year;
            private string _month;
            private string _enddate;

            // public ValidStartAndEndDateAttribute()
            // {
            // }

            public ValidStartAndEndDateAttribute(string year, string month, string enddate )
            {
                _year = year;
                _month = month;
                _enddate = enddate;
            }

            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {

                EditForecastTaskData forecast = (EditForecastTaskData)validationContext.ObjectInstance;
                DateTime? _endDate = Convert.ToDateTime(_enddate);
                int? Year = Convert.ToInt32(_year);
                int? Month = Convert.ToInt32(_month);

                if (value != null && _endDate != null)
                {
                    DateTime _startdate = Convert.ToDateTime(value);


                    int? _startdatemonth = _startdate.Month;
                    int? _enddatemonth = _endDate?.Month;
                    int? _startdateyear = _startdate.Year;
                    int? _enddateyear = _endDate?.Year;
                    // int? forecastyear = forecast.Year;
                    int? forecastyear = Year;

                    if (_startdate <= _endDate)
                    {
                        if (_startdatemonth!=Month)
                        {
                            return new ValidationResult("Please choose the correct month and year for the Start date.");

                        }
                        if ( _startdateyear!=forecastyear)
                        {
                            return new ValidationResult("Please choose the correct month and year for the Start date.");

                        }
                        if (_enddatemonth!=Month)
                        {
                            return new ValidationResult("Please choose the correct month and year for the End date.");

                        }
                        if ( _enddateyear!=forecastyear)
                        {
                            return new ValidationResult("Please choose the correct month and year for the End date.");

                        }
                        return ValidationResult.Success;
                    }
                    return new ValidationResult("Start date can not be greater than end date.");

                }

                return new ValidationResult("Start or End date can not be null.");
            }
        }
    }
}