namespace Ace_Super_Market.CapaPresentacionLocal
{
    partial class MenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bModificarCliente = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bCrearCliente = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.bModificarCliente);
            this.panel1.Controls.Add(this.bCrearCliente);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 491);
            this.panel1.TabIndex = 0;
            // 
            // bModificarCliente
            // 
            this.bModificarCliente.FlatAppearance.BorderSize = 0;
            this.bModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModificarCliente.Font = new System.Drawing.Font("Verdana", 12F);
            this.bModificarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bModificarCliente.ImageIndex = 0;
            this.bModificarCliente.ImageList = this.imageList1;
            this.bModificarCliente.Location = new System.Drawing.Point(3, 111);
            this.bModificarCliente.Name = "bModificarCliente";
            this.bModificarCliente.Size = new System.Drawing.Size(162, 53);
            this.bModificarCliente.TabIndex = 4;
            this.bModificarCliente.Text = "Listado de Clientes      ";
            this.bModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bModificarCliente.UseVisualStyleBackColor = true;
            this.bModificarCliente.Click += new System.EventHandler(this.bModificarCliente_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "boton_agregar.png");
            // 
            // bCrearCliente
            // 
            this.bCrearCliente.FlatAppearance.BorderSize = 0;
            this.bCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCrearCliente.Font = new System.Drawing.Font("Verdana", 12F);
            this.bCrearCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCrearCliente.ImageIndex = 0;
            this.bCrearCliente.ImageList = this.imageList1;
            this.bCrearCliente.Location = new System.Drawing.Point(3, 52);
            this.bCrearCliente.Name = "bCrearCliente";
            this.bCrearCliente.Size = new System.Drawing.Size(162, 53);
            this.bCrearCliente.TabIndex = 3;
            this.bCrearCliente.Text = "Crear Cliente";
            this.bCrearCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCrearCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bCrearCliente.UseVisualStyleBackColor = true;
            this.bCrearCliente.Click += new System.EventHandler(this.bCrearCliente_Click);
            // 
            // cerrar
            // 
            this.cerrar.Image = global::Ace_Super_Market.Properties.Resources.cerrar;
            this.cerrar.Location = new System.Drawing.Point(58, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(40, 40);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 2;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            this.cerrar.MouseEnter += new System.EventHandler(this.cerrar_MouseEnter);
            this.cerrar.MouseLeave += new System.EventHandler(this.cerrar_MouseLeave);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Crimson;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(168, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(540, 491);
            this.panelContenedor.TabIndex = 1;
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 491);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCrearCliente;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bModificarCliente;
        private System.Windows.Forms.Panel panelContenedor;
    }
}