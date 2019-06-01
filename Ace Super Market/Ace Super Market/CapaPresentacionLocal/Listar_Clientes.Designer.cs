namespace Ace_Super_Market.CapaPresentacionLocal
{
    partial class Listar_Clientes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tClientes = new System.Windows.Forms.DataGridView();
            this.tidCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tidentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttipoidentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcodigoClienteF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tClientes)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(971, 40);
            this.panel1.TabIndex = 2;
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
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click_1);
            this.cerrar.MouseEnter += new System.EventHandler(this.cerrar_MouseEnter);
            this.cerrar.MouseLeave += new System.EventHandler(this.cerrar_MouseLeave);
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
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            this.minimizar.MouseEnter += new System.EventHandler(this.minimizar_MouseEnter);
            this.minimizar.MouseLeave += new System.EventHandler(this.minimizar_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.Exportar);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 93);
            this.panel2.TabIndex = 3;
            // 
            // Exportar
            // 
            this.Exportar.Font = new System.Drawing.Font("Verdana", 12F);
            this.Exportar.Location = new System.Drawing.Point(629, 34);
            this.Exportar.Name = "Exportar";
            this.Exportar.Size = new System.Drawing.Size(112, 27);
            this.Exportar.TabIndex = 2;
            this.Exportar.Text = "Exportar";
            this.Exportar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F);
            this.button1.Location = new System.Drawing.Point(511, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Recargar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(86, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(418, 27);
            this.txtBuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.tClientes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 288);
            this.panel3.TabIndex = 4;
            // 
            // tClientes
            // 
            this.tClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tidCliente,
            this.tnombreCliente,
            this.tidentificacion,
            this.ttipoidentificacion,
            this.ttelefono,
            this.tdireccion,
            this.temail,
            this.tcodigoClienteF});
            this.tClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tClientes.Location = new System.Drawing.Point(0, 0);
            this.tClientes.MultiSelect = false;
            this.tClientes.Name = "tClientes";
            this.tClientes.ReadOnly = true;
            this.tClientes.Size = new System.Drawing.Size(971, 288);
            this.tClientes.TabIndex = 1;
            this.tClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tProductos_CellContentClick);
            // 
            // tidCliente
            // 
            this.tidCliente.HeaderText = "ID Cliente";
            this.tidCliente.Name = "tidCliente";
            this.tidCliente.ReadOnly = true;
            // 
            // tnombreCliente
            // 
            this.tnombreCliente.HeaderText = "Nombre Cliente";
            this.tnombreCliente.Name = "tnombreCliente";
            this.tnombreCliente.ReadOnly = true;
            // 
            // tidentificacion
            // 
            this.tidentificacion.HeaderText = "Identificacion";
            this.tidentificacion.Name = "tidentificacion";
            this.tidentificacion.ReadOnly = true;
            // 
            // ttipoidentificacion
            // 
            this.ttipoidentificacion.HeaderText = "Tipo de Identificacion";
            this.ttipoidentificacion.Name = "ttipoidentificacion";
            this.ttipoidentificacion.ReadOnly = true;
            // 
            // ttelefono
            // 
            this.ttelefono.HeaderText = "Telefono";
            this.ttelefono.Name = "ttelefono";
            this.ttelefono.ReadOnly = true;
            // 
            // tdireccion
            // 
            this.tdireccion.HeaderText = "Direccion";
            this.tdireccion.Name = "tdireccion";
            this.tdireccion.ReadOnly = true;
            // 
            // temail
            // 
            this.temail.HeaderText = "Email";
            this.temail.Name = "temail";
            this.temail.ReadOnly = true;
            // 
            // tcodigoClienteF
            // 
            this.tcodigoClienteF.HeaderText = "Codigo Cliente Facel";
            this.tcodigoClienteF.Name = "tcodigoClienteF";
            this.tcodigoClienteF.ReadOnly = true;
            // 
            // Listar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 421);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Listar_Clientes";
            this.Text = "Listar_Clientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exportar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttipoidentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn temail;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcodigoClienteF;
    }
}