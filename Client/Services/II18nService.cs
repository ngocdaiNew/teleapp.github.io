using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeleApp.Client.Services
{
    public interface II18nService
    {
       Task<string> Get(string name);

        void Init(string lg);
    }
}
