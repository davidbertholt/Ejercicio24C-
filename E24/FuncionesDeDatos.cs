using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E24
{
    public class FuncionesDatos
    {
        Random random;
        private int limiteSuperiorPrecio;
        private int limiteInferiorPrecio;
        private int limiteSuperiorAtencion;
        private int limiteInferiorAtencion;
        private int llegadasXhora;

        public FuncionesDatos(int llegXH, int supAt, int infAt, int supPr, int infPr)
        {
            random = new Random();

            limiteSuperiorPrecio = supPr;
            limiteInferiorPrecio = infPr;
            limiteSuperiorAtencion = supAt;
            limiteInferiorAtencion = infAt;
            llegadasXhora = llegXH;

        }

        public double obtenerUniformePrecio()
        {
            double rnd = random.NextDouble();
            return limiteInferiorPrecio + rnd * (limiteSuperiorPrecio - limiteInferiorPrecio);
        }
        public double obtenerUniformeAtencion()
        {
            double rnd = random.NextDouble();
            return limiteInferiorAtencion + rnd * (limiteSuperiorAtencion - limiteInferiorAtencion);
        }

        public double obtenerExponencialLlegadas(double rnd)
        {
            //double rnd = random.NextDouble();
            // como la media son llegadas por hora exponencial sera -(60/media)*LN(1-rnd)
            return Math.Round(-(60 / llegadasXhora) * Math.Log(1 - rnd), 3);

        }
    }
}
