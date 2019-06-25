using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using Newtonsoft.Json;

//using OfficeOpenXml;

using Microsoft.AspNetCore.Identity;
using ProjectCentreBackend.Models.Entities;
using ProjectCentreBackend.Persistence;
using ProjectCentreBackend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using OfficeOpenXml;
using System.Data;
using ProjectCentreBackend.Models.Methods;
//using FluentValidation;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Globalization;
using System.Data.SqlClient;
using System.Collections.Concurrent;
using ProjectCentreBackend.Core.Interfaces;
using AutoMapper;
using ProjectCentreBackend.ViewModels;

namespace ProjectCentreBackend.Controllers
{

    [Route("api/uploadactuals")]
    public class UploadActualsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        // private readonly ProjectCentreDbContext _appDbContext;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IUnitOfWork unitOfWork;
        private const string XlsxContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

        private readonly IActualRepository _actuatualrepository;
        private readonly ProjectCentreDbContext _appDbContext;
        private readonly IGetIdsWithPartIdsRepository _getIdsWithPartIds;
        private readonly IMapper _mapper;

        public UploadActualsController(UserManager<AppUser> userManager, ProjectCentreDbContext appDbContext, IGetIdsWithPartIdsRepository getIdsWithPartIds, IMapper mapper, IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment, IActualRepository actuatualrepository)
        {
            _actuatualrepository = actuatualrepository;
            this.unitOfWork = unitOfWork;
            _appDbContext = appDbContext;
            _mapper = mapper;
            _getIdsWithPartIds = getIdsWithPartIds;
            _userManager = userManager;
            _hostingEnvironment = hostingEnvironment;
        }

        public static string CreateNewId(string ActualId, int length){

           GeneratePublicId generatePublicId = new GeneratePublicId();
           return generatePublicId.PartId(ActualId,8);
        }

        public static string GetProjectId(string ProjectCode)
        {

            GetIdsWithPartIdsRepository getIdsWithPartIds = new GetIdsWithPartIdsRepository();
            return getIdsWithPartIds.GetProjectCredentials(ProjectCode).ProjectId;
        }

        public static string GetProjectName(string ProjectCode)
        {

            GetIdsWithPartIdsRepository getIdsWithPartIds = new GetIdsWithPartIdsRepository();
            return getIdsWithPartIds.GetProjectCredentials(ProjectCode).ProjectName;
        }



        public class ActualToUpload
        {
            public string ActualId { get; set; }
            public string UploadBatchNumber { get; set; }

            [Display(Name = "Project Code")]
            [Required]
            public string ActualProjectCode { get; set; }

            [Display(Name = "Company Code")]
            public string CompanyCode { get; set; }
            public string CompanyId { get; set; }
            public string ProjectId { get; set; }
            public string ProjectName { get; set; }
            public DateTime? TransactionDate { get; set; }
            public string ActualCostCategory { get; set; }
            public string ProjectCostCode { get; set; }
            public string AccountingCode { get; set; }
            [Required]
            public long ActualYear { get; set; }
            [Required]
            public byte ActualMonth { get; set; }
            public string Description { get; set; }
            public string JournalComments { get; set; }
            public string InvoiceNumber { get; set; }
            public string Source { get; set; }
            public string ExpenditureType { get; set; }
            public string ExpenditureClass { get; set; }
            public string VendorName { get; set; }
            public string ExternalVendorNumber { get; set; }
            public string ActualResourceName { get; set; }
            public string PurchaseOrderDetail { get; set; }
            [Required]
            public string TransactionCurrency { get; set; }
            public string ReportingCurrency { get; set; }
            public string DocumentDate { get; set; }
            public string MiAccountDescription { get; set; }
            [Required]
            public decimal? TransactionAmount { get; set; }

            [Required]
            public decimal? ReportingAmount { get; set; }
            [Display(Name = "Actual Code")]

            public string ActualCode {get ; set;}
            // public string ActualCode {get { return "ACT" + "-" + CreateNewId(ActualId).ToUpper();}}
            public decimal? TotalAllocatedAmount { get; set; }
            public decimal? UnAllocatedAmount { get; set; }
            public bool FullyReconciledYesOrNo { get; set; }


        }

