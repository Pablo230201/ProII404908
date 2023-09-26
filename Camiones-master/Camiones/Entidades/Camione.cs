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
        public int pesoMaximo { get; set; }
        public List<TipoCarga> listaCargas { get; set; }
        public int Peso { get; private set; }

        public Camione() 
        {
            idCamion = 0;
            Patente = string.Empty;
            estadoCamion = 0;
            pesoMaximo = 0;
            listaCargas = new List<TipoCarga>();
        }
        public Camione(int idCamion, int peso)
        {
            this.idCamion = idCamion;
            //this.Patente = patente;
            this.estadoCamion = estadoCamion;
            this.pesoMaximo = peso;
            this.listaCargas = listaCargas;
        }
        public int CalcularTotalCargas()
        {
            return  pesoMaximo;
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

        public object PesoRestante()
        {
            return CalcularTotalCargas();
        }

        public void AgregarCarga(Carga nCarga)
        {
            int cargaActual = CalcularTotalCargas();
            int cargaNueva = cargaActual + (int)Peso;
        }
        public override string ToString()
        {
            return "Camion: " + Patente;
        }
    }
}

        