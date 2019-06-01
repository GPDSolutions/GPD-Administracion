﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaPresentacionLocal
{
    public partial class MenuAjustes : Form
    {
        public MenuAjustes()
        {
            InitializeComponent();
        }

        private void abrirForm<myForm>() where myForm : Form, new()
        {
            Form openForm;
            openForm = panelContenedor.Controls.OfType<myForm>().FirstOrDefault();

            if (openForm == null)
            {
                openForm = new myForm();
                openForm.Text = "Ajustes";
                openForm.TopLevel = false;
                openForm.FormBorderStyle = FormBorderStyle.None;
                openForm.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(openForm);
                panelContenedor.Tag = openForm;
                openForm.Show();
                openForm.BringToFront();

            }
            else
            {
                openForm.BringToFront();
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrar_MouseEnter(object sender, EventArgs e)
        {
            this.cerrar.Image = ((System.Drawing.Image)(Properties.Resources.cerrar_over));
        }

        private void cerrar_MouseLeave(object sender, EventArgs e)
        {
            this.cerrar.Image = ((System.Drawing.Image)(Properties.Resources.cerrar));
        }

        private void agregarProductos_Click(object sender, EventArgs e)
        {
            abrirForm<Crear_Usuario>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm<Modificar_Usuario>();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}

