using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeleApp.Client.Services
{
    public class JsInterop: IJsInterop
    {
         private readonly IJSRuntime jsRuntime;

        public JsInterop(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async Task<string> Captcha(string actionName)
        {
            return await jsRuntime.InvokeAsync<string>("runCaptcha", actionName);
        }

        public async Task<string[]> Languages()
        {
            return await jsRuntime.InvokeAsync<string[]>("navigatorLanguages");
        }

        public async Task<string> GetCookie()
        {
            return await jsRuntime.InvokeAsync<string>("getDocumentCookie");
        }
    }
}
