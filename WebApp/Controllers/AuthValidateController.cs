using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Utility;

namespace WebApp.Controllers
{
    [Route("api/AuthValidate")]
    [ApiController]
    public class AuthValidateController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<string>> GetData()
        {
            return "You are authenticted";
        }

        [HttpGet("{id:int}")]
        [Authorize(Roles = SD.Role_Admin)]
        public async Task<ActionResult<string>> GetData(int intValue)
        {
            return "You are authorized with the role of admin";
        }
    }
}
