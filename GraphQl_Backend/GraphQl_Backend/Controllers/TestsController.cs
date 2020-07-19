using GraphQl_Backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace GraphQl_Backend.Controllers
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

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _repository.GetTest(id);
            return Ok(data);
        }
    }
}