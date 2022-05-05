using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E24
{
    public partial class Form1 : Form, IPrint
    {
        private Simulacion sim;

        string ordenKey = "gdOrden";
        string relojKey = "gdReloj";
        string eventoKey = "gdEvento";
        string clienteKey = "gdCliente";
        string colaKey = "gdCola";

        // Llegadas
        string rndLlegadasKey = "gdRND";
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

        int desde = 0;
        int hasta = 20;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnSimular_Click(object sender, EventArgs e)
        {
            desde = 0;
            hasta = 20;
            bool simular = true;
            lblCantidadHorasError.Visible = false;
            lblLlegadasError.Visible = false;
            lblAtencionError.Visible = false;
            lblPrecioError.Visible = false;
            lblDesdeHastaError.Visible = false;

            if (txtCantidadHoras.Text == "" || int.Parse(txtCantidadHoras.Text) <= 0)
            {
                lblCantidadHorasError.Visible = true;
                simular = false;
            }

            if (txtCantidadLlegadasXHora.Text == "" || int.Parse(txtCantidadLlegadasXHora.Text) <= 0)
            {
                lblLlegadasError.Visible = true;
                simular = false;
            }

            if (txtAtencionLimiteSuperior.Text == "" ||
                txtAtencionLimiteInferior.Text == "" ||
                int.Parse(txtAtencionLimiteInferior.Text) < 0 ||
                int.Parse(txtAtencionLimiteSuperior.Text) <= 0 ||
                int.Parse(txtAtencionLimiteSuperior.Text) <= int.Parse(txtAtencionLimiteInferior.Text))
            {
                lblAtencionError.Visible = true;
                simular = false;
            }

            if (txtPrecioLimiteSuperior.Text == "" ||
                txtPrecioLimiteInferior.Text == "" ||
                int.Parse(txtPrecioLimiteInferior.Text) < 0 ||
                int.Parse(txtPrecioLimiteSuperior.Text) <= 0 ||
                int.Parse(txtPrecioLimiteSuperior.Text) <= int.Parse(txtPrecioLimiteInferior.Text))
            {
                lblPrecioError.Visible = true;
                simular = false;
            }

            if (txtDesde.Text != "" && int.Parse(txtDesde.Text) >= 0)
            {
                desde = int.Parse(txtDesde.Text);
            }
            if (txtHasta.Text != "" && int.Parse(txtHasta.Text) > 0)
            {
                hasta = int.Parse(txtHasta.Text);
            }
            if (desde >= hasta ||
               (txtDesde.Text != "" && int.Parse(txtDesde.Text) < 0) ||
               (txtHasta.Text != "" && int.Parse(txtHasta.Text) <= 0))
            {
                this.lblDesdeHastaError.Visible = true;
                simular = false;
            }

            if (simular)
            {
                int cantidadHoras = int.Parse(txtCantidadHoras.Text);
                int cantidadLlegadasXHora = int.Parse(txtCantidadLlegadasXHora.Text);
                int atencionLimiteSuperior = int.Parse(txtAtencionLimiteSuperior.Text);
                int atencionLimiteInferior = int.Parse(txtAtencionLimiteInferior.Text);
                int precioLimiteSuperior = int.Parse(txtPrecioLimiteSuperior.Text);
                int precioLimiteInferior = int.Parse(txtPrecioLimiteInferior.Text);

                sim = new Simulacion(cantidadHoras, cantidadLlegadasXHora, atencionLimiteSuperior, atencionLimiteInferior, precioLimiteSuperior, precioLimiteInferior);
                dataGridEventos.Rows.Clear();
                sim.ejecutar(this);
            }
            else
            {
                MessageBox.Show("Para poder simular debe corregir los errores");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridEventos.Rows.Clear();
            if (sim != null)
            {
                sim.reset();
            }
        }

        public void MostrarResultados(double pr, double gs, double pP, int gratis)
        {
            double precio = Math.Round(pr, 3);
            double gastos = Math.Round(gs, 3);
            double preciosPerdidosPorTiempo = Math.Round(pP, 3);
            double gananciasTotales = Math.Round((precio - gastos - preciosPerdidosPorTiempo), 3);
            double precioSinGarantia = (Math.Round(precio + (preciosPerdidosPorTiempo * 0.75), 3));
            double gastosSinGarantia = Math.Round((gastos + (preciosPerdidosPorTiempo * 0.25)), 3);

            MessageBox.Show("Las ganancias de las reparaciones cobradas fueron de " + precio
                + "\nLos gastos de las mismas fueron de " + gastos
                + "\nSe perdieron " + preciosPerdidosPorTiempo + " por pasar mas de 30 minutos el cliente en nuestro sistema."
                + "\nPor lo que las ganancias totales fueron de " + gananciasTotales
                + "\nDe no aplicar la garantía se hubiese ganado " + precioSinGarantia
                + "\nY los gastos serian de " + gastosSinGarantia
                + "\n La cantidad de clientes gratis son: " + gratis);
        }

        public void Print(Vector vect)
        {
            // Si quiero graficar todo, que nos va a traer problemas porque la tabla consume mucha ram, eliminamos el IF
            if (vect.Orden >= desde && vect.Orden <= hasta)
            {
                int newIndex = dataGridEventos.Rows.Add();



                // General
                dataGridEventos.Rows[newIndex].Cells[ordenKey].Value = vect.Orden;
                dataGridEventos.Rows[newIndex].Cells[relojKey].Value = vect.Reloj;
                dataGridEventos.Rows[newIndex].Cells[eventoKey].Value = vect.Evento;
                dataGridEventos.Rows[newIndex].Cells[clienteKey].Value = vect.Cliente;
                dataGridEventos.Rows[newIndex].Cells[colaKey].Value = vect.LargoCola;

                // Llegadas
                if (vect.RNDLlegada > 0)
                {
                    dataGridEventos.Rows[newIndex].Cells[rndLlegadasKey].Value = vect.RNDLlegada;
                }
                dataGridEventos.Rows[newIndex].Cells[tiempoEntreLlegadasKey].Value = vect.TiempoEntreLlegada;
                dataGridEventos.Rows[newIndex].Cells[tiempoProximaLlegadaKey].Value = vect.TiempoProximaLlegada;

                // R1
                dataGridEventos.Rows[newIndex].Cells[estadoR1Key].Value = vect.Reparador1.Estado;
                if (!vect.Reparador1.isLibre())
                {
                    dataGridEventos.Rows[newIndex].Cells[clienteR1Key].Value = vect.Reparador1.Cliente;
                    dataGridEventos.Rows[newIndex].Cells[tiempoAtencionR1Key].Value = vect.Reparador1.TiempoAtencion;
                    dataGridEventos.Rows[newIndex].Cells[tiempoFinAtencionR1Key].Value = vect.Reparador1.TiempoProximaAtencion;
                    dataGridEventos.Rows[newIndex].Cells[precioR1Key].Value = vect.Reparador1.Precio;
                    dataGridEventos.Rows[newIndex].Cells[costoR1Key].Value = vect.Reparador1.Gastos;
                }

                // R2
                dataGridEventos.Rows[newIndex].Cells[estadoR2Key].Value = vect.Reparador2.Estado;
                if (!vect.Reparador2.isLibre())
                {
                    dataGridEventos.Rows[newIndex].Cells[clienteR2Key].Value = vect.Reparador2.Cliente;
                    dataGridEventos.Rows[newIndex].Cells[tiempoAtencionR2Key].Value = vect.Reparador2.TiempoAtencion;
                    dataGridEventos.Rows[newIndex].Cells[tiempoFinAtencionR2Key].Value = vect.Reparador2.TiempoProximaAtencion;
                    dataGridEventos.Rows[newIndex].Cells[precioR2Key].Value = vect.Reparador2.Precio;
                    dataGridEventos.Rows[newIndex].Cells[costoR2Key].Value = vect.Reparador2.Gastos;
                }
                // R3
                dataGridEventos.Rows[newIndex].Cells[estadoR3Key].Value = vect.Reparador3.Estado;
                if (!vect.Reparador3.isLibre())
                {
                    dataGridEventos.Rows[newIndex].Cells[clienteR3Key].Value = vect.Reparador3.Cliente;
                    dataGridEventos.Rows[newIndex].Cells[tiempoAtencionR3Key].Value = vect.Reparador3.TiempoAtencion;
                    dataGridEventos.Rows[newIndex].Cells[tiempoFinAtencionR3Key].Value = vect.Reparador3.TiempoProximaAtencion;
                    dataGridEventos.Rows[newIndex].Cells[precioR3Key].Value = vect.Reparador3.Precio;
                    dataGridEventos.Rows[newIndex].Cells[costoR3Key].Value = vect.Reparador3.Gastos;
                }
            }
        }

        private void isDigit(KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAtencionLimiteSuperior_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e);
        }

        private void txtAtencionLimiteInferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e);

        }

        private void txtPrecioLimiteSuperior_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e);

        }

        private void txtPrecioLimiteInferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e);

        }

        private void txtCantidadLlegadasXHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e);

        }

        private void txtCantidadHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e);

        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e);

        }

        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e);

        }
    }
}
