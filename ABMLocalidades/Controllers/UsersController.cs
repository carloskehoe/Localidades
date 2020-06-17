using ABMLocalidades.Entities;
using ABMLocalidades.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABMLocalidades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {

            _userRepository = userRepository;
        }
        // GET: api/<UsersController>
        [HttpGet("user")]
        public User GetUser(int id)
        {
            return _userRepository.GetUserId(id);
        }

        [HttpPost("user")]
        public User InsertUser([FromBody] User user)
        {
            return _userRepository.InsertUser(user);
        }

        [HttpGet("{id}/user")]
        public User GetUserId(int id)
        {
            return _userRepository.GetUserId(id);
        }

        //// GET api/<UsersController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<UsersController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<UsersController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UsersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

    }
}
