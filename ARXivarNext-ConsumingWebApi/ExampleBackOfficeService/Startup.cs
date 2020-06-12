using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using ExampleBackOfficeService.Dal;
using ExampleBackOfficeService.Services;
using ExampleBackOfficeService.Core;
using IdentityServer4.AccessTokenValidation;
using ExampleBackOfficeService.Utilities.SwaggerExtensions;
using ExampleBackOfficeService.Utilities.BaseExtensions;

namespace ExampleBackOfficeService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private IAppSettingsService _appSettingsService;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            //App Settings application 
            _appSettingsService = new AppSettingsService(Configuration);            
            services.AddSingleton<IAppSettingsService>(_appSettingsService);

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
              .AddIdentityServerAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme,
                  jwtOptions =>
                  {
#warning Dovremmo imporre Https
                      jwtOptions.RequireHttpsMetadata = true;
                  }, referenceOptions =>
                  {
                      referenceOptions.Authority = _appSettingsService.ARXivarNextAuthenticationUrl;
                      referenceOptions.IntrospectionEndpoint = referenceOptions.Authority.ConcatUrls("api/auth/introspect");
                      referenceOptions.ClientId = _appSettingsService.ARXivarNextClientId;
                      referenceOptions.ClientSecret = _appSettingsService.ARXivarNextClientSecret;

                      // Todo: cache da abilitare
                      referenceOptions.EnableCaching = true;
                      //referenceOptions.CacheDuration= TimeSpan.FromSeconds(1); // that's the default
                  });


            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //Job service  
            services.AddScoped<IEngineInfoService, EngineInfoService>();

            //Register dapper in scope  
            services.AddScoped<IDapperHelper, DapperHelper>();

            services.AddScoped<IEngineCalculator, EngineCalculator>();

            //singleton -- services.AddSingleton<IArxivarService>(new ArxivarService());
            //services.AddScoped<IArxivarService, ArxivarService>();

         

            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });

            services.AddMvc(option => option.EnableEndpointRouting = false);

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "Ziggy - BackOffice",
                    Description = "Test Engine Service",

                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Able Tech s.r.l.",
                        Email = string.Empty,
                        Url = new Uri("https://www.arxivar.it")
                    },
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                c.DisableAdditionalProperties();
              //  c.AddXmlDocumentation();
                c.AddSecurityConfiguration();
                c.AddEnumDocumentation();
                //c.AddPolymorphism(typeof(BaseApiModel).Assembly); // Aggiungo polimorfismo su web api model
                c.AddApiCounters();
                c.SortSchemas();


            });

            //Memory cache
            services.AddMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IConfiguration configuration)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();

            IAppSettingsService appSettingsService = new AppSettingsService(Configuration);

            app.UseSwaggerUI(c =>
            {
                var swaggerUIPage = _appSettingsService.SwaggerUIPage;
                c.SwaggerEndpoint(swaggerUIPage, "Test Engine Service Api V1");
                c.RoutePrefix = string.Empty;

            });

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCookiePolicy();

            app.UseMvc();
        }



    }
}
