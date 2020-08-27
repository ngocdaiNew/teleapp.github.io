using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace TeleApp.Server  
{  
    // This class is used for naming the Resource files.   
    // You must specify exact name of Resource here.   
    public class BlazorResource { }  
}  
namespace TeleApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class I18nController : ControllerBase
    {
        private IStringLocalizer<BlazorResource> stringLocalizer;  
  
        public I18nController(IStringLocalizer<BlazorResource> stringLocalizer)  
        {  
            this.stringLocalizer = stringLocalizer;  
        }  
  
        [HttpGet]  
        public ActionResult GetClientTranslations()  
        {  
            var res = new Dictionary<string, string>();  
            return Ok(stringLocalizer.GetAllStrings().ToDictionary(s => s.Name, s => s.Value));  
        }  
    }
}