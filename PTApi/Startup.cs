using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using PTApi.Data;
using PTApi.Data.Repositories;
using PTApi.Helpers;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Persistence.Blob;
using PTApi.Repositories;
using PTApi.Services;
using System;
using System.IO;
using System.Net;
using System.Text;


using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.ResponseCaching;

using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Microsoft.Net.Http.Headers;
using PTApi.Extensions;

namespace PTApi
{
    public class Startup
    {
        //public IConfiguration Configuration { get; }
        //public static char[] SecretKey { get; private set; }
        private const string SecretKey = "mygreatsupersecret"; // todo: get this from somewhere secure

        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;

        //    IConfigurationBuilder builder = new ConfigurationBuilder();
        //    builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));

        //    var root = builder.Build();
        //    var SecretKey = root.GetConnectionString("SecretKey");

        //}

        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;

        //}

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }


        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddCors(options => options.AddPolicy("Cors",
            builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));


            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));

            //services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });


            // jwt wire up
            // Get options from app settings
            var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));


            // Configure JwtIssuerOptions
            services.Configure<JwtIssuerOptions>(options =>
            {
                options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
                options.SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
            });

            services.AddScoped<IBlobStorage>(factory =>
            {
                return new BlobStorage(new BlobSetting(
                    storageAccount: Configuration["Blob_StorageAccount"],
                    storageKey: Configuration["Blob_StorageKey"],
                    containerName: Configuration["Blob_ContainerName"]));
            });

            services.AddIdentity<ApplicationUser, IdentityRole>(o =>
            {
                // configure identity options
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 6;
            })

           .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            // api user claim policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin_Group", policy => policy
                .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.AccountOwner,
                Constants.Strings.JwtClaims.Admin,
                Constants.Strings.JwtClaims.SuperAdmin));

                options.AddPolicy("Portfolio_Group", policy => policy
                .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.ProjectManager,
                Constants.Strings.JwtClaims.PortfolioAdmin,
                Constants.Strings.JwtClaims.SeniorProjectManager));

                options.AddPolicy("Finance_Group", policy => policy
                .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.FinanceAdmin,
                Constants.Strings.JwtClaims.FinanceManager));

                options.AddPolicy("AccountOwner", policy => policy
               .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.AccountOwner));

                options.AddPolicy("Super_Admin", policy => policy
                .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.SuperAdmin));

                options.AddPolicy("Admin", policy => policy
                .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.Admin));

                options.AddPolicy("Project_Manager", policy => policy
                .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.ProjectManager));

                options.AddPolicy("Senior_Project_Manager", policy => policy
                .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.SeniorProjectManager));

                options.AddPolicy("Portfolio_Admin", policy => policy
               .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.PortfolioAdmin));

                options.AddPolicy("Finance_Admin", policy => policy
               .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.FinanceAdmin));

                options.AddPolicy("Finance_Manager", policy => policy
               .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.FinanceManager));

                options.AddPolicy("Read_Only", policy => policy
               .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.ReadOnly));

                options.AddPolicy("ReadWrite_TimesheetOnly", policy => policy
                .RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.ReadWriteTimesheetOnly));
            });



            services.AddResponseCaching();

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)],

                ValidateAudience = true,
                ValidAudience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)],

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = _signingKey,

                RequireExpirationTime = false,
                ValidateLifetime = false,
                ClockSkew = TimeSpan.Zero
            };

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(configureOptions =>
            //{
            //    configureOptions.ClaimsIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
            //    configureOptions.TokenValidationParameters = tokenValidationParameters;
            //    configureOptions.SaveToken = true;
            //});


            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Audience = Configuration.GetSection("TokenProviderOptions:Audience").Value;
                options.ClaimsIssuer = Configuration.GetSection("TokenProviderOptions:Issuer").Value;
                options.TokenValidationParameters = tokenValidationParameters;
                options.SaveToken = true;
            });

            //services.AddMvc();
            services.AddMvc().AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Add application services.

            services.AddTransient<UserManager<ApplicationUser>>();
            services.AddSingleton<IJwtFactory, JwtFactory>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddAutoMapper();
            
            // services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // services.AddScoped<IFileStorageService, FileStorageService>();
            services.AddScoped<IBlobStorage, BlobStorage>();

            services.AddScoped<IGeneratePublicIdMethod, GeneratePublicIdMethod>();
            services.AddScoped<IGetIdsWithPartIdsMethod, GetIdsWithPartIdsMethod>();

            services.AddScoped<IProjectForecastService, ProjectForecastService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IForecastService, ForecastService>();
            services.AddScoped<IResourceService, ResourceService>();
            services.AddScoped<IProjectService, ProjectService>();
            

            services.Configure<EmailConfiguration>(Configuration.GetSection("EmailConfiguration"));
            services.AddTransient<IEmailService, EmailService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped< IProjectsPermittedRepository, ProjectsPermittedRepository>();
            services.AddScoped<IActualRepository, ActualRepository>();
            services.AddScoped<IProjectBudgetRepository, ProjectBudgetRepository>();

            services.AddScoped<IForecastTaskRepository, ForecastTaskRepository>();
            services.AddScoped<IProjectBudgetTrackerRepository, ProjectBudgetTrackerRepository>();
            services.AddScoped<IResourceRepository, ResourceRepository>();
            services.AddScoped<IProjectRagStatusRepository, ProjectRagStatusRepository>();
            services.AddScoped<IAssumptionRepository, AssumptionRepository>();
            services.AddScoped<IDependencyRepository, DependencyRepository>();
            services.AddScoped<IIssueRepository, IssueRepository>();
            services.AddScoped<IRiskRepository, RiskRepository>();

            services.AddScoped<IResourceTimesheetRepository, ResourceTimesheetRepository>();
            services.AddScoped<ICompanyMethodologyRepository, CompanyMethodologyRepository>();
            services.AddScoped<ICompanyMethodologyStageRepository, CompanyMethodologyStageRepository>();
            services.AddScoped<ICompanyRateCardRepository, CompanyRateCardRepository>();
            services.AddScoped<ICurrencySymbolRepository, CurrencySymbolRepository>();

            services.AddScoped<IBusinessunitRepository, BusinessunitRepository>();
            services.AddScoped<IDomainRepository, DomainRepository>();
            services.AddScoped<IPlatformRepository, PlatformRepository>();
            services.AddScoped<IPortfolioRepository, PortfolioRepository>();
            services.AddScoped<IProgrammeRepository, ProgrammeRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseResponseCaching();
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseExceptionHandler(
            //builder =>
            //{
            //    builder.Run(
            //        async context =>
            //        {
            //            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            //            context.Response.Headers.Add("Access-Control-Allow-Origin", "*");

            //            var error = context.Features.Get<IExceptionHandlerFeature>();
            //            if (error != null)
            //            {
            //                context.Response.AddApplicationError(error.Error.Message);
            //                await context.Response.WriteAsync(error.Error.Message).ConfigureAwait(false);
            //            }
            //        });
            //});

            //app.Use(async (context, next) =>
            //{
            //    await next();

            //    if (context.Response.StatusCode == 404 && !Path.HasExtension(context.Request.Path.Value))
            //    {
            //        context.Request.Path = "/index.html";
            //        await next();
            //    }
            //});



            app.Use(async (context, next) =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                await next();

                var error = context.Features.Get<IExceptionHandlerFeature>();
                if (error != null)
                {
                    context.Response.AddApplicationError(error.Error.Message);
                    await context.Response.WriteAsync(error.Error.Message).ConfigureAwait(false);
                }

                if (context.Response.StatusCode == 404 && !Path.HasExtension(context.Request.Path.Value))
                {
                    context.Request.Path = "/index.html";
                    await next();
                }
            });



            //app.UseAuthentication();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            app.UseCors("Cors");

            app.UseMvc();
        }
    }
}