        public static string CreateNewId(string CompanyId){

           GeneratePublicId generatePublicId = new GeneratePublicId();
           return generatePublicId.PartId(CompanyId,8);
        }

        [HttpGet]
        [Route("export")]
        public IActionResult InMemoryReport()
        {
            byte[] reportBytes;
            using (var package = ExportTemplate())
            {
                reportBytes = package.GetAsByteArray();
            }

            return File(reportBytes, XlsxContentType, "actuals.xlsx");
        }


        // create a file , call it "actuals", execute ExportTemplate, save and return the file.
        public IActionResult FileReport()
        {
            var fileDownloadName = "actuals.xlsx";
            var reportsFolder = "actuals";

            using (var package = ExportTemplate())
            {
                package.SaveAs(new FileInfo(Path.Combine(_hostingEnvironment.WebRootPath, reportsFolder, fileDownloadName)));
            }
            return File($"~/{reportsFolder}/{fileDownloadName}", XlsxContentType, fileDownloadName);
        }

        [HttpGet]
        [Route("readfile")]
        // get a file from this location , call it "actuals", execute ExportTemplate, save and return the file.
        public IActionResult ReadFile()
        {
            var fileDownloadName = "actuals.xlsx";
            var reportsFolder = "actuals";
            var fileInfo = new FileInfo(Path.Combine(_hostingEnvironment.WebRootPath, reportsFolder, fileDownloadName));
            if (!fileInfo.Exists)
            {
                using (var package = ExportTemplate())
                {
                    package.SaveAs(fileInfo);
                }
            }

            return Content(readExcelPackage(fileInfo, worksheetName: "Actuals"));
        }



        private string readExcelActualPackage([FromBody] FileInfo fileInfo)
        {
            using (var package = new ExcelPackage(fileInfo))
            {
                return readExcelPackageToString(package, package.Workbook.Worksheets["Actuals"]);
            }
        }

        private string readExcelPackage(FileInfo fileInfo, string worksheetName)
        {
            using (var package = new ExcelPackage(fileInfo))
            {
                return readExcelPackageToString(package, package.Workbook.Worksheets[worksheetName]);
            }
        }

