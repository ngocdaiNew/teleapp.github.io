using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeleApp.Client.Services
{
    public interface IBrowserCookieService
    {
        Task<string> Get(Func<string, bool> filterCookie);  
    }
}
