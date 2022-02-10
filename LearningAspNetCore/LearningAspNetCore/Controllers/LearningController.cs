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


        [HttpGet("GetAllHeaders")]
        public ActionResult<Dictionary<string, string>> GetAllHeaders()
        {
            Dictionary<string, string> requestHeaders =
               new Dictionary<string, string>();
            foreach (var header in Request.Headers)
            {
                requestHeaders.Add(header.Key, header.Value);
            }
            return requestHeaders;
        }


    }
}
