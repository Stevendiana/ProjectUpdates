using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PTApi.ViewModels
{
    public class ResourceUtilizationViewModel: BaseEntity
    {
        public string ResourceUtilizationSummaryId { get; set; }
        public int Year { get; set; }
        public string CompanyId { get; set; }
        public Company Company { get; set; }
        public string ResourceId { get; set; }
        public Resource Resource { get; set; }

        public decimal? JanResourceUtilizationInDays { get; set; }
        public decimal? FebResourceUtilizationInDays { get; set; }
        public decimal? MarResourceUtilizationInDays { get; set; }
        public decimal? AprResourceUtilizationInDays { get; set; }
        public decimal? MayResourceUtilizationInDays { get; set; }
        public decimal? JunResourceUtilizationInDays { get; set; }
        public decimal? JulResourceUtilizationInDays { get; set; }
        public decimal? AugResourceUtilizationInDays { get; set; }
        public decimal? SepResourceUtilizationInDays { get; set; }
        public decimal? OctResourceUtilizationInDays { get; set; }
        public decimal? NovResourceUtilizationInDays { get; set; }
        public decimal? DecResourceUtilizationInDays { get; set; }
        // Schedule - Actual Days taken From ForecastTaskTimesheet
        public decimal? TotalUtilizationInDays
        { get; set; }

        //standard daily hours = 8hrs.

        public decimal? JanAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? FebAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? MarAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? AprAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? MayAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? JunAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? JulAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? AugAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? SepAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? OctAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? NovAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? DecAvailabilityBeforeHolidaysInDays { get; set; }

        public decimal? TotalAvailabilityBeforeHolidaysInDays
        { get; set; }

        public decimal? JanTotalHolidays { get; set; }
        public decimal? FebTotalHolidays { get; set; }
        public decimal? MarTotalHolidays { get; set; }
        public decimal? AprTotalHolidays { get; set; }
        public decimal? MayTotalHolidays { get; set; }
        public decimal? JunTotalHolidays { get; set; }
        public decimal? JulTotalHolidays { get; set; }
        public decimal? AugTotalHolidays { get; set; }
        public decimal? SepTotalHolidays { get; set; }
        public decimal? OctTotalHolidays { get; set; }
        public decimal? NovTotalHolidays { get; set; }
        public decimal? DecTotalHolidays { get; set; }


        public decimal? JanAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? FebAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? MarAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? AprAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? MayAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? JunAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? JulAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? AugAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? SepAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? OctAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? NovAvailabilityAfterHolidaysInDays { get; set; }
        public decimal? DecAvailabilityAfterHolidaysInDays { get; set; }


        // Schedule - Actual Days taken From ResourceWorkTimesheet 
        public decimal? TotalAvailabilityAfterHolidaysInDays
        { get; set; }
        public decimal? JanUtilizationPercentage { get; set; }
        public decimal? FebUtilizationPercentage { get; set; }
        public decimal? MarUtilizationPercentage { get; set; }
        public decimal? AprUtilizationPercentage { get; set; }
        public decimal? MayUtilizationPercentage { get; set; }
        public decimal? JunUtilizationPercentage { get; set; }
        public decimal? JulUtilizationPercentage { get; set; }
        public decimal? AugUtilizationPercentage { get; set; }
        public decimal? SepUtilizationPercentage { get; set; }
        public decimal? OctUtilizationPercentage { get; set; }
        public decimal? NovUtilizationPercentage { get; set; }
        public decimal? DecUtilizationPercentage { get; set; }

    }
}
