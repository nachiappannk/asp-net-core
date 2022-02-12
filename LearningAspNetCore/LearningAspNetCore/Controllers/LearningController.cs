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

        [HttpDelete("delete")]
        public string GetG()
        {
            return Request.Method;
        }

        [HttpPut("put")]
        public string GetDel()
        {
            return Request.Method;
        }

        [HttpPost("post")]
        public string GetPost()
        {
            return Request.Method;
        }

        [HttpGet("get")]
        public string GetGet()
        {
            return Request.Method;
        }

    }
}