        private string readExcelPackageToString(ExcelPackage package, ExcelWorksheet worksheet)
        {
            var rowCount = worksheet.Dimension?.Rows;
            var colCount = worksheet.Dimension?.Columns;

            if (!rowCount.HasValue || !colCount.HasValue)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            for (int row = 1; row <= rowCount.Value; row++)
            {
                for (int col = 1; col <= colCount.Value; col++)
                {
                    sb.AppendFormat("{0}\t", worksheet.Cells[row, col].Value);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        //private string readExcelPackageToString(ExcelPackage package, ExcelWorksheet worksheet)
        //[HttpGet("{companyId}")]

        private ActionResult reviewExcelPackageToString(ExcelPackage package, ExcelWorksheet worksheet)
        {
            var rowCount = worksheet.Dimension?.Rows;
            var colCount = worksheet.Dimension?.Columns;

            if (!rowCount.HasValue || !colCount.HasValue)
            {
                return null;
            }

            var sb = new StringBuilder();
            for (int row = 1; row <= rowCount.Value; row++)
            {
                sb.Append("<table class='table'><tr>");
                for (int col = 1; col <= colCount.Value; col++)
                {
                    //sb.AppendFormat("{0}\t", worksheet.Cells[row, col].Value);

                    if (worksheet.Cells[row, col].Value == null || string.IsNullOrWhiteSpace(worksheet.Cells[row, col].Value.ToString())) continue;
                    sb.Append("<th>" + worksheet.Cells[row, col].Value.ToString() + "</th>");
                }
                //sb.Append(Environment.NewLine);
                sb.Append("</tr>");
                sb.AppendLine("<tr>");

                for (int col = 1; col <= colCount.Value; col++)
                {
                    //sb.AppendFormat("{0}\t", worksheet.Cells[row, col].Value);

                    if (worksheet.Cells[row, col].Value != null)
                        sb.Append("<td>" + worksheet.Cells[row, col].Value.ToString() + "</td>");
                }

                sb.AppendLine("</tr>");

                sb.Append("</table>");
            }
            // return sb.ToString();
            return this.Content(sb.ToString());
        }

        public ExcelPackage ExportTemplate()
        {

            var package = new ExcelPackage();

            package.Workbook.Properties.Title = "Actuals Upload Template";
            package.Workbook.Properties.Author = "Stephen N.";
            package.Workbook.Properties.Subject = "Actuals Upload Template";
            package.Workbook.Properties.Keywords = "Actuals";

            // add a new worksheet to the empty workbook
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Actuals");
            //First add the headers
            worksheet.Cells[1, 1].Value = "Project Code";
            worksheet.Cells[1, 2].Value = "Project Name";
            worksheet.Cells[1, 3].Value = "Transaction Date";
            worksheet.Cells[1, 4].Value = "Cost Category";
            worksheet.Cells[1, 5].Value = "Project Cost Centre";
            worksheet.Cells[1, 6].Value = "Accounting Code/ General Ledger";
            worksheet.Cells[1, 7].Value = "Actual Year";
            worksheet.Cells[1, 8].Value = "Actual Month";
            worksheet.Cells[1, 9].Value = "Cost Description";
            worksheet.Cells[1, 10].Value = "Invoice Number";
            worksheet.Cells[1, 11].Value = "Source/ Vendor";
            worksheet.Cells[1, 12].Value = "Expenditure Type";
            worksheet.Cells[1, 13].Value = "Expenditure Class";
            worksheet.Cells[1, 14].Value = "Vendor Name";
            worksheet.Cells[1, 15].Value = "External Vendor Number";
            worksheet.Cells[1, 16].Value = "Actual Resource Name";
            worksheet.Cells[1, 17].Value = "Purchase Order Detail";
            worksheet.Cells[1, 18].Value = "Transaction Currency";
            worksheet.Cells[1, 19].Value = "Document Date";
            worksheet.Cells[1, 20].Value = "MI Account Description";
            worksheet.Cells[1, 21].Value = "TransactionAmount";
            worksheet.Cells[1, 22].Value = "Reporting Currency";
            worksheet.Cells[1, 23].Value = "Reporting Amount";

            //Add values
            worksheet.Cells["A2"].Value = 1000;
            worksheet.Cells["B2"].Value = "Programme Management Centre";
            worksheet.Cells["C2"].Value = "01/01/2018";
            worksheet.Cells["D2"].Value = "Revex";
            worksheet.Cells["E2"].Value = " ";
            worksheet.Cells["F2"].Value = "Revex";
            worksheet.Cells["G2"].Value = "2018";
            worksheet.Cells["H2"].Value = "1";
            worksheet.Cells["I2"].Value = "Design cost";
            worksheet.Cells["J2"].Value = "Revex";
            worksheet.Cells["K2"].Value = "Revex";
            worksheet.Cells["L2"].Value = "Revex";
            worksheet.Cells["M2"].Value = "Revex";
            worksheet.Cells["N2"].Value = "Revex";
            worksheet.Cells["O2"].Value = "Revex";
            worksheet.Cells["P2"].Value = "Revex";
            worksheet.Cells["Q2"].Value = " ";
            worksheet.Cells["R2"].Value = "USD";
            worksheet.Cells["S2"].Value = "01/01/2018";
            worksheet.Cells["T2"].Value = "Resource cost";
            worksheet.Cells["U2"].Value = "1000";
            worksheet.Cells["V2"].Value = " ";
            worksheet.Cells["W2"].Value = "1000";

            return package;

        }


        public async Task<IActionResult> FileUpload(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return RedirectToAction("Index");
            }

            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream).ConfigureAwait(false);

                using (var package = new ExcelPackage(memoryStream))
                {
                    var worksheet = package.Workbook.Worksheets[1]; // Tip: To access the first worksheet, try index 1, not 0
                    return Content(readExcelPackageToString(package, worksheet));
                }
            }
        }

