﻿namespace Ace_Super_Market.CapaPresentacionLocal
{
    partial class MenuAjustes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAjustes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.agregarProductos = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 437);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.agregarProductos);
            this.panel2.Controls.Add(this.cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 437);
            this.panel2.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "boton_agregar.png");
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Crimson;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(168, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(824, 437);
            this.panelContenedor.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(3, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Crear Respaldo DB";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(3, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modificar Usuario        ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agregarProductos
            // 
            this.agregarProductos.FlatAppearance.BorderSize = 0;
            this.agregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarProductos.Font = new System.Drawing.Font("Verdana", 12F);
            this.agregarProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.agregarProductos.ImageIndex = 0;
            this.agregarProductos.ImageList = this.imageList1;
            this.agregarProductos.Location = new System.Drawing.Point(3, 52);
            this.agregarProductos.Name = "agregarProductos";
            this.agregarProductos.Size = new System.Drawing.Size(162, 53);
            this.agregarProductos.TabIndex = 1;
            this.agregarProductos.Text = "Crear Usuario";
            this.agregarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.agregarProductos.UseVisualStyleBackColor = true;
            this.agregarProductos.Click += new System.EventHandler(this.agregarProductos_Click);
            // 
            // cerrar
            // 
            this.cerrar.Image = global::Ace_Super_Market.Properties.Resources.cerrar;
            this.cerrar.Location = new System.Drawing.Point(58, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(40, 40);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            this.cerrar.MouseEnter += new System.EventHandler(this.cerrar_MouseEnter);
            this.cerrar.MouseLeave += new System.EventHandler(this.cerrar_MouseLeave);
            // 
            // MenuAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 437);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "MenuAjustes";
            this.Text = "MenuAjustes";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button agregarProductos;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}