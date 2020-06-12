using Microsoft.Extensions.Configuration;

namespace ExampleBackOfficeService.Services
{
    public class AppSettingsService : IAppSettingsService
    {
        private readonly IConfiguration _configuration;

        public AppSettingsService(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public int CacheMin
        {
            get
            {
                return _configuration.GetValue<int>("AppSettings:CacheMin");
            }
        }


        public string ARXivarNextWebApiUrl
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:ARXivarNextWebApiUrl");
            }
        }

        public string ARXivarNextAuthenticationUrl
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:ARXivarNextAuthenticationUrl");
            }
        }
        public string ARXivarNextClientId
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:ARXivarNextClientId");
            }
        }
    

        public string ARXivarNextClientSecret
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:ARXivarNextClientSecret");
            }
        }
        public string SwaggerUIPage
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:SwaggerUIPage");
            }
        }

    }
}