        [Authorize(Policy="Admin_Group")]
        [HttpPost("{companyId}")]
        public async Task<IActionResult> ImportActuals(string companyId, IFormFile file)
        {
            List<ActualToUpload> actualToUploads = new List<ActualToUpload>();
           // List<string> data = new List<string>();

            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream).ConfigureAwait(false);
                    using (ExcelPackage package = new ExcelPackage(memoryStream))
                    {
                        if (file != null)
                        {

                            StringBuilder sb = new StringBuilder();
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                            int rowCount = worksheet.Dimension.Rows;
                            int ColCount = worksheet.Dimension.Columns;
                            bool bHeaderRow = true;

                            var start = worksheet.Dimension.Start;
                            var end = worksheet.Dimension.End;

                            var uploadBatchNumber = Guid.NewGuid().ToString();
                            var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
                            var email = HttpContext.User.Claims.Single(c => c.Type == "name").Value;

                            for (int row = 2; row <= rowCount; row++)
                            {
                                //if (ModelState.IsValid)

                                if (bHeaderRow)
                                // if (
                                //     !string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString()) &&
                                //     !string.IsNullOrEmpty(worksheet.Cells[row, 3].Value?.ToString()) &&
                                //     !string.IsNullOrEmpty(worksheet.Cells[row, 7].Value?.ToString()) &&
                                //     !string.IsNullOrEmpty(worksheet.Cells[row, 8].Value?.ToString()) &&
                                //     !string.IsNullOrEmpty(worksheet.Cells[row, 9].Value?.ToString()) &&
                                //     !string.IsNullOrEmpty(worksheet.Cells[row, 21].Value?.ToString()))
                                {
                                    ActualToUpload aTUpload = new ActualToUpload();

                                    int transactionDate = Convert.ToInt32( !string.IsNullOrEmpty(worksheet.Cells[row, 21].Value?.ToString())? worksheet.Cells[row, 3].Value?.ToString():null);
                                    DateTime convertedtransactionDate =  !string.IsNullOrEmpty(worksheet.Cells[row, 21].Value?.ToString())? FromExcelSerialDate(transactionDate):FromExcelSerialDate(0);

                                    string actualYear = worksheet.Cells[row, 7].Value?.ToString();
                                    long convertedactualYear = Convert.ToInt64(actualYear);

                                    string actualMonth = worksheet.Cells[row, 8].Value?.ToString();
                                    byte convertedactualMonth = Convert.ToByte(actualMonth);

                                    string transactionamount = worksheet.Cells[row, 21].Value?.ToString();
                                    decimal convertedtransactionamount = Convert.ToDecimal(transactionamount);

                                    string reportingamount = worksheet.Cells[row, 23].Value?.ToString();
                                    decimal convertedreportingamount = Convert.ToDecimal(reportingamount);

                                    int documentDate = Convert.ToInt32(worksheet.Cells[row, 19].Value?.ToString());
                                    // DateTime converteddocumentDate = DateTime.ParseExact(documentDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                    DateTime converteddocumentDate = FromExcelSerialDate(documentDate);

                                    aTUpload.ProjectName = worksheet.Cells[row, 2].Value?.ToString();
                                    aTUpload.ActualProjectCode = worksheet.Cells[row, 1].Value?.ToString();

                                    aTUpload.CompanyId = companyId;
                                    aTUpload.TransactionDate = convertedtransactionDate;
                                    aTUpload.ActualCostCategory = worksheet.Cells[row, 4].Value?.ToString();
                                    aTUpload.ProjectCostCode = worksheet.Cells[row, 5].Value?.ToString();
                                    aTUpload.AccountingCode = worksheet.Cells[row, 6].Value?.ToString();
                                    aTUpload.ActualYear = convertedactualYear;
                                    aTUpload.ActualMonth = convertedactualMonth;
                                    aTUpload.Description = worksheet.Cells[row, 9].Value?.ToString();
                                    aTUpload.InvoiceNumber = worksheet.Cells[row, 10].Value?.ToString();
                                    aTUpload.Source = worksheet.Cells[row, 11].Value?.ToString();
                                    aTUpload.ExpenditureType = worksheet.Cells[row, 12].Value?.ToString();
                                    aTUpload.ExpenditureClass = worksheet.Cells[row, 13].Value?.ToString();
                                    aTUpload.VendorName = worksheet.Cells[row, 14].Value?.ToString();
                                    aTUpload.ExternalVendorNumber = worksheet.Cells[row, 15].Value?.ToString();
                                    aTUpload.ActualResourceName = worksheet.Cells[row, 16].Value?.ToString();
                                    aTUpload.PurchaseOrderDetail = worksheet.Cells[row, 17].Value?.ToString();
                                    aTUpload.TransactionCurrency = worksheet.Cells[row, 18].Value?.ToString();
                                    aTUpload.DocumentDate = converteddocumentDate.ToString("dd/MM/yyyy");
                                    aTUpload.MiAccountDescription = worksheet.Cells[row, 20].Value?.ToString();
                                    aTUpload.ReportingCurrency = worksheet.Cells[row, 22].Value?.ToString();
                                    aTUpload.TransactionAmount = convertedtransactionamount;
                                    aTUpload.ReportingAmount = convertedreportingamount;
                                    aTUpload.UploadBatchNumber = uploadBatchNumber;


                                   //_appDbContext.Actuals.Add(aTUpload);
                                    actualToUploads.Add(aTUpload);
                                    continue;

                                }
                                else
                                {

                                    // if (string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString()))
                                    // {
                                    //     ModelState.AddModelError("actualProjectCode", string.Format("Project Code is required.", worksheet.Cells[row, 1].Value.ToString()));
                                    //     return BadRequest(ModelState);

                                    // }
                                    // if (string.IsNullOrEmpty(worksheet.Cells[row, 3].Value?.ToString()))
                                    // {
                                    //     ModelState.AddModelError("transactionDate", string.Format("Transaction Date is required.", worksheet.Cells[row, 3].Value.ToString()));
                                    //     return BadRequest(ModelState);

                                    // }
                                    // if (string.IsNullOrEmpty(worksheet.Cells[row, 7].Value?.ToString()))
                                    // {
                                    //     ModelState.AddModelError("actualYear", string.Format("Actual Year is required.", worksheet.Cells[row, 7].Value.ToString()));
                                    //     return BadRequest(ModelState);

                                    // }
                                    // if (string.IsNullOrEmpty(worksheet.Cells[row, 8].Value?.ToString()))
                                    // {
                                    //     ModelState.AddModelError("actualMonth", string.Format("Actual Month is required.", worksheet.Cells[row, 8].Value.ToString()));
                                    //     return BadRequest(ModelState);

                                    // }
                                    // if (string.IsNullOrEmpty(worksheet.Cells[row, 9].Value?.ToString()))
                                    // {
                                    //     ModelState.AddModelError("description", string.Format("Cost Description is required.", worksheet.Cells[row, 9].Value.ToString()));
                                    //     return BadRequest(ModelState);

                                    // }
                                    // if (string.IsNullOrEmpty(worksheet.Cells[row, 21].Value?.ToString()))
                                    // {
                                    //     ModelState.AddModelError("transactionAmount", string.Format("Transaction Amount is required.", worksheet.Cells[row, 21].Value.ToString()));
                                    //     return BadRequest(ModelState);
                                    // }

                                    ModelState.AddModelError("file", string.Format("Fie has no header or contains no data.", file));
                                    return BadRequest(ModelState);
                                }
                            }

                            return Ok(actualToUploads);
                        }
                        else
                        {
                           ModelState.AddModelError("file", string.Format("Please attach a file.", file));
                           return BadRequest(ModelState);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return Json("Some error occured while importing." + ex.Message);
            }
        }




