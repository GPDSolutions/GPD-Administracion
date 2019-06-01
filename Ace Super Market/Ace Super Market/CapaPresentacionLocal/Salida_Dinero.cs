using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaPresentacionLocal
{
    public partial class Salida_Dinero : Form
    {
        public Salida_Dinero()
        {
            InitializeComponent();
            cargarTipoSalida();
        }

        private void cargarTipoSalida()
        {
            CapaLogica.gestor objG = new CapaLogica.gestor();
            List<String> LtipoSalidas = new List<String>();
            LtipoSalidas = objG.optenerTipoSalidas();
            DateTime thisDay = DateTime.Today;
            txtFecha.Text = thisDay.ToString("yyyy-MM-dd");
            for (int a = 0;a< LtipoSalidas.Count;a++)
            {
                cTipoSalida.Items.Add(LtipoSalidas[a]);
            }


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

        private void button1_Click(object sender, EventArgs e)
        {
            Principal objP = new Principal();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            Dictionary<String, string> Dmovimiento = new Dictionary<string, string>(); 
            if (verificarTipoSalida() == true)
            {
                Dmovimiento.Add("tipoMovimiento","Retiro");
                Dmovimiento.Add("finanzaAfectada", cTipoSalida.Text);
                Dmovimiento.Add("montoMovimiento", txtMonto.Text);
                Dmovimiento.Add("razonMovimiento", txtRazon.Text);
                Dmovimiento.Add("usuarioMovimiento", objP.getnombreUsuario());
                Dmovimiento.Add("fechaMovimiento", txtFecha.Text);

                objG.crearMovimiento(Dmovimiento);


                Reportes.SalidaDinero objR = new Reportes.SalidaDinero();
                objR.Refresh();
                objR.SetParameterValue("Usuario", objP.getnombreUsuario());
                objR.SetParameterValue("montoRetiro", "₡" + Double.Parse(txtMonto.Text).ToString("0,0.0", CultureInfo.InvariantCulture));
                objR.SetParameterValue("razonRetiro", txtRazon.Text);
                objR.PrintToPrinter(1,false,0,0);

                txtMonto.Text = "";
                txtRazon.Text = "";
            }

        }

        private Boolean verificarTipoSalida()
        {
            Boolean verificacion = true;

            if (cTipoSalida.Text.Equals(""))
            {
                verificacion = false;
                MessageBox.Show("Elija un tipo de Finanza");
            }
            if (txtMonto.Text.Any(x => !char.IsNumber(x)))
            {
                verificacion = false;
                MessageBox.Show("Monto no Numerico");
            }

            return verificacion;
        }


    }
}
