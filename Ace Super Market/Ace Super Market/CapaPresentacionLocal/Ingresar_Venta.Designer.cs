namespace Ace_Super_Market.CapaPresentacionLocal
{
    partial class Ingresar_Venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.tventa = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.lid = new System.Windows.Forms.Label();
            this.lDirecion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodigoInterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoBarra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ltotal = new System.Windows.Forms.Label();
            this.livi = new System.Windows.Forms.Label();
            this.lmonto = new System.Windows.Forms.Label();
            this.tcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ttipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tunidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tventa)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1043, 40);
            this.panel1.TabIndex = 0;
            // 
            // cerrar
            // 
            this.cerrar.Image = global::Ace_Super_Market.Properties.Resources.cerrar;
            this.cerrar.Location = new System.Drawing.Point(53, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(35, 35);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 1;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            this.cerrar.MouseEnter += new System.EventHandler(this.cerrar_MouseEnter);
            this.cerrar.MouseLeave += new System.EventHandler(this.cerrar_MouseLeave);
            // 
            // minimizar
            // 
            this.minimizar.Image = global::Ace_Super_Market.Properties.Resources.minimizar;
            this.minimizar.Location = new System.Drawing.Point(12, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 35);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 1;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            this.minimizar.MouseEnter += new System.EventHandler(this.minimizar_MouseEnter);
            this.minimizar.MouseLeave += new System.EventHandler(this.minimizar_MouseLeave);
            // 
            // tventa
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tventa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tventa.BackgroundColor = System.Drawing.Color.Indigo;
            this.tventa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tventa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcodigo,
            this.tnombre,
            this.tprecio,
            this.tcantidad,
            this.ttotal,
            this.check,
            this.ttipoProducto,
            this.tunidadmedida});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tventa.DefaultCellStyle = dataGridViewCellStyle3;
            this.tventa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tventa.Location = new System.Drawing.Point(0, 0);
            this.tventa.Name = "tventa";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tventa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tventa.Size = new System.Drawing.Size(1043, 165);
            this.tventa.TabIndex = 1;
            this.tventa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tventa_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.lid);
            this.panel2.Controls.Add(this.lDirecion);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtCodigoInterno);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.textCliente);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtFecha);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.NFactura);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cCliente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.codigoBarra);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 154);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 12F);
            this.button3.Location = new System.Drawing.Point(715, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.Font = new System.Drawing.Font("Verdana", 12F);
            this.lid.Location = new System.Drawing.Point(455, 48);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(18, 18);
            this.lid.TabIndex = 19;
            this.lid.Text = "0";
            // 
            // lDirecion
            // 
            this.lDirecion.AutoSize = true;
            this.lDirecion.Font = new System.Drawing.Font("Verdana", 12F);
            this.lDirecion.Location = new System.Drawing.Point(12, 120);
            this.lDirecion.Name = "lDirecion";
            this.lDirecion.Size = new System.Drawing.Size(87, 18);
            this.lDirecion.TabIndex = 18;
            this.lDirecion.Text = "Direcion :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F);
            this.button2.Location = new System.Drawing.Point(585, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ingresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodigoInterno
            // 
            this.txtCodigoInterno.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCodigoInterno.Location = new System.Drawing.Point(501, 86);
            this.txtCodigoInterno.Name = "txtCodigoInterno";
            this.txtCodigoInterno.Size = new System.Drawing.Size(78, 27);
            this.txtCodigoInterno.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F);
            this.label6.Location = new System.Drawing.Point(367, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Codigo interno";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 12F);
            this.checkBox1.Location = new System.Drawing.Point(277, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 22);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Exonerar Cliente";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textCliente
            // 
            this.textCliente.Font = new System.Drawing.Font("Verdana", 12F);
            this.textCliente.Location = new System.Drawing.Point(80, 4);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(190, 27);
            this.textCliente.TabIndex = 14;
            this.textCliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F);
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Buscar";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtFecha.Location = new System.Drawing.Point(738, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(99, 27);
            this.txtFecha.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F);
            this.label4.Location = new System.Drawing.Point(677, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha";
            // 
            // NFactura
            // 
            this.NFactura.Enabled = false;
            this.NFactura.Font = new System.Drawing.Font("Verdana", 12F);
            this.NFactura.Location = new System.Drawing.Point(574, 4);
            this.NFactura.Name = "NFactura";
            this.NFactura.Size = new System.Drawing.Size(97, 27);
            this.NFactura.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(474, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "N° Factura";
            // 
            // cCliente
            // 
            this.cCliente.AutoCompleteCustomSource.AddRange(new string[] {
            "Nombre Cliente"});
            this.cCliente.Font = new System.Drawing.Font("Verdana", 12F);
            this.cCliente.FormattingEnabled = true;
            this.cCliente.Location = new System.Drawing.Point(80, 44);
            this.cCliente.Name = "cCliente";
            this.cCliente.Size = new System.Drawing.Size(359, 26);
            this.cCliente.TabIndex = 8;
            this.cCliente.Text = "Cliente Contado";
            this.cCliente.SelectedIndexChanged += new System.EventHandler(this.cCliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente";
            // 
            // codigoBarra
            // 
            this.codigoBarra.Font = new System.Drawing.Font("Verdana", 12F);
            this.codigoBarra.Location = new System.Drawing.Point(157, 86);
            this.codigoBarra.Name = "codigoBarra";
            this.codigoBarra.Size = new System.Drawing.Size(190, 27);
            this.codigoBarra.TabIndex = 6;
            this.codigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoBarra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de Barra";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Controls.Add(this.tventa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 194);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1043, 165);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Controls.Add(this.txtVuelto);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.ltotal);
            this.panel3.Controls.Add(this.livi);
            this.panel3.Controls.Add(this.lmonto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 109);
            this.panel3.TabIndex = 3;
            // 
            // txtVuelto
            // 
            this.txtVuelto.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtVuelto.Location = new System.Drawing.Point(499, 9);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(190, 27);
            this.txtVuelto.TabIndex = 20;
            this.txtVuelto.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F);
            this.label7.Location = new System.Drawing.Point(402, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Paga  Con:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F);
            this.button1.Location = new System.Drawing.Point(405, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generar Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ltotal
            // 
            this.ltotal.AutoSize = true;
            this.ltotal.Font = new System.Drawing.Font("Verdana", 12F);
            this.ltotal.Location = new System.Drawing.Point(728, 80);
            this.ltotal.Name = "ltotal";
            this.ltotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ltotal.Size = new System.Drawing.Size(61, 18);
            this.ltotal.TabIndex = 2;
            this.ltotal.Text = "Total :";
            // 
            // livi
            // 
            this.livi.AutoSize = true;
            this.livi.Font = new System.Drawing.Font("Verdana", 12F);
            this.livi.Location = new System.Drawing.Point(728, 51);
            this.livi.Name = "livi";
            this.livi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.livi.Size = new System.Drawing.Size(46, 18);
            this.livi.TabIndex = 1;
            this.livi.Text = "IVI :";
            // 
            // lmonto
            // 
            this.lmonto.AutoSize = true;
            this.lmonto.Font = new System.Drawing.Font("Verdana", 12F);
            this.lmonto.Location = new System.Drawing.Point(728, 23);
            this.lmonto.Name = "lmonto";
            this.lmonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lmonto.Size = new System.Drawing.Size(96, 18);
            this.lmonto.TabIndex = 0;
            this.lmonto.Text = "Subtotal  :";
            // 
            // tcodigo
            // 
            this.tcodigo.HeaderText = "Codigo";
            this.tcodigo.Name = "tcodigo";
            // 
            // tnombre
            // 
            this.tnombre.HeaderText = "Nombre Producto";
            this.tnombre.Name = "tnombre";
            this.tnombre.Width = 400;
            // 
            // tprecio
            // 
            this.tprecio.HeaderText = "Precio";
            this.tprecio.Name = "tprecio";
            this.tprecio.Width = 150;
            // 
            // tcantidad
            // 
            this.tcantidad.HeaderText = "Cantidad";
            this.tcantidad.Name = "tcantidad";
            // 
            // ttotal
            // 
            this.ttotal.HeaderText = "Total";
            this.ttotal.Name = "ttotal";
            this.ttotal.Width = 150;
            // 
            // check
            // 
            this.check.HeaderText = "check";
            this.check.Name = "check";
            this.check.Visible = false;
            // 
            // ttipoProducto
            // 
            this.ttipoProducto.HeaderText = "TP";
            this.ttipoProducto.Name = "ttipoProducto";
            // 
            // tunidadmedida
            // 
            this.tunidadmedida.HeaderText = "Unidad de Medida";
            this.tunidadmedida.Name = "tunidadmedida";
            this.tunidadmedida.Visible = false;
            // 
            // Ingresar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1043, 468);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Ingresar_Venta";
            this.Text = "Ingresar_Venta";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tventa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.DataGridView tventa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox codigoBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ltotal;
        private System.Windows.Forms.Label livi;
        private System.Windows.Forms.Label lmonto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NFactura;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCodigoInterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lDirecion;
        private System.Windows.Forms.Label lid;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tunidadmedida;
    }
}