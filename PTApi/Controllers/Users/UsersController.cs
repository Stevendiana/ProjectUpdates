using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    public class EditProfileData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class CompanyDetails
    {
        public string CompanyId { get; set; }
        public string CompanyAccountName { get; set; }
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
        public int FinanceReportingYear { get; set; }
        public bool FreezeForecast { get; set; }
        public byte? StandardDailyHours { get; set; }
        public bool DoEmployeesWorkWeekends { get; set; }
        public string CompanyCurrentShortName { get; set; }
        public string CompanyCurrentLongName { get; set; }
        //public CurrencySymbol CurrencySymbol { get; set; }
    }


    [Produces("application/json")]
    [Route("api/users")]
    public class UsersController: Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHostingEnvironment _hostingEnvironment;
        // private readonly IFileStorageService _fileService;
        private readonly IBlobStorage _blobStorage;
        CloudBlobClient blobClient;
        string baseUri = "https://pmofilesdb.blob.core.windows.net/";
        public UsersController(UserManager<AppUser> userManager, ProjectCentreDbContext appDbContext,IBlobStorage blobStorage,
        IHttpContextAccessor httpContextAccessor, IHostingEnvironment hostingEnvironment)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
            _blobStorage = blobStorage;
            var credentials = new StorageCredentials("pmofilesdb", "tb9gl6ComX8UHTFrrfx++v3C9YQO9pcMy/ZxHOEffR9wZzIhZWbJppvhqBLMiVZ1Ki0Y8x5EAKEk1eEsCxpTyQ==");
            blobClient = new CloudBlobClient(new Uri(baseUri), credentials);
        }

        [HttpGet("{id}")]
        public ActionResult Get(string id) {
            var user = _appDbContext.Users.SingleOrDefault(u => u.Id == id);

            if(user == null)
               return NotFound("User not found");

              return Ok(user);
        }

        [HttpGet("{companyId}")]
        public ActionResult GetuserCompanyId(string companyId) {
            var userCompany = _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == companyId);

            if(userCompany == null)
               return NotFound("User company not found");

              return Ok(userCompany);
        }

        [Authorize]
        [HttpGet("mycompany")]
         public ActionResult GetCompany() {

              return Ok(GetSecureUserCompany());
        }

       [Authorize]
        [HttpPost("mycompany")]
         public ActionResult Post([FromBody] CompanyDetails companyDetails) {
            var userCompany = GetSecureUserCompany();

            userCompany.CompanyAccountName = companyDetails.CompanyAccountName ?? userCompany.CompanyAccountName;
            userCompany.CompanyAddress = companyDetails.CompanyAddress ?? userCompany.CompanyAddress;
            userCompany.CompanyReg = companyDetails.CompanyReg ?? userCompany.CompanyReg;
            userCompany.Country = companyDetails.Country ?? userCompany.Country;
            userCompany.AllowReconciliation = companyDetails.AllowReconciliation;
            userCompany.DoEmployeesWorkWeekends = companyDetails.DoEmployeesWorkWeekends;
            userCompany.FinanceReportingPeriod = companyDetails.FinanceReportingPeriod ?? userCompany.FinanceReportingPeriod;
            userCompany.FinanceReportingYear = companyDetails.FinanceReportingYear;
            userCompany.FreezeForecast = companyDetails.FreezeForecast;
            userCompany.Industry = companyDetails.Industry ?? userCompany.Industry;
            userCompany.ReportingCurrency = GetCurrency(companyDetails.CompanyCurrencyId).CompanyCurrencySymbol ?? userCompany.ReportingCurrency;
            userCompany.Sector = companyDetails.Sector ?? userCompany.Sector;
            userCompany.StandardDailyHours = companyDetails.StandardDailyHours ?? userCompany.StandardDailyHours;
            userCompany.VatReg = companyDetails.VatReg ?? userCompany.VatReg;
            userCompany.CompanyCurrentShortName = GetCurrency(companyDetails.CompanyCurrencyId).CompanyCurrencyShortName ?? userCompany.CompanyCurrentShortName;
            userCompany.CompanyCurrentLongName = GetCurrency(companyDetails.CompanyCurrencyId).CompanyCurrencyLongName ?? userCompany.CompanyCurrentLongName;
            userCompany.CompanyRef = userCompany.CompanyRef;
            userCompany.CompanyContactEmail = userCompany.CompanyContactEmail;

            //user.LastName = profileData.LastName ?? user.LastName;

            _appDbContext.SaveChanges();

            return Ok(userCompany);
        }


        //[Authorize]
        [HttpGet("me")]
         public ActionResult Get() {

              return Ok(GetSecureUser());
        }

        //[Authorize]
        [HttpPost("me")]
         public ActionResult Post([FromBody] EditProfileData profileData) {

            var user = GetSecureUser();
            var resourceInDb = GetResource(user.Id);

            resourceInDb.FirstName = profileData.FirstName ?? resourceInDb.FirstName;
            resourceInDb.LastName = profileData.LastName ?? resourceInDb.LastName;

            _appDbContext.SaveChanges();

            return Ok(user);
        }


        public ActionResult UploadImage()
        {
            string imageName = null;
            var user = GetSecureUser();
            var resourceInDb = GetResource(user.Id);

            var httpRequest = HttpContext.Request;
            //Upload Image
            var postedFile = httpRequest.Form.Files["Image"];
            //Create custom filename
            imageName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).Take(10).ToArray()).Replace(" ", "-");
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(postedFile.FileName);

            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "Images" , imageName);

            if (postedFile.Length > 0)
            {

                // create and save file in wwwroot;
                // var fileStream = new FileStream(uploads, FileMode.Create);
                using (var stream = postedFile.OpenReadStream()) {
                    //   postedFile.CopyToAsync(fileStream);
                    //   var documentId = _imageService.SaveDocument(fileStream);
                    string documentId = string.Empty;
                    // documentId = _fileService.SaveDocument(stream).ToString();
                    var file = GetDocument(documentId, imageName);

                    resourceInDb.ImageCaption = httpRequest.Form["ImageCaption"];
                    resourceInDb.ImageName = imageName;
                    // resourceInDb.ImageUrl = _fileService.UriFor(documentId);
                    resourceInDb.ImageId = documentId;
                }

                _appDbContext.SaveChanges();
                return Ok();;
            }

            return BadRequest("No file attached in the request.");


            // using (var memoryStream = new MemoryStream())
            // {
            //     postedFile.CopyToAsync(memoryStream);
            //     resourceInDb.AvatarImage  = memoryStream.ToArray();
            // }


        }

        public async Task<IActionResult> GetDocument(string documentId, string fileName)
        {
            var doc = await _blobStorage.DownloadDocument(documentId, fileName);

            return File(doc.Stream, doc.ContentType, doc.FileName);
        }

        public byte[] ConvertIformtobyte(string imagename)
        {
            if (imagename != null)
            {
              var reportsFolder = "Images";
              var photopath = $"wwwroot/{reportsFolder}/{imagename}";

              byte[] bytes = System.IO.File.ReadAllBytes(photopath);

              if (photopath != null)
              {
                return bytes;
                // return File(bytes, "image/jpeg");

              }
              return null;

            }
            return null;
        }



        Resource GetResource(string id)
        {

           var resourceInDb = _appDbContext.Resources.SingleOrDefault(r => r.IdentityId == id);

            return resourceInDb ;
        }


        AppUser GetSecureUser()
        {
            //var id = HttpContext.User.Claims.First().Value;
            var id = HttpContext.User.Claims.Single(c=>c.Type=="id").Value;
            return _appDbContext.Users.SingleOrDefault(u => u.Id == id);
        }


        CurrencySymbol GetCurrency(int? id)
        {
           var compcurrency = _appDbContext.CurrencySymbols.SingleOrDefault(c => c.CurrencySymbolId == id);
            return compcurrency ;
        }

        Company GetSecureUserCompany()
        {
            //var id = HttpContext.User.Claims.First().Value;
            var id = HttpContext.User.Claims.Single(c=>c.Type=="id").Value;
            var comp = HttpContext.User.Claims.Single(c=>c.Type=="comp").Value;
            return _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == comp);
        }



        public async Task<IActionResult> Index()
        {
            var model = new FilesViewModel();
            foreach (var item in await _blobStorage.ListAsync())
            {
                model.Files.Add(
                    new FileDetails { Name = item.Name, BlobName = item.BlobName });
            }
            return View(model);
        }


        [Authorize]
        [HttpPost ("uploadImage")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var user = GetSecureUser();
            var resourceInDb = GetResource(user.Id);

            if (file == null) throw new Exception("File is null");
            if (file.Length == 0) throw new Exception("File is empty");



            var fileName = file.GetFilename();
            var filePath = Path.GetTempFileName();

            var fileStream = await file.GetFileStream();

            using (var stream = file.OpenReadStream())
            {
                // await file.CopyToAsync(stream);
                var documentId = Guid.NewGuid().ToString();

                // await _blobStorage.GetImageContainerAsync();
                // await _blobStorage.GetBlockBlobAsync(documentId);
                var container = blobClient.GetContainerReference("images");
                var blob = container.GetBlockBlobReference(documentId);

                // Image img = Image.FromStream(stream);
                // img.Save(fileName);

                // Create or overwrite the "myblob" blob with contents from file.
                await blob.UploadFromStreamAsync(stream);
                if (resourceInDb.ImageId != null)
                {
                    await _blobStorage.DeleteDocument(resourceInDb.ImageId);
                }

                resourceInDb.ImageUrl = blob.Uri.ToString();
                // resourceInDb.ImageUrl = _blobStorage.UriFor(documentId);
                resourceInDb.ImageId = documentId;
                resourceInDb.ImageName = fileName;

                _appDbContext.SaveChanges();

                return Ok();
            }
        }
        // public async Task<IActionResult> UploadFile(IFormFile file)
        // {
        //     var user = GetSecureUser();
        //     var resourceInDb = GetResource(user.Id);

        //     if (file == null) throw new Exception("File is null");
        //     if (file.Length == 0) throw new Exception("File is empty");


        //     var blobName = file.GetFilename();
        //     var filePath = Path.GetTempFileName();

        //     var fileStream = await file.GetFileStream();

        //     using (var stream = new FileStream(filePath, FileMode.Create))
        //     {
        //         // await file.CopyToAsync(stream);
        //         var documentId = Guid.NewGuid().ToString();
        //         var container = blobClient.GetContainerReference("images");
        //         var blob = container.GetBlockBlobReference(documentId);

        //         await blob.UploadFromStreamAsync(stream);
        //         if (resourceInDb.ImageId != null)
        //         {
        //             await _blobStorage.DeleteDocument(resourceInDb.ImageId);
        //         }

        //         resourceInDb.ImageUrl = _blobStorage.UriFor(documentId);
        //         resourceInDb.ImageId = documentId;
        //     }

        //     _appDbContext.SaveChanges();

        //     return Ok();
        // }

        public async Task<IActionResult> Download(string blobName, string name)
        {
            if (string.IsNullOrEmpty(blobName))
                return Content("Blob Name not present");

            var stream = await _blobStorage.DownloadAsync(blobName);
            return File(stream.ToArray(), "application/octet-stream", name);
        }

        public async Task<IActionResult> Delete(string blobName)
        {
            if (string.IsNullOrEmpty(blobName))
                return Content("Blob Name not present");

            await _blobStorage.DeleteAsync(blobName);

            return RedirectToAction("Index");
        }


    }
}