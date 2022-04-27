using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    internal class Vector
    {
        private string evento;
        private double reloj;
        private Cliente cliente;
        private Cliente[] colaClientes;
        private int largoCola;
        public double tiempoEntreLlegada;
        public double tiempoProximaLlegada;
        private Reparador reparador1;
        private Reparador reparador2;
        private Reparador reparador3;


        public Vector (string ev, double rel, Cliente cli, Cliente[] colaCli, int largoC, double entre, double prox, Reparador rep1, Reparador rep2, Reparador rep3)
        {
            reloj = rel;
            evento = ev;
            cliente = cli;
            colaClientes = colaCli;
            largoCola = largoC;
            reparador1 = rep1;
            reparador2 = rep2;
            reparador3 = rep3;
            tiempoEntreLlegada = entre;
            tiempoProximaLlegada = prox;
        
        }

        public double Reloj
        {
            get { return reloj;}
        }
        public string Evento
        {
            get { return evento;}
        }
        public Cliente Cliente
        {
            get { return cliente;}
        }
        public Cliente[] ColaClientes
        {
            get { return colaClientes;}
        }
        public int LargoCola
        {
            get { return largoCola;}
        }
        public Reparador Reparador1
        {
            get { return reparador1; }
        }
        public Reparador Reparador2
        {
            get { return reparador2; }
        }
        public Reparador Reparador3
        {
            get { return reparador3; }
        }
        public double TiempoEntreLlegada
        {
            get { return tiempoEntreLlegada; }
        }
        public double TiempoProximaLlegada
        {
            get { return tiempoProximaLlegada; }
        }
    }
}
