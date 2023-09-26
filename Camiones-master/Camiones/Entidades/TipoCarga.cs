using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camiones.Entidades
{
    public class TipoCarga
    {
        public Camione Camione { get; set; }

        public Carga Carga { get; set; }

        public string Nombre { get; set; }
        public int Peso { get; internal set; }

        public TipoCarga()
        {
            Camione = new Camione();
            Nombre = string.Empty;
        }
       public TipoCarga(Camione camione, string nombre)
        {
            Camione = camione;
            Nombre = nombre;
        }

        public double CalcularSubtotal()
        {
            return Peso;
        }
    }
}
