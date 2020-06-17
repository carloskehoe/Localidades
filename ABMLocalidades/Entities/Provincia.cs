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
       
        public string Id { get; set;}
        public string Nombre { get; set; }
        
        public string IdPais { get; set; }
    }
}
