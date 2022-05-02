using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    public class Reparador
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
            get 
            {
                return estado; 
            }
            set
            {
                estado = value;
            }
        }
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
        public double TiempoAtencion
        {
            get 
            { 
                return tiempoAtencion;
            }
            set
            {
                tiempoAtencion = value;
            }
        }
        public double TiempoProximaAtencion
        {
            get 
            {
                return tiempoProximaAtencion;
            }
            set
            {
                tiempoProximaAtencion= value;   
            }
        }
        public double Precio
        {
            get 
            { 
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        public double Gastos
        {
            get 
            {
                return gastos;
            }
            set
            {
                gastos = value;
            }
        }


    }
}
