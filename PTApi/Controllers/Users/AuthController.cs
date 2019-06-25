using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using Newtonsoft.Json;
using PTApi.Data;
using PTApi.Helpers;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Services;
using PTApi.ViewModels;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PTApi.Controllers
{
    public class JwtPacket: ActionResult
    {
        public string Token { get; set; }
        public string Comp { get; set; }
        public string FirstName { get; set; }
        public string Avatar { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Role { get; set; }
        public string RoleGroup { get; set; }
        public string Email { get; set; }
        public string Resource { get; set; }
        public string AllowRec { get; set; }
        public string FinanceRepPeriod { get; set; }
        public string FinanceRepYear { get; set; }
        public string ReportingDay { get; set; }
        public string CompanyLogo { get; set; }
        public string CurrencyLongName { get; set; }
        public string CurrencyShortName { get; set; }
        public string CurrencySymbol { get; set; }
        public string FreezeForecast { get; set; }
        public byte? StandardDailyHrs { get; set; }
        public string DoEmployeesWorkWeekends { get; set; }

    }

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _appDbContext;
        private readonly IProjectService _projectService;
        private readonly IUserService _userService;
        private readonly IResourceService _resourceService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly JsonSerializerSettings _serializerSettings;
        private readonly JwtIssuerOptions _jwtOptions;
        //private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly ILogger _logger;
        private readonly IEmailService _emailService;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;


        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,IJwtFactory jwtFactory ,IHttpContextAccessor httpContextAccessor,
                              IOptions<JwtIssuerOptions> jwtOptions, IMapper mapper, ApplicationDbContext appDbContext,IEmailService emailService, IGeneratePublicIdMethod getpublicId, 
                              IGetIdsWithPartIdsMethod getIdsWithPartIds, ISmsSender smsSender, ILoggerFactory loggerFactory, IProjectService projectService, IUserService userService,IResourceService resourceService)
        {
            _userManager = userManager; _signInManager = signInManager;_jwtFactory = jwtFactory; _jwtOptions = jwtOptions.Value;_resourceService = resourceService;
            _userManager = userManager; _httpContextAccessor = httpContextAccessor; _mapper=mapper; _emailService=emailService; _getIdsWithPartIds = getIdsWithPartIds;
            _getpublicId = getpublicId;
            _appDbContext = appDbContext; _smsSender = smsSender;_projectService = projectService;_userService=userService;
            _logger = loggerFactory.CreateLogger<AuthController>();

            _serializerSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
        }

        public string CreateNewId(string param, int length)
        {
            return _getpublicId.PartId(param, 8);
        }

        public JsonResult ValidateEmailAddress(string email)
        {
            bool dBuser = _appDbContext.Users.Any(x => x.UserName == email);

             if (dBuser == true)
             return Json(data: string.Format("an account for address {0} already exists.", email));

          return Json(data: true);
        }


       // POST api/auth/register
        [HttpPost("register")]
        public async Task<IActionResult> Register ([FromBody]RegistrationViewModel model)
        {
            // return validation error if email already exists
            ApplicationUser existingPerson = _appDbContext.Users.Where(e => e.UserName == model.Email).FirstOrDefault();
            //bool dBuser = _appDbContext.Users.Any(x => x.UserName == model.Email);

            if (existingPerson != null)
            {
                 ModelState.AddModelError("email", string.Format("an account for {0} already exists.", model.Email));
                return BadRequest(ModelState);
            }
            // return validation error if required fields aren't filled in
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var Resource =
                new Resource {

                    AppUserRole = "AccountOwner",
                    FirstName = model.Email,
                    AddedBy = model.Email,
                    IsDisabled = false,
                    ResourceEmailAddress = model.Email,
                    UserCreatedEmail = model.Email,
                    UserModifiedEmail = model.Email,
                    DateCreated =  DateTime.UtcNow,
                    DateModified =  DateTime.UtcNow,


                    Company = new Company
                    {
                        CompanyAccountName = model.CompanyName,
                        CompanyContactEmail = model.Email,
                        ReportingCurrency = GetCurrency(56).CompanyCurrencySymbol,
                        UserCreatedEmail = model.Email,
                        UserModifiedEmail = model.Email,
                        DateCreated =  DateTime.UtcNow,
                        DateModified =  DateTime.UtcNow,


                        CompanyCurrencyId= 56,
                        AllowReconciliation=true,
                        FinanceReportingPeriod= "January",
                        FinanceReportingYear= DateTime.Now.Year,
                        RecurringReportingDay= 1,
                        FreezeForecast= false,
                        StandardDailyHours= 8,
                        DoEmployeesWorkWeekends = false,

                        CompanyCurrentShortName = GetCurrency(56).CompanyCurrencyShortName,
                        CompanyCurrentLongName = GetCurrency(56).CompanyCurrencyLongName,
                    },

                     //project = new Project(IProjectService ProjectService);

                    Project = new Project(_projectService, _userService, _resourceService){

                        ProjectName = "My First Project",
                        ProjectManagerUserName = model.Email,
                        ProjectStatus = "Active",

                        UserCreatedEmail = model.Email,
                        UserModifiedEmail = model.Email,
                        DateCreated =  DateTime.UtcNow,
                        DateModified =  DateTime.UtcNow,

                        ProjectManagementRank = new ProjectManagementRank{
                            UserCreatedEmail = model.Email,
                            UserModifiedEmail = model.Email,
                            DateCreated =  DateTime.UtcNow,
                            DateModified =  DateTime.UtcNow,
                        },
                    },

                    Identity = new ApplicationUser
                    {

                        UserName = model.Email,
                        Email = model.Email,
                    },

                };


                var userIdentity = Resource.Identity;

                var result = await _userManager.CreateAsync(userIdentity, model.Password);

                _appDbContext.Add(Resource);

                userIdentity.CompanyId = Resource.CompanyId;

                var projectId = Guid.NewGuid().ToString();

                Resource.CompanyId = Resource.Company.CompanyId;
                Resource.IdentityId = Resource.Identity.Id;
                Resource.Project.ProjectId = projectId;

                Resource.Project.CompanyId = Resource.Company.CompanyId;

                Resource.Project.ProjectRef = "PRJ" + "-" + CreateNewId(Resource.Project.ProjectId, 8).ToUpper();
                Resource.Project.ProjectCode = "PRJ" + "-" + CreateNewId(Resource.Project.ProjectId, 8).ToUpper();
                Resource.Company.CompanyRef = "COM" + "-" + CreateNewId(Resource.Company.CompanyId, 8).ToUpper();

                Resource.Project.RevexCostCode =  "300" + CreateNewId(Resource.Project.ProjectId, 7).ToString().ToUpper();
                Resource.Project.CapexCostCode =  "400"+ CreateNewId(Resource.Project.ProjectId, 7).ToString().ToUpper();
                Resource.Project.OpexCostCode =  "500" + CreateNewId(Resource.Project.ProjectId, 7).ToString().ToUpper();

                Resource.Project.ProjectManagementRank.ProjectId = projectId;
                Resource.Project.ProjectManagementRank.ProjectManagerUserId = userIdentity.Id;

                var resourceId = Guid.NewGuid().ToString();
                Resource.ResourceId = resourceId;
                userIdentity.ResourceId = resourceId;
                Resource.ResourceNumber = "RES" + "-" + CreateNewId(resourceId, 8).ToUpper();

                Resource.UserCreatedId = Resource.Identity.Id;
                Resource.UserCreatedResourceId = resourceId;
                Resource.UserModifiedResourceId = resourceId;
                Resource.UserModifiedId = Resource.Identity.Id;

                Resource.Project.UserCreatedId = Resource.Identity.Id;
                Resource.Project.UserCreatedResourceId = resourceId;
                Resource.Project.UserModifiedId = Resource.Identity.Id;
                Resource.Project.UserModifiedResourceId = resourceId;

                Resource.Company.UserCreatedId = Resource.Identity.Id;
                Resource.Company.UserCreatedResourceId = resourceId;
                Resource.Company.UserModifiedResourceId = resourceId;
                Resource.Company.UserModifiedId = Resource.Identity.Id;

                Resource.Project.ProjectManagementRank.UserCreatedId = Resource.Identity.Id;
                Resource.Project.ProjectManagementRank.UserCreatedResourceId = resourceId;
                Resource.Project.ProjectManagementRank.UserModifiedResourceId = resourceId;
                Resource.Project.ProjectManagementRank.UserModifiedId = Resource.Identity.Id;

                var notification = Notification.ProjectCreated(Resource.Project, Resource.IdentityId, resourceId);
                userIdentity.UserNotifications.Add(new UserNotification(userIdentity, notification));

                await _appDbContext.SaveChangesAsync();

                string ctoken = _userManager.GenerateEmailConfirmationTokenAsync(userIdentity).Result;

                string messageBodyIncludeEmail = WelcomeEmail().Replace("{0}", model.Email);
                string messageBodyIncludeId = messageBodyIncludeEmail.Replace("{1}", userIdentity.Id);
                string messageBody = messageBodyIncludeId.Replace("{2}", ctoken);

                await _emailService.SendEmailAsync(model.Email, "Welcome To The ProjectOffice Community!", messageBody);

                await _signInManager.SignInAsync(userIdentity, isPersistent: false);
                _logger.LogInformation(3, "User created a new account with password.");

                return Ok(CreateRegisterJwtPacket(userIdentity, model));
            }
        }

        public static string ReadFile(string FileName)
        {
            try
            {
                var builder = new BodyBuilder();
                using (StreamReader reader = System.IO.File.OpenText(FileName))
                {
                    // string fileContent = reader.ReadToEnd();
                    builder.HtmlBody = reader.ReadToEnd();
                    if (builder.HtmlBody != null && builder.HtmlBody != "")
                    {
                       // string editedFileContent = fileContent.Replace("\r\n", "<br />");
                       // return fileContent;
                        return builder.HtmlBody;
                    }
                }
            }
            catch (Exception ex)
            {
                //Log
                throw ex;
            }
            return null;
        }




       // [Produces("text/html")]
        // [HttpGet("welcome")]
        public string WelcomeEmail()
        {
            // var pageName = "welcomeemail.html";
            // var pageFolder = "htmlpages";
            // var file = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot", $"{pageFolder}", $"{pageName}");
            // string email = "stevendi23@yahoo.com";

            string emailContent = ReadFile("./wwwroot/htmlpages/welcomeemail.html");
            return emailContent;
        }

        // [Produces("text/html")]
        [HttpGet("welcome")]
        public IActionResult SendWelcomeEmail()
        {
            string email = "stevendi23@yahoo.com";
            string resourceId = "b6140394-1c0f-4846-9be4-a8c9187e67fd";
            string messageBodyIncludeEmail = WelcomeEmail().Replace("{0}", email);
            string messageBody = messageBodyIncludeEmail.Replace("{1}", resourceId);

            _emailService.SendEmailAsync(email, "Welcome To The ProjectOffice Community!", messageBody);
            return Ok();
        }

        [HttpPost("confirmemail/{id}")]
        public IActionResult confirmemail(string id)
        {
            ApplicationUser user = _appDbContext.Users.SingleOrDefault(u => u.ResourceId == id);

            if (user!=null)
            {
                user.HasConfirmEmail = true;
                user.EmailConfirmed = true;
                _appDbContext.SaveChanges();
            }

           return Ok();
        }

        [HttpGet("confirmEmail/{id}/{token}")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string id, string token)
        {
            if (id == null || token == null)
            {
                return BadRequest();
            }
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return BadRequest();
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            return Ok();
        }


        public string GetLoginUrl()
        {
            var url = this.Url.Link("Default", new { Controller = "Auth", Action = "Login" });
            return url;
        }


        // POST api/auth/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]CredentialsViewModel credentials)
        {
            // get the user to verifty
            var user = await _userManager.FindByNameAsync(credentials.UserName);

            if (user == null)
                return NotFound("Username or password is not recognised.");
            // user.EmailConfirmed = true;


            if (!user.EmailConfirmed)
            {
                ModelState.AddModelError("email","Please verify your email address by clicking the verification button in the verification email we sent you.");
                return BadRequest(ModelState);
            }

            var identity = await GetClaimsIdentity(credentials.UserName, credentials.Password);
            var id=identity.Claims.Single(c=>c.Type=="id").Value;
            var comp=identity.Claims.Single(c=>c.Type=="comp").Value;
            var resourceId=identity.Claims.Single(c=>c.Type=="resourceid").Value;

            var userResource = GetResource(resourceId,comp);

            if (userResource.IsDisabled)
            {
                ModelState.AddModelError("email","Sorry, it seems your account may have been disabled, please check with your admin team to resolve this.");
                return BadRequest(ModelState);
            }

            // check the credentials
            await _userManager.CheckPasswordAsync(user, credentials.Password);

           return Ok(CreateJwtPacket(user, credentials));
        }

        private async Task<ApplicationUser> GetCurrentUser()
        {
            return await _userManager.GetUserAsync(HttpContext.User);
        }


        ApplicationUser GetSecureUser()
        {

            //var id = HttpContext.User.Claims.First().Value;
           var id = User.Claims.Single(c=>c.Type=="id").Value;
            return _appDbContext.Users.SingleOrDefault(u => u.Id == id);
        }

        Company GetCompany(string id){

            return _appDbContext.Companies.SingleOrDefault(c => c.CompanyId == id);
        }

        CurrencySymbol GetCurrency(int? id)
        {
           var compcurrency = _appDbContext.CurrencySymbols.SingleOrDefault(c => c.CurrencySymbolId == id);
            return compcurrency ;
        }

        Resource GetResource(string id, string companyid)
        {
           var resourceInDb = _appDbContext.Resources.SingleOrDefault(r => (r.ResourceId == id) && (r.CompanyId == companyid));
            return resourceInDb ;
        }

        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName, string password)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                // get the user to verifty
                var userToVerify = await _userManager.FindByNameAsync(userName);

                // var userResource = GetResource(userToVerify.Id);
                // var userCompany = GetCompany(userToVerify.CompanyId);
                var userResource = GetResource(userToVerify.ResourceId, userToVerify.CompanyId );
                var userCompany = GetCompany(userToVerify.CompanyId);
                var userCompanyCurrency = GetCurrency(userCompany.CompanyCurrencyId);


                if (userToVerify != null)
                {
                    // check the credentials
                    if (await _userManager.CheckPasswordAsync(userToVerify, password))
                    {
                        return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(
                            userName,userToVerify.Id,userToVerify.CompanyId,userResource.AppUserRole,
                            _userService.GetAppResourceRole(userResource.AppUserRole),
                            userResource.FirstName, userResource.ImageUrl??"", userResource.LastName, userToVerify.Email, userResource.ResourceId,
                            userCompany.AllowReconciliation.ToString(),  userCompany.FinanceReportingPeriod,
                            userCompany.CompanyAccountName,
                            userCompany.FinanceReportingYear.ToString(),
                            userCompany.RecurringReportingDay.ToString(),
                            userCompany.LogoUrl??"",
                            userCompany.FreezeForecast.ToString(),  userCompany.StandardDailyHours.ToString(),
                            userCompany.DoEmployeesWorkWeekends.ToString(),  userCompanyCurrency.CompanyCurrencyLongName,
                            userCompanyCurrency.CompanyCurrencyShortName,  userCompanyCurrency.CompanyCurrencySymbol
                        ));
                    }
                }
            }

            // Credentials are invalid, or account doesn't exist
            return await Task.FromResult<ClaimsIdentity>(null);
        }

        public string ConvertImage(byte[] image)
        {
            if (image != null)
            {
                return System.Convert.ToBase64String(image);
            }

            return null;
        }

        public byte[] GetInMemoryPhoto(string imagename)
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


        public async Task<JwtPacket> CreateRegisterJwtPacket(ApplicationUser user, RegistrationViewModel credentials)
        {
            var identity = await GetClaimsIdentity(credentials.Email, credentials.Password);

            var id=identity.Claims.Single(c=>c.Type=="id").Value;
            var comp=identity.Claims.Single(c=>c.Type=="comp").Value;
            var email=identity.Claims.Single(c=>c.Type=="email").Value;
            var resourceId=identity.Claims.Single(c=>c.Type=="resourceid").Value;
            var userResource = GetResource(resourceId,comp);


            var firstname = userResource.FirstName;
            var lastname = userResource.LastName;
            var avatar = userResource.ImageUrl;

            var rol = userResource.AppUserRole;
            var rolGroup =_userService.GetAppResourceRole(userResource.AppUserRole);
            var resourceid = userResource.ResourceId;

            var userCompany = GetCompany(comp);

            var allowrec = userCompany.AllowReconciliation;
            var financerepperiod = userCompany.FinanceReportingPeriod;
            var companyName = userCompany.CompanyAccountName;
            var financerepyear = userCompany.FinanceReportingYear;
            var reportingday = userCompany.RecurringReportingDay;

            var compcurrencysym =userCompany.ReportingCurrency;
            var compcurrencylng =userCompany.CompanyCurrentLongName;
            var compcurrencysht =userCompany.CompanyCurrentShortName;

            var freezefore = userCompany.FreezeForecast;
            var standarddailyhrs = userCompany.StandardDailyHours;
            var doempsworkweekends = userCompany.DoEmployeesWorkWeekends;

            var companylogo = userCompany.LogoUrl;



            var auth_token = await _jwtFactory.GenerateEncodedToken(credentials.Email, identity);

            return new JwtPacket(){

                Token = auth_token, FirstName = firstname,
                LastName = lastname, Avatar = avatar, CompanyName = companyName,
                Comp = comp, Role = rol,RoleGroup = rolGroup,
                Email = email, Resource = resourceid,
                AllowRec = allowrec.ToString(), FinanceRepPeriod = financerepperiod, FinanceRepYear = financerepyear.ToString(),
                ReportingDay = reportingday.ToString(), CompanyLogo = companylogo,
                CurrencyLongName = compcurrencylng, CurrencyShortName = compcurrencysht,
                CurrencySymbol = compcurrencysym, FreezeForecast = freezefore.ToString(),
                StandardDailyHrs = standarddailyhrs, DoEmployeesWorkWeekends = doempsworkweekends.ToString()
            };
        }


        public async Task<JwtPacket> CreateJwtPacket(ApplicationUser user, CredentialsViewModel credentials)
        {
            var identity = await GetClaimsIdentity(credentials.UserName, credentials.Password);

            var id=identity.Claims.Single(c=>c.Type=="id").Value;
            var comp=identity.Claims.Single(c=>c.Type=="comp").Value;
            var email=identity.Claims.Single(c=>c.Type=="email").Value;
            var resourceId=identity.Claims.Single(c=>c.Type=="resourceid").Value;


            var userResource = GetResource(resourceId,comp);
            var firstname = userResource.FirstName;
            var lastname = userResource.LastName;
            var avatar = userResource.ImageUrl;

            var rol = userResource.AppUserRole;
            var rolGroup =_userService.GetAppResourceRole(userResource.AppUserRole);
            var resourceid = userResource.ResourceId;

            var userCompany = GetCompany(comp);

            var allowrec = userCompany.AllowReconciliation;
            var financerepperiod = userCompany.FinanceReportingPeriod;
            var companyName = userCompany.CompanyAccountName;
            var financerepyear = userCompany.FinanceReportingYear;
            var reportingday = userCompany.RecurringReportingDay;

            var compcurrencysym =userCompany.ReportingCurrency;
            var compcurrencylng =userCompany.CompanyCurrentLongName;
            var compcurrencysht =userCompany.CompanyCurrentShortName;

            var freezefore = userCompany.FreezeForecast;
            var standarddailyhrs = userCompany.StandardDailyHours;
            var doempsworkweekends = userCompany.DoEmployeesWorkWeekends;

            var companylogo = userCompany.LogoUrl;



            var auth_token = await _jwtFactory.GenerateEncodedToken(credentials.UserName, identity);

            // await _userManager.GetClaimsAsync(user);

            return new JwtPacket(){

                Token = auth_token, FirstName = firstname,
                LastName = lastname, Avatar = avatar,
                CompanyName = companyName,
                Comp = comp, Role = rol,RoleGroup = rolGroup,
                Email = email, Resource = resourceid,
                AllowRec = allowrec.ToString(), FinanceRepPeriod = financerepperiod, FinanceRepYear = financerepyear.ToString(),
                ReportingDay = reportingday.ToString(), CompanyLogo = companylogo,
                CurrencyLongName = compcurrencylng, CurrencyShortName = compcurrencysht,
                CurrencySymbol = compcurrencysym, FreezeForecast = freezefore.ToString(),
                StandardDailyHrs = standarddailyhrs, DoEmployeesWorkWeekends = doempsworkweekends.ToString()
            };
        }
        private static long ToUnixEpochDate(DateTime date) => (long)Math.Round((date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);
    }


}