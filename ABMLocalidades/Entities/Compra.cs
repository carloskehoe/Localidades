using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABMLocalidades.Entities
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public int IdUsuario { get; set; }
    }
}
