using ABMLocalidades.Entities;
using ABMLocalidades.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.ComTypes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABMLocalidades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosRepository _userRepository;
        public UsuariosController(IUsuariosRepository userRepository)
        {

            _userRepository = userRepository;
        }
        // GET: api/<UsersController>
        [HttpGet("user")]
        public Usuario GetUser(int id)
        {
            return _userRepository.GetUserId(id);
        }

        [HttpPost("login")]
        public string GetLogin([FromBody] Login login)
        {
            var usuario = _userRepository.GetUserByMail(login.Email);
            if(usuario==null)
            { 
               
            return "Usuario no encontrado";
            }
            if (usuario.Clave == login.Password)
            {

                if (usuario.Email != login.Email)
                {
                    return "Usuario no encontrado";

                }
                return "Usuario Logeado";
            }
            else 
                return "usuario o password incorrecto";
            


        }

            

        [HttpPost("user")]
        public Usuario InsertUser([FromBody] Usuario user)
        {
            return _userRepository.InsertUser(user);
        }

        [HttpGet("{id}/user")]
        public Usuario GetUserId(int id)
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