        // [Authorize(Policy="Admin_Group")]
        // [HttpPost("{companyId}")]
        // public async Task<IActionResult> ImportActuals(string companyId, IFormFile file)
        // {
        //     List<ActualToUpload> actualToUploads = new List<ActualToUpload>();
        //     List<string> data = new List<string>();

        //     try
        //     {
        //         using (var memoryStream = new MemoryStream())
        //         {
        //             await file.CopyToAsync(memoryStream).ConfigureAwait(false);
        //             using (ExcelPackage package = new ExcelPackage(memoryStream))
        //             {
        //                 if (file != null)
        //                 {

        //                     StringBuilder sb = new StringBuilder();
        //                     ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
        //                     int rowCount = worksheet.Dimension.Rows;
        //                     int ColCount = worksheet.Dimension.Columns;
        //                     bool bHeaderRow = true;

        //                     var start = worksheet.Dimension.Start;
        //                     var end = worksheet.Dimension.End;

        //                     var uploadBatchNumber = Guid.NewGuid().ToString();
        //                     var comp = HttpContext.User.Claims.Single(c => c.Type == "comp").Value;
        //                     var email = HttpContext.User.Claims.Single(c => c.Type == "name").Value;

        //                     for (int row = 2; row <= rowCount; row++)
        //                     {
        //                          if (!ModelState.IsValid)
        //                                 return BadRequest(ModelState);
        //                           if (bHeaderRow)
        //                         // if (bHeaderRow &&
        //                         // !string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString()) &&
        //                         // !string.IsNullOrEmpty(worksheet.Cells[row, 3].Value?.ToString()) &&
        //                         // !string.IsNullOrEmpty(worksheet.Cells[row, 7].Value?.ToString()) &&
        //                         // !string.IsNullOrEmpty(worksheet.Cells[row, 8].Value?.ToString()) &&
        //                         // !string.IsNullOrEmpty(worksheet.Cells[row, 9].Value?.ToString()) &&
        //                         // !string.IsNullOrEmpty(worksheet.Cells[row, 21].Value?.ToString()))

