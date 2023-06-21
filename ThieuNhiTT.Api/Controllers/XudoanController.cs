using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThieuNhiTT.Api.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThieuNhiTT.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class XudoanController : ControllerBase
    {
        // GET: /<controller>/
        [HttpGet(Name = "GetXuDoan")]
        public IEnumerable<XuDoan> Get()
        {
            var xd = new XuDoan();
            xd.TenXuDoan = "Ane Le Thi Thanh";
            xd.GiaoXu = "Nhan Hoa";
            var ls = new List<XuDoan>();
            ls.Add(xd);
            return ls;
        }
    }
}

