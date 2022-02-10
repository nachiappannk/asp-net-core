using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningAspNetCore
{
    public class Author
    {

        [FromHeader]
        public int Id { get; set; }
        [FromHeader]
        public string FirstName { get; set; }
        [FromHeader]
        public string LastName { get; set; }



    }
}
