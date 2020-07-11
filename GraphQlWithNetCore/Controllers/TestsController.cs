using GraphQlWithNetCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace GraphQlWithNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        IRepository _repository;

        public TestsController(IRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var data = _repository.GetAllTests();
            return Ok(data);
        }
    }
}