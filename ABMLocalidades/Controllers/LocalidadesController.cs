using System.Collections.Generic;
using ABMLocalidades.Entities;
using ABMLocalidades.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABMLocalidades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadesController : ControllerBase
    {
       private readonly ILocalidadesRepository _localidadesRepository;
        public LocalidadesController(ILocalidadesRepository localidadesRepository)
        {

            _localidadesRepository = localidadesRepository;
        }

        // GET: api/<PaisController>
        [AllowAnonymous]
        [HttpGet("pais")]
        public IEnumerable<Pais> GetPais()
        {            
            return _localidadesRepository.GetPaises();           
        }

        //GET api/<ProvinciaController>/5
        [HttpGet("pais/{id}/provincia")]
        public IEnumerable<Provincia> GetProvincia(int id)
        {
            return _localidadesRepository.GetProvincias(id);

        }

        [HttpGet("provincia/{id}/ciudad")]
        public IEnumerable<Ciudad> GetCiudad(int id)
        {
            return _localidadesRepository.GetCiudades(id);
          
        }

        [HttpPost("ciudad")]
        public Ciudad InsertCiudad([FromBody] Ciudad ciudad)
        {
            return _localidadesRepository.InsertCiudad(ciudad);
        }

        [HttpPut("ciudad")]
        public Ciudad UpdateCiudad([FromBody] Ciudad ciudad)
        {
            return _localidadesRepository.InsertCiudad(ciudad);
        }
    }
}
