using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E24
{
    internal interface IPrint
    {
        void Print(Vector v);
        void MostrarResultados(double precio, double gastos, double preciosPerdidosPorTiempo, int gratis);
    }
}
