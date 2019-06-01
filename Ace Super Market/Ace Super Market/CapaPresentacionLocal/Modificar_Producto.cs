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
    public partial class Modificar_Producto : Form
    {
        public Modificar_Producto()
        {
            InitializeComponent();
        }

        public void cargarDatos(string pcodigoBarra, string pnombreProducto, string pcodigo, string pcantidadProducto, string pprecioCosto, string pprecioVenta, string putilidad, string pmetrosCubicos, string ppeso, string ptipoProducto)
        {
            txtcodigoBarra.Text = pcodigoBarra;
            txtnombreProducto.Text = pnombreProducto;
            txtcodigo.Text = pcodigo;
            txtcantidad.Text = pcantidadProducto;
            txtcosco.Text = pprecioCosto;
            txtventa.Text = pprecioVenta;
            cutilidad.SelectedIndex = int.Parse(putilidad);
            txtcubicos.Text = pmetrosCubicos;
            txtpeso.Text = ppeso;
            ctipo.SelectedIndex = int.Parse(ptipoProducto);

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
            Dictionary<string, string> Lproductos = new Dictionary<string, string>();
            CapaPresentacionLocal.Listado_Productos fromL = new CapaPresentacionLocal.Listado_Productos();
            CapaLogica.gestor objG = new CapaLogica.gestor();

            Lproductos.Add("CodigoBarra", txtcodigoBarra.Text);
            Lproductos.Add("NombreProducto", txtnombreProducto.Text);
            Lproductos.Add("Codigo", txtcodigo.Text);
            Lproductos.Add("Cantidad", txtcantidad.Text);
            Lproductos.Add("PrecioCosto", txtcosco.Text);
            Lproductos.Add("PrecioVenta", txtventa.Text);
            Lproductos.Add("Utilidad", cutilidad.Text);
            Lproductos.Add("MetrosCubicos", txtcubicos.Text);
            Lproductos.Add("Peso", txtpeso.Text);
            Lproductos.Add("TipoProducto", ctipo.Text);
            Lproductos.Add("UnidadMedida", cmbunidadMedida.Text);

            objG.ingresarProductos(Lproductos);
            objG.setCantidad(Lproductos);
            this.Close();
        }
    }
}
