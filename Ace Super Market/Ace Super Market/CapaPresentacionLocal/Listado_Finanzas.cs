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
    public partial class Listado_Finanzas : Form
    {
        public Listado_Finanzas()
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
            for (int a = 0; a < LtipoSalidas.Count; a++)
            {
                cTipoFinanza.Items.Add(LtipoSalidas[a]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> Dfinanza = new Dictionary<String, String>();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            if (cTipoFinanza.Text.Equals(""))
            {

            }
            else
            {
                Dfinanza = objG.optenerFinanza(cTipoFinanza.Text);

                lbFinanza.Text = "Finanza : "+Dfinanza["nombre"];
                lbsaldo.Text = "Saldo : "+ "₡" + Double.Parse(Dfinanza["saldo"]).ToString("0,0.0", CultureInfo.InvariantCulture);
                lbfechaMovimiento.Text = "Ultimo Movimiento : " + Dfinanza["fechaUltMovimiento"];
                cargartablaMovimientos();

            }
        }

        public void cargartablaMovimientos()
        {
            String pmovimientoFinanza = cTipoFinanza.Text;
            CapaLogica.gestor objG = new CapaLogica.gestor();
            List<Dictionary<String, String>> Lmovimientos = new List<Dictionary<String, String>>();
            Dictionary<String, String> Dmovimiento = new Dictionary<String, String>();

            Lmovimientos = objG.cargarMovimentos(pmovimientoFinanza);
            tFinanza.Rows.Clear();
            for (int a = 0;a<Lmovimientos.Count();a++)
            {
                Dmovimiento = Lmovimientos[a];
                tFinanza.Rows.Add(Dmovimiento["tipoMovimiento"], Dmovimiento["finanzaAfectada"], "₡" + double.Parse(Dmovimiento["montoMovimento"]).ToString("0,0.0", CultureInfo.InvariantCulture),
                                  Dmovimiento["razonMovimiento"], Dmovimiento["usuarioMovimiento"], Dmovimiento["fechaMovimiento"]);
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




        private void Exportar_Click(object sender, EventArgs e)
        {
            exportarExcel(tFinanza);
        }

        public void exportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;

        }


    }
}
