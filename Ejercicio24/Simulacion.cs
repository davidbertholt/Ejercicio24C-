using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    internal class Simulacion
    {
        // Estados
        private string REPARADOR_OCUPADO = "OCUPADO";
        private string REPARADOR_LIBRE = "LIBRE";
        private string CLIENTE_SIENDO_ATENDIDO = "CLIENTE_SIENDO_ATENDIDO";
        private string CLIENTE_FINALIZADO = "CLIENTE_FINALIZADO";
        private string CLIENTE_PENDIENTE = "CLIENTE_PENDIENTE";
        private string REPARACION_PAGADA = "REPARACION_PAGADA";
        private string REPARACION_GRATIS = "REPARACION_GRATIS";

        private Vector[] v;

        // Parametros simulacion
        private int tiempoSimulacion;
        private int llegadasXhora;
        private int limiteSuperiorAtencion;
        private int limiteInferiorAtencion;
        private int limiteSuperiorPrecio;
        private int limiteInferiorPrecio;

        private double relojSistema = 0;

        private int rndLlegadaCliente;

        public Simulacion(int tmp_sim, int llegXH, int supAt, int infAt, int supPr, int infPr)
        {
            tiempoSimulacion = tmp_sim;
            llegadasXhora = llegXH;
            limiteSuperiorAtencion = supAt;
            limiteInferiorAtencion = infAt;
            limiteSuperiorPrecio = supPr;
            limiteInferiorPrecio = infPr;
        }

        public Vector[] ejecutar ()
        {
            Random random = new Random();

            rndLlegadaCliente = random.Next(100);


            return v;
        }

        private double obtenerUniformePrecio (int rnd) {
            double tiempo = (double)rnd / 100;
            double amplitud = limiteSuperiorPrecio - limiteInferiorPrecio;
            return limiteInferiorPrecio + tiempo * amplitud;
        }
        private double obtenerUniformeAtencion (int rnd) {
            double tiempo = (double)rnd / 100;
            double amplitud = limiteSuperiorAtencion - limiteInferiorAtencion;
            return limiteInferiorPrecio + tiempo * amplitud;
        }

        private double obtenerExponencialLlegadas (int rnd)
        {
            double tiempo = (double)rnd / 100;
            // como la media son llegadas por hora exponencial sera -(60/media)*LN(1-rnd)
            double lambda = -60 / llegadasXhora;
            return -lambda * Math.Log(1 - tiempo);

        }
    }
}
