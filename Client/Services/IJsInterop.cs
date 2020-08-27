using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeleApp.Client.Services
{
    public interface IJsInterop
    {
        Task<string> Captcha(string actionName);
        Task<string> GetCookie();
      
        Task<string[]> Languages();
    }
}
