using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camiones.Entidades
{
    public class Carga
    {
        public int id_Carga { get; set; }
        public double Peso { get; set; }
        public int tipoCarga { get; set; }
       

        public Carga()
        {
            id_Carga = 0;   
            Peso = 0;
            tipoCarga = 0;
           
        }
        public Carga(int id_carga, double peso, int tipocarga)
        {
            id_Carga= id_carga;
            Peso = peso;
            tipoCarga = tipoCarga;
        }
        
        public override string ToString()
        {
            return "Carga: " + id_Carga + " Peso:" + Peso;
        }

       
    }
}
