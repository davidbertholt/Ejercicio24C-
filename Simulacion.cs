using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        // Eventos
        private string LLEGADA_CLIENTE = "LLEGADA_CLIENTE";
        private string SALIDA_CLIENTE = "SALIDA_CLIENTE";
        private string INIICIO_ATENCION_CLIENTE = "INIICIO_ATENCION_CLIENTE";
        private string FIN_ATENCION_CLIENTE = "FIN_ATENCION_CLIENTE";
        private string INIICIO_SIMULACION = "INIICIO_SIMULACION";
        private string FIN_SIMULACION = "FIN_SIMULACION";

        private List<Vector> v;
        private Vector v0;
        private Vector v1;

        // Parametros simulacion
        private int tiempoSimulacion;
        private int llegadasXhora;
        private int limiteSuperiorAtencion;
        private int limiteInferiorAtencion;
        private int limiteSuperiorPrecio;
        private int limiteInferiorPrecio;

        private double relojSistema = 0;

        private double precioTotal = 0;
        private double costoTotal = 0;
        private double costoPorTiempo = 0;

        private int rndAtencion;
        private int rndPrecio;

        private int rndLlegadaCliente;
        private double tiempoEntreLlegada;
        private double tiempoProximaLlegada;

        private Reparador reparador1;
        private Reparador reparador2;
        private Reparador reparador3;

        private double finR1 = Math.Pow(2, 53) - 3;
        private double finR2 = Math.Pow(2, 53) - 2;
        private double finR3 = Math.Pow(2, 53) - 1;
        private double nuevaLlegada = 0;

        private double[] finEventos;

        private Cliente cliente;
        private List<Cliente> colaCliente;
        private int largoCola = 0;

        private Random random;

        public Simulacion(int tmp_sim, int llegXH, int supAt, int infAt, int supPr, int infPr)
        {
            tiempoSimulacion = tmp_sim * 60;
            llegadasXhora = llegXH;
            limiteSuperiorAtencion = supAt;
            limiteInferiorAtencion = infAt;
            limiteSuperiorPrecio = supPr;
            limiteInferiorPrecio = infPr;

            // Random para todos
            random = new Random();
            finEventos = new double[4] { nuevaLlegada, finR1, finR2, finR3 };
        }

        public Vector[] ejecutar()
        {

            // Generao Vector
            v = new List<Vector>();

            // Estado Inicial
            //int rndInicial = random.Next(100);
            //v0 = generarEstadoInicial(rndInicial);
            v0 = generarEstadoInicial();

            // Se agrega a 0
            v.Add(v0);

            int proximoEvento = 0; // ya que despues del Estado nicial viene una llegada cliente

            int nuevoOrden = 1;
            string nuevoEstado = CLIENTE_SIENDO_ATENDIDO;
            Cliente cli = new Cliente(nuevoOrden, nuevoEstado);

            colaCliente.Add(cli);

            largoCola = 0;

            relojSistema = tiempoProximaLlegada;

            reparador1 = generarReparadorOcupado(1);
            finEventos[1] = reparador1.TiempoProximaAtencion;

            tiempoEntreLlegada = obtenerExponencialLlegadas();
            tiempoProximaLlegada += tiempoEntreLlegada;
            finEventos[0] = tiempoProximaLlegada;

            v1 = new Vector(LLEGADA_CLIENTE, relojSistema, cli, colaCliente.ToArray(), largoCola, tiempoEntreLlegada, tiempoProximaLlegada, reparador1, reparador2, reparador3);
            v.Add(v1);


            while( relojSistema < tiempoSimulacion)
            {
                
                switch(proximoEvento)
                {
                    case 0: // llegada cliente
                        int repLibre = hayReparadorLibre(v1);
                        v1 = generarNuevaLlegada(v1, repLibre);
                        break;
                    case 1: // Fin reparador 1
                        v1 = finalizarReparacion(v1, 1);
                        break;
                    case 2: // Fin reparador 2
                        v1 = finalizarReparacion(v1, 2);
                        break;
                    case 3: // Fin reparador 3
                        v1 = finalizarReparacion(v1, 3);
                        break;

                }


                v1.Reloj = relojSistema;
                v.Add(v1);

                // Obtenemos el id del menor evento
                proximoEvento = obtenerProximoEvento();};
                relojSistema = finEventos[proximoEvento];
            return v.ToArray();
        }

        private int obtenerProximoEvento()
        {
            double menor = finEventos[0];
            int ret = 0;
            for(int i = 1; i < 4; i++)
            {
                if (finEventos[i] < menor)
                {
                    menor = finEventos[i];
                    ret = i;
                }
            }
            return ret;
        }

        private Vector finalizarReparacion(Vector vect, int rep)
        {
            vect.Evento = FIN_ATENCION_CLIENTE;
            if (vect.LargoCola == 0)
            {
                switch (rep)
                {
                    case 1:
                        //vect.Cliente = vect.ColaClientes[vect.Reparador1.Cliente - 1]; // ya que el orden del cliente es 1 mas que su posicion
                        vect.Reparador1 = generarReparadorLibre();
                        finEventos[rep] = finR1;
                        break;
                    case 2:
                        //vect.Cliente = vect.ColaClientes[vect.Reparador2.Cliente - 1]; // ya que el orden del cliente es 1 mas que su posicion
                        vect.Reparador2 = generarReparadorLibre();
                        finEventos[rep] = finR2;
                        break;
                    case 3:
                        //vect.Cliente = vect.ColaClientes[vect.Reparador3.Cliente - 1]; // ya que el orden del cliente es 1 mas que su posicion
                        vect.Reparador3 = generarReparadorLibre();
                        finEventos[rep] = finR3;
                        break;
                }
            } else
            {
                vect.LargoCola -= 1;
                Cliente clienteATomar = obtenerProximoClientePendiente(vect.ColaClientes);
                vect.ColaClientes[clienteATomar.Orden - 1].Estado = CLIENTE_SIENDO_ATENDIDO;

                switch (rep)
                {
                    case 1:
                        vect.Cliente = vect.ColaClientes[vect.Reparador1.Cliente - 1]; // ya que el orden del cliente es 1 mas que su posicion
                        vect.Reparador1 = generarReparadorOcupado(clienteATomar.orden);
                        finEventos[rep] = vect.Reparador1.TiempoProximaAtencion;
                        break;
                    case 2:
                        vect.Cliente = vect.ColaClientes[vect.Reparador2.Cliente - 1]; // ya que el orden del cliente es 1 mas que su posicion
                        vect.Reparador2 = generarReparadorOcupado(clienteATomar.orden);
                        finEventos[rep] = vect.Reparador2.TiempoProximaAtencion;
                        break;
                    case 3:
                        vect.Cliente = vect.ColaClientes[vect.Reparador3.Cliente - 1]; // ya que el orden del cliente es 1 mas que su posicion
                        vect.Reparador3 = generarReparadorOcupado(clienteATomar.orden);
                        finEventos[rep] = vect.Reparador3.TiempoProximaAtencion;
                        break;
                }


            }

            vect.ColaClientes[vect.Cliente.Orden - 1].Estado = CLIENTE_FINALIZADO;

            return vect;
        }

        private Cliente obtenerProximoClientePendiente(Cliente[] clientes)
        {
           return clientes.ToList().Find(cli => cli.Estado == CLIENTE_PENDIENTE);
        }

        #region Funciones sobre Reparadores
        private int hayReparadorLibre(Vector vect) 
        {
            int ret = 0;
            if (vect.Reparador1.Estado.Equals(REPARADOR_LIBRE))
            {
                ret = 1;
            }
            else if (vect.Reparador2.Estado.Equals(REPARADOR_LIBRE)) {
                ret = 2;
            }
            else if (vect.Reparador3.Estado.Equals(REPARADOR_LIBRE)) {
                ret = 3;
            }
            return ret;
        }

        private Reparador generarReparadorOcupado(int cliente)
        {
            string nuevoEstado = REPARADOR_OCUPADO;
            double tiempoAtencion = obtenerUniformeAtencion();
            double nuevoTiempoAtencion = tiempoAtencion;
            double nuevoTiempoProximaAtencion = relojSistema + tiempoAtencion;
            double precioTentativo = obtenerUniformePrecio();
            double precioNuevo = 0;
            if (nuevoTiempoAtencion > 30)
            {
                costoPorTiempo += precioTentativo;
            }
            else
            {
                precioNuevo = precioTentativo;
                precioTotal += precioTentativo;
            };

            double nuevosGastos = precioTentativo * 0.25;
            costoTotal += nuevosGastos;

            Reparador rep = new Reparador(nuevoEstado, cliente, nuevoTiempoAtencion, nuevoTiempoProximaAtencion, precioNuevo, nuevosGastos);
            return rep;
        }
        private Reparador generarReparadorLibre()
        {
            Reparador rep = new Reparador(REPARADOR_LIBRE, 0, 0, 0, 0, 0);
            return rep;
        }
        #endregion

        #region Funcion sobre Llegada
        private Vector generarNuevaLlegada (Vector vect, int reparadorLibre)
        {
            int nuevoOrden = vect.ColaClientes.ToArray().Length + 1;
            string nuevoEstado = CLIENTE_PENDIENTE;
            if (reparadorLibre > 0)
            {
                nuevoEstado = CLIENTE_SIENDO_ATENDIDO;
                
                // Ocupar reparador
                switch (reparadorLibre)
                {
                    case 1:
                        reparador1 = generarReparadorOcupado(nuevoOrden);
                        finEventos[reparadorLibre] = reparador1.TiempoProximaAtencion;
                        break;
                    case 2:
                        reparador2 = generarReparadorOcupado(nuevoOrden);
                        finEventos[reparadorLibre] = reparador2.TiempoProximaAtencion;
                        break;
                    case 3:
                        reparador3 = generarReparadorOcupado(nuevoOrden);
                        finEventos[reparadorLibre] = reparador3.TiempoProximaAtencion;
                        break;
                }

            } else
            {
                largoCola += 1;
            }
            vect.Evento = LLEGADA_CLIENTE;

            Cliente cli = new Cliente(nuevoOrden, nuevoEstado);
            vect.Cliente = cli;

            colaCliente.Add(cli);
            vect.ColaClientes = colaCliente.ToArray();  

            vect.LargoCola = largoCola;
            vect.Reparador1 = reparador1;
            vect.Reparador2 = reparador2;
            vect.Reparador3 = reparador3;

            vect.tiempoEntreLlegada = obtenerExponencialLlegadas();
            vect.tiempoProximaLlegada += tiempoEntreLlegada;
            finEventos[0] = vect.tiempoProximaLlegada;

            return vect;
        }
        #endregion

        #region Estado Inicial
        private Vector generarEstadoInicial ()
        {
            rndLlegadaCliente = random.Next(100);
            tiempoEntreLlegada = obtenerExponencialLlegadas();
            tiempoProximaLlegada = relojSistema + tiempoEntreLlegada;
            relojSistema = 0;
            reparador1 = new Reparador(REPARADOR_LIBRE, 0, 0, 0, 0, 0);
            reparador2 = new Reparador(REPARADOR_LIBRE, 0, 0, 0, 0, 0);
            reparador3 = new Reparador(REPARADOR_LIBRE, 0, 0, 0, 0, 0);
            cliente = new Cliente(0, "");
            colaCliente = new List<Cliente>();

            v0 = new Vector(INIICIO_SIMULACION, relojSistema, cliente, colaCliente.ToArray(), largoCola, tiempoEntreLlegada, tiempoProximaLlegada, reparador1, reparador2, reparador3);

            return v0;
        }
        #endregion

        #region Funciones de datos
        private double obtenerUniformePrecio () {
            rndPrecio = random.Next(100);
            double tiempo = rndPrecio / 100.0;
            double amplitud = limiteSuperiorPrecio - limiteInferiorPrecio;
            return limiteInferiorPrecio + tiempo * amplitud;
        }
        private double obtenerUniformeAtencion () {
            rndAtencion = random.Next(100);
            double tiempo = rndAtencion / 100.0;
            double amplitud = limiteSuperiorAtencion - limiteInferiorAtencion;
            return limiteInferiorAtencion + tiempo * amplitud;
        }

        private double obtenerExponencialLlegadas ()
        {
            rndLlegadaCliente = random.Next(100);
            double tiempo = rndLlegadaCliente / 100.0;
            // como la media son llegadas por hora exponencial sera -(60/media)*LN(1-rnd)
            double lambda = 60 / llegadasXhora;
            return -lambda * Math.Log(1 - tiempo);

        }
        #endregion

        #region Datos para tabla
        public DataTable getDtVector(Vector[] vec)
        {
            string relojKey = "Reloj";
            string eventoKey = "Evento";
            string clienteKey= "Cliente";
            string colaKey= "Cola";
            string tiempoEntreLlegadasKey= "Tiempo entre llegadas";
            string tiempoProximaLlegadaKey= "Próxima llegada";
            // R1
            string estadoR1Key= "Estado R1";
            string clienteR1Key= "Cliente R1";
            string tiempoAtencionR1Key= "Tipo Atención R1";
            string tiempoFinAtencionR1Key= "Tiempo Prox At R1";
            string precioR1Key= "Precio R1";
            string costoR1Key= "Costo R1";
            // R2
            string estadoR2Key= "Estado R2";
            string clienteR2Key= "Cliente R2";
            string tiempoAtencionR2Key= "Tipo Atención R2";
            string tiempoFinAtencionR2Key= "Tiempo Prox At R2";
            string precioR2Key= "Precio R2";
            string costoR2Key= "Costo R2";
            // R3
            string estadoR3Key= "Estado R3";
            string clienteR3Key= "Cliente R3";
            string tiempoAtencionR3Key= "Tipo Atención R3";
            string tiempoFinAtencionR3Key= "Tiempo Prox At R3";
            string precioR3Key= "Precio R3";
            string costoR3Key= "Costo R3";
            
            DataTable dtVector = new DataTable();

            dtVector.TableName = "dtSimCola";

            dtVector.Columns.Add(relojKey, typeof(double));
            dtVector.Columns.Add(eventoKey, typeof(string));
            dtVector.Columns.Add(clienteKey, typeof(int));
            dtVector.Columns.Add(colaKey, typeof(int));
            dtVector.Columns.Add(tiempoEntreLlegadasKey, typeof(double));
            dtVector.Columns.Add(tiempoProximaLlegadaKey, typeof(double));
            // R1
            dtVector.Columns.Add(estadoR1Key, typeof(string));
            dtVector.Columns.Add(clienteR1Key, typeof(string));
            dtVector.Columns.Add(tiempoAtencionR1Key, typeof(double));
            dtVector.Columns.Add(tiempoFinAtencionR1Key, typeof(double));
            dtVector.Columns.Add(precioR1Key, typeof(double));
            dtVector.Columns.Add(costoR1Key, typeof(double));
             // R2
            dtVector.Columns.Add(estadoR2Key, typeof(string));
            dtVector.Columns.Add(clienteR2Key, typeof(string));
            dtVector.Columns.Add(tiempoAtencionR2Key, typeof(double));
            dtVector.Columns.Add(tiempoFinAtencionR2Key, typeof(double));
            dtVector.Columns.Add(precioR2Key, typeof(double));
            dtVector.Columns.Add(costoR2Key, typeof(double));
             // R3
            dtVector.Columns.Add(estadoR3Key, typeof(string));
            dtVector.Columns.Add(clienteR3Key, typeof(string));
            dtVector.Columns.Add(tiempoAtencionR3Key, typeof(double));
            dtVector.Columns.Add(tiempoFinAtencionR3Key, typeof(double));
            dtVector.Columns.Add(precioR3Key, typeof(double));
            dtVector.Columns.Add(costoR3Key, typeof(double));
            

            for (int i = 0; i < vec.Length; i++)
            {
                if (v[i] != null)
                {
                    v0 = v[i];
                    DataRow dr = dtVector.NewRow();
                    dr[relojKey] = v0.Reloj;
                    dr[eventoKey] = v0.Evento;
                    dr[clienteKey] = v0.Cliente.Orden;
                    dr[colaKey] = v0.LargoCola;
                    dr[tiempoEntreLlegadasKey] = v0.TiempoEntreLlegada;
                    dr[tiempoProximaLlegadaKey] = v0.TiempoProximaLlegada;
                    // R1
                    dr[estadoR1Key] = v0.Reparador1.Estado;
                    dr[clienteR1Key] = v0.Reparador1.Cliente;
                    dr[tiempoAtencionR1Key] = v0.Reparador1.TiempoAtencion;
                    dr[tiempoFinAtencionR1Key] = v0.Reparador1.TiempoProximaAtencion;
                    dr[precioR1Key] = v0.Reparador1.Precio;
                    dr[costoR1Key] = v0.Reparador1.Gastos;
                    // R2
                    dr[estadoR2Key] = v0.Reparador2.Estado;
                    dr[clienteR2Key] = v0.Reparador2.Cliente;
                    dr[tiempoAtencionR2Key] = v0.Reparador2.TiempoAtencion;
                    dr[tiempoFinAtencionR2Key] = v0.Reparador2.TiempoProximaAtencion;
                    dr[precioR2Key] = v0.Reparador2.Precio;
                    dr[costoR2Key] = v0.Reparador2.Gastos;
                    // R3
                    dr[estadoR3Key] = v0.Reparador3.Estado;
                    dr[clienteR3Key] = v0.Reparador3.Cliente;
                    dr[tiempoAtencionR3Key] = v0.Reparador3.TiempoAtencion;
                    dr[tiempoFinAtencionR3Key] = v0.Reparador3.TiempoProximaAtencion;
                    dr[precioR3Key] = v0.Reparador3.Precio;
                    dr[costoR3Key] = v0.Reparador3.Gastos;


                    dtVector.Rows.Add(dr);
                }
            }

            return dtVector;
        }
        #endregion

    }

}
