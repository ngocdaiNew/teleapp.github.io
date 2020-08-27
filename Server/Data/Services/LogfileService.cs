using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TeleApp.Shared.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace TeleApp.Server.Data.Services
{
    public class LogfileService : ILogfileService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public LogfileService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> CreateLogfile(LogfileModel logfile)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.Logfile (CustomerId,Type,Phone,Staff,Status,CreateTime,RecordFile,CustomerName,Project,DurationTime,PhoneReceiver,DeviceId,Group,Company,createdAt) "
                        + "values (@CustomerId,@Type,@Phone,@Staff,@Status,@CreateTime,@RecordFile,@CustomerName,@Project,@DurationTime,@PhoneReceiver,@DeviceId,@Group,@Company,@createdAt)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new
                    {
                        logfile.CustomerId,
                        logfile.Type,
                        logfile.Phone,
                        logfile.Staff,
                        logfile.Status,
                        logfile.CreateTime,
                        logfile.RecordFile,
                        logfile.CustomerName,
                        logfile.Project,
                        logfile.DurationTime,
                        logfile.PhoneReceiver,
                        logfile.DeviceId,
                        logfile.Group,
                        logfile.Company,
                        logfile.createdAt
                    }, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return true;
        }

        public async Task<bool> DeleteLogfile(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.Logfile where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { id }, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return true;
        }

        public async Task<bool> EditLogfile(int id, LogfileModel logfile)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.Logfile set Project = @Project where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { logfile.Project, id }, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return true;
        }

        public async Task<List<LogfileModel>> GetLogfiles()
        {
            IEnumerable<LogfileModel> logfiles;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select top 50 * from dbo.Logfile";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    logfiles = await conn.QueryAsync<LogfileModel>(query);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }

            }
            return logfiles.ToList();
        }

        public async Task<ResultGridLogfile> GetLogfilesPage(int pos, int pagesize, string orderterm, string whereterm)
        {
            ResultGridLogfile resultGrid = new ResultGridLogfile();

            IEnumerable<LogfileModel> logfiles;
            int logfilesTotal = 0;
            var parametersRead = new DynamicParameters();
            parametersRead.Add("@pageSize", pagesize, DbType.Int16, ParameterDirection.Input);
            parametersRead.Add("@page", pos, DbType.Int16, ParameterDirection.Input);
            parametersRead.Add("@orderBy", orderterm, DbType.String, ParameterDirection.Input);
            parametersRead.Add("@where", whereterm, DbType.String, ParameterDirection.Input);
            var parametersReadTotal = new DynamicParameters();
            parametersReadTotal.Add("@where", whereterm, DbType.String, ParameterDirection.Input);

            using (var conn = new SqlConnection(_configuration.Value))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    logfiles = await conn.QueryAsync<LogfileModel>("p_Logfile_ReadData", parametersRead, commandType: CommandType.StoredProcedure);
                    logfilesTotal = await conn.QueryFirstOrDefaultAsync<int>("p_Logfile_ReadData_Total", parametersReadTotal, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            resultGrid.listLogfiles = logfiles.ToList();
            resultGrid.pageSize = logfilesTotal;
            return resultGrid;
        }

        public async Task<ListColumnSelectModel> GetSelectList()
        {
            ListColumnSelectModel logfiles = new ListColumnSelectModel();
            List<string> Project;
            List<int> Type;
            List<string> Staff;
            var sql =
                @"
                SELECT Name FROM Project
                SELECT DISTINCT Type FROM Logfile";

            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    var logfilesNew = await conn.QueryMultipleAsync(sql);
                    Project = logfilesNew.Read<string>().ToList();
                    Type = logfilesNew.Read<int>().ToList(); 
                    
                    if (conn.State == ConnectionState.Open)
                    conn.Close();
                } 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            logfiles.ListProject = Project;
            logfiles.ListType = Type;
            return logfiles;
        }

        public async Task<LogfileModel> SingleLogfile(int id)
        {
            LogfileModel logfile = new LogfileModel();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Logfile where Id =@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    logfile = await conn.QueryFirstOrDefaultAsync<LogfileModel>(query, new { id }, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return logfile;
        }
    }
}
