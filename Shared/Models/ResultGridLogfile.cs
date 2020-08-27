using System;
using System.Collections.Generic;
using System.Text;

namespace TeleApp.Shared.Models
{
    public class ResultGridLogfile
    {
        public List<LogfileModel> listLogfiles { get; set; }
        public int pageSize { get; set; }
    }
}
