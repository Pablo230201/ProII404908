using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Camiones.Entidades;

namespace Camiones.Entidades
{
    public class Camione 
    {
        public Carga c = new Carga();
        public int idCamion { get; set; }
        public string Patente { get; set; }
        public int estadoCamion { get; set; }
        public double pesoMaximo { get; set; }
        public List<TipoCarga> listaCargas { get; set; }

        public Camione() 
        {
            idCamion = 0;
            Patente = string.Empty;
            estadoCamion = 0;
            pesoMaximo = 0;
            listaCargas = new List<TipoCarga>();
        }
        public Camione(int idCamion, string Patente, int estadoCamion, double pesoMaximo)
        {
            this.idCamion = idCamion;
            this.Patente = Patente;
            this.estadoCamion = estadoCamion;
            this.pesoMaximo = pesoMaximo;
            this.listaCargas = listaCargas;
        }
        public double CalcularTotal()
        {
            {
                double total = 0;
                for (int i = 0; i < listaCargas.Count; i++)
                {
                    total += listaCargas[i].CalcularSubtotal();
                }
                return total;
            }

        }

        public double PesoRestante()
        {
            return pesoMaximo - c.Peso;
        }

        public void AgregarCarga(Carga nCarga)
        {
            double cargaActual = PesoRestante();
            double cargaNueva = cargaActual + c.Peso;
        }
        public override string ToString()
        {
            return "Camion: " + Patente;
        }
    }
}

        