namespace Ejercicio24
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioLimiteInferior = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioLimiteSuperior = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidadLlegadasXHora = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAtencionLimiteInferior = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAtencionLimiteSuperior = new System.Windows.Forms.TextBox();
            this.dataGridEventos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadHoras = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gdReloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdCola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdTiempoEntreLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdTiempoProximaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdEstadoR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdClienteR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdTiempoAtencionR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdTiempoProximaAtencionR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdPrecioR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdGastosR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdEstadoR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdClienteR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdTiempoAtencionR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdTiempoProximaAtencionR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdPrecioR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdGastosR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdEstadoR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdClienteR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdTiempoAtencionR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdTiempoProximaAtencionR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdPrecioR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdGastosR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(808, 17);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(104, 51);
            this.btnSimular.TabIndex = 0;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(918, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 51);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioLimiteInferior);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrecioLimiteSuperior);
            this.groupBox1.Location = new System.Drawing.Point(250, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Limite superior";
            // 
            // txtPrecioLimiteInferior
            // 
            this.txtPrecioLimiteInferior.Location = new System.Drawing.Point(79, 27);
            this.txtPrecioLimiteInferior.Name = "txtPrecioLimiteInferior";
            this.txtPrecioLimiteInferior.Size = new System.Drawing.Size(50, 20);
            this.txtPrecioLimiteInferior.TabIndex = 4;
            this.txtPrecioLimiteInferior.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Limite inferior";
            // 
            // txtPrecioLimiteSuperior
            // 
            this.txtPrecioLimiteSuperior.Location = new System.Drawing.Point(215, 26);
            this.txtPrecioLimiteSuperior.Name = "txtPrecioLimiteSuperior";
            this.txtPrecioLimiteSuperior.Size = new System.Drawing.Size(50, 20);
            this.txtPrecioLimiteSuperior.TabIndex = 5;
            this.txtPrecioLimiteSuperior.Text = "400";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCantidadLlegadasXHora);
            this.groupBox2.Location = new System.Drawing.Point(139, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 56);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Llegadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Media";
            // 
            // txtCantidadLlegadasXHora
            // 
            this.txtCantidadLlegadasXHora.Location = new System.Drawing.Point(48, 26);
            this.txtCantidadLlegadasXHora.Name = "txtCantidadLlegadasXHora";
            this.txtCantidadLlegadasXHora.Size = new System.Drawing.Size(50, 20);
            this.txtCantidadLlegadasXHora.TabIndex = 0;
            this.txtCantidadLlegadasXHora.Text = "7";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtAtencionLimiteInferior);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtAtencionLimiteSuperior);
            this.groupBox4.Location = new System.Drawing.Point(530, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 56);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atencion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Limite superior";
            // 
            // txtAtencionLimiteInferior
            // 
            this.txtAtencionLimiteInferior.Location = new System.Drawing.Point(79, 27);
            this.txtAtencionLimiteInferior.Name = "txtAtencionLimiteInferior";
            this.txtAtencionLimiteInferior.Size = new System.Drawing.Size(50, 20);
            this.txtAtencionLimiteInferior.TabIndex = 4;
            this.txtAtencionLimiteInferior.Text = "13";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Limite inferior";
            // 
            // txtAtencionLimiteSuperior
            // 
            this.txtAtencionLimiteSuperior.Location = new System.Drawing.Point(215, 27);
            this.txtAtencionLimiteSuperior.Name = "txtAtencionLimiteSuperior";
            this.txtAtencionLimiteSuperior.Size = new System.Drawing.Size(50, 20);
            this.txtAtencionLimiteSuperior.TabIndex = 5;
            this.txtAtencionLimiteSuperior.Text = "17";
            // 
            // dataGridEventos
            // 
            this.dataGridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gdReloj,
            this.gdEvento,
            this.gdCliente,
            this.gdCola,
            this.gdTiempoEntreLlegadas,
            this.gdTiempoProximaLlegada,
            this.gdEstadoR1,
            this.gdClienteR1,
            this.gdTiempoAtencionR1,
            this.gdTiempoProximaAtencionR1,
            this.gdPrecioR1,
            this.gdGastosR1,
            this.gdEstadoR2,
            this.gdClienteR2,
            this.gdTiempoAtencionR2,
            this.gdTiempoProximaAtencionR2,
            this.gdPrecioR2,
            this.gdGastosR2,
            this.gdEstadoR3,
            this.gdClienteR3,
            this.gdTiempoAtencionR3,
            this.gdTiempoProximaAtencionR3,
            this.gdPrecioR3,
            this.gdGastosR3});
            this.dataGridEventos.Location = new System.Drawing.Point(15, 74);
            this.dataGridEventos.Name = "dataGridEventos";
            this.dataGridEventos.Size = new System.Drawing.Size(1117, 500);
            this.dataGridEventos.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtCantidadHoras);
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 56);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad de Horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // txtCantidadHoras
            // 
            this.txtCantidadHoras.Location = new System.Drawing.Point(61, 27);
            this.txtCantidadHoras.Name = "txtCantidadHoras";
            this.txtCantidadHoras.Size = new System.Drawing.Size(50, 20);
            this.txtCantidadHoras.TabIndex = 0;
            this.txtCantidadHoras.Text = "1";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1028, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 51);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gdReloj
            // 
            this.gdReloj.HeaderText = "Reloj";
            this.gdReloj.Name = "gdReloj";
            this.gdReloj.ReadOnly = true;
            // 
            // gdEvento
            // 
            this.gdEvento.HeaderText = "Evento";
            this.gdEvento.Name = "gdEvento";
            this.gdEvento.ReadOnly = true;
            // 
            // gdCliente
            // 
            this.gdCliente.HeaderText = "Cliente";
            this.gdCliente.Name = "gdCliente";
            this.gdCliente.ReadOnly = true;
            // 
            // gdCola
            // 
            this.gdCola.HeaderText = "Cola";
            this.gdCola.Name = "gdCola";
            this.gdCola.ReadOnly = true;
            // 
            // gdTiempoEntreLlegadas
            // 
            this.gdTiempoEntreLlegadas.HeaderText = "Tiempo entre llegadas";
            this.gdTiempoEntreLlegadas.Name = "gdTiempoEntreLlegadas";
            this.gdTiempoEntreLlegadas.ReadOnly = true;
            // 
            // gdTiempoProximaLlegada
            // 
            this.gdTiempoProximaLlegada.HeaderText = "Tiempo proxima llegada";
            this.gdTiempoProximaLlegada.Name = "gdTiempoProximaLlegada";
            this.gdTiempoProximaLlegada.ReadOnly = true;
            // 
            // gdEstadoR1
            // 
            this.gdEstadoR1.HeaderText = "Estado R1";
            this.gdEstadoR1.Name = "gdEstadoR1";
            this.gdEstadoR1.ReadOnly = true;
            // 
            // gdClienteR1
            // 
            this.gdClienteR1.HeaderText = "Cliente R1";
            this.gdClienteR1.Name = "gdClienteR1";
            this.gdClienteR1.ReadOnly = true;
            // 
            // gdTiempoAtencionR1
            // 
            this.gdTiempoAtencionR1.HeaderText = "Tiempo atencion R1";
            this.gdTiempoAtencionR1.Name = "gdTiempoAtencionR1";
            this.gdTiempoAtencionR1.ReadOnly = true;
            // 
            // gdTiempoProximaAtencionR1
            // 
            this.gdTiempoProximaAtencionR1.HeaderText = "Tiempo proxima atencion R1";
            this.gdTiempoProximaAtencionR1.Name = "gdTiempoProximaAtencionR1";
            this.gdTiempoProximaAtencionR1.ReadOnly = true;
            // 
            // gdPrecioR1
            // 
            this.gdPrecioR1.HeaderText = "Precio R1";
            this.gdPrecioR1.Name = "gdPrecioR1";
            this.gdPrecioR1.ReadOnly = true;
            // 
            // gdGastosR1
            // 
            this.gdGastosR1.HeaderText = "Gastos R1";
            this.gdGastosR1.Name = "gdGastosR1";
            this.gdGastosR1.ReadOnly = true;
            // 
            // gdEstadoR2
            // 
            this.gdEstadoR2.HeaderText = "Estado R2";
            this.gdEstadoR2.Name = "gdEstadoR2";
            this.gdEstadoR2.ReadOnly = true;
            // 
            // gdClienteR2
            // 
            this.gdClienteR2.HeaderText = "Cliente R2";
            this.gdClienteR2.Name = "gdClienteR2";
            this.gdClienteR2.ReadOnly = true;
            // 
            // gdTiempoAtencionR2
            // 
            this.gdTiempoAtencionR2.HeaderText = "Tiempo atencion R2";
            this.gdTiempoAtencionR2.Name = "gdTiempoAtencionR2";
            this.gdTiempoAtencionR2.ReadOnly = true;
            // 
            // gdTiempoProximaAtencionR2
            // 
            this.gdTiempoProximaAtencionR2.HeaderText = "Tiempo proxima atencion R2";
            this.gdTiempoProximaAtencionR2.Name = "gdTiempoProximaAtencionR2";
            this.gdTiempoProximaAtencionR2.ReadOnly = true;
            // 
            // gdPrecioR2
            // 
            this.gdPrecioR2.HeaderText = "Precio R2";
            this.gdPrecioR2.Name = "gdPrecioR2";
            this.gdPrecioR2.ReadOnly = true;
            // 
            // gdGastosR2
            // 
            this.gdGastosR2.HeaderText = "Gastos R2";
            this.gdGastosR2.Name = "gdGastosR2";
            this.gdGastosR2.ReadOnly = true;
            // 
            // gdEstadoR3
            // 
            this.gdEstadoR3.HeaderText = "Estado R3";
            this.gdEstadoR3.Name = "gdEstadoR3";
            this.gdEstadoR3.ReadOnly = true;
            // 
            // gdClienteR3
            // 
            this.gdClienteR3.HeaderText = "Cliente R3";
            this.gdClienteR3.Name = "gdClienteR3";
            this.gdClienteR3.ReadOnly = true;
            // 
            // gdTiempoAtencionR3
            // 
            this.gdTiempoAtencionR3.HeaderText = "Tiempo atencion R3";
            this.gdTiempoAtencionR3.Name = "gdTiempoAtencionR3";
            this.gdTiempoAtencionR3.ReadOnly = true;
            // 
            // gdTiempoProximaAtencionR3
            // 
            this.gdTiempoProximaAtencionR3.HeaderText = "Tiempo proxima atencion R3";
            this.gdTiempoProximaAtencionR3.Name = "gdTiempoProximaAtencionR3";
            this.gdTiempoProximaAtencionR3.ReadOnly = true;
            // 
            // gdPrecioR3
            // 
            this.gdPrecioR3.HeaderText = "Precio R3";
            this.gdPrecioR3.Name = "gdPrecioR3";
            this.gdPrecioR3.ReadOnly = true;
            // 
            // gdGastosR3
            // 
            this.gdGastosR3.HeaderText = "Gastos R3";
            this.gdGastosR3.Name = "gdGastosR3";
            this.gdGastosR3.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 581);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridEventos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimular);
            this.Name = "Form1";
            this.Text = "Ejercicio 24";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioLimiteInferior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioLimiteSuperior;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidadLlegadasXHora;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAtencionLimiteInferior;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAtencionLimiteSuperior;
        private System.Windows.Forms.DataGridView dataGridEventos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadHoras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdReloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdTiempoEntreLlegadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdTiempoProximaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdEstadoR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdClienteR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdTiempoAtencionR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdTiempoProximaAtencionR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdPrecioR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdGastosR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdEstadoR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdClienteR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdTiempoAtencionR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdTiempoProximaAtencionR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdPrecioR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdGastosR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdEstadoR3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdClienteR3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdTiempoAtencionR3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdTiempoProximaAtencionR3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdPrecioR3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdGastosR3;
    }
}

