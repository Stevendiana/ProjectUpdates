using System.Threading;

namespace PTApi.Methods
{
    public class GeneratePublicIdMethod : IGeneratePublicIdMethod
    {
        private static int orderNumber = 0;

        public int Seq()
        {
          return Interlocked.Increment(ref orderNumber);
        }

        public string PartId(string param, int length)
        {
             string result = param.Substring(0, length);
             return result;
        }

        public string CostCodeGeneration(string param, int length)
        {
             string result = param.Substring(14, length);
             return result;
        }

        public  decimal Test(string companyId)
        {
            return 100/2;
        }


        public string ConvertMonthNumbersToWords(int? period)
        {
            int? value = period;
            switch (value)
            {
                case 1:
                    if (period == 1)
                    {
                        return "January";
                    }
                    break;

                case 2:
                    if (period == 2)
                    {
                        return "February";
                    }
                    break;

                case 3:
                    if (period == 3)
                    {
                        return "March";
                    }
                    break;

                case 4:
                    if (period == 4)
                    {
                        return "April";
                    }
                    break;

                case 5:
                    if (period == 5)
                    {
                        return "May";
                    }
                    break;

                case 6:
                    if (period == 6)
                    {
                        return "June";
                    }
                    break;

                case 7:
                    if (period == 7)
                    {
                        return "July";
                    }
                    break;

                case 8:
                    if (period == 8)
                    {
                        return "August";
                    }
                    break;

                case 9:
                    if (period == 9)
                    {
                        return "September";
                    }
                    break;

                case 10:
                    if (period == 10)
                    {
                        return "October";
                    }
                    break;

                case 11:
                    if (period == 11)
                    {
                        return "November";
                    }
                    break;

                case 12:
                    if (period == 12)
                    {
                        return "December";
                    }
                    break;

                case 13:
                    if (period == null)
                    {
                        return " ";
                    }
                    break;

            }
            return "";
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
    }
}