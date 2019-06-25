namespace PTApi.Methods
{
    public interface IGeneratePublicIdMethod
    {
        int Seq();
        string PartId(string param, int length);
        string CostCodeGeneration(string param, int length);
        decimal Test(string companyId);
        int ConvertMonthWordsToNumbers(string period);
        string ConvertMonthNumbersToWords(int? period);
    }
}