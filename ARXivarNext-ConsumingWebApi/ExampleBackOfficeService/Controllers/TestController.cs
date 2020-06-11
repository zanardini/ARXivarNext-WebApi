using System;
using Microsoft.Extensions.Configuration;
using ExampleBackOfficeService.Models;
using ExampleBackOfficeService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ExampleBackOfficeService.Core;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Linq;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace ExampleBackOfficeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TestController : ControllerBase
    {
        private readonly IEngineInfoService _engineInfoService;
        private IMemoryCache _cache;

        private readonly IConfiguration _configuration;
        private readonly IEngineCalculator _engineCalculator;

        public TestController(IEngineInfoService engineInfoService, IEngineCalculator engineCalculator, IMemoryCache memoryCache, IConfiguration configuration)
        {
            _cache = memoryCache;
            _configuration = configuration;
            _engineInfoService = engineInfoService;
            _engineCalculator = engineCalculator;
        }

        /// <summary>
        /// Calculate simulation
        /// </summary>
        /// <param name="id">Key ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<EngineResult> Get(string id)
        {
            try
            {
                var arxivarRestConfiguration = new IO.Swagger.Client.Configuration()
                {
                    BasePath = _configuration.GetValue<string>("AppSettings:ARXivarNextWebApiUrl"),
                    ApiKey = new Dictionary<string, string>() { { "Authorization", Request.Headers["Authorization"] } },
                    ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "" } }
                };

                var usersApi = new IO.Swagger.Api.UsersApi(arxivarRestConfiguration);
                
                var userInfo = usersApi.UsersGetUserInfo();
                var userInfo_CompleteDescription = userInfo.CompleteDescription;
                var userInfo_CompleteName = userInfo.CompleteName;
                var userInfo_UserId = userInfo.User;

                ClaimsIdentity claims = (this.User.Identity as ClaimsIdentity);
                string userIdString = claims.FindFirst("arx:user_id").Value;
                int userIdNumber = System.Convert.ToInt32(userIdString);
                IO.Swagger.Model.UserInfoDTO userInfoDTO = usersApi.UsersGet(userIdNumber);

                EngineResult model;
                if (_cache.TryGetValue(id, out model))
                    return model;

                var engineCount = _engineInfoService.GetCountById(id);
                if (engineCount == null)
                    return StatusCode(404);
                if (engineCount.C < 1)
                    return StatusCode(404, string.Format("Id '{0}' not found.", id));
                if (engineCount.C > 1)
                    return StatusCode(403, string.Format("Id '{0}' found too many times {1}", id, engineCount.C));


                var engineInfo = _engineInfoService.GetDataById(id);
                if (engineInfo == null)
                    return StatusCode(404);

                model = _engineCalculator.Calculate(id, engineInfo);

                var cacheMin = _configuration.GetValue<int>("AppSettings:CacheMin");
                _cache.Set(id, model, new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(cacheMin)));

                return model;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}