namespace Ace_Super_Market.CapaPresentacionLocal
{
    partial class Modificar_Usuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_Usuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modificarContrasenna = new System.Windows.Forms.CheckBox();
            this.modificarUsuario = new System.Windows.Forms.Button();
            this.bAjustes = new System.Windows.Forms.GroupBox();
            this.cModificarUsuario = new System.Windows.Forms.CheckBox();
            this.cCrearUsuario = new System.Windows.Forms.CheckBox();
            this.bInventario = new System.Windows.Forms.GroupBox();
            this.cIngresarProductos = new System.Windows.Forms.CheckBox();
            this.bVenta = new System.Windows.Forms.GroupBox();
            this.cIngresarVenta = new System.Windows.Forms.CheckBox();
            this.bPrincipal = new System.Windows.Forms.GroupBox();
            this.cReportes = new System.Windows.Forms.CheckBox();
            this.cClientes = new System.Windows.Forms.CheckBox();
            this.cAjustes = new System.Windows.Forms.CheckBox();
            this.cInventario = new System.Windows.Forms.CheckBox();
            this.cVenta = new System.Windows.Forms.CheckBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cFinanzas = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bAjustes.SuspendLayout();
            this.bInventario.SuspendLayout();
            this.bVenta.SuspendLayout();
            this.bPrincipal.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(954, 40);
            this.panel1.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 496);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Controls.Add(this.modificarContrasenna);
            this.panel3.Controls.Add(this.modificarUsuario);
            this.panel3.Controls.Add(this.bAjustes);
            this.panel3.Controls.Add(this.bInventario);
            this.panel3.Controls.Add(this.bVenta);
            this.panel3.Controls.Add(this.bPrincipal);
            this.panel3.Controls.Add(this.usuario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.nombreUsuario);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 496);
            this.panel3.TabIndex = 4;
            // 
            // modificarContrasenna
            // 
            this.modificarContrasenna.AutoSize = true;
            this.modificarContrasenna.Font = new System.Drawing.Font("Verdana", 12F);
            this.modificarContrasenna.Location = new System.Drawing.Point(186, 119);
            this.modificarContrasenna.Name = "modificarContrasenna";
            this.modificarContrasenna.Size = new System.Drawing.Size(196, 22);
            this.modificarContrasenna.TabIndex = 21;
            this.modificarContrasenna.Text = "Reiniciar Contraseña";
            this.modificarContrasenna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modificarContrasenna.UseVisualStyleBackColor = true;
            // 
            // modificarUsuario
            // 
            this.modificarUsuario.Font = new System.Drawing.Font("Verdana", 12F);
            this.modificarUsuario.Location = new System.Drawing.Point(659, 105);
            this.modificarUsuario.Name = "modificarUsuario";
            this.modificarUsuario.Size = new System.Drawing.Size(127, 49);
            this.modificarUsuario.TabIndex = 20;
            this.modificarUsuario.Text = "Modificar Usuario";
            this.modificarUsuario.UseVisualStyleBackColor = true;
            this.modificarUsuario.Click += new System.EventHandler(this.modificarUsuario_Click);
            // 
            // bAjustes
            // 
            this.bAjustes.Controls.Add(this.cModificarUsuario);
            this.bAjustes.Controls.Add(this.cCrearUsuario);
            this.bAjustes.Enabled = false;
            this.bAjustes.Location = new System.Drawing.Point(652, 172);
            this.bAjustes.Name = "bAjustes";
            this.bAjustes.Size = new System.Drawing.Size(190, 274);
            this.bAjustes.TabIndex = 19;
            this.bAjustes.TabStop = false;
            this.bAjustes.Text = "Ajustes";
            // 
            // cModificarUsuario
            // 
            this.cModificarUsuario.AutoSize = true;
            this.cModificarUsuario.Font = new System.Drawing.Font("Verdana", 12F);
            this.cModificarUsuario.Location = new System.Drawing.Point(6, 59);
            this.cModificarUsuario.Name = "cModificarUsuario";
            this.cModificarUsuario.Size = new System.Drawing.Size(168, 22);
            this.cModificarUsuario.TabIndex = 6;
            this.cModificarUsuario.Text = "Modificar Usuario";
            this.cModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // cCrearUsuario
            // 
            this.cCrearUsuario.AutoSize = true;
            this.cCrearUsuario.Font = new System.Drawing.Font("Verdana", 12F);
            this.cCrearUsuario.Location = new System.Drawing.Point(6, 31);
            this.cCrearUsuario.Name = "cCrearUsuario";
            this.cCrearUsuario.Size = new System.Drawing.Size(138, 22);
            this.cCrearUsuario.TabIndex = 5;
            this.cCrearUsuario.Text = "Crear Usuario";
            this.cCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // bInventario
            // 
            this.bInventario.Controls.Add(this.cIngresarProductos);
            this.bInventario.Enabled = false;
            this.bInventario.Location = new System.Drawing.Point(438, 172);
            this.bInventario.Name = "bInventario";
            this.bInventario.Size = new System.Drawing.Size(196, 274);
            this.bInventario.TabIndex = 18;
            this.bInventario.TabStop = false;
            this.bInventario.Text = "Inventario";
            // 
            // cIngresarProductos
            // 
            this.cIngresarProductos.AutoSize = true;
            this.cIngresarProductos.Font = new System.Drawing.Font("Verdana", 12F);
            this.cIngresarProductos.Location = new System.Drawing.Point(4, 31);
            this.cIngresarProductos.Name = "cIngresarProductos";
            this.cIngresarProductos.Size = new System.Drawing.Size(181, 22);
            this.cIngresarProductos.TabIndex = 4;
            this.cIngresarProductos.Text = "Ingresar Productos";
            this.cIngresarProductos.UseVisualStyleBackColor = true;
            // 
            // bVenta
            // 
            this.bVenta.Controls.Add(this.cIngresarVenta);
            this.bVenta.Enabled = false;
            this.bVenta.Location = new System.Drawing.Point(254, 172);
            this.bVenta.Name = "bVenta";
            this.bVenta.Size = new System.Drawing.Size(156, 274);
            this.bVenta.TabIndex = 17;
            this.bVenta.TabStop = false;
            this.bVenta.Text = "Venta";
            // 
            // cIngresarVenta
            // 
            this.cIngresarVenta.AutoSize = true;
            this.cIngresarVenta.Font = new System.Drawing.Font("Verdana", 12F);
            this.cIngresarVenta.Location = new System.Drawing.Point(5, 31);
            this.cIngresarVenta.Name = "cIngresarVenta";
            this.cIngresarVenta.Size = new System.Drawing.Size(148, 22);
            this.cIngresarVenta.TabIndex = 3;
            this.cIngresarVenta.Text = "Ingresar Venta";
            this.cIngresarVenta.UseVisualStyleBackColor = true;
            // 
            // bPrincipal
            // 
            this.bPrincipal.Controls.Add(this.cFinanzas);
            this.bPrincipal.Controls.Add(this.cReportes);
            this.bPrincipal.Controls.Add(this.cClientes);
            this.bPrincipal.Controls.Add(this.cAjustes);
            this.bPrincipal.Controls.Add(this.cInventario);
            this.bPrincipal.Controls.Add(this.cVenta);
            this.bPrincipal.Enabled = false;
            this.bPrincipal.Location = new System.Drawing.Point(80, 172);
            this.bPrincipal.Name = "bPrincipal";
            this.bPrincipal.Size = new System.Drawing.Size(150, 274);
            this.bPrincipal.TabIndex = 16;
            this.bPrincipal.TabStop = false;
            this.bPrincipal.Text = "Principal";
            // 
            // cReportes
            // 
            this.cReportes.AutoSize = true;
            this.cReportes.Font = new System.Drawing.Font("Verdana", 12F);
            this.cReportes.Location = new System.Drawing.Point(6, 143);
            this.cReportes.Name = "cReportes";
            this.cReportes.Size = new System.Drawing.Size(100, 22);
            this.cReportes.TabIndex = 4;
            this.cReportes.Text = "Reportes";
            this.cReportes.UseVisualStyleBackColor = true;
            // 
            // cClientes
            // 
            this.cClientes.AutoSize = true;
            this.cClientes.Font = new System.Drawing.Font("Verdana", 12F);
            this.cClientes.Location = new System.Drawing.Point(6, 115);
            this.cClientes.Name = "cClientes";
            this.cClientes.Size = new System.Drawing.Size(94, 22);
            this.cClientes.TabIndex = 3;
            this.cClientes.Text = "Clientes";
            this.cClientes.UseVisualStyleBackColor = true;
            // 
            // cAjustes
            // 
            this.cAjustes.AutoSize = true;
            this.cAjustes.Font = new System.Drawing.Font("Verdana", 12F);
            this.cAjustes.Location = new System.Drawing.Point(7, 87);
            this.cAjustes.Name = "cAjustes";
            this.cAjustes.Size = new System.Drawing.Size(89, 22);
            this.cAjustes.TabIndex = 2;
            this.cAjustes.Text = "Ajustes";
            this.cAjustes.UseVisualStyleBackColor = true;
            // 
            // cInventario
            // 
            this.cInventario.AutoSize = true;
            this.cInventario.Font = new System.Drawing.Font("Verdana", 12F);
            this.cInventario.Location = new System.Drawing.Point(6, 59);
            this.cInventario.Name = "cInventario";
            this.cInventario.Size = new System.Drawing.Size(111, 22);
            this.cInventario.TabIndex = 1;
            this.cInventario.Text = "Inventario";
            this.cInventario.UseVisualStyleBackColor = true;
            // 
            // cVenta
            // 
            this.cVenta.AutoSize = true;
            this.cVenta.Font = new System.Drawing.Font("Verdana", 12F);
            this.cVenta.Location = new System.Drawing.Point(7, 31);
            this.cVenta.Name = "cVenta";
            this.cVenta.Size = new System.Drawing.Size(74, 22);
            this.cVenta.TabIndex = 0;
            this.cVenta.Text = "Venta";
            this.cVenta.UseVisualStyleBackColor = true;
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Verdana", 12F);
            this.usuario.Location = new System.Drawing.Point(207, 23);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(136, 27);
            this.usuario.TabIndex = 1;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(111, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.Font = new System.Drawing.Font("Verdana", 12F);
            this.nombreUsuario.Location = new System.Drawing.Point(186, 70);
            this.nombreUsuario.MaximumSize = new System.Drawing.Size(461, 27);
            this.nombreUsuario.MinimumSize = new System.Drawing.Size(461, 27);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(461, 27);
            this.nombreUsuario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(110, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ver.png");
            this.imageList1.Images.SetKeyName(1, "ocultar.png");
            // 
            // cFinanzas
            // 
            this.cFinanzas.AutoSize = true;
            this.cFinanzas.Font = new System.Drawing.Font("Verdana", 12F);
            this.cFinanzas.Location = new System.Drawing.Point(6, 171);
            this.cFinanzas.Name = "cFinanzas";
            this.cFinanzas.Size = new System.Drawing.Size(99, 22);
            this.cFinanzas.TabIndex = 5;
            this.cFinanzas.Text = "Finanzas";
            this.cFinanzas.UseVisualStyleBackColor = true;
            // 
            // Modificar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Modificar_Usuario";
            this.Text = "Modificar_Usuario";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.bAjustes.ResumeLayout(false);
            this.bAjustes.PerformLayout();
            this.bInventario.ResumeLayout(false);
            this.bInventario.PerformLayout();
            this.bVenta.ResumeLayout(false);
            this.bVenta.PerformLayout();
            this.bPrincipal.ResumeLayout(false);
            this.bPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button modificarUsuario;
        private System.Windows.Forms.GroupBox bAjustes;
        private System.Windows.Forms.CheckBox cModificarUsuario;
        private System.Windows.Forms.CheckBox cCrearUsuario;
        private System.Windows.Forms.GroupBox bInventario;
        private System.Windows.Forms.CheckBox cIngresarProductos;
        private System.Windows.Forms.GroupBox bVenta;
        private System.Windows.Forms.CheckBox cIngresarVenta;
        private System.Windows.Forms.GroupBox bPrincipal;
        private System.Windows.Forms.CheckBox cAjustes;
        private System.Windows.Forms.CheckBox cInventario;
        private System.Windows.Forms.CheckBox cVenta;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox modificarContrasenna;
        private System.Windows.Forms.CheckBox cClientes;
        private System.Windows.Forms.CheckBox cReportes;
        private System.Windows.Forms.CheckBox cFinanzas;
    }
}