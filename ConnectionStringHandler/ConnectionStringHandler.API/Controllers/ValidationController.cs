using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectionStringHandler.Models;
using ConnectionStringHandler.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConnectionStringHandler.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        [Route(Constants.ValidateCredentials)]
        [HttpPost]
        public IActionResult ValidateLoginCredentials(Login loginModel)
        {

            return null;
        }
    }
}