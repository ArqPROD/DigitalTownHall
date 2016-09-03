using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DigitalTownHall.Controllers
{
    [RoutePrefix("api/testes")]
    public class TesteController : MainController
    {
        // GET: api/Teste
        /// <summary>
        /// Gets a test value
        /// </summary>
        /// <returns>string values</returns>
        [HttpGet]
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Teste/5
        [HttpGet]
        [Route("{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Teste
        [HttpPost]
        [Route("")]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Teste/5
        [HttpPut]
        [Route("")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Teste/5
        [HttpDelete]
        [Route("{id:int}")]
        public void Delete(int id)
        {
        }
    }
}
