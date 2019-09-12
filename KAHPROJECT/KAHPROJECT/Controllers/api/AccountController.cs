using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Web.Http;
using System.Net;
using Microsoft.EntityFrameworkCore;
using KAHPROJECT.Models;

namespace KAHPROJECT.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
       
  

        [HttpPost]
        public Users UserLogin([FromBody]Users user)
        {
           
            return user;
        }


    }
}