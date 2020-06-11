using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace ExampleBackOfficeService.Dal
{
    public interface IDapperHelper : IDisposable
    {
        DbConnection GetConnection();
        T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text);
        List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text);
        int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text);
        T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text);
        T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text);
    }
}
