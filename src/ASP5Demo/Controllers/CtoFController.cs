using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP5Demo.Controllers
{
    [Route("api/[controller]")]
    public class CtoFController : Controller
    {
        // GET: api/CtoF
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "This is a converter from C to F" };
        }

        // GET api/values/5
        [HttpGet("{c}")]
        public string Get(int c)
        {
            return (((9* c)/5)+32).ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
