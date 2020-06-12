using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleBackOfficeService.Services
{
    public interface IAppSettingsService
    {
        public int CacheMin { get; }

        public string ARXivarNextWebApiUrl { get; }

        public string ARXivarNextAuthenticationUrl { get; }

        public string ARXivarNextClientId { get; }

        public string ARXivarNextClientSecret { get; }
        
        public string SwaggerUIPage { get; }
    }
}
