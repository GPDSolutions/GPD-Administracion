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
    public partial class Listado_Productos : Form
    {
        public Listado_Productos()
        {
            InitializeComponent();
            cargarProductos();
        }

        public void cargarProductos()
        {
            List<Dictionary<string, string>> Lproductos = new List<Dictionary<string, string>>();
            Dictionary<string, string> Dproducto = new Dictionary<string, string>();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            Lproductos = objG.listarProductos();

            for (int a = 0;a<Lproductos.Count;a++)
            {
                Dproducto = Lproductos[a];
                tProductos.Rows.Add(Dproducto["CodigoBarra"], Dproducto["NombreProducto"], Dproducto["Codigo"], Dproducto["Cantidad"],
                                    Dproducto["PrecioCosto"], Dproducto["PrecioVenta"], Dproducto["Utilidad"], Dproducto["MetrosCubicos"],
                                    Dproducto["Peso"], Dproducto["TipoProducto"], Dproducto["UnidadMedida"]);
            }
        }

        public  void recargarDatos()
        {
            tProductos.Rows.Clear();
            cargarProductos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            List<Dictionary<string, string>> Lproductos = new List<Dictionary<string, string>>();
            Dictionary<string, string> Dproducto = new Dictionary<string, string>();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            Lproductos = objG.listarProductos();

            tProductos.Rows.Clear();
            for (int a = 0; a < Lproductos.Count; a++)
            {
                Dproducto = Lproductos[a];

                if (Dproducto["CodigoBarra"].Contains(txtBuscar.Text)||
                    Dproducto["NombreProducto"].Contains(txtBuscar.Text)||
                    Dproducto["Codigo"].Contains(txtBuscar.Text))
                {
                    tProductos.Rows.Add(Dproducto["CodigoBarra"], Dproducto["NombreProducto"], Dproducto["Codigo"], Dproducto["Cantidad"],
                                        Dproducto["PrecioCosto"], Dproducto["PrecioVenta"], Dproducto["Utilidad"], Dproducto["MetrosCubicos"],
                                        Dproducto["Peso"], Dproducto["TipoProducto"]);
                }

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

        private void tProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tProductos.CurrentCell.RowIndex;
            String tipo;
            if (tProductos[9, index].Value.ToString().Equals("GR"))
            {
                tipo = "0";
            }
            else
            {
                tipo = "1";
            }
            CapaPresentacionLocal.Modificar_Producto formP = new CapaPresentacionLocal.Modificar_Producto();
            formP.cargarDatos(tProductos[0, index].Value.ToString(), tProductos[1, index].Value.ToString(),
                              tProductos[2, index].Value.ToString(), tProductos[3, index].Value.ToString(),
                              tProductos[4, index].Value.ToString(), tProductos[5, index].Value.ToString(),
                              tProductos[6, index].Value.ToString(), tProductos[7, index].Value.ToString(),
                              tProductos[8, index].Value.ToString(), tipo);

            if (Application.OpenForms["Modificar_Producto"] != null)
            {
                MessageBox.Show("Ya tiene una instancia de modificar producto en ejecucion");
            }
            else
            {
                formP.Show();
            }
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recargarDatos();
        }

        private void Exportar_Click(object sender, EventArgs e)
        {
            exportarExcel(tProductos);
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
