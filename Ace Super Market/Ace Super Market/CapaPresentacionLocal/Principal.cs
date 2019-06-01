using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Ace_Super_Market.CapaPresentacionLocal
{
    public partial class Principal : Form
    {
        public static String usuarioActual;
        public Principal()
        {
            InitializeComponent();
            timer1.Enabled = true;
            
        }

        public void setnombreUsuario(String pnombreUsuario)
        {
            Dictionary<string, string> Ddatos = new Dictionary<string, string>();
            List<Dictionary<string, string>> Lproductos = new List<Dictionary<string, string>>();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            usuarioActual = pnombreUsuario;
            cargarroles();

            

            Ddatos = objG.getDatos();

            lcantidadProductos.Text = Ddatos["Productos"];
            lcantidadEmpleados.Text = Ddatos["Usuarios"];
            lcantidadClientes.Text = Ddatos["Clientes"];

            Lproductos = objG.listarProductos();
            Ddatos.Clear();

            for (int a = 0; a < Lproductos.Count; a++)
            {
                Ddatos = Lproductos[a];
                if (double.Parse(Ddatos["Cantidad"]) <= 3)
                {                  
                    tProductos.Rows.Add(Ddatos["NombreProducto"], Ddatos["Codigo"], Ddatos["Cantidad"]);
                }

            }

        }
        
        public String getnombreUsuario()
        {
            return usuarioActual;
        }

        private void cargarroles()
        {
            CapaLogica.gestor objG = new CapaLogica.gestor();
            Dictionary<string, string> Dusuario = new Dictionary<string, string>();
            Dusuario = objG.buscarUsuario(usuarioActual);
            String[] rol = Dusuario["rol"].Split(',');

            label1.Text = "Usuario: "+ Dusuario["nombreUsuario"];
            if (rol[0].Equals("0"))
            {
               
                button1.Enabled = false;
            }
             if (rol[1].Equals("0"))
            {
                
                button2.Enabled = false;
            }
             if (rol[2].Equals("0"))
            {
                
                button3.Enabled = false;
            }
            if (rol[3].Equals("0"))
            {
                button4.Enabled = false;
            }
            if (rol[4].Equals("0"))
            {
                button5.Enabled = false;
            }
            if (rol[5].Equals("0"))
            {
                button6.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label2.Text = DateTime.Now.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar_MouseEnter(object sender, EventArgs e)
        {
            this.cerrar.Image = ((System.Drawing.Image)(Properties.Resources.cerrar_over));
        }

        private void cerrar_MouseLeave(object sender, EventArgs e)
        {
            this.cerrar.Image = ((System.Drawing.Image)(Properties.Resources.cerrar));
        }

        private void minimizar_MouseEnter(object sender, EventArgs e)
        {
            this.minimizar.Image = ((System.Drawing.Image)(Properties.Resources.minimizar_over));
        }

        private void minimizar_MouseLeave(object sender, EventArgs e)
        {
            this.minimizar.Image = ((System.Drawing.Image)(Properties.Resources.minimizar));
        }


        private void abrirForm<myForm>() where myForm : Form, new()
        {
            Form openForm ;
            openForm = panelPrincipal.Controls.OfType<myForm>().FirstOrDefault();

            if (openForm == null)
            {
                openForm = new myForm();
                openForm.Text = "dd";
                openForm.TopLevel = false;
                openForm.FormBorderStyle = FormBorderStyle.None;
                openForm.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(openForm);
                panelPrincipal.Tag = openForm;
                openForm.Show();
                openForm.BringToFront();

            }
            else
            {
                openForm.BringToFront();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            abrirForm<MenuInventario>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm<MenuVenta>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirForm<MenuAjustes>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirForm<MenuCliente>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirForm<MenuReportes>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirForm<MenuFinanzas>();
        }
    }
}
