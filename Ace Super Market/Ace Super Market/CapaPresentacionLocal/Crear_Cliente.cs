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
    public partial class Crear_Cliente : Form
    {
        String idClienteN;
        String codigoProvincia;
        String codigoCanton;
        String codigoDistrito;

        public Crear_Cliente()
        {
            InitializeComponent();
            cargarProvincia();
            setidClienteN();
        }

        public void setidClienteN()
        {
            CapaLogica.gestor objG = new CapaLogica.gestor();
            idClienteN = objG.buscarUltimoIdCliente();
        }

        private void cerrar_Click(object sender, EventArgs e)
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

        public void cargarProvincia()
        {
            cProvincia.Text = "San jose";
            cargarCanton(cProvincia.Text);           
            cargarDistrito(cCanton.Text);


        }

        public void cargarCanton(String pprovincia)
        {
            CapaLogica.gestor objG = new CapaLogica.gestor();

            List<Dictionary<String, String>> Lcanton = new List<Dictionary<String, String>>();
            Dictionary<String, String> Dcanton = new Dictionary<string, string>();

            Lcanton = objG.getCanton(pprovincia);

            for (int a = 0;a< Lcanton.Count;a++)
            {
                Dcanton = Lcanton[a];
                cCanton.Items.Add(Dcanton["nombreCanton"]);
            }
            cDistrito.Items.Clear();
            cargarDistrito(cCanton.Text);
        }

        public void cargarDistrito(String pcanton)
        {
            CapaLogica.gestor objG = new CapaLogica.gestor();
            List<Dictionary<String, String>> Ldistrito = new List<Dictionary<String, String>>();
            Dictionary<String, String> Ddistrito = new Dictionary<string, string>();

            Ldistrito = objG.getDistrito(pcanton);
            for (int a = 0; a < Ldistrito.Count; a++)
            {
                Ddistrito = Ldistrito[a];
                cDistrito.Items.Add(Ddistrito["nombreDistrito"]);
            }

        }

        private void cProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

           String provincia =  cProvincia.Text;
            cCanton.Items.Clear();

            
            cargarCanton(provincia);            
        }

        private void cCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            String canton = cCanton.Text;
            cDistrito.Items.Clear();
            cargarDistrito(canton);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Dictionary<String, string> Dcliente = new Dictionary<string, string>();
            CapaLogica.gestor objG = new CapaLogica.gestor();


            Dcliente.Add("idCliente",idClienteN);
            Dcliente.Add("NombreCliente",txtNombre.Text);
            Dcliente.Add("Identificacion",txtMIdentificacion.Text);
            Dcliente.Add("TipoIdentificacion", "0"+(cbTipoIdentificacion.SelectedIndex+1).ToString());
            Dcliente.Add("Telefono",txtTelefono.Text);
            Dcliente.Add("Direccion", txtSede.Text + "," + txtDireccion.Text + "," + cDistrito.Text + "," + cCanton.Text + "," + cProvincia.Text + "," + txtPais.Text);
            Dcliente.Add("Email",txtEmail.Text);

            List<Dictionary<String, String>> Lcanton = new List<Dictionary<String, String>>();
            List<Dictionary<String, String>> Ldistrito = new List<Dictionary<String, String>>();
            Dictionary<String, String> Dcanton = new Dictionary<string, string>();
            Dictionary<String, String> Ddistrito = new Dictionary<string, string>();
            Lcanton = objG.getCanton(cProvincia.Text);
            Ldistrito = objG.getDistrito(cCanton.Text);
            String codCanton = "";
            String codDistrito = "";
            for (int a = 0;a<Lcanton.Count;a++)
            {
                Dcanton = Lcanton[a];
                if (Dcanton["nombreCanton"].Equals(cCanton.Text))
                {
                    codCanton = Dcanton["idCanton"];
                }

            }
            for (int a = 0; a < Ldistrito.Count; a++)
            {
                Ddistrito = Ldistrito[a];
                if (Ddistrito["nombreDistrito"].Equals(cDistrito.Text))
                {
                    codDistrito = Ddistrito["idDistrito"];
                }

            }
            Dcliente.Add("CodigoClienteF", (cProvincia.SelectedIndex + 1).ToString()+","+ codCanton+","+codDistrito+","+codDistrito);

            objG.crearCliente(Dcliente);

        }

        private void cbTipoIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTipoIdentificacion.Text.Equals("Fisica"))
            {
                txtMIdentificacion.Mask = "0-0000-0000";
            }
            if (cbTipoIdentificacion.Text.Equals("Juridica"))
            {
                txtMIdentificacion.Mask = "0-000-000000";
            }
            if (cbTipoIdentificacion.Text.Equals("NITE"))
            {
                txtMIdentificacion.Mask = "0000000000";
            }
            if (cbTipoIdentificacion.Text.Equals("DIMEX"))
            {
                txtMIdentificacion.Mask = "000000000000";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
