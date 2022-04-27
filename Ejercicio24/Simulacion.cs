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

        public DataTable getDtVector(Vector[] vec)
        {
            DataTable dtVector = new DataTable();

            dtVector.TableName = "dtSimCola";

            dtVector.Columns.Add("Evento", typeof(string));
            dtVector.Columns.Add("Reloj Sistema", typeof(double));
            dtVector.Columns.Add("RND LLeg. CLiente", typeof(int));
            dtVector.Columns.Add("Tiempo entre llegada Cliente", typeof(double));
            dtVector.Columns.Add("Próxima llegada Cliente", typeof(double));
            dtVector.Columns.Add("RND Atención", typeof(int));
            dtVector.Columns.Add("Tipo Atención", typeof(string));
            dtVector.Columns.Add("RND Venta", typeof(int));
            dtVector.Columns.Add("Tiempo Venta", typeof(double));
            dtVector.Columns.Add("Fin Venta", typeof(double));
            dtVector.Columns.Add("Fin Entrega Reloj", typeof(double));
            dtVector.Columns.Add("Fin Retiro Reloj", typeof(double));
            dtVector.Columns.Add("RND Reparación", typeof(int));
            dtVector.Columns.Add("Tiempo Reparación", typeof(double));
            dtVector.Columns.Add("Fin Reparación", typeof(double));
            dtVector.Columns.Add("Estado Ayudante", typeof(string));
            dtVector.Columns.Add("Cola Ayudante", typeof(int));
            dtVector.Columns.Add("Estado Relojero", typeof(string));
            dtVector.Columns.Add("Cola Relojero", typeof(int));
            dtVector.Columns.Add("Relojes reparados listos", typeof(int));
            dtVector.Columns.Add("Acum. retiros no efectuados", typeof(int));
            dtVector.Columns.Add("Cola Máxima Clientes", typeof(int));

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != null)
                {
                    v0 = v[i];
                    DataRow dr = dtVector.NewRow();
                    dr["Evento"] = v0.Evento;
                    dr["Reloj Sistema"] = v0.Reloj_sistema;
                    dr["RND LLeg. CLiente"] = v0.Rnd_lleg_cliente;
                    dr["Tiempo entre llegada Cliente"] = v0.Tmp_ent_lleg;
                    dr["Próxima llegada Cliente"] = v0.Prox_lleg_cliente;
                    dr["RND Atención"] = v0.Rnd_atencion;
                    dr["Tipo Atención"] = v0.Tipo_atencion;
                    dr["RND Venta"] = v0.Rnd_venta;
                    dr["Tiempo Venta"] = v0.Tmp_venta;
                    dr["Fin Venta"] = v0.Fin_venta;
                    dr["Fin Entrega Reloj"] = v0.Fin_entrega_reloj;
                    dr["Fin Retiro Reloj"] = v0.Fin_retiro_reloj;
                    dr["RND Reparación"] = v0.Rnd_reparacion;
                    dr["Tiempo Reparación"] = v0.Tmp_reparacion;
                    dr["Fin Reparación"] = v0.Fin_reparacion;
                    dr["Estado Ayudante"] = v0.Estado_ayudante;
                    dr["Cola Ayudante"] = v0.Cola_ayudante;
                    dr["Estado Relojero"] = v0.Estado_relojero;
                    dr["Cola Relojero"] = v0.Cola_relojero;
                    dr["Relojes reparados listos"] = v0.Cant_relojes_reparados;
                    dr["Acum. retiros no efectuados"] = v0.Acum_ret_rj_no_efectuado;
                    dr["Cola Máxima Clientes"] = v0.Cola_max_clietes;
                    dtVector.Rows.Add(dr);
                }
            }

            return dtVector;
        }
    }
}
