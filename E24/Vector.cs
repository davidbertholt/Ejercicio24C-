using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E24
{
    public class Vector
    {
        public Vector(int orden, string ev, double rel, int cli, int largoC, double rnd, double entre, double prox, Reparador rep1, Reparador rep2, Reparador rep3)
        {
            this.Orden = orden;
            this.Reloj = rel;
            this.Evento = ev;
            this.Cliente = cli;
            this.LargoCola = largoC;
            this.Reparador1 = rep1;
            this.Reparador2 = rep2;
            this.Reparador3 = rep3;
            this.RNDLlegada = rnd;
            this.TiempoEntreLlegada = entre;
            this.TiempoProximaLlegada = prox;

        }

        public int Orden { get; set; }
        public double Reloj { get; set; }
        public string Evento { get; set; }

        public int Cliente { get; set; }

        public int LargoCola { get; set; }
        public Reparador Reparador1 { get; set; }

        public Reparador Reparador2 { get; set; }

        public Reparador Reparador3 { get; set; }
        public double RNDLlegada { get; set; }
        public double TiempoEntreLlegada { get; set; }

        public double TiempoProximaLlegada { get; set; }
    }
}