using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E24
{
    internal class Simulacion
    {
        private Vector v;

        // Parametros simulacion
        private int tiempoSimulacion;

        private double relojSistema = 0;
        private int proximoEvento = 0;

        private int proximoClienteAtencion = 0;
        private int proximoClienteLlegada = 0;

        private double proximaLlegada = 0;

        private static double MAX_NUMBER = Math.Pow(2, 53);

        private double finR1 = MAX_NUMBER - 2;
        private double finR3 = MAX_NUMBER - 1;
        private double finR2 = MAX_NUMBER;

        private double[] finEventos;

        private double precioTotal = 0;
        private double gastoTotal = 0;
        private double perdidaPorTiempo = 0;

        private FuncionesDatos obtenerDatos;

        private IPrint printer;

        private Reparador reparador1;
        private Reparador reparador2;
        private Reparador reparador3;

        private List<Cliente> colaCLiente;

        private int orden = 0;

        private Random randomLlegadas = new Random();
        private double rnd = 0.0;
        private int cantidadGratis = 0;
        public Simulacion(int tmp_sim, int llegXH, int supAt, int infAt, int supPr, int infPr)
        {
            colaCLiente = new List<Cliente>();
            obtenerDatos = new FuncionesDatos(llegXH, supAt, infAt, supPr, infPr);
            tiempoSimulacion = tmp_sim * 60;

            reparador1 = new Reparador(Constantes.REPARADOR_LIBRE, 0, 0, 0, 0, 0);
            reparador2 = new Reparador(Constantes.REPARADOR_LIBRE, 0, 0, 0, 0, 0);
            reparador3 = new Reparador(Constantes.REPARADOR_LIBRE, 0, 0, 0, 0, 0);

            finEventos = new double[] { proximaLlegada, finR1, finR2, finR3 };

        }

        public void ejecutar(IPrint view)
        {
            printer = view;

            obtenerEstadoInicial();

            printer.Print(v);

            bucleSimulacion();
        }

        public void reset()
        {
            v = null;
            tiempoSimulacion = 0;
            relojSistema = 0;
            proximoEvento = 0;
            proximoClienteAtencion = 0;
            proximoClienteLlegada = 0;
            reparador1.liberarReparador();
            reparador2.liberarReparador();
            reparador3.liberarReparador();
            precioTotal = 0;
            gastoTotal = 0;
            perdidaPorTiempo = 0;

        }

        private void obtenerEstadoInicial()
        {
            double rand = randomLlegadas.NextDouble();
            rnd = rand;
            double llegadaInicial = obtenerDatos.obtenerExponencialLlegadas(rand);
            proximoClienteLlegada = 1;
            proximoClienteAtencion = 1;
            finEventos[0] = llegadaInicial;

            v = new Vector(orden, Constantes.ESTADO_INICIAL, relojSistema, 0, 0, rnd, llegadaInicial, llegadaInicial, reparador1, reparador2, reparador3);
        }

        private void bucleSimulacion()
        {
            while (finEventos[proximoEvento] < tiempoSimulacion)
            {
                v.Reloj = finEventos[proximoEvento];

                switch (proximoEvento)
                {
                    case 0: // LLEGA UN CLIENTE
                        generarLlegadaCliente();
                        proximoClienteLlegada++;
                        break;
                    case 1: // REPARACION EN R1
                        generarFinAtencion(1);
                        break;
                    case 2: // REPARACION EN R2
                        generarFinAtencion(2);
                        break;
                    case 3: // REPARACION EN R3
                        generarFinAtencion(3);
                        break;
                }

                orden++;
                v.Orden = orden;
                v.RNDLlegada = rnd;
                printer.Print(v);

                proximoEvento = obtenerProximoEvento();
            }

            printer.MostrarResultados(precioTotal, gastoTotal, perdidaPorTiempo, cantidadGratis);
        }

        private int obtenerProximoEvento()
        {
            int menorIndex = 0;
            double menorValue = finEventos[menorIndex];
            for (int i = 1; i < 4; i++)
            {
                if (finEventos[i] < menorValue)
                {
                    menorIndex = i;
                    menorValue = finEventos[i];
                }
            }
            return menorIndex;
        }

        private int hayReparadorLibre()
        {
            if (reparador1.isLibre())
            {
                return 1;
            }
            else if (reparador2.isLibre())
            {
                return 2;
            }
            else if (reparador3.isLibre())
            {
                return 3;
            }
            return 0;
        }
        private void generarLlegadaCliente()
        {
            Cliente cli = new Cliente(proximoClienteAtencion, v.Reloj);
            colaCLiente.Add(cli);

            int rl = hayReparadorLibre();

            if (rl > 0) // hay reparador libre
            {
                ocuparReparador(rl);
            }
            else
            {
                v.LargoCola++;
            }
            v.Evento = Constantes.LLEGADA_CLIENTE;

            double rand = randomLlegadas.NextDouble();
            rnd = rand;
            v.TiempoEntreLlegada = obtenerDatos.obtenerExponencialLlegadas(rand);
            v.TiempoProximaLlegada = Math.Round(v.TiempoProximaLlegada + v.TiempoEntreLlegada, 3);

            v.Cliente = proximoClienteLlegada;

            finEventos[0] = v.TiempoProximaLlegada;
        }

        private void generarFinAtencion(int rep)
        {
            switch (rep)
            {
                case 1:
                    v.Cliente = v.Reparador1.Cliente;
                    break;
                case 2:
                    v.Cliente = v.Reparador2.Cliente;
                    break;
                case 3:
                    v.Cliente = v.Reparador3.Cliente;
                    break;
            }

            if (v.LargoCola > 0) // debe ingresar un cliente
            {
                v.LargoCola--;

                ocuparReparador(rep);
            }
            else
            {
                // debo liberar al rep
                switch (rep)
                {
                    case 1:
                        v.Reparador1.liberarReparador();
                        break;
                    case 2:
                        v.Reparador2.liberarReparador();
                        break;
                    case 3:
                        v.Reparador3.liberarReparador();
                        break;
                }
                finEventos[rep] = MAX_NUMBER;

                proximoClienteAtencion = proximoClienteLlegada;
            }

            v.Evento = Constantes.FIN_ATENCION;
        }

        private void ocuparReparador(int rep)
        {

            double timpoAtencion = obtenerDatos.obtenerUniformeAtencion();
            double timpoProximaAtencion = v.TiempoProximaLlegada + timpoAtencion;
            double tiempoTotalCliente = v.Reloj - colaCLiente[proximoClienteAtencion - 1].TimepoLlegadaAlSistema + timpoAtencion;

            double precioTentativo = obtenerDatos.obtenerUniformePrecio();
            double precio = 0;
            double gasto = 0;

            if (tiempoTotalCliente > 30)
            {
                perdidaPorTiempo += precioTentativo;
                cantidadGratis++;
            }
            else
            {
                precio = precioTentativo;
                gasto = Math.Round(precio * 0.25, 3);
            }

            gastoTotal += gasto;
            precioTotal += precio;
            switch (rep)
            {
                case 1:
                    v.Reparador1.ocuparReparador(proximoClienteAtencion, timpoAtencion, timpoProximaAtencion, precio, gasto);
                    break;
                case 2:
                    v.Reparador2.ocuparReparador(proximoClienteAtencion, timpoAtencion, timpoProximaAtencion, precio, gasto);
                    break;
                case 3:
                    v.Reparador3.ocuparReparador(proximoClienteAtencion, timpoAtencion, timpoProximaAtencion, precio, gasto);
                    break;
            }

            proximoClienteAtencion++;

            finEventos[rep] = Math.Round(timpoProximaAtencion, 3);

        }
    }
}
