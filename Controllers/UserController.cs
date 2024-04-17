using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_authorization_and_authorization.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace final_authorization_and_authorization.Controllers
{
    [Authorize(Policy = "AdminOnly")]    
    //[AllowAnonymous]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("/add")]
        public IActionResult Authenticate(AuthenticateModel model)
        {


         
            return Ok(model);
        }

        [HttpGet]
        [Route("/auth")]
        public IActionResult AdminOnly()
        {
            return Ok($"Admin Only Content");
        }
    }
}