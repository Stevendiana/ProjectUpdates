using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using PTApi.Data.Repositories;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Persistence.Blob;
using PTApi.Persistence.Blob.Models;
using PTApi.Services;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CompanyDetailsController: Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IBlobStorage _blobStorage;
        CloudBlobClient blobClient;
        string baseUri = "https://pmofilesdb.blob.core.windows.net/";

        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;

        public string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }


        public CompanyDetailsController(UserManager<ApplicationUser> userManager, IMapper mapper,IBlobStorage blobStorage, IUserService userService,
            IGeneratePublicIdMethod getpublicId, IGetIdsWithPartIdsMethod getIdsWithPartIds, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _mapper = mapper;
             _blobStorage = blobStorage;
            _getIdsWithPartIds = getIdsWithPartIds;
            _getpublicId = getpublicId;
            _unitOfWork = unitOfWork;
            var credentials = new StorageCredentials("pmofilesdb", "tb9gl6ComX8UHTFrrfx++v3C9YQO9pcMy/ZxHOEffR9wZzIhZWbJppvhqBLMiVZ1Ki0Y8x5EAKEk1eEsCxpTyQ==");
            blobClient = new CloudBlobClient(new Uri(baseUri), credentials);
        }



        public class EditCompanyData
        {
            public string CompanyId { get; set; }
            public string CompanyAccountName { get; set; }
            public string CompanyRef  { get; set; }
            public string CompanyContactEmail { get; set; }
            public string CompanyCode { get; set; }
            public string CompanyAddress { get; set; }
            public string CompanyReg { get; set; }
            public string VatReg { get; set; }
            public string ReportingCurrency { get; set; }
            public string Sector { get; set; }
            public string Industry { get; set; }
            public string Country { get; set; }
            public int? CompanyCurrencyId { get; set; }
            public bool AllowReconciliation { get; set; }
            public string FinanceReportingPeriod { get; set; }
            public bool FreezeForecast { get; set; }
            public byte? StandardDailyHours { get; set; }
            public bool DoEmployeesWorkWeekends { get; set; }
            public string CompanyCurrentShortName { get; set; }
            public string CompanyCurrentLongName { get; set; }
        }



       

       // [Authorize]
        [HttpPost("mycompany")]
        public ActionResult Post([FromBody] EditCompanyData companyDetails) {
            var userCompany = _unitOfWork.Companies.Getcompany(_userService.GetSecureUserCompany());

            userCompany.CompanyAccountName = companyDetails.CompanyAccountName ?? userCompany.CompanyAccountName;
            userCompany.CompanyAddress = companyDetails.CompanyAddress ?? userCompany.CompanyAddress;
            userCompany.CompanyReg = companyDetails.CompanyReg ?? userCompany.CompanyReg;
            userCompany.Country = companyDetails.Country ?? userCompany.Country;
            userCompany.AllowReconciliation = companyDetails.AllowReconciliation;
            userCompany.DoEmployeesWorkWeekends = companyDetails.DoEmployeesWorkWeekends;
            userCompany.FinanceReportingPeriod = companyDetails.FinanceReportingPeriod ?? userCompany.FinanceReportingPeriod;
            userCompany.FreezeForecast = companyDetails.FreezeForecast;
            userCompany.Industry = companyDetails.Industry ?? userCompany.Industry;
            userCompany.ReportingCurrency = _unitOfWork.CurrencySymbols.GetSharedAppEntity(companyDetails.CompanyCurrencyId).CompanyCurrencySymbol ?? userCompany.ReportingCurrency;
            userCompany.Sector = companyDetails.Sector ?? userCompany.Sector;
            userCompany.StandardDailyHours = companyDetails.StandardDailyHours ?? userCompany.StandardDailyHours;
            userCompany.VatReg = companyDetails.VatReg ?? userCompany.VatReg;
            userCompany.CompanyCurrentShortName = _unitOfWork.CurrencySymbols.GetSharedAppEntity(companyDetails.CompanyCurrencyId).CompanyCurrencyShortName ?? userCompany.CompanyCurrentShortName;
            userCompany.CompanyCurrentLongName = _unitOfWork.CurrencySymbols.GetSharedAppEntity(companyDetails.CompanyCurrencyId).CompanyCurrencyLongName ?? userCompany.CompanyCurrentLongName;
            userCompany.CompanyRef = userCompany.CompanyRef;
            userCompany.CompanyContactEmail = userCompany.CompanyContactEmail;

            //user.LastName = profileData.LastName ?? user.LastName;

            _unitOfWork.Complete();

            return Ok(userCompany);
        }



        [Authorize]
        [HttpPost ("uploadLogo")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var userCompany = _unitOfWork.Companies.Getcompany(_userService.GetSecureUserCompany());

            if (file == null) throw new Exception("File is null");
            if (file.Length == 0) throw new Exception("File is empty");



            var fileName = file.GetFilename();
            var filePath = Path.GetTempFileName();

            var fileStream = await file.GetFileStream();

            using (var stream = file.OpenReadStream())
            {
                var documentId = Guid.NewGuid().ToString();
                var container = blobClient.GetContainerReference("logos");
                var blob = container.GetBlockBlobReference(documentId);

                await blob.UploadFromStreamAsync(stream);
                if (userCompany.LogoId != null)
                {
                    await _blobStorage.DeleteComLogo(userCompany.LogoId);
                }

                userCompany.LogoUrl = blob.Uri.ToString();
                userCompany.LogoName = fileName;
                userCompany.LogoId = documentId;

                _unitOfWork.Complete();

                return Ok();
            }
        }

    }
}