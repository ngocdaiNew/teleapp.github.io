using System;
using System.Collections.Generic;
using System.Text;
using TeleApp.Shared.Resources;
using Telerik.Blazor.Services;

namespace TeleApp.Shared.Services
{
    public class ShareResxLocalizer : ITelerikStringLocalizer
    {
        public string this[string name]
        {
            get
            {
                return GetStringFromResource(name);
            }
        }

        public string GetStringFromResource(string key)
        {
            return TelerikResource.ResourceManager.GetString(key, TelerikResource.Culture);
        }
    }
}
