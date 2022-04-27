using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    internal class Reparador
    {
    private string estado;
    private int cliente;
    private double tiempoAtencion;
    private double tiempoProximaAtencion;
    private double precio;
    private double gastos;
    
        public Reparador (string est, int cli, double tiempoA, double tiempoProximaA, double p, double g
)
        {
            estado = est;
            cliente = cli;
            tiempoAtencion = tiempoA;
            tiempoProximaAtencion = tiempoProximaA;
            precio = p;
            gastos = g;

        }

        public string Estado
            {
                get { return estado; }
            }
        public int Cliente
            {
                get { return cliente;  }
            }
        public double TiempoAtencion
            {
                get { return tiempoAtencion; }
            }
        public double TiempoProximaAtencion
            {
                get { return tiempoProximaAtencion; }
            }
        public double Precio
            {
                get { return precio; }
            }
        public double Gastos
        {
            get { return gastos; }
        }


    }
}
