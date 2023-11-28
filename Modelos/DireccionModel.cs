using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuVa.Models
{
    class DireccionModel
    {
        public int NUMERO { get; set; }
        public string CALLE { get; set; }
        public string COLONIA { get; set; }
        public string CIUDAD { get; set; }
        public string ESTADO { get; set; }
        public int CP { get; set; }
        public string ENTRECALLE { get; set; }
        public string REFERENCIA { get; set; }
        public string INDICACIONES { get; set; }

        public DireccionModel(int NUMERO, string CALLE, string COLONIA, string CIUDAD, string ESTADO, int CP, string ENTRECALLE, string REFERENCIA, string INDICACIONES)
        {
            this.NUMERO = NUMERO;
            this.CALLE = CALLE;
            this.COLONIA = COLONIA;
            this.CIUDAD = CIUDAD;
            this.ESTADO = ESTADO;
            this.CP = CP;
            this.ENTRECALLE = ENTRECALLE;
            this.REFERENCIA = REFERENCIA;
            this.INDICACIONES = INDICACIONES;

        }

        public DireccionModel()
        {
        }
    }

    
}
