using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl.Service.Model;
using GraphQlService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphQl.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _repository.GetAllUsers();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult AddUser(UserRegistrationInfo userInfo)
        {
            var data = _repository.AddUser(userInfo);
            return Ok(data);
        }

        [HttpGet("{userID}")]
        public IActionResult Get(string userID)
        {
            var data = _repository.GetUser(userID);
            return Ok(data);
        }
    }
}
