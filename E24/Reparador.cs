using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E24
{
    public class Reparador
    {
        public Reparador(string est, int cli, double tiempoA, double tiempoProximaA, double p, double g)
        {
            Estado = est;
            Cliente = cli;
            TiempoAtencion = tiempoA;
            TiempoProximaAtencion = tiempoProximaA;
            Precio = p;
            Gastos = g;

        }

        public void liberarReparador()
        {
            Estado = Constantes.REPARADOR_LIBRE;
            Cliente = 0;
            TiempoAtencion = 0;
            TiempoProximaAtencion = 0;
            Gastos = 0;
            Precio = 0;
        }

        public void ocuparReparador(int cliente, double tiempoAtencion, double tiempoProximaAtencion, double precio, double gastos)
        {

            Estado = Constantes.REPARADOR_OCUPADO;
            Cliente = cliente;
            TiempoAtencion = Math.Round(tiempoAtencion, 3);
            TiempoProximaAtencion = Math.Round(tiempoProximaAtencion, 3);
            Gastos = Math.Round(gastos, 3);
            Precio = Math.Round(precio, 3);

        }

        public bool isLibre()
        {
            return this.Estado.Equals(Constantes.REPARADOR_LIBRE);
        }

        public string Estado { get; set; }
        public int Cliente { get; set; }
        public double TiempoAtencion { get; set; }
        public double TiempoProximaAtencion { get; set; }
        public double Precio { get; set; }
        public double Gastos { get; set; }

    }
}
