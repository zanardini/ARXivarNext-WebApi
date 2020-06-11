using System.Data;
using ExampleBackOfficeService.Dal;
using ExampleBackOfficeService.Entities;
using Dapper;

namespace ExampleBackOfficeService.Services
{
    public class EngineInfoService : IEngineInfoService
    {
        private readonly IDapperHelper _dapperHelper;

        public EngineInfoService(IDapperHelper dapperHelper)
        {
            this._dapperHelper = dapperHelper;
        }

        public EngineInfo GetDataById(string id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("id", id, DbType.String);
            return _dapperHelper.Get<EngineInfo>("Select top 1 FieldC as ValueC from MyTable where ID = @Id", dbPara, CommandType.Text);
        }

        public EngineCount GetCountById(string id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("id", id, DbType.String);
            return _dapperHelper.Get<EngineCount>("Select COUNT (*) as C from MyTable where ID = @Id", dbPara, CommandType.Text);
        }
    }
}