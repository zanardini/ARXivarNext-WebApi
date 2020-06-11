using ExampleBackOfficeService.Entities;

namespace ExampleBackOfficeService.Services
{
    public interface IEngineInfoService
    {
        EngineInfo GetDataById(string id);

        EngineCount GetCountById(string id);
    }
}
