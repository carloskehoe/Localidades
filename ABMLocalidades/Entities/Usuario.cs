using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABMLocalidades.Entities
{
    public class Usuario
    {
        
        public string Nombre { get; set; }
        public int Id {get; set;}
        public string IdCiudad {get; set;}

        public string Email { get; set; }

        public string Clave { get; set; }

        public int IdRol { get; set; }

    }
}
