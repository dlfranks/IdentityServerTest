using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Authorize(Policy ="PublicSecure")]
        [HttpGet("public")]
        public ActionResult GetPublicData()
        {
            return Ok("This is public data.");
        }

        [Authorize(Policy = "UserSecure")]
        [HttpGet("user")]
        public ActionResult GetUserData()
        {
            return Ok("This is user data.");
        }

        [Authorize(Policy = "AdminSecure")]
        [HttpGet("admin")]
        public ActionResult UpdateAdminData()
        {
            return Ok("Admin has been updated data.");
        }
    }
}
