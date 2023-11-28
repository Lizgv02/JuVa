using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuVa.Models
{
    class CuponModel
    {
        public string Clave { get; set; }
        public string Titulo { get; set; }
        public string Descripción { get; set; }
        public int Nivel { get; set; }
        public float Descuento { get; set; }
    }
}
