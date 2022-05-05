namespace E24
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
            this.lblPrecioError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioLimiteInferior = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioLimiteSuperior = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLlegadasError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidadLlegadasXHora = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblAtencionError = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAtencionLimiteInferior = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAtencionLimiteSuperior = new System.Windows.Forms.TextBox();
            this.dataGridEventos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCantidadHorasError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadHoras = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblDesdeHastaError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gdOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdReloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdCola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdRND = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(1268, 3);
            this.btnSimular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(89, 31);
            this.btnSimular.TabIndex = 0;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1268, 40);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 31);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrecioError);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioLimiteInferior);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrecioLimiteSuperior);
            this.groupBox1.Location = new System.Drawing.Point(292, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(320, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio";
            // 
            // lblPrecioError
            // 
            this.lblPrecioError.AutoSize = true;
            this.lblPrecioError.ForeColor = System.Drawing.Color.Red;
            this.lblPrecioError.Location = new System.Drawing.Point(25, 57);
            this.lblPrecioError.Name = "lblPrecioError";
            this.lblPrecioError.Size = new System.Drawing.Size(266, 30);
            this.lblPrecioError.TabIndex = 8;
            this.lblPrecioError.Text = "Ambos deben ser enteros positivos o cero\r\nEl limite inferior debe ser menor al li" +
    "mite superior";
            this.lblPrecioError.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Limite superior";
            // 
            // txtPrecioLimiteInferior
            // 
            this.txtPrecioLimiteInferior.Location = new System.Drawing.Point(92, 31);
            this.txtPrecioLimiteInferior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioLimiteInferior.Name = "txtPrecioLimiteInferior";
            this.txtPrecioLimiteInferior.Size = new System.Drawing.Size(58, 23);
            this.txtPrecioLimiteInferior.TabIndex = 4;
            this.txtPrecioLimiteInferior.Text = "100";
            this.txtPrecioLimiteInferior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioLimiteInferior_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Limite inferior";
            // 
            // txtPrecioLimiteSuperior
            // 
            this.txtPrecioLimiteSuperior.Location = new System.Drawing.Point(251, 30);
            this.txtPrecioLimiteSuperior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioLimiteSuperior.Name = "txtPrecioLimiteSuperior";
            this.txtPrecioLimiteSuperior.Size = new System.Drawing.Size(58, 23);
            this.txtPrecioLimiteSuperior.TabIndex = 5;
            this.txtPrecioLimiteSuperior.Text = "400";
            this.txtPrecioLimiteSuperior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioLimiteSuperior_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLlegadasError);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCantidadLlegadasXHora);
            this.groupBox2.Location = new System.Drawing.Point(162, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(122, 91);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Llegadas";
            // 
            // lblLlegadasError
            // 
            this.lblLlegadasError.AutoSize = true;
            this.lblLlegadasError.ForeColor = System.Drawing.Color.Red;
            this.lblLlegadasError.Location = new System.Drawing.Point(1, 57);
            this.lblLlegadasError.Name = "lblLlegadasError";
            this.lblLlegadasError.Size = new System.Drawing.Size(92, 30);
            this.lblLlegadasError.TabIndex = 3;
            this.lblLlegadasError.Text = "Debe ser entero \nMayor a cero";
            this.lblLlegadasError.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Media";
            // 
            // txtCantidadLlegadasXHora
            // 
            this.txtCantidadLlegadasXHora.Location = new System.Drawing.Point(56, 30);
            this.txtCantidadLlegadasXHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidadLlegadasXHora.Name = "txtCantidadLlegadasXHora";
            this.txtCantidadLlegadasXHora.Size = new System.Drawing.Size(58, 23);
            this.txtCantidadLlegadasXHora.TabIndex = 0;
            this.txtCantidadLlegadasXHora.Text = "7";
            this.txtCantidadLlegadasXHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadLlegadasXHora_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblAtencionError);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtAtencionLimiteInferior);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtAtencionLimiteSuperior);
            this.groupBox4.Location = new System.Drawing.Point(618, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(317, 91);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atencion";
            // 
            // lblAtencionError
            // 
            this.lblAtencionError.AutoSize = true;
            this.lblAtencionError.ForeColor = System.Drawing.Color.Red;
            this.lblAtencionError.Location = new System.Drawing.Point(25, 58);
            this.lblAtencionError.Name = "lblAtencionError";
            this.lblAtencionError.Size = new System.Drawing.Size(266, 30);
            this.lblAtencionError.TabIndex = 9;
            this.lblAtencionError.Text = "Ambos deben ser enteros positivos o cero\r\nEl limite inferior debe ser menor al li" +
    "mite superior";
            this.lblAtencionError.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Limite superior";
            // 
            // txtAtencionLimiteInferior
            // 
            this.txtAtencionLimiteInferior.Location = new System.Drawing.Point(92, 31);
            this.txtAtencionLimiteInferior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAtencionLimiteInferior.Name = "txtAtencionLimiteInferior";
            this.txtAtencionLimiteInferior.Size = new System.Drawing.Size(58, 23);
            this.txtAtencionLimiteInferior.TabIndex = 4;
            this.txtAtencionLimiteInferior.Text = "13";
            this.txtAtencionLimiteInferior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtencionLimiteInferior_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Limite inferior";
            // 
            // txtAtencionLimiteSuperior
            // 
            this.txtAtencionLimiteSuperior.Location = new System.Drawing.Point(251, 31);
            this.txtAtencionLimiteSuperior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAtencionLimiteSuperior.Name = "txtAtencionLimiteSuperior";
            this.txtAtencionLimiteSuperior.Size = new System.Drawing.Size(58, 23);
            this.txtAtencionLimiteSuperior.TabIndex = 5;
            this.txtAtencionLimiteSuperior.Text = "17";
            this.txtAtencionLimiteSuperior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtencionLimiteSuperior_KeyPress);
            // 
            // dataGridEventos
            // 
            this.dataGridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gdOrden,
            this.gdReloj,
            this.gdEvento,
            this.gdCliente,
            this.gdCola,
            this.gdRND,
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
            this.dataGridEventos.Location = new System.Drawing.Point(18, 111);
            this.dataGridEventos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridEventos.Name = "dataGridEventos";
            this.dataGridEventos.Size = new System.Drawing.Size(1339, 551);
            this.dataGridEventos.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCantidadHorasError);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtCantidadHoras);
            this.groupBox3.Location = new System.Drawing.Point(18, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(138, 91);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad de Horas";
            // 
            // lblCantidadHorasError
            // 
            this.lblCantidadHorasError.AutoSize = true;
            this.lblCantidadHorasError.ForeColor = System.Drawing.Color.Red;
            this.lblCantidadHorasError.Location = new System.Drawing.Point(7, 57);
            this.lblCantidadHorasError.Name = "lblCantidadHorasError";
            this.lblCantidadHorasError.Size = new System.Drawing.Size(92, 30);
            this.lblCantidadHorasError.TabIndex = 2;
            this.lblCantidadHorasError.Text = "Debe ser entero \nMayor a cero";
            this.lblCantidadHorasError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // txtCantidadHoras
            // 
            this.txtCantidadHoras.Location = new System.Drawing.Point(71, 31);
            this.txtCantidadHoras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidadHoras.Name = "txtCantidadHoras";
            this.txtCantidadHoras.Size = new System.Drawing.Size(58, 23);
            this.txtCantidadHoras.TabIndex = 0;
            this.txtCantidadHoras.Text = "1";
            this.txtCantidadHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadHoras_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1268, 74);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 31);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(96, 31);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(56, 23);
            this.txtDesde.TabIndex = 11;
            this.txtDesde.Text = "0";
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(252, 31);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(58, 23);
            this.txtHasta.TabIndex = 12;
            this.txtHasta.Text = "20";
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHasta_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblDesdeHastaError);
            this.groupBox5.Controls.Add(this.txtDesde);
            this.groupBox5.Controls.Add(this.txtHasta);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(943, 14);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(317, 91);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Registros a mostrar";
            // 
            // lblDesdeHastaError
            // 
            this.lblDesdeHastaError.AutoSize = true;
            this.lblDesdeHastaError.ForeColor = System.Drawing.Color.Red;
            this.lblDesdeHastaError.Location = new System.Drawing.Point(26, 58);
            this.lblDesdeHastaError.Name = "lblDesdeHastaError";
            this.lblDesdeHastaError.Size = new System.Drawing.Size(266, 30);
            this.lblDesdeHastaError.TabIndex = 9;
            this.lblDesdeHastaError.Text = "Ambos deben ser enteros positivos o cero\r\nEl limite inferior debe ser menor al li" +
    "mite superior";
            this.lblDesdeHastaError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Limite superior";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Limite inferior";
            // 
            // gdOrden
            // 
            this.gdOrden.HeaderText = "Orden";
            this.gdOrden.Name = "gdOrden";
            this.gdOrden.ReadOnly = true;
            this.gdOrden.Width = 65;
            // 
            // gdReloj
            // 
            this.gdReloj.HeaderText = "Reloj";
            this.gdReloj.Name = "gdReloj";
            this.gdReloj.ReadOnly = true;
            this.gdReloj.Width = 58;
            // 
            // gdEvento
            // 
            this.gdEvento.HeaderText = "Evento";
            this.gdEvento.Name = "gdEvento";
            this.gdEvento.ReadOnly = true;
            this.gdEvento.Width = 68;
            // 
            // gdCliente
            // 
            this.gdCliente.HeaderText = "Cliente";
            this.gdCliente.Name = "gdCliente";
            this.gdCliente.ReadOnly = true;
            this.gdCliente.Width = 69;
            // 
            // gdCola
            // 
            this.gdCola.HeaderText = "Cola";
            this.gdCola.Name = "gdCola";
            this.gdCola.ReadOnly = true;
            this.gdCola.Width = 56;
            // 
            // gdRND
            // 
            this.gdRND.HeaderText = "RND";
            this.gdRND.Name = "gdRND";
            this.gdRND.ReadOnly = true;
            // 
            // gdTiempoEntreLlegadas
            // 
            this.gdTiempoEntreLlegadas.HeaderText = "Tiempo entre llegadas";
            this.gdTiempoEntreLlegadas.Name = "gdTiempoEntreLlegadas";
            this.gdTiempoEntreLlegadas.ReadOnly = true;
            this.gdTiempoEntreLlegadas.Width = 135;
            // 
            // gdTiempoProximaLlegada
            // 
            this.gdTiempoProximaLlegada.HeaderText = "Tiempo proxima llegada";
            this.gdTiempoProximaLlegada.Name = "gdTiempoProximaLlegada";
            this.gdTiempoProximaLlegada.ReadOnly = true;
            this.gdTiempoProximaLlegada.Width = 146;
            // 
            // gdEstadoR1
            // 
            this.gdEstadoR1.HeaderText = "Estado R1";
            this.gdEstadoR1.Name = "gdEstadoR1";
            this.gdEstadoR1.ReadOnly = true;
            this.gdEstadoR1.Width = 77;
            // 
            // gdClienteR1
            // 
            this.gdClienteR1.HeaderText = "Cliente R1";
            this.gdClienteR1.Name = "gdClienteR1";
            this.gdClienteR1.ReadOnly = true;
            this.gdClienteR1.Width = 79;
            // 
            // gdTiempoAtencionR1
            // 
            this.gdTiempoAtencionR1.HeaderText = "Tiempo atencion R1";
            this.gdTiempoAtencionR1.Name = "gdTiempoAtencionR1";
            this.gdTiempoAtencionR1.ReadOnly = true;
            this.gdTiempoAtencionR1.Width = 114;
            // 
            // gdTiempoProximaAtencionR1
            // 
            this.gdTiempoProximaAtencionR1.HeaderText = "Tiempo proxima atencion R1";
            this.gdTiempoProximaAtencionR1.Name = "gdTiempoProximaAtencionR1";
            this.gdTiempoProximaAtencionR1.ReadOnly = true;
            this.gdTiempoProximaAtencionR1.Width = 153;
            // 
            // gdPrecioR1
            // 
            this.gdPrecioR1.HeaderText = "Precio R1";
            this.gdPrecioR1.Name = "gdPrecioR1";
            this.gdPrecioR1.ReadOnly = true;
            this.gdPrecioR1.Width = 75;
            // 
            // gdGastosR1
            // 
            this.gdGastosR1.HeaderText = "Gastos R1";
            this.gdGastosR1.Name = "gdGastosR1";
            this.gdGastosR1.ReadOnly = true;
            this.gdGastosR1.Width = 77;
            // 
            // gdEstadoR2
            // 
            this.gdEstadoR2.HeaderText = "Estado R2";
            this.gdEstadoR2.Name = "gdEstadoR2";
            this.gdEstadoR2.ReadOnly = true;
            this.gdEstadoR2.Width = 77;
            // 
            // gdClienteR2
            // 
            this.gdClienteR2.HeaderText = "Cliente R2";
            this.gdClienteR2.Name = "gdClienteR2";
            this.gdClienteR2.ReadOnly = true;
            this.gdClienteR2.Width = 79;
            // 
            // gdTiempoAtencionR2
            // 
            this.gdTiempoAtencionR2.HeaderText = "Tiempo atencion R2";
            this.gdTiempoAtencionR2.Name = "gdTiempoAtencionR2";
            this.gdTiempoAtencionR2.ReadOnly = true;
            this.gdTiempoAtencionR2.Width = 114;
            // 
            // gdTiempoProximaAtencionR2
            // 
            this.gdTiempoProximaAtencionR2.HeaderText = "Tiempo proxima atencion R2";
            this.gdTiempoProximaAtencionR2.Name = "gdTiempoProximaAtencionR2";
            this.gdTiempoProximaAtencionR2.ReadOnly = true;
            this.gdTiempoProximaAtencionR2.Width = 153;
            // 
            // gdPrecioR2
            // 
            this.gdPrecioR2.HeaderText = "Precio R2";
            this.gdPrecioR2.Name = "gdPrecioR2";
            this.gdPrecioR2.ReadOnly = true;
            this.gdPrecioR2.Width = 75;
            // 
            // gdGastosR2
            // 
            this.gdGastosR2.HeaderText = "Gastos R2";
            this.gdGastosR2.Name = "gdGastosR2";
            this.gdGastosR2.ReadOnly = true;
            this.gdGastosR2.Width = 77;
            // 
            // gdEstadoR3
            // 
            this.gdEstadoR3.HeaderText = "Estado R3";
            this.gdEstadoR3.Name = "gdEstadoR3";
            this.gdEstadoR3.ReadOnly = true;
            this.gdEstadoR3.Width = 77;
            // 
            // gdClienteR3
            // 
            this.gdClienteR3.HeaderText = "Cliente R3";
            this.gdClienteR3.Name = "gdClienteR3";
            this.gdClienteR3.ReadOnly = true;
            this.gdClienteR3.Width = 79;
            // 
            // gdTiempoAtencionR3
            // 
            this.gdTiempoAtencionR3.HeaderText = "Tiempo atencion R3";
            this.gdTiempoAtencionR3.Name = "gdTiempoAtencionR3";
            this.gdTiempoAtencionR3.ReadOnly = true;
            this.gdTiempoAtencionR3.Width = 114;
            // 
            // gdTiempoProximaAtencionR3
            // 
            this.gdTiempoProximaAtencionR3.HeaderText = "Tiempo proxima atencion R3";
            this.gdTiempoProximaAtencionR3.Name = "gdTiempoProximaAtencionR3";
            this.gdTiempoProximaAtencionR3.ReadOnly = true;
            this.gdTiempoProximaAtencionR3.Width = 153;
            // 
            // gdPrecioR3
            // 
            this.gdPrecioR3.HeaderText = "Precio R3";
            this.gdPrecioR3.Name = "gdPrecioR3";
            this.gdPrecioR3.ReadOnly = true;
            this.gdPrecioR3.Width = 75;
            // 
            // gdGastosR3
            // 
            this.gdGastosR3.HeaderText = "Gastos R3";
            this.gdGastosR3.Name = "gdGastosR3";
            this.gdGastosR3.ReadOnly = true;
            this.gdGastosR3.Width = 77;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 680);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridEventos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimular);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private Label lblCantidadHorasError;
        private Label lblLlegadasError;
        private Label lblPrecioError;
        private Label lblAtencionError;
        private TextBox txtDesde;
        private TextBox txtHasta;
        private GroupBox groupBox5;
        private Label lblDesdeHastaError;
        private Label label3;
        private Label label9;
        private DataGridViewTextBoxColumn gdOrden;
        private DataGridViewTextBoxColumn gdReloj;
        private DataGridViewTextBoxColumn gdEvento;
        private DataGridViewTextBoxColumn gdCliente;
        private DataGridViewTextBoxColumn gdCola;
        private DataGridViewTextBoxColumn gdRND;
        private DataGridViewTextBoxColumn gdTiempoEntreLlegadas;
        private DataGridViewTextBoxColumn gdTiempoProximaLlegada;
        private DataGridViewTextBoxColumn gdEstadoR1;
        private DataGridViewTextBoxColumn gdClienteR1;
        private DataGridViewTextBoxColumn gdTiempoAtencionR1;
        private DataGridViewTextBoxColumn gdTiempoProximaAtencionR1;
        private DataGridViewTextBoxColumn gdPrecioR1;
        private DataGridViewTextBoxColumn gdGastosR1;
        private DataGridViewTextBoxColumn gdEstadoR2;
        private DataGridViewTextBoxColumn gdClienteR2;
        private DataGridViewTextBoxColumn gdTiempoAtencionR2;
        private DataGridViewTextBoxColumn gdTiempoProximaAtencionR2;
        private DataGridViewTextBoxColumn gdPrecioR2;
        private DataGridViewTextBoxColumn gdGastosR2;
        private DataGridViewTextBoxColumn gdEstadoR3;
        private DataGridViewTextBoxColumn gdClienteR3;
        private DataGridViewTextBoxColumn gdTiempoAtencionR3;
        private DataGridViewTextBoxColumn gdTiempoProximaAtencionR3;
        private DataGridViewTextBoxColumn gdPrecioR3;
        private DataGridViewTextBoxColumn gdGastosR3;
    }
}

