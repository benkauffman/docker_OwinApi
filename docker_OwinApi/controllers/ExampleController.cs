using System.Net;
using System.Web.Http;
using System.Collections.Generic;
using System.Web.Http.Description;

namespace docker_OwinApi
{
    [RoutePrefix("example")]
    public class ExampleController : ApiController
    {
        // GET api/example 
        [HttpGet]
        [ResponseType(typeof(IEnumerable<int>))]
        public IHttpActionResult GetAll()
        {
            List<int> strList = new List<int>();
            for(int i = 1; i <= 10; i++)
            {
                strList.Add(i);
            }

            return Ok(strList);
        }

        // GET api/values/5 
        [HttpGet]
        [Route("{id:int}")]
        [ResponseType(typeof(int))]
        public IHttpActionResult GetOne(int id)
        {
            if (id >= 1 && id <= 10)
                return Ok(id);

            return NotFound();
        }

        // POST api/values 
        [HttpPost]
        [ResponseType(typeof(int))]
        public IHttpActionResult CreateOne([FromBody]int value)
        {
            if (value >= 1 && value <= 10)
            {
                //these values already exist
                return StatusCode(HttpStatusCode.Conflict);
            }
            else
            {
                return Ok(value);
            }
            
        }

        // PUT api/values/5 
        [HttpPut]
        [Route("{id:int}")]
        [ResponseType(typeof(int))]
        public IHttpActionResult UpdateOne(int id, [FromBody]int value)
        {
            if (id >= 1 && id <= 10)
                return Ok(id);

            return NotFound();
        }

        // DELETE api/values/5 
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            if (id >= 1 && id <= 10)
                return Ok(id);

            return NotFound();
        }
    }
}