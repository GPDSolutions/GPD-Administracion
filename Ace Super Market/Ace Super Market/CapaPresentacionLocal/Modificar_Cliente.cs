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
    public partial class Modificar_Cliente : Form
    {
        public Modificar_Cliente()
        {
            InitializeComponent();
        }

        public void cargarDatos(string pIdCliente, string pnombreCliente, string pIdentificacion, string pTipoIdentificacion, string ptelefono, string pdireccion, string pemail, string pcodigoFacel)
        {
            txtIdCliente.Text = pIdCliente;
            txtNombreCliente.Text = pnombreCliente;
            txtIdentificacion.Text = pIdentificacion;
            txtTipoIdentificacion.Text = pTipoIdentificacion;
            txtTelefono.Text = ptelefono;
            txtDireccion.Text = pdireccion;
            txtEmail.Text = pemail;
            txtCodigoFacel.Text = pcodigoFacel;


        }

        private void cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
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



         private void btnActualizar_Click(object sender, EventArgs e)
          {
              Dictionary<string, string> Dcliente = new Dictionary<string, string>();
              CapaLogica.gestor objG = new CapaLogica.gestor();

            Dcliente.Add("idCliente", txtIdCliente.Text);
            Dcliente.Add("NombreCliente", txtNombreCliente.Text);
            Dcliente.Add("Identificacion", txtIdentificacion.Text);
            Dcliente.Add("TipoIdentificacion", txtTipoIdentificacion.Text);
            Dcliente.Add("Telefono", txtTelefono.Text);
            Dcliente.Add("Direccion", txtDireccion.Text);
            Dcliente.Add("Email", txtEmail.Text);
            Dcliente.Add("CodigoClienteF", txtCodigoFacel.Text);

            objG.crearCliente(Dcliente);
              this.Close();
          }
    }
}
