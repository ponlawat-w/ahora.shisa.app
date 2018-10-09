using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AhoraShisa.Controllers
{
    [Route("/")]
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet]
        public long GetCurrentTimestamp()
        {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }
    }
}