        //                         // worksheet.Cells[row, 1].Value?.ToString() != "" &&
        //                         // worksheet.Cells[row, 3].Value?.ToString() != "" &&
        //                         // worksheet.Cells[row, 7].Value?.ToString() != "" &&
        //                         // worksheet.Cells[row, 8].Value?.ToString() != "" &&
        //                         // worksheet.Cells[row, 9].Value?.ToString() != "" &&
        //                         // worksheet.Cells[row, 21].Value?.ToString() != "")
        //                         {
        //                             ActualToUpload aTUpload = new ActualToUpload();

        //                             int transactionDate = Convert.ToInt32(worksheet.Cells[row, 3].Value?.ToString());
        //                             DateTime convertedtransactionDate = FromExcelSerialDate(transactionDate);

        //                             string actualYear = worksheet.Cells[row, 7].Value?.ToString();
        //                             long convertedactualYear = Convert.ToInt64(actualYear);

        //                             string actualMonth = worksheet.Cells[row, 8].Value?.ToString();
        //                             byte convertedactualMonth = Convert.ToByte(actualMonth);

        //                             string amount = worksheet.Cells[row, 21].Value?.ToString();
        //                             decimal convertedamount = Convert.ToDecimal(amount);

        //                             int documentDate = Convert.ToInt32(worksheet.Cells[row, 19].Value?.ToString());
        //                             // DateTime converteddocumentDate = DateTime.ParseExact(documentDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        //                             DateTime converteddocumentDate = FromExcelSerialDate(documentDate);

        //                             aTUpload.ProjectName = worksheet.Cells[row, 2].Value?.ToString();
        //                             aTUpload.ActualProjectCode = worksheet.Cells[row, 1].Value?.ToString();

        //                             aTUpload.CompanyId = companyId;
        //                             aTUpload.TransactionDate = convertedtransactionDate;
        //                             aTUpload.ActualCostCategory = worksheet.Cells[row, 4].Value?.ToString();
        //                             aTUpload.ProjectCostCode = worksheet.Cells[row, 5].Value?.ToString();
        //                             aTUpload.AccountingCode = worksheet.Cells[row, 6].Value?.ToString();
        //                             aTUpload.ActualYear = convertedactualYear;
        //                             aTUpload.ActualMonth = convertedactualMonth;
        //                             aTUpload.Description = worksheet.Cells[row, 9].Value?.ToString();
        //                             aTUpload.InvoiceNumber = worksheet.Cells[row, 10].Value?.ToString();
        //                             aTUpload.Source = worksheet.Cells[row, 11].Value?.ToString();
        //                             aTUpload.ExpenditureType = worksheet.Cells[row, 12].Value?.ToString();
        //                             aTUpload.ExpenditureClass = worksheet.Cells[row, 13].Value?.ToString();
        //                             aTUpload.VendorName = worksheet.Cells[row, 14].Value?.ToString();
        //                             aTUpload.ExternalVendorNumber = worksheet.Cells[row, 15].Value?.ToString();
        //                             aTUpload.ActualResourceName = worksheet.Cells[row, 16].Value?.ToString();
        //                             aTUpload.PurchaseOrderDetail = worksheet.Cells[row, 17].Value?.ToString();
        //                             aTUpload.TransactionCurrency = worksheet.Cells[row, 18].Value?.ToString();
        //                             aTUpload.DocumentDate = converteddocumentDate.ToString("dd/MM/yyyy");
        //                             aTUpload.MiAccountDescription = worksheet.Cells[row, 20].Value?.ToString();
        //                             aTUpload.TransactionAmount = convertedamount;
        //                             aTUpload.UploadBatchNumber = uploadBatchNumber;

