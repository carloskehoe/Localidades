using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ABMLocalidades.Entities
{
    public class Ciudad
    {
        
        public int IdLocalidad { get; set; }
        public string nombreLocalidad { get; set; }
        public string IdProvincia { get; set; }
        

    }
}
