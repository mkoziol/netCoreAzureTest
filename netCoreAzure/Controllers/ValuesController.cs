using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netCoreAzure.Data;

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
        public List<tableName> Get(int id)
        {
            string name = "";

            List<tableName> list= new List<tableName>();
            using (Context context = new Context())
            {

                list = context.Users.ToList();
            }


            return list;
        }
    }
}
