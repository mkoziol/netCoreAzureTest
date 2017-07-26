using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netCoreAzure.Controllers
{
    [Route("api/Sleepy")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            System.Threading.Thread.Sleep(5000);
            return new string[] { "Fender", "Gibsoan" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            System.Threading.Thread.Sleep(6000);
            return $"The value you sent was xax123dev5: {id} ";
        }
    }
}
