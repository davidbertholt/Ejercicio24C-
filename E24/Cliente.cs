using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E24
{
    internal class Cliente
    {
        public Cliente(int orden, double tiempoLlegada)
        {
            Orden = orden;
            Index = orden - 1;
            TimepoLlegadaAlSistema = tiempoLlegada;

        }

        public int Orden { get; set; }
        public int Index { get; set; }
        public double TimepoLlegadaAlSistema { get; set; }
    }
}
