using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    internal class Vector
    {
        private double reloj;
        private string evento;
        private Cliente cliente;
        private Cliente[] colaClientes;
        private int largoCola;
        public double tiempoEntreLlegada;
        public double tiempoProximaLlegada;
        private Reparador[] reparadores;


        public Vector (double rel, string ev, Cliente cli, Cliente[] colaCli, int largoC, double entre, double prox, Reparador[] rep )
        {
            reloj = rel;
            evento = ev;
            cliente = cli;
            colaClientes = colaCli;
            largoCola = largoC;
            reparadores = rep;
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
        public Reparador[] Reparadores
        {
            get { return reparadores; }
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
