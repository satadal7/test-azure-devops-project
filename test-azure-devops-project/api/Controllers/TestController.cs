using System;
using common;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        readonly DemoCommon demoCommon = new DemoCommon();

        [HttpGet]
        [Route("")]
        public ActionResult<string> Get()
        {
            return demoCommon.Text;
        }
    }
}
