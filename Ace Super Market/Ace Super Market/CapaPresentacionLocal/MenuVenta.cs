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
    public partial class MenuVenta : Form
    {
        public MenuVenta()
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
                openForm.Text = "Venta";
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

        private void agregarProductos_Click(object sender, EventArgs e)
        {
            abrirForm<Ingresar_Venta>();
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

        private void button2_Click(object sender, EventArgs e)
        {
            abrirForm<Nota_Credito>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirForm<Factutas_Electronicas>();
        }
    }
}
