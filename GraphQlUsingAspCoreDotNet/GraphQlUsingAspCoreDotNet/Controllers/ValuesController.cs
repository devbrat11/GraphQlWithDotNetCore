using GraphQlUsingAspCoreDotNet.Data;
using Microsoft.AspNetCore.Mvc;

namespace GraphQlUsingAspCoreDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IRepository _repository;

        public ValuesController(IRepository repository)
        {
            _repository = repository;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var data = _repository.GetAllTests();
            return Ok(data);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
