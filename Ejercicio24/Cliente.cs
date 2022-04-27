using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    internal class Cliente
    {
        // public double tiempoInicioEstado;
        public int orden;
        public string estado;

        public Cliente(int o, string est)
        {
            orden = o;
            estado = est;

        }
        public string Estado
        {
            get { return estado; }
        }
        public int Orden
        {
            get { return orden; }
        }
    }
}
