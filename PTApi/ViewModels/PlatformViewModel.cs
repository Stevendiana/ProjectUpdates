using PTApi.Methods;
using PTApi.Models;
using System.ComponentModel.DataAnnotations;

namespace PTApi.ViewModels
{
    public class PlatformViewModel
    {

        public string PlatformId { get; set; }
        public string PlatformCode
        {
            get { return "PLAT" + "-" + CreateNewId(PlatformId, 8).ToUpper(); }
        }

        [Required]
        public string PlatformName { get; set; }
        [Required]
        public string CompanyId { get; set; }
        public string HeadOfPlatform { get; set; }
        public Company Company { get; set; }




        private static string CreateNewId(string platformId, int length)
        {
            GeneratePublicIdMethod generatePublicId = new GeneratePublicIdMethod();
            return generatePublicId.PartId(platformId, 8);
        }

    }
}