        //                             if (!ModelState.IsValid)
        //                                 return BadRequest(ModelState);

        //                            //_appDbContext.Actuals.Add(aTUpload);
        //                             actualToUploads.Add(aTUpload);
        //                             continue;

        //                         }
        //                         else
        //                         {
        //                             //sb.Append(worksheet.Cells[row, col].Value.ToString() + "\t");
        //                             data.Add("<ul>");
        //                             if (worksheet.Cells[row, 1].Value?.ToString() == "" || worksheet.Cells[row, 1].Value?.ToString() == null) data.Add("<li> Project Code is required</li>");
        //                             if (worksheet.Cells[row, 3].Value?.ToString() == "" || worksheet.Cells[row, 3].Value?.ToString() == null) data.Add("<li> Transaction Date is required</li>");
        //                             if (worksheet.Cells[row, 7].Value?.ToString() == "" || worksheet.Cells[row, 7].Value?.ToString() == null) data.Add("<li> Actual Year is required</li>");
        //                             if (worksheet.Cells[row, 8].Value?.ToString() == "" || worksheet.Cells[row, 8].Value?.ToString() == null) data.Add("<li> Actual Month is required</li>");
        //                             if (worksheet.Cells[row, 9].Value?.ToString() == "" || worksheet.Cells[row, 9].Value?.ToString() == null) data.Add("<li> Cost Description is required</li>");
        //                             if (worksheet.Cells[row, 21].Value?.ToString() == "" || worksheet.Cells[row, 21].Value?.ToString() == null) data.Add("<li> Amount is required</li>");
        //                             data.Add("</ul>");
        //                             data.ToArray();
        //                             return Json(data);
        //                         }


        //                     }

        //                     // if (reviewed==true)
        //                     // {
        //                     //     var actuals = _mapper.Map<List<ActualToUpload>, List<Actual>>(actualToUploads);
        //                     //     foreach (var actual in actuals)
        //                     //     {
        //                     //         var project = _getIdsWithPartIds.GetProjectCredentials(actual.ActualProjectCode);

        //                     //         var id = Guid.NewGuid().ToString();

        //                     //         actual.ActualId = id;
        //                     //         actual.ProjectId = project.ProjectId.ToString();
        //                     //         actual.ProjectName = project.ProjectName.ToString();
        //                     //         actual.CompanyId = comp;
        //                     //         actual.CompanyCode = _getIdsWithPartIds.GetCompanyCode(comp);
        //                     //         actual.UploadBatchNumber = uploadBatchNumber;
        //                     //         actual.DateCreated = DateTime.UtcNow;
        //                     //         actual.DateModified = DateTime.UtcNow;
        //                     //         actual.UserCreatedEmail = email;
        //                     //         actual.UserModifiedEmail = email;

        //                     //         actual.ActualCode = "ACT" + "-" + CreateNewId(id,8).ToUpper();
        //                     //         continue;
        //                     //     }

        //                     //     //return Json("success");
        //                     //     // return Json(actualToUploads);

        //                     //     await _appDbContext.Actuals.AddRangeAsync(actuals);
        //                     //     await  _appDbContext.SaveChangesAsync();
        //                     //     var result = await _actuatualrepository.GetRecentlyUploadedActuals(comp, uploadBatchNumber);

        //                     //     List<ActualViewModel> newactuals = new List<ActualViewModel>();
        //                     //     foreach (var item in result)
        //                     //     {
        //                     //         var actualViewModel = _mapper.Map<Actual, ActualViewModel>(item);
        //                     //         actualViewModel.TotalAllocatedAmount =_getIdsWithPartIds.GetTotalAllocatedAmountFromReconcileActual(item.ActualId, item.ProjectId)??0;
        //                     //         actualViewModel.FullyReconciledYesOrNo = FullyReconciledYesOrNo(item.Amount, item.TotalAllocatedAmount);
        //                     //         actualViewModel.UnAllocatedAmount = UnAllocatedAmount(item.Amount, item.TotalAllocatedAmount)??0;

