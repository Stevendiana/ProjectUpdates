using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using Newtonsoft.Json;
using PTApi.Data.Repositories;
using PTApi.Helpers;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Services;
using PTApi.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        //private readonly ApplicationDbContext _appDbContext;
        private readonly IUnitOfWork _unitOfWork;
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
                              IOptions<JwtIssuerOptions> jwtOptions, IMapper mapper, IUnitOfWork unitOfWork, IEmailService emailService, IGeneratePublicIdMethod getpublicId, 
                              IGetIdsWithPartIdsMethod getIdsWithPartIds, ISmsSender smsSender, ILoggerFactory loggerFactory, IProjectService projectService, IUserService userService,IResourceService resourceService)
        {
            _userManager = userManager; _signInManager = signInManager;_jwtFactory = jwtFactory; _jwtOptions = jwtOptions.Value;_resourceService = resourceService;
            _userManager = userManager; _httpContextAccessor = httpContextAccessor; _mapper=mapper; _emailService=emailService; _getIdsWithPartIds = getIdsWithPartIds;
            _getpublicId = getpublicId;
            _unitOfWork = unitOfWork; _smsSender = smsSender;_projectService = projectService;_userService=userService;
            _logger = loggerFactory.CreateLogger<AuthController>();

            _serializerSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
        }

        public string CreateNewId(string param, int lenght)
        {
            return _getpublicId.PartId(param, lenght);
        }

        public JsonResult ValidateEmailAddress(string email)
        {
            bool dBuser = _unitOfWork.Users.CheckUserExist(email);

             if (dBuser == true)
             return Json(data: string.Format("an account for address {0} already exists.", email));

          return Json(data: true);
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


        public class AddNewuser
        {
            [Required]
            public string ResourceId { get; set; }
            [Required]
            public string Role { get; set; }
            [Required]
            public string CompanyId { get; set; }
            [DataType(DataType.Password)]
            public string Password { get; set; }

        }

        // [Produces("text/html")]
        [HttpGet("welcome")]
        public string WelcomeEmail()
        {
            // var pageName = "welcomeemail.html";
            // var pageFolder = "htmlpages";
            // var file = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot", $"{pageFolder}", $"{pageName}");
            // string email = "stevendi23@yahoo.com";

            string emailContent = ReadFile("./wwwroot/htmlpages/welcomeemail.html");
            return emailContent;
        }

        // POST api/auth/register
        [HttpPost("register")]
        public async Task<IActionResult> Register ([FromBody]RegistrationViewModel model)
        {
            // return validation error if email already exists
            bool dBuser = _unitOfWork.Users.CheckUserExist(model.Email);

            if (dBuser)
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
                var Project = new Project(_projectService, _userService, _resourceService)
                {

                    ProjectName = "My First Project",
                    ProjectManagerUserName = model.Email,
                    ProjectStatus = "Active",

                    UserCreatedEmail = model.Email,
                    UserModifiedEmail = model.Email,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,

                    ProjectManagementRank = new ProjectManagementRank
                    {
                        UserCreatedEmail = model.Email,
                        UserModifiedEmail = model.Email,
                        DateCreated = DateTime.UtcNow,
                        DateModified = DateTime.UtcNow,
                    },

                    Company = new Company
                    {
                        CompanyAccountName = model.CompanyName,
                        CompanyContactEmail = model.Email,
                        ReportingCurrency = _unitOfWork.CurrencySymbols.GetOneCurrency(56).CompanyCurrencySymbol,
                        UserCreatedEmail = model.Email,
                        UserModifiedEmail = model.Email,
                        DateCreated = DateTime.UtcNow,
                        DateModified = DateTime.UtcNow,


                        CompanyCurrencyId = 56,
                        AllowReconciliation = true,
                        FinanceReportingPeriod = "January",
                        FinanceReportingYear = DateTime.Now.Year,
                        RecurringReportingDay = 1,
                        FreezeForecast = false,
                        StandardDailyHours = 8,
                        DoEmployeesWorkWeekends = false,
                        IrrecoverableVATPercentage = 0,
                        UseRateCard = true,

                        CompanyCurrentShortName = _unitOfWork.CurrencySymbols.GetOneCurrency(56).CompanyCurrencyShortName,
                        CompanyCurrentLongName = _unitOfWork.CurrencySymbols.GetOneCurrency(56).CompanyCurrencyLongName,
                    },

                    Sponsor = new Resource
                    {
                        FirstName = model.Email,
                        IsDisabled = false,
                        ResourceEmailAddress = model.Email,
                        UserCreatedEmail = model.Email,
                        UserModifiedEmail = model.Email,
                        DateCreated = DateTime.UtcNow,
                        DateModified = DateTime.UtcNow,

                        Identity = new ApplicationUser
                        {

                            UserName = model.Email,
                            Email = model.Email,
                            AppUserRole = "AccountOwner",

                            DateCreated = DateTime.Now.ToUniversalTime(),
                            DateModified = DateTime.Now.ToUniversalTime(),

                        },
                    },

                    Domain = new Domain
                    {
                        DomainName = "Autonomous - (stand-alone)",
                        DateCreated = DateTime.Now.ToUniversalTime(),
                        DateModified = DateTime.Now.ToUniversalTime(),
                    },

                    BusinessUnit = new BusinessUnit
                    {
                        BusinessunitName = "Autonomous - (stand-alone)",
                        DateCreated = DateTime.Now.ToUniversalTime(),
                        DateModified = DateTime.Now.ToUniversalTime(),
                    },

                    Portfolio = new Portfolio
                    {
                        PortfolioName = "Autonomous - (stand-alone)",
                        DateCreated = DateTime.Now.ToUniversalTime(),
                        DateModified = DateTime.Now.ToUniversalTime(),
                    },

                    Programme = new Programme
                    {
                        ProgrammeName = "Autonomous - (stand-alone)",
                        DateCreated = DateTime.Now.ToUniversalTime(),
                        DateModified = DateTime.Now.ToUniversalTime(),
                    },

                };


                var userIdentity = Project.Sponsor.Identity;
                var resource = Project.Sponsor;
                var company = Project.Company;
                var domain = Project.Domain;
                var businessunit = Project.BusinessUnit;
                var portfolio = Project.Portfolio;
                var programme = Project.Programme;
                var projectManagementRank = Project.ProjectManagementRank;

                var result = await _userManager.CreateAsync(userIdentity, model.Password);

                _unitOfWork.Projects.Add(Project);

                userIdentity.CompanyId = company.CompanyId;

                userIdentity.UserCreatedId = userIdentity.Id;
                userIdentity.UserCreatedResourceId = resource.ResourceId;
                userIdentity.UserCreatedEmail = userIdentity.Email;
                userIdentity.UserCreatedFirstName = resource.FirstName;
                userIdentity.UserCreatedLastName = resource.LastName;
                userIdentity.UserCreatedAvatar = resource.ImageUrl;

                userIdentity.UserModifiedId = userIdentity.Id;
                userIdentity.UserModifiedEmail = resource.ResourceId;
                userIdentity.UserModifiedResourceId = userIdentity.Email;
                userIdentity.UserModifiedFirstName = resource.FirstName;
                userIdentity.UserModifiedLastName = resource.LastName;
                userIdentity.UserModifiedAvartar = resource.ImageUrl;

                var domainId = Guid.NewGuid().ToString();
                domain.Id = domainId;
                domain.DomainCode = "DOM" + "-" + CreateNewId(domainId, 8).ToUpper();
                domain.CompanyId = company.CompanyId;
                
                var businessunitId = Guid.NewGuid().ToString();
                businessunit.Id = businessunitId;
                businessunit.DomainId = domainId;
                businessunit.BusinessunitCode = "BUU" + "-" + CreateNewId(businessunitId, 8).ToUpper();
                businessunit.CompanyId = company.CompanyId;

                var portfolioId = Guid.NewGuid().ToString();
                portfolio.Id = portfolioId;
                portfolio.BusinessunitId = businessunitId;
                portfolio.DomainId = domainId;
                portfolio.PortfolioCode = "PORT" + "-" + CreateNewId(domainId, 8).ToUpper();
                portfolio.CompanyId = company.CompanyId;

                var programmeId = Guid.NewGuid().ToString();
                programme.Id = programmeId;
                programme.PortfolioId = portfolioId;
                programme.BusinessunitId = businessunitId;
                programme.DomainId = domainId;
                programme.ProgrammeCode = "PROG" + "-" + CreateNewId(domainId, 8).ToUpper();
                programme.CompanyId = company.CompanyId;

                var projectId = Guid.NewGuid().ToString();

                resource.CompanyId = company.CompanyId;
                resource.IdentityId = resource.Identity.Id;
                Project.ProjectId = projectId;

                Project.CompanyId = company.CompanyId;

                Project.ProjectRef = "PRJ" + "-" + CreateNewId(projectId, 8).ToUpper();
                Project.ProjectCode = "PRJ" + "-" + CreateNewId(projectId, 8).ToUpper();
                company.CompanyRef = "COM" + "-" + CreateNewId(company.CompanyId, 8).ToUpper();

                Project.RevexCostCode =  "300" + CreateNewId(projectId, 7).ToString().ToUpper();
                Project.CapexCostCode =  "400"+ CreateNewId(projectId, 7).ToString().ToUpper();
                Project.OpexCostCode =  "500" + CreateNewId(projectId, 7).ToString().ToUpper();

                Project.ProjectManagementRank.ProjectId = projectId;
                Project.ProjectManagementRank.ProjectManagerUserId = userIdentity.Id;

                var resourceId = Guid.NewGuid().ToString();
                resource.ResourceId = resourceId;
                userIdentity.ResourceId = resourceId;
                resource.ResourceNumber = "RES" + "-" + CreateNewId(resourceId, 8).ToUpper();

                resource.UserCreatedId = resource.Identity.Id;
                resource.UserCreatedResourceId = resourceId;
                resource.UserModifiedResourceId = resourceId;
                resource.UserModifiedId = resource.Identity.Id;

                Project.UserCreatedId = resource.Identity.Id;
                Project.UserCreatedResourceId = resourceId;
                Project.UserModifiedId = resource.Identity.Id;
                Project.UserModifiedResourceId = resourceId;

                company.UserCreatedId = resource.Identity.Id;
                company.UserCreatedResourceId = resourceId;
                company.UserModifiedResourceId = resourceId;
                company.UserModifiedId = resource.Identity.Id;

                projectManagementRank.UserCreatedId = resource.Identity.Id;
                projectManagementRank.UserCreatedResourceId = resourceId;
                projectManagementRank.UserModifiedResourceId = resourceId;
                projectManagementRank.UserModifiedId = resource.Identity.Id;

                domain.UserCreatedId = resource.Identity.Id;
                domain.UserCreatedResourceId = resourceId;
                domain.UserModifiedResourceId = resourceId;
                domain.UserModifiedId = resource.Identity.Id;

                businessunit.UserCreatedId = resource.Identity.Id;
                businessunit.UserCreatedResourceId = resourceId;
                businessunit.UserModifiedResourceId = resourceId;
                businessunit.UserModifiedId = resource.Identity.Id;

                portfolio.UserCreatedId = resource.Identity.Id;
                portfolio.UserCreatedResourceId = resourceId;
                portfolio.UserModifiedResourceId = resourceId;
                portfolio.UserModifiedId = resource.Identity.Id;

                programme.UserCreatedId = resource.Identity.Id;
                programme.UserCreatedResourceId = resourceId;
                programme.UserModifiedResourceId = resourceId;
                programme.UserModifiedId = resource.Identity.Id;

                var notification = Notification.ProjectCreated(Project, resource.IdentityId, resourceId);
                userIdentity.UserNotifications.Add(new UserNotification(userIdentity, notification));

                await _unitOfWork.CompleteAsync();

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

        [HttpPost("createuser/{companyId}")]
        [Authorize(Policy = "Admin_Group")]
        public async Task<IActionResult> CreateUsers(string companyId, [FromBody]IEnumerable<AddNewuser> uList)
        {
            var comp = _userService.GetSecureUserCompany();
            var currentuser = _userService.GetSecureUserId();
            var currentuseremail = _userService.GetSecureUserEmail();
            var currentresourceId = _userService.GetSecureResource();

            var currentresource = _unitOfWork.Resources.GetOneResouce(currentresourceId, comp);


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (companyId == comp)
                {
                    foreach (var model in uList)
                    {
                        var res = _unitOfWork.Resources.GetOneResouce(model.ResourceId, comp);
                        var resemail = res.ResourceEmailAddress;

                        bool dBuser = _unitOfWork.Users.CheckUserExist(resemail);

                        if (dBuser)
                        {
                            ModelState.AddModelError("email", string.Format("an account for {0} already exists.", resemail));
                            return BadRequest(ModelState);
                        }
                        else
                        {
                            var Identity = new ApplicationUser
                            {

                                UserName = resemail,
                                Email = resemail,
                                CompanyId = comp,
                                ResourceId = model.ResourceId,


                                AppUserRole = model.Role,
                                DateCreated = DateTime.Now.ToUniversalTime(),
                                UserCreatedId = currentuser,
                                UserCreatedResourceId = currentresourceId,
                                UserCreatedEmail = currentuseremail,
                                UserCreatedFirstName = currentresource.FirstName,
                                UserCreatedLastName = currentresource.LastName,
                                UserCreatedAvatar = currentresource.ImageUrl,

                                DateModified = DateTime.Now.ToUniversalTime(),
                                UserModifiedId = currentuser,
                                UserModifiedEmail = currentuseremail,
                                UserModifiedResourceId = currentresourceId,
                                UserModifiedFirstName = currentresource.FirstName,
                                UserModifiedLastName = currentresource.LastName,
                                UserModifiedAvartar = currentresource.ImageUrl,
                            };

                            var newuser = Identity;

                            await _userManager.CreateAsync(newuser, model.Password);

                            //_unitOfWork.Resources.Add(Resource);

                            newuser.Resource.IdentityId = newuser.Id;


                            await _unitOfWork.CompleteAsync();

                            string ctoken = _userManager.GenerateEmailConfirmationTokenAsync(newuser).Result;

                            string messageBodyIncludeEmail = WelcomeEmail().Replace("{0}", resemail);
                            string messageBodyIncludeId = messageBodyIncludeEmail.Replace("{1}", newuser.Id);
                            string messageBody = messageBodyIncludeId.Replace("{2}", ctoken);

                            await _emailService.SendEmailAsync(resemail, "Welcome To The ProjectOffice Community!", messageBody);

                            await _signInManager.SignInAsync(newuser, isPersistent: false);
                            _logger.LogInformation(3, "User created a new account with password.");
                        }

                        continue;

                    };
                }

                return BadRequest("You dont have the right permission to perform this action.");
            }
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
        // POST api/auth/login
        [HttpPost("login")]
        [AllowAnonymous]
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

            var userResource = _unitOfWork.Resources.GetOneResouce(resourceId,comp);

            if (userResource.IsDisabled)
            {
                ModelState.AddModelError("email","Sorry, it seems your account may have been disabled, please check with your admin team to resolve this.");
                return BadRequest(ModelState);
            }

            // check the credentials
            await _userManager.CheckPasswordAsync(user, credentials.Password);

           return Ok(CreateJwtPacket(user, credentials));
        }

        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName, string password)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                // get the user to verifty
                var userToVerify = await _userManager.FindByNameAsync(userName);

                // var userResource = GetResource(userToVerify.Id);
                // var userCompany = GetCompany(userToVerify.CompanyId);
                var userResource = _unitOfWork.Resources.GetOneResouce(userToVerify.ResourceId, userToVerify.CompanyId );
                var userCompany = _unitOfWork.Companies.Getcompany(userToVerify.CompanyId);
                var userCompanyCurrency = _unitOfWork.CurrencySymbols.GetOneCurrency(userCompany.CompanyCurrencyId);
                var thisuser = _unitOfWork.Users.GetOneUser(userToVerify.Id, userToVerify.CompanyId);


                if (userToVerify != null)
                {
                    // check the credentials
                    if (await _userManager.CheckPasswordAsync(userToVerify, password))
                    {
                        return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(
                            userName,userToVerify.Id,userToVerify.CompanyId, thisuser.AppUserRole,
                            _userService.GetAppResourceRole(thisuser.AppUserRole),
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

        public async Task<JwtPacket> CreateRegisterJwtPacket(ApplicationUser user, RegistrationViewModel credentials)
        {
            var identity = await GetClaimsIdentity(credentials.Email, credentials.Password);

            var id=identity.Claims.Single(c=>c.Type=="id").Value;
            var comp=identity.Claims.Single(c=>c.Type=="comp").Value;
            var email=identity.Claims.Single(c=>c.Type=="email").Value;
            var resourceId=identity.Claims.Single(c=>c.Type=="resourceid").Value;
            var userResource = _unitOfWork.Resources.GetOneResouce(resourceId, comp);
            var thisuser = _unitOfWork.Users.GetOneUser(id, comp);


            var firstname = userResource.FirstName;
            var lastname = userResource.LastName;
            var avatar = userResource.ImageUrl;

            var rol = thisuser.AppUserRole;
            var rolGroup =_userService.GetAppResourceRole(thisuser.AppUserRole);
            var resourceid = userResource.ResourceId;

            var userCompany = _unitOfWork.Companies.Getcompany(comp);

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


            var userResource = _unitOfWork.Resources.GetOneResouce(resourceId,comp);
            var thisuser = _unitOfWork.Users.GetOneUser(id,comp);
            var firstname = userResource.FirstName;
            var lastname = userResource.LastName;
            var avatar = userResource.ImageUrl;

            var rol = thisuser.AppUserRole;
            var rolGroup =_userService.GetAppResourceRole(thisuser.AppUserRole);
            var resourceid = userResource.ResourceId;

            var userCompany = _unitOfWork.Companies.Getcompany(comp);

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

        // [Produces("text/html")]
        //[HttpGet("welcome")]
        //public IActionResult SendWelcomeEmail()
        //{
        //    string email = "stevendi23@yahoo.com";
        //    string resourceId = "b6140394-1c0f-4846-9be4-a8c9187e67fd";
        //    string messageBodyIncludeEmail = WelcomeEmail().Replace("{0}", email);
        //    string messageBody = messageBodyIncludeEmail.Replace("{1}", resourceId);

        //    _emailService.SendEmailAsync(email, "Welcome To The ProjectOffice Community!", messageBody);
        //    return Ok();
        //}

        //[HttpPost("confirmemail/{id}")]
        //public IActionResult confirmemail(string id)
        //{
        //    ApplicationUser user = _appDbContext.Users.SingleOrDefault(u => u.ResourceId == id);

        //    if (user!=null)
        //    {
        //        user.HasConfirmEmail = true;
        //        user.EmailConfirmed = true;
        //        _appDbContext.SaveChanges();
        //    }

        //   return Ok();
        //}


        //private async Task<ApplicationUser> GetCurrentUser()
        //{
        //    return await _userManager.GetUserAsync(HttpContext.User);
        //}
        //public string ConvertImage(byte[] image)
        //{
        //    if (image != null)
        //    {
        //        return System.Convert.ToBase64String(image);
        //    }

        //    return null;
        //}

        //public byte[] GetInMemoryPhoto(string imagename)
        //{
        //    if (imagename != null)
        //    {
        //        var reportsFolder = "Images";
        //        var photopath = $"wwwroot/{reportsFolder}/{imagename}";

        //        byte[] bytes = System.IO.File.ReadAllBytes(photopath);

        //        if (photopath != null)
        //        {
        //            return bytes;
        //            // return File(bytes, "image/jpeg");

        //        }
        //        return null;

        //    }
        //    return null;
        //}

        //public string GetLoginUrl()
        //{
        //    var url = this.Url.Link("Default", new { Controller = "Auth", Action = "Login" });
        //    return url;
        //}






    }


}