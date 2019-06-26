namespace PTApi.Helpers
{
    public static class Constants
    {
        public static class Strings
        {
            public static class JwtClaimIdentifiers
            {
                public const string Rol = "rol", RolGroup = "rolGroup",
                Id = "id", Comp = "comp",
                Firstname = "firstname",  Avatar = "avatar",
                Lastname = "lastname",  CompanyName = "companyname",  Email = "email",
                ResourceId = "resourceid", AllowRec = "allowrec",
                Financerepperiod = "financerepperiod",
                Financerepyear = "financerepyear",
                ReportingDay = "reportingday",
                CompanyLogo = "companylogo",
                Freezefore = "freezefore",
                Standarddailyhrs = "standarddailyhrs",
                Doempsworkweekends = "doempsworkweekends",
                Compcurrencylng = "compcurrencylng",
                Compcurrencysht = "compcurrencysht",
                Compcurrencysym = "compcurrencysym";

            }

            public static class JwtClaims
            {
                // public const string ApiAccess = "api_access";
                public const string AccountOwner = "AccountOwner";
                public const string SuperAdmin = "SuperAdmin";
                public const string ResourceOnly = "ResourceOnly";
                public const string Admin = "Admin";

                public const string ProjectManager = "ProjectManager";
                public const string SeniorProjectManager = "SeniorProjectManager";
                public const string PortfolioAdmin = "PortfolioAdmin";

                public const string FinanceAdmin = "FinanceAdmin";
                public const string FinanceManager = "FinanceManager";

                public const string ReadOnly = "ReadOnly";
                public const string ReadWriteTimesheetOnly = "ReadWriteTimesheetOnly";

            }

            public static class ReportingPeriods
            {
                public const string January = "January";
                public const string February = "February";
                public const string March = "March";
                public const string April = "April";
                public const string May = "May";
                public const string June = "June";
                public const string July = "July";
                public const string August = "August";
                public const string September = "September";
                public const string October = "October";
                public const string November = "November";
                public const string December = "December";

            }

            public static class CostTypes
            {
                public const string LabourCost = "Labour";
                public const string MaterialCost = "Material";
                public const string ServiceCost = "Service";
                public const string OtherCost = "Other";
            }
            public static class StatusTypes
            {
                public const string PendingApproval = "Pending Approval";
                public const string Approved = "Approved";
                public const string Rejected = "Rejected";
                //public const string Revised = "Revised";
            }



            public enum ReportingPeriod
            {
                January,
                February,
                March,
                April,
                May,
                June,
                July,
                August,
                September,
                October,
                November,
                December

            }

            public enum AccountOwnerCanGiveAccess
            {
                ResourceOnly,
                SuperAdmin,
                Admin,
                ProjectManager,
                SeniorProjectManager,
                PortfolioAdmin,
                FinanceAdmin,
                FinanceManager,
                ReadOnly,
                ReadWriteTimesheetOnly,
            }

            public enum SuperAdminCanGiveAccess
            {
                Admin,
                ResourceOnly,
                ProjectManager,
                SeniorProjectManager,
                PortfolioAdmin,
                FinanceAdmin,
                FinanceManager,
                ReadOnly,
                ReadWriteTimesheetOnly,
            }

            public enum AdminCanGiveAccess
            {
                ProjectManager,
                ResourceOnly,
                SeniorProjectManager,
                PortfolioAdmin,
                FinanceAdmin,
                FinanceManager,
                ReadOnly,
                ReadWriteTimesheetOnly,
            }

            public enum EmployeeTypes
            {
                PermanentStaff,
                ManagedService,
                Contractor,
                TemporaryStaff

            }
            public enum StatusWorkFlows
            {
                Draft,
                Approved,
                Rejected,
                Revised

            }

            public enum ResourceTypes
            {
                FullTime,
                FixedTerm,
                PartTime,
                Temporary

            }
            public enum ProjectStatus
            {
                Not_Started,
                Active,
                On_Hold,
                Completed_and_Closed,
                Cancelled
            }


            public enum StandardFullTimeEffort
            {
              ZeroHours_per_day,
              OneHours_per_day,
              TwoHours_per_day,
              ThreeHours_per_day,
              FourHours_per_day,
              FiveHours_per_day,
              SixHourss_per_day,
              SevenHours_per_day,
              EightHours_per_day,
              NineHours_per_day,
              TenHours_per_day,
              ElevenHours_per_day,
              TwelveHours_per_day,
            }

            public enum ReportingYear
            {
                Current_Year, Current_Year_Plus1, Current_Year_Plus2, Current_Year_Plus3, Current_Year_Plus4,Current_Year_Plus5,
                Current_Year_Minus1, Current_Year_Minus2, Current_Year_Minus3, Current_Year_Minus4,Current_Year_Minus5
            }

            public enum CostCategory
            {
                Revenue, Capex, Revex, Opex
            }

            public enum CostSubCategory
            {
                Contractor, Others, Salaries, Telecoms, Software, Hardware, Managed_Services
            }

            public enum RagStatus
            {
                Red, Amber, Green
            }

            public enum CostType
            {
                Labour_Cost, Material_Cost
            }

            public enum ProjectOperationalStatus
            {
                Active = 1,
                On_Hold = 2,
                Completed_and_Closed = 3,
                Not_Started = 4,
                Cancelled = 5
            }






            // public double calc(double x, double y) {
            //     switch (this) {
            //     case PLUS:
            //         return x + y;
            //     case MINUS:
            //         return x - y;
            //     case MULTILPLE:
            //         return x * y;
            //     case DIVIDED_BY:
            //         return x / y;
            //     }
            //     return 0;
            // }




        }
    }
}
