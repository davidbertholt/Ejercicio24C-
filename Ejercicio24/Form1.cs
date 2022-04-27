﻿using System;
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
    public partial class Form1 : Form
    {
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

            Simulacion sim = new Simulacion(cantidadHoras, cantidadLlegadasXHora, atencionLimiteSuperior, atencionLimiteInferior, precioLimiteSuperior, precioLimiteInferior);
            Vector[] vect = sim.ejecutar();

            dataGridEventos.DataSource = sim.getDtVector(vect);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
