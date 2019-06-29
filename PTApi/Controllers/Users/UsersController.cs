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
using PTApi.Services;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PTApi.Controllers
{

    [Produces("application/json")]
    [Route("api/users")]
    public class UsersController: Controller
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


        public UsersController(UserManager<ApplicationUser> userManager, IMapper mapper, IBlobStorage blobStorage, IUserService userService,
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



        //public async Task<IActionResult> Index()
        //{
        //    var model = new FilesViewModel();
        //    foreach (var item in await _blobStorage.ListAsync())
        //    {
        //        model.Files.Add(
        //            new FileDetails { Name = item.Name, BlobName = item.BlobName });
        //    }
        //    return View(model);
        //}


        //public async Task<IActionResult> Download(string blobName, string name)
        //{
        //    if (string.IsNullOrEmpty(blobName))
        //        return Content("Blob Name not present");

        //    var stream = await _blobStorage.DownloadAsync(blobName);
        //    return File(stream.ToArray(), "application/octet-stream", name);
        //}

        //public async Task<IActionResult> Delete(string blobName)
        //{
        //    if (string.IsNullOrEmpty(blobName))
        //        return Content("Blob Name not present");

        //    await _blobStorage.DeleteAsync(blobName);

        //    return RedirectToAction("Index");
        //}

        //public ActionResult UploadImage()
        //{
        //    string imageName = null;
        //    var user = GetSecureUser();
        //    var resourceInDb = GetResource(user.Id);

        //    var httpRequest = HttpContext.Request;
        //    //Upload Image
        //    var postedFile = httpRequest.Form.Files["Image"];
        //    //Create custom filename
        //    imageName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).Take(10).ToArray()).Replace(" ", "-");
        //    imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(postedFile.FileName);

        //    var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "Images" , imageName);

        //    if (postedFile.Length > 0)
        //    {

        //        // create and save file in wwwroot;
        //        // var fileStream = new FileStream(uploads, FileMode.Create);
        //        using (var stream = postedFile.OpenReadStream()) {
        //            //   postedFile.CopyToAsync(fileStream);
        //            //   var documentId = _imageService.SaveDocument(fileStream);
        //            string documentId = string.Empty;
        //            // documentId = _fileService.SaveDocument(stream).ToString();
        //            var file = GetDocument(documentId, imageName);

        //            resourceInDb.ImageCaption = httpRequest.Form["ImageCaption"];
        //            resourceInDb.ImageName = imageName;
        //            // resourceInDb.ImageUrl = _fileService.UriFor(documentId);
        //            resourceInDb.ImageId = documentId;
        //        }

        //        _appDbContext.SaveChanges();
        //        return Ok();;
        //    }

        //    return BadRequest("No file attached in the request.");


        //    // using (var memoryStream = new MemoryStream())
        //    // {
        //    //     postedFile.CopyToAsync(memoryStream);
        //    //     resourceInDb.AvatarImage  = memoryStream.ToArray();
        //    // }


        //}

        //public async Task<IActionResult> GetDocument(string documentId, string fileName)
        //{
        //    var doc = await _blobStorage.DownloadDocument(documentId, fileName);

        //    return File(doc.Stream, doc.ContentType, doc.FileName);
        //}

        //public byte[] ConvertIformtobyte(string imagename)
        //{
        //    if (imagename != null)
        //    {
        //      var reportsFolder = "Images";
        //      var photopath = $"wwwroot/{reportsFolder}/{imagename}";

        //      byte[] bytes = System.IO.File.ReadAllBytes(photopath);

        //      if (photopath != null)
        //      {
        //        return bytes;
        //        // return File(bytes, "image/jpeg");

        //      }
        //      return null;

        //    }
        //    return null;
        //}


    }
}