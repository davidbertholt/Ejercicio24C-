using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio24
{
    public partial class Form1 : Form, IPrint
    {
        private Simulacion sim;

        string relojKey = "gdReloj";
        string eventoKey = "gdEvento";
        string clienteKey = "gdCliente";
        string colaKey = "gdCola";

        // Llegadas
        string tiempoEntreLlegadasKey = "gdTiempoEntreLlegadas";
        string tiempoProximaLlegadaKey = "gdTiempoProximaLlegada";

        // R1
        string estadoR1Key = "gdEstadoR1";
        string clienteR1Key = "gdClienteR1";
        string tiempoAtencionR1Key = "gdTiempoAtencionR1";
        string tiempoFinAtencionR1Key = "gdTiempoProximaAtencionR1";
        string precioR1Key = "gdPrecioR1";
        string costoR1Key = "gdGastosR1";
        
        // R2
        string estadoR2Key = "gdEstadoR2";
        string clienteR2Key = "gdClienteR2";
        string tiempoAtencionR2Key = "gdTiempoAtencionR2";
        string tiempoFinAtencionR2Key = "gdTiempoProximaAtencionR2";
        string precioR2Key = "gdPrecioR2";
        string costoR2Key = "gdGastosR2";
        
        // R3
        string estadoR3Key = "gdEstadoR3";
        string clienteR3Key = "gdClienteR3";
        string tiempoAtencionR3Key = "gdTiempoAtencionR3";
        string tiempoFinAtencionR3Key = "gdTiempoProximaAtencionR3";
        string precioR3Key = "gdPrecioR3";
        string costoR3Key = "gdGastosR3";

        public Form1()
        {
            InitializeComponent();
        }


        private void btnSimular_Click(object sender, EventArgs e)
        {
            int cantidadHoras = int.Parse(txtCantidadHoras.Text);
            int cantidadLlegadasXHora = int.Parse(txtCantidadLlegadasXHora.Text);
            int atencionLimiteSuperior = int.Parse(txtAtencionLimiteSuperior.Text);
            int atencionLimiteInferior = int.Parse(txtAtencionLimiteInferior.Text);
            int precioLimiteSuperior = int.Parse(txtPrecioLimiteSuperior.Text);
            int precioLimiteInferior = int.Parse(txtPrecioLimiteInferior.Text);

            sim = new Simulacion(cantidadHoras, cantidadLlegadasXHora, atencionLimiteSuperior, atencionLimiteInferior, precioLimiteSuperior, precioLimiteInferior);
            sim.ejecutar(this);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridEventos.Rows.Clear();
            sim.reset();

        }

        public void Print(Vector vect)
        {
            int newIndex = dataGridEventos.Rows.Add();
            
            // General
            dataGridEventos.Rows[newIndex].Cells[relojKey].Value = vect.Reloj;
            dataGridEventos.Rows[newIndex].Cells[eventoKey].Value = vect.Evento;
            dataGridEventos.Rows[newIndex].Cells[clienteKey].Value = vect.Cliente;
            dataGridEventos.Rows[newIndex].Cells[colaKey].Value = vect.LargoCola;
            
            // Llegadas
            dataGridEventos.Rows[newIndex].Cells[tiempoEntreLlegadasKey].Value = vect.TiempoEntreLlegada;
            dataGridEventos.Rows[newIndex].Cells[tiempoProximaLlegadaKey].Value = vect.TiempoProximaLlegada;

            // R1
            dataGridEventos.Rows[newIndex].Cells[estadoR1Key].Value = vect.Reparador1.Estado;
            if ( vect.Reparador1.Estado.Equals("OCUPADO"))
            {
                dataGridEventos.Rows[newIndex].Cells[clienteR1Key].Value = vect.Reparador1.Cliente;
                dataGridEventos.Rows[newIndex].Cells[tiempoAtencionR1Key].Value = vect.Reparador1.TiempoAtencion;
                dataGridEventos.Rows[newIndex].Cells[tiempoFinAtencionR1Key].Value = vect.Reparador1.TiempoProximaAtencion;
                dataGridEventos.Rows[newIndex].Cells[precioR1Key].Value = vect.Reparador1.Precio;
                dataGridEventos.Rows[newIndex].Cells[costoR1Key].Value = vect.Reparador1.Gastos;
            }

            // R2
            dataGridEventos.Rows[newIndex].Cells[estadoR2Key].Value = vect.Reparador2.Estado;
            if (vect.Reparador2.Estado.Equals("OCUPADO"))
            {
                dataGridEventos.Rows[newIndex].Cells[clienteR2Key].Value = vect.Reparador2.Cliente;
                dataGridEventos.Rows[newIndex].Cells[tiempoAtencionR2Key].Value = vect.Reparador2.TiempoAtencion;
                dataGridEventos.Rows[newIndex].Cells[tiempoFinAtencionR2Key].Value = vect.Reparador2.TiempoProximaAtencion;
                dataGridEventos.Rows[newIndex].Cells[precioR2Key].Value = vect.Reparador2.Precio;
                dataGridEventos.Rows[newIndex].Cells[costoR2Key].Value = vect.Reparador2.Gastos;
            }
            // R3
            dataGridEventos.Rows[newIndex].Cells[estadoR3Key].Value = vect.Reparador3.Estado;
            if (vect.Reparador3.Estado.Equals("OCUPADO"))
            {
                dataGridEventos.Rows[newIndex].Cells[clienteR3Key].Value = vect.Reparador3.Cliente;
                dataGridEventos.Rows[newIndex].Cells[tiempoAtencionR3Key].Value = vect.Reparador3.TiempoAtencion;
                dataGridEventos.Rows[newIndex].Cells[tiempoFinAtencionR3Key].Value = vect.Reparador3.TiempoProximaAtencion;
                dataGridEventos.Rows[newIndex].Cells[precioR3Key].Value = vect.Reparador3.Precio;
                dataGridEventos.Rows[newIndex].Cells[costoR3Key].Value = vect.Reparador3.Gastos;
            }
        }
    }
}
