using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ABMLocalidades.Entities
{
    public class Provincia
    {
       
        public string IdProvincia { get; set;}
        public string NombreProvincia { get; set; }
        
        public string IdPais { get; set; }
    }
}
