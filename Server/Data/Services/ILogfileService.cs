using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeleApp.Shared.Models;

namespace TeleApp.Server.Data.Services
{
    public interface ILogfileService
    {
        Task<List<LogfileModel>> GetLogfiles();  
        Task<bool> CreateLogfile(LogfileModel logfile);  
        Task<bool> EditLogfile(int id, LogfileModel logfile);  
        Task<LogfileModel> SingleLogfile(int id);  
        Task<bool> DeleteLogfile(int id);  
        Task<ResultGridLogfile> GetLogfilesPage(int pos, int pagesize, string orderterm, string whereterm);  
        Task<ListColumnSelectModel> GetSelectList();  
    }
}
