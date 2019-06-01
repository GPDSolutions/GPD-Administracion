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
    public partial class Listar_Clientes : Form
    {
        public Listar_Clientes()
        {
            InitializeComponent();
            cargarClientes();
        }

        public void cargarClientes()
        {
            List<Dictionary<string, string>> Lproductos = new List<Dictionary<string, string>>();
            Dictionary<string, string> Dproducto = new Dictionary<string, string>();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            Lproductos = objG.listarClientes();

            for (int a = 0; a < Lproductos.Count; a++)
            {
                Dproducto = Lproductos[a];
                tClientes.Rows.Add(Dproducto["idCliente"], Dproducto["nombreCliente"], Dproducto["identificacion"], Dproducto["tipoIdentificacion"],
                                    Dproducto["telefono"], Dproducto["direccion"], Dproducto["email"], Dproducto["codigoClienteF"]);
            }
        }

        public void recargarDatos()
        {
            tClientes.Rows.Clear();
            cargarClientes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            List<Dictionary<string, string>> Lproductos = new List<Dictionary<string, string>>();
            Dictionary<string, string> Dproducto = new Dictionary<string, string>();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            Lproductos = objG.listarProductos();

            tClientes.Rows.Clear();
            for (int a = 0; a < Lproductos.Count; a++)
            {
                Dproducto = Lproductos[a];

                if (Dproducto["idCliente"].Contains(txtBuscar.Text) ||
                    Dproducto["nombreCliente"].Contains(txtBuscar.Text) ||
                    Dproducto["identificacion"].Contains(txtBuscar.Text))
                {
                    tClientes.Rows.Add(Dproducto["idCliente"], Dproducto["nombreCliente"], Dproducto["identificacion"], Dproducto["tipoIdentificacion"],
                                    Dproducto["telefono"], Dproducto["direccion"], Dproducto["email"], Dproducto["codigoClienteF"]);
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
            int index = tClientes.CurrentCell.RowIndex;
            CapaPresentacionLocal.Modificar_Cliente formP = new CapaPresentacionLocal.Modificar_Cliente();
            formP.cargarDatos(tClientes[0, index].Value.ToString(), tClientes[1, index].Value.ToString(),
                              tClientes[2, index].Value.ToString(), tClientes[3, index].Value.ToString(),
                              tClientes[4, index].Value.ToString(), tClientes[5, index].Value.ToString(),
                              tClientes[6, index].Value.ToString(), tClientes[7, index].Value.ToString());
            formP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recargarDatos();
        }

        private void Exportar_Click(object sender, EventArgs e)
        {
            exportarExcel(tClientes);
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
