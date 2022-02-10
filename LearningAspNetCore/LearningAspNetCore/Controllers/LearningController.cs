using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
        [Route("/api/learning-controller/bodystring")]
        public string JsonStringBody([FromBody] string content)
        {
            // Note that the string sent is not a raw string, but rather a JSON string as it includes the wrapping quotes:
            return content;
        }


        [HttpPost]
        [Route("/api/learning-controller/ReadStringDataManual")]
        public async Task<string> ReadStringDataManual()
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }


        }



    }
}
