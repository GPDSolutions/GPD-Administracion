namespace Ace_Super_Market.CapaPresentacionLocal
{
    partial class Listado_Finanzas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbfechaMovimiento = new System.Windows.Forms.Label();
            this.lbsaldo = new System.Windows.Forms.Label();
            this.lbFinanza = new System.Windows.Forms.Label();
            this.cTipoFinanza = new System.Windows.Forms.ComboBox();
            this.Exportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tFinanza = new System.Windows.Forms.DataGridView();
            this.tipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finanzaAfectada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFinanza)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1035, 40);
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
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cTipoFinanza);
            this.panel2.Controls.Add(this.Exportar);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 153);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbfechaMovimiento);
            this.groupBox1.Controls.Add(this.lbsaldo);
            this.groupBox1.Controls.Add(this.lbFinanza);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daatos generales de la Finanza";
            // 
            // lbfechaMovimiento
            // 
            this.lbfechaMovimiento.AutoSize = true;
            this.lbfechaMovimiento.Location = new System.Drawing.Point(623, 41);
            this.lbfechaMovimiento.Name = "lbfechaMovimiento";
            this.lbfechaMovimiento.Size = new System.Drawing.Size(181, 18);
            this.lbfechaMovimiento.TabIndex = 2;
            this.lbfechaMovimiento.Text = "Ultimo Movimiento : ";
            // 
            // lbsaldo
            // 
            this.lbsaldo.AutoSize = true;
            this.lbsaldo.Location = new System.Drawing.Point(376, 41);
            this.lbsaldo.Name = "lbsaldo";
            this.lbsaldo.Size = new System.Drawing.Size(72, 18);
            this.lbsaldo.TabIndex = 1;
            this.lbsaldo.Text = "Saldo : ";
            // 
            // lbFinanza
            // 
            this.lbFinanza.AutoSize = true;
            this.lbFinanza.Location = new System.Drawing.Point(49, 41);
            this.lbFinanza.Name = "lbFinanza";
            this.lbFinanza.Size = new System.Drawing.Size(84, 18);
            this.lbFinanza.TabIndex = 0;
            this.lbFinanza.Text = "Finanza :";
            // 
            // cTipoFinanza
            // 
            this.cTipoFinanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cTipoFinanza.Font = new System.Drawing.Font("Verdana", 12F);
            this.cTipoFinanza.FormattingEnabled = true;
            this.cTipoFinanza.Location = new System.Drawing.Point(228, 35);
            this.cTipoFinanza.Name = "cTipoFinanza";
            this.cTipoFinanza.Size = new System.Drawing.Size(255, 26);
            this.cTipoFinanza.TabIndex = 3;
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
            this.button1.Location = new System.Drawing.Point(511, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.tFinanza);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1035, 295);
            this.panel3.TabIndex = 4;
            // 
            // tFinanza
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tFinanza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tFinanza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tFinanza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoMovimiento,
            this.finanzaAfectada,
            this.montoMovimiento,
            this.razonMovimiento,
            this.usuarioMovimiento,
            this.fechaMovimiento});
            this.tFinanza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tFinanza.Location = new System.Drawing.Point(0, 0);
            this.tFinanza.MultiSelect = false;
            this.tFinanza.Name = "tFinanza";
            this.tFinanza.ReadOnly = true;
            this.tFinanza.Size = new System.Drawing.Size(1035, 295);
            this.tFinanza.TabIndex = 1;
            // 
            // tipoMovimiento
            // 
            this.tipoMovimiento.HeaderText = "Tipo Movimiento";
            this.tipoMovimiento.Name = "tipoMovimiento";
            this.tipoMovimiento.ReadOnly = true;
            // 
            // finanzaAfectada
            // 
            this.finanzaAfectada.HeaderText = "Fianaza Afectada";
            this.finanzaAfectada.Name = "finanzaAfectada";
            this.finanzaAfectada.ReadOnly = true;
            // 
            // montoMovimiento
            // 
            this.montoMovimiento.HeaderText = "Monto Movimiento";
            this.montoMovimiento.Name = "montoMovimiento";
            this.montoMovimiento.ReadOnly = true;
            // 
            // razonMovimiento
            // 
            this.razonMovimiento.HeaderText = "Razon Movimento";
            this.razonMovimiento.Name = "razonMovimiento";
            this.razonMovimiento.ReadOnly = true;
            this.razonMovimiento.Width = 380;
            // 
            // usuarioMovimiento
            // 
            this.usuarioMovimiento.HeaderText = "Usuario Movimiento";
            this.usuarioMovimiento.Name = "usuarioMovimiento";
            this.usuarioMovimiento.ReadOnly = true;
            // 
            // fechaMovimiento
            // 
            this.fechaMovimiento.HeaderText = "Fecha Movimiento";
            this.fechaMovimiento.Name = "fechaMovimiento";
            this.fechaMovimiento.ReadOnly = true;
            this.fechaMovimiento.Width = 200;
            // 
            // Listado_Finanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Listado_Finanzas";
            this.Text = "Listado_Finanzas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tFinanza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exportar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tFinanza;
        private System.Windows.Forms.ComboBox cTipoFinanza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbfechaMovimiento;
        private System.Windows.Forms.Label lbsaldo;
        private System.Windows.Forms.Label lbFinanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn finanzaAfectada;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaMovimiento;
    }
}