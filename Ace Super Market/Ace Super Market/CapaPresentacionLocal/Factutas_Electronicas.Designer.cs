namespace Ace_Super_Market.CapaPresentacionLocal
{
    partial class Factutas_Electronicas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tblDatosFactura = new System.Windows.Forms.DataGridView();
            this.testado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tclave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttipoidentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnumerocedulaemisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tfechaemisiondoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdetallemensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmontototalimpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttotalfactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnumerocedulareceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnumeroconsecutivoreceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnombrecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcorerocliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.rdbPendientes = new System.Windows.Forms.RadioButton();
            this.rdbAceptadas = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCorreoEmisor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNumConsecutivo = new System.Windows.Forms.TextBox();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.txtTotalImpuesto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCedulaReceptor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDetalleMensaje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMensaje = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaEmisor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreEmisor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedulaEmisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosFactura)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 40);
            this.panel1.TabIndex = 3;
            // 
            // cerrar
            // 
            this.cerrar.Image = global::Ace_Super_Market.Properties.Resources.cerrar;
            this.cerrar.Location = new System.Drawing.Point(55, 2);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(35, 35);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 2;
            this.cerrar.TabStop = false;
            // 
            // minimizar
            // 
            this.minimizar.Image = global::Ace_Super_Market.Properties.Resources.minimizar;
            this.minimizar.Location = new System.Drawing.Point(14, 2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 35);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 3;
            this.minimizar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.tblDatosFactura);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1151, 229);
            this.panel3.TabIndex = 5;
            // 
            // tblDatosFactura
            // 
            this.tblDatosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDatosFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testado,
            this.tclave,
            this.ttipoidentificacion,
            this.tnumerocedulaemisor,
            this.tfechaemisiondoc,
            this.tmensaje,
            this.tdetallemensaje,
            this.tmontototalimpuesto,
            this.ttotalfactura,
            this.tnumerocedulareceptor,
            this.tnumeroconsecutivoreceptor,
            this.tnombrecliente,
            this.tcorerocliente,
            this.check});
            this.tblDatosFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDatosFactura.Location = new System.Drawing.Point(0, 0);
            this.tblDatosFactura.Name = "tblDatosFactura";
            this.tblDatosFactura.Size = new System.Drawing.Size(715, 229);
            this.tblDatosFactura.TabIndex = 1;
            // 
            // testado
            // 
            this.testado.HeaderText = "Estado";
            this.testado.Name = "testado";
            // 
            // tclave
            // 
            this.tclave.HeaderText = "Clave";
            this.tclave.Name = "tclave";
            // 
            // ttipoidentificacion
            // 
            this.ttipoidentificacion.HeaderText = "Tipo Identificacion";
            this.ttipoidentificacion.Name = "ttipoidentificacion";
            // 
            // tnumerocedulaemisor
            // 
            this.tnumerocedulaemisor.HeaderText = "Numero Cedula Emisor";
            this.tnumerocedulaemisor.Name = "tnumerocedulaemisor";
            // 
            // tfechaemisiondoc
            // 
            this.tfechaemisiondoc.HeaderText = "Fecha Emision Doc";
            this.tfechaemisiondoc.Name = "tfechaemisiondoc";
            // 
            // tmensaje
            // 
            this.tmensaje.HeaderText = "Mensaje";
            this.tmensaje.Name = "tmensaje";
            // 
            // tdetallemensaje
            // 
            this.tdetallemensaje.HeaderText = "Detalle Mensaje";
            this.tdetallemensaje.Name = "tdetallemensaje";
            // 
            // tmontototalimpuesto
            // 
            this.tmontototalimpuesto.HeaderText = "Monto Total Impuesto";
            this.tmontototalimpuesto.Name = "tmontototalimpuesto";
            // 
            // ttotalfactura
            // 
            this.ttotalfactura.HeaderText = "Total Factura";
            this.ttotalfactura.Name = "ttotalfactura";
            // 
            // tnumerocedulareceptor
            // 
            this.tnumerocedulareceptor.HeaderText = "Numero Cedula Receptor";
            this.tnumerocedulareceptor.Name = "tnumerocedulareceptor";
            // 
            // tnumeroconsecutivoreceptor
            // 
            this.tnumeroconsecutivoreceptor.HeaderText = "Numero Consecutivo Receptor";
            this.tnumeroconsecutivoreceptor.Name = "tnumeroconsecutivoreceptor";
            // 
            // tnombrecliente
            // 
            this.tnombrecliente.HeaderText = "Nombre Cliente";
            this.tnombrecliente.Name = "tnombrecliente";
            // 
            // tcorerocliente
            // 
            this.tcorerocliente.HeaderText = "Correo Cliente";
            this.tcorerocliente.Name = "tcorerocliente";
            // 
            // check
            // 
            this.check.HeaderText = "check";
            this.check.Name = "check";
            this.check.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel4.Controls.Add(this.btnProcesar);
            this.panel4.Controls.Add(this.rdbPendientes);
            this.panel4.Controls.Add(this.rdbAceptadas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(715, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 229);
            this.panel4.TabIndex = 0;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Enabled = false;
            this.btnProcesar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(55, 99);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(251, 33);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // rdbPendientes
            // 
            this.rdbPendientes.AutoSize = true;
            this.rdbPendientes.Font = new System.Drawing.Font("Verdana", 12F);
            this.rdbPendientes.Location = new System.Drawing.Point(189, 47);
            this.rdbPendientes.Name = "rdbPendientes";
            this.rdbPendientes.Size = new System.Drawing.Size(117, 22);
            this.rdbPendientes.TabIndex = 1;
            this.rdbPendientes.TabStop = true;
            this.rdbPendientes.Text = "Pendientes";
            this.rdbPendientes.UseVisualStyleBackColor = true;
            this.rdbPendientes.CheckedChanged += new System.EventHandler(this.rdbPendientes_CheckedChanged);
            // 
            // rdbAceptadas
            // 
            this.rdbAceptadas.AutoSize = true;
            this.rdbAceptadas.Font = new System.Drawing.Font("Verdana", 12F);
            this.rdbAceptadas.Location = new System.Drawing.Point(55, 47);
            this.rdbAceptadas.Name = "rdbAceptadas";
            this.rdbAceptadas.Size = new System.Drawing.Size(111, 22);
            this.rdbAceptadas.TabIndex = 0;
            this.rdbAceptadas.TabStop = true;
            this.rdbAceptadas.Text = "Aceptadas";
            this.rdbAceptadas.UseVisualStyleBackColor = true;
            this.rdbAceptadas.CheckedChanged += new System.EventHandler(this.rdbAceptadas_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.txtCorreoEmisor);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmbTipoIdentificacion);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtNumConsecutivo);
            this.panel2.Controls.Add(this.txtTotalFactura);
            this.panel2.Controls.Add(this.txtTotalImpuesto);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtCedulaReceptor);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDetalleMensaje);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbMensaje);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtFechaEmisor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNombreEmisor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCedulaEmisor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtClave);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtRutaArchivo);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 362);
            this.panel2.TabIndex = 4;
            // 
            // txtCorreoEmisor
            // 
            this.txtCorreoEmisor.Enabled = false;
            this.txtCorreoEmisor.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCorreoEmisor.Location = new System.Drawing.Point(223, 267);
            this.txtCorreoEmisor.Name = "txtCorreoEmisor";
            this.txtCorreoEmisor.Size = new System.Drawing.Size(220, 27);
            this.txtCorreoEmisor.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F);
            this.label13.Location = new System.Drawing.Point(46, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Correo Emisor";
            // 
            // cmbTipoIdentificacion
            // 
            this.cmbTipoIdentificacion.Enabled = false;
            this.cmbTipoIdentificacion.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbTipoIdentificacion.FormattingEnabled = true;
            this.cmbTipoIdentificacion.Items.AddRange(new object[] {
            "Fisica",
            "Juridica",
            "DIMEX",
            "NITE"});
            this.cmbTipoIdentificacion.Location = new System.Drawing.Point(223, 84);
            this.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion";
            this.cmbTipoIdentificacion.Size = new System.Drawing.Size(141, 26);
            this.cmbTipoIdentificacion.TabIndex = 24;
            this.cmbTipoIdentificacion.Text = "Fisica";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F);
            this.label11.Location = new System.Drawing.Point(45, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tipo Identificacion";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(696, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 27);
            this.button2.TabIndex = 22;
            this.button2.Text = "Validar Y Registrar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNumConsecutivo
            // 
            this.txtNumConsecutivo.Enabled = false;
            this.txtNumConsecutivo.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNumConsecutivo.Location = new System.Drawing.Point(747, 168);
            this.txtNumConsecutivo.Name = "txtNumConsecutivo";
            this.txtNumConsecutivo.Size = new System.Drawing.Size(220, 27);
            this.txtNumConsecutivo.TabIndex = 21;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Enabled = false;
            this.txtTotalFactura.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtTotalFactura.Location = new System.Drawing.Point(747, 131);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(220, 27);
            this.txtTotalFactura.TabIndex = 20;
            // 
            // txtTotalImpuesto
            // 
            this.txtTotalImpuesto.Enabled = false;
            this.txtTotalImpuesto.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtTotalImpuesto.Location = new System.Drawing.Point(747, 91);
            this.txtTotalImpuesto.Name = "txtTotalImpuesto";
            this.txtTotalImpuesto.Size = new System.Drawing.Size(220, 27);
            this.txtTotalImpuesto.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F);
            this.label10.Location = new System.Drawing.Point(591, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Num Consecutivo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F);
            this.label9.Location = new System.Drawing.Point(587, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = " Total Factura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F);
            this.label8.Location = new System.Drawing.Point(587, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = " Total Impuesto";
            // 
            // txtCedulaReceptor
            // 
            this.txtCedulaReceptor.Enabled = false;
            this.txtCedulaReceptor.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCedulaReceptor.Location = new System.Drawing.Point(747, 51);
            this.txtCedulaReceptor.Name = "txtCedulaReceptor";
            this.txtCedulaReceptor.Size = new System.Drawing.Size(220, 27);
            this.txtCedulaReceptor.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F);
            this.label7.Location = new System.Drawing.Point(587, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cedula Receptor";
            // 
            // txtDetalleMensaje
            // 
            this.txtDetalleMensaje.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtDetalleMensaje.Location = new System.Drawing.Point(223, 307);
            this.txtDetalleMensaje.Multiline = true;
            this.txtDetalleMensaje.Name = "txtDetalleMensaje";
            this.txtDetalleMensaje.Size = new System.Drawing.Size(317, 49);
            this.txtDetalleMensaje.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F);
            this.label6.Location = new System.Drawing.Point(45, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Detalle Mensaje";
            // 
            // cmbMensaje
            // 
            this.cmbMensaje.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbMensaje.FormattingEnabled = true;
            this.cmbMensaje.Items.AddRange(new object[] {
            "Aceptado",
            "Aceptado Parcialmente",
            "Rechazado"});
            this.cmbMensaje.Location = new System.Drawing.Point(223, 231);
            this.cmbMensaje.Name = "cmbMensaje";
            this.cmbMensaje.Size = new System.Drawing.Size(141, 26);
            this.cmbMensaje.TabIndex = 11;
            this.cmbMensaje.Text = "Aceptado";
            this.cmbMensaje.SelectedIndexChanged += new System.EventHandler(this.cmbMensaje_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F);
            this.label5.Location = new System.Drawing.Point(45, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mensaje";
            // 
            // txtFechaEmisor
            // 
            this.txtFechaEmisor.Enabled = false;
            this.txtFechaEmisor.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtFechaEmisor.Location = new System.Drawing.Point(223, 194);
            this.txtFechaEmisor.Name = "txtFechaEmisor";
            this.txtFechaEmisor.Size = new System.Drawing.Size(272, 27);
            this.txtFechaEmisor.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F);
            this.label4.Location = new System.Drawing.Point(45, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Emisor";
            // 
            // txtNombreEmisor
            // 
            this.txtNombreEmisor.Enabled = false;
            this.txtNombreEmisor.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNombreEmisor.Location = new System.Drawing.Point(223, 158);
            this.txtNombreEmisor.Name = "txtNombreEmisor";
            this.txtNombreEmisor.Size = new System.Drawing.Size(168, 27);
            this.txtNombreEmisor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(45, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Emisor";
            // 
            // txtCedulaEmisor
            // 
            this.txtCedulaEmisor.Enabled = false;
            this.txtCedulaEmisor.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCedulaEmisor.Location = new System.Drawing.Point(223, 120);
            this.txtCedulaEmisor.Name = "txtCedulaEmisor";
            this.txtCedulaEmisor.Size = new System.Drawing.Size(168, 27);
            this.txtCedulaEmisor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(45, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cedula Emisor";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtClave.Location = new System.Drawing.Point(223, 51);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(317, 27);
            this.txtClave.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clave Documento";
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtRutaArchivo.Location = new System.Drawing.Point(325, 6);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(404, 27);
            this.txtRutaArchivo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(754, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Factutas_Electronicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Factutas_Electronicas";
            this.Text = "Factutas_Electronicas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosFactura)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEmisor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedulaEmisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedulaReceptor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDetalleMensaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMensaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaEmisor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNumConsecutivo;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.TextBox txtTotalImpuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView tblDatosFactura;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbPendientes;
        private System.Windows.Forms.RadioButton rdbAceptadas;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cmbTipoIdentificacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCorreoEmisor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn testado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tclave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttipoidentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnumerocedulaemisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tfechaemisiondoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdetallemensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmontototalimpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttotalfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnumerocedulareceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnumeroconsecutivoreceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnombrecliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcorerocliente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}