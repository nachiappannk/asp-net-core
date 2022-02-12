using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningAspNetCore.Controllers
{
    [ApiController]
    [Route("/api/learning-controller")]
    public class LearningController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "hi";
        }


        [HttpPost]
        [Route("users/{email}/photos")]
        public ActionResult Upload([FromRoute] string email)
        {
            string message = $"Hi, {email}";
            return Ok(message);

        }
    }
}
