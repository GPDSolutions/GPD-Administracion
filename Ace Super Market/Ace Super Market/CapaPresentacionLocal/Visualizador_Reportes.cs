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
    public partial class Visualizador_Reportes : Form
    {
        public Visualizador_Reportes()
        {
            InitializeComponent();
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
            if (cReportes.Text.Equals("Tipos de reporte"))
            {
                MessageBox.Show("Elija un tipo re porte a mostrar");
            }
            if (cReportes.Text.Equals("Cierra de Caja Global"))
            {
                Reportes.CierraCaja objR = new Reportes.CierraCaja();
                objR.Refresh();
                crystalReportViewer1.ReportSource = objR;
            }
            if (cReportes.Text.Equals("Cierra de Caja General"))
            {
                CapaPresentacionLocal.Principal objP = new CapaPresentacionLocal.Principal();
                Reportes.CierraCajaGeneral objR = new Reportes.CierraCajaGeneral();
                objR.Refresh();
                objR.SetParameterValue("UsuarioCierre", objP.getnombreUsuario());
                objR.SetParameterValue("ptipofinanza", objP.getnombreUsuario());
                crystalReportViewer1.ReportSource = objR;
            }



        }



    }
}
