using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeleApp.Server.Data.Services;
using TeleApp.Shared.Models;

namespace TeleApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LogfileController : ControllerBase
    {
        private readonly ILogfileService _logfileService;
        private readonly HttpClient _client;
        public LogfileController(ILogfileService logfileService, HttpClient client)
        {
            _logfileService = logfileService;
            _client = client;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            ResultGridLogfile resultGrid = new ResultGridLogfile();
            var logfiles = await _logfileService.GetLogfiles();
            int logfileSize = logfiles.Count();

            resultGrid.listLogfiles = logfiles.ToList();
            resultGrid.pageSize = logfileSize;
            if (logfileSize > 0)
            {
                return Ok(resultGrid);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _logfileService.SingleLogfile(id));
        }
        [HttpGet("GetLogfileSelect")]
        public async Task<IActionResult> GetLogfileSelect()
        {
            var response = await _client.GetFromJsonAsync<UserNameFromApiModel[]>("http://portalapi.hvnet.vn/api/basedata/getusertelelogs");
            ListColumnSelectModel listColumnSelectModel = new ListColumnSelectModel();
            listColumnSelectModel = await _logfileService.GetSelectList();
            listColumnSelectModel.ListProject = listColumnSelectModel.ListProject.Where(y => !string.IsNullOrEmpty(y)).ToList();
            listColumnSelectModel.ListType = listColumnSelectModel.ListType.Where(y => !string.IsNullOrEmpty(y.ToString()) && y != 0 && y != 4 && y != 5 && y != 6).ToList();
            var dataNew = response.Where(y => y != null).ToList();
            listColumnSelectModel.ListStaff = new List<string>();
            dataNew.ForEach(m => listColumnSelectModel.ListStaff.Add(m.UserName));
            return Ok(listColumnSelectModel);
            //var response = await _client.GetFromJsonAsync<UserNameFromApiModel[]>("http://portalapi.hvnet.vn/api/basedata/getusertelelogs");
            //var dataNew = response.Where(y => y != null).ToList();
            //ListColumnSelectModel listColumnSelectModel = new ListColumnSelectModel();
            //listColumnSelectModel.ListStaff = new List<string>();
            //listColumnSelectModel.ListStaff.Add("Anh Thu");
            //listColumnSelectModel.ListProject = new List<string>();
            //listColumnSelectModel.ListProject.Add("portal.hvnet.vn");
            //listColumnSelectModel.ListType = new List<int>();
            //listColumnSelectModel.ListType.Add(2);
            //dataNew.ForEach(m => listColumnSelectModel.ListStaff.Add(m.UserName));

            //return Ok(listColumnSelectModel);
        }
        //[HttpGet("GetPageSizeFilterSex/{key}")]
        //public IActionResult GetPageSizeFilterSex(string key)
        //{
        //    var members = _unitOfWork.Member.FindBy(s => s.Id != null && s.Id >= 0 && s.Sexs == key).Count();
        //    return Ok(members);
        //}
        [HttpGet("GetPageFilter/{pos}/{termsearch}/{pagesize}/{termduan}/{termcalltype}/{termtaikhoan}/{startdate}/{enddate}")]
        public async Task<IActionResult> GetPageFilter(int pos, string termsearch, int pagesize, string termduan, string termcalltype, string termtaikhoan, string startdate, string enddate)
        {
            string searchterm = termsearch.Split("=")[1];
            string duanterm = termduan.Split("=")[1];
            string calltypeterm = termcalltype.Split("=")[1];
            string taikhoanterm = termtaikhoan.Split("=")[1];
            string startdateterm = startdate.Split("=")[1];
            string enddateterm = enddate.Split("=")[1];
            string orderbyterm = " Id desc ";
            string whereterm = " 1=1 ";

            if (!string.IsNullOrEmpty(searchterm) || (!string.IsNullOrEmpty(duanterm) || !string.IsNullOrEmpty(calltypeterm) || !string.IsNullOrEmpty(taikhoanterm)))
            {
                whereterm += " AND Phone LIKE '%" + searchterm + "%' ";
                whereterm += " AND Project LIKE '%" + duanterm + "%' ";
                whereterm += " AND Type LIKE '%" + calltypeterm + "%' ";
                whereterm += " AND Staff LIKE '%" + taikhoanterm + "%' ";
                whereterm += " AND CreateTime >= " + long.Parse(startdateterm) + " AND CreateTime <= " + long.Parse(enddateterm) + " ";
            }

            ResultGridLogfile resultGrid = new ResultGridLogfile();
            resultGrid = await _logfileService.GetLogfilesPage(pos, pagesize, orderbyterm, whereterm);

            if (resultGrid.pageSize > 0)
            {
                return Ok(resultGrid);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(LogfileModel logfilemodel)
        {
            try
            {
                await _logfileService.CreateLogfile(logfilemodel);

                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, LogfileModel logfilemodel)
        {
            try
            {
                await _logfileService.EditLogfile(id, logfilemodel);

                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _logfileService.DeleteLogfile(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}