using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    public class Vector
    {
        private string evento;
        private double reloj;
        private int cliente;
        //private List<Cliente> colaClientes;
        private int largoCola;
        public double tiempoEntreLlegada;
        public double tiempoProximaLlegada;
        private Reparador reparador1;
        private Reparador reparador2;
        private Reparador reparador3;


        //public Vector (string ev, double rel, int cli, List<Cliente> colaCli, int largoC, double entre, double prox, Reparador rep1, Reparador rep2, Reparador rep3)
        public Vector (string ev, double rel, int cli, int largoC, double entre, double prox, Reparador rep1, Reparador rep2, Reparador rep3)
        {
            this.reloj = rel;
            this.evento = ev;
            this.cliente = cli;
            this.largoCola = largoC;
            this.reparador1 = rep1;
            this.reparador2 = rep2;
            this.reparador3 = rep3;
            this.tiempoEntreLlegada = entre;
            this.tiempoProximaLlegada = prox;
        
        }

        public double Reloj
        {
            get
            {
                return reloj;
            }
            set
            { 
                reloj = value;
            }
        }
        public string Evento
        {
            get
            {
                return evento;
            }
            set 
            {
                evento = value;
            }
        }
        // public Cliente Cliente
        public int Cliente
        {
            get 
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }
        /* public List<Cliente> ColaClientes
        {
            get 
            {
                return colaClientes;
            }
            set
            {
                colaClientes = value;
            }
        }*/ 
        public int LargoCola
        {
            get 
            {
                return largoCola;
            }
            set
            {
                largoCola = value;
            }
        }
        public Reparador Reparador1
        {
            get
            { 
                return reparador1;
            }
            set
            {
                reparador1 = value;
            }
        }
        public Reparador Reparador2
        {
            get
            {
                return reparador2;
            }
            set
            {
                reparador2 = value;
            }
        }
        public Reparador Reparador3
        {
            get
            {
                return reparador3;
            }
            set
            {
                reparador3 = value;
            }
        }
        public double TiempoEntreLlegada
        {
            get 
            {
                return tiempoEntreLlegada;
            }
            set
            {
                tiempoEntreLlegada = value;
            }
        }
        public double TiempoProximaLlegada
        {
            get 
            {
                return tiempoProximaLlegada;
            }
            set
            {
                tiempoProximaLlegada = value;
            }
        }
    }
}