        //                     //         newactuals.Add(actualViewModel);

        //                     //         continue;
        //                     //     }

        //                     //     return Ok(newactuals);

        //                     // }

        //                     return Ok(actualToUploads);
        //                 }
        //                 else
        //                 {
        //                     data.Add("<ul>");
        //                     if (file == null) data.Add("<li>Please choose Excel file</li>");
        //                     data.Add("</ul>");
        //                     data.ToArray();
        //                     return Json(data);
        //                 }
        //             }
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         return Json("Some error occured while importing." + ex.Message);
        //     }
        // }

        public static DateTime FromExcelSerialDate(int SerialDate)
        {

            if (SerialDate > 59) SerialDate -= 1;
            return new DateTime(1899, 12, 31).AddDays(SerialDate);

        }


        public FileResult DownloadExcel()
        {
            string path = "/Doc/Users.xlsx";
            return File(path, "application/vnd.ms-excel", "Users.xlsx");
        }

        public static decimal? UnAllocatedAmount(decimal? amount, decimal? totallocated)
        {
            if (totallocated ==null)
            {
                return amount;
            }
            return amount - totallocated;
        }

        // if UnAllocatedAmount = 0 return "Yes" else return "No"
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public static bool FullyReconciledYesOrNo(decimal? amount, decimal? totallocated)
        {
            if (totallocated != amount)
                return false;
            return true;
        }





        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [HttpPost]
        // public async Task<IActionResult> Index(ICollection<IFormFile> files)
        // {
        //     var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
        //     foreach (var file in files)
        //     {
        //         if (file.Length > 0)
        //         {
        //             using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
        //             {
        //                 await file.CopyToAsync(fileStream);

        //             }

        //         }
        //     }
        //     return View();
        // }

        // public ActionResult SaveData(List<Actual> actuals)
        // {
        //     bool status = false;
        //     if (ModelState.IsValid)
        //     {
        //         using (ApplicationDbContext dc = new ApplicationDbContext())
        //         {
        //             foreach (var i in actuals)
        //             {
        //                 dc.Actuals.Add(i);
        //             }
        //             dc.SaveChanges();
        //         }
        //         status = true;
        //     }
        //     return  Ok("Successfully uploaded.");
        // }


        AppUser GetSecureUser()
        {

            //var id = HttpContext.User.Claims.First().Value;
           var id = User.Claims.Single(c=>c.Type=="id").Value;
            return _appDbContext.Users.SingleOrDefault(u => u.Id == id);
        }



        [Authorize]
        [HttpPost("save")]
        // [Produces("text/csv")]
        public ActionResult POST([FromBody] List<ActualToUpload> actuals)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loadedactuals = _mapper.Map<List<ActualToUpload>, List<Actual>>(actuals);

            var user = GetSecureUser();
            var uploadBatchNumber = Guid.NewGuid().ToString();

            foreach (var actual in loadedactuals)
            {
                var project = _getIdsWithPartIds.GetProjectCredentials(actual.ActualProjectCode);

                if (project == null)
                {
                    ModelState.AddModelError("ActualProjectCode", string.Format("Wrong Project code.", actual.ActualProjectCode));
                    return BadRequest(ModelState);

                }

                var id = Guid.NewGuid().ToString();

                actual.ActualId = id;
                actual.ProjectId = project.ProjectId.ToString();
                actual.ProjectName = project.ProjectName.ToString();
                actual.CompanyId = user.CompanyId;
                actual.CompanyCode = _getIdsWithPartIds.GetCompanyCode(user.CompanyId);
                actual.UploadBatchNumber = uploadBatchNumber;
                actual.DateCreated = DateTime.UtcNow;
                actual.DateModified = DateTime.UtcNow;
                actual.UserCreatedEmail = user.Email;
                actual.UserModifiedEmail = user.Email;

                actual.ActualCode = "ACT" + "-" + CreateNewId(id,8).ToUpper();

                var newactual = _appDbContext.Actuals.Add(actual).Entity;
                continue;
            }
            _appDbContext.SaveChanges();

            return Ok();

        }
    }
}

