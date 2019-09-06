using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KAHPROJECT.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public IActionResult Login()
        {
            if (!ModelState.IsValid)
                throw new Exception();
            return Content("Api works");
        }
    }
}