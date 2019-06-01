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
    public partial class Ingresar_Productos : Form
    {
        double vprecioCosto = 0;
        double vprecioCosto10 = 0;
        double vprecioCosto13 = 0;
        double precioCostoGeneral = 0;
        double precioVentaUtilidad = 0;
        double precioanterior = 0;
        int productos = 0;
        public Ingresar_Productos()
        {
            InitializeComponent();
        }




        private void codigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                codigoBarra.Enabled = false;
                nombreProducto.Enabled = true;
                codigo.Enabled = true;
                cantidadProducto.Enabled = true;
                precioCosto.Enabled = true;
                c10.Enabled = true;
                c13.Enabled = true;
                cE.Enabled = true;
                utilidad.Enabled = true;
                precioVenta.Enabled = true;
                metrosCubicos.Enabled = true;
                peso.Enabled = true;
                fecha.Enabled = true;
                vendedor.Enabled = true;
                tProductos.Enabled = true;
                cmbUnidadMedida.Enabled = true;
                cargardatos();
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Boolean verifiacacionVacio = false;
            Boolean verificacionNumeral = false;
            if (String.IsNullOrEmpty(nombreProducto.Text) || 
                String.IsNullOrEmpty(codigo.Text) ||
                String.IsNullOrEmpty(cantidadProducto.Text) ||
                String.IsNullOrEmpty(precioCosto.Text) ||
                String.IsNullOrEmpty(precioVenta.Text) ||
                String.IsNullOrEmpty(metrosCubicos.Text) ||
                String.IsNullOrEmpty(peso.Text) ||
                String.IsNullOrEmpty(fecha.Text) ||
                String.IsNullOrEmpty(vendedor.Text))
            {
                MessageBox.Show("Existen Campos Vacios","MAMADOR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                verifiacacionVacio = true;
            }

            if (codigo.Text.Any(x => !char.IsNumber(x)) ||
                cantidadProducto.Text.Any(x => !char.IsNumber(x)) ||
                precioCosto.Text.Any(x => !char.IsNumber(x)) ||
                precioVenta.Text.Any(x => !char.IsNumber(x)) ||
                metrosCubicos.Text.Any(x => !char.IsNumber(x)) ||
                peso.Text.Any(x => !char.IsNumber(x)) )
            {
                MessageBox.Show("Existen Campos Numericos Con Valores Alfanuméricos O Espacios", "MAMADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                verificacionNumeral = true;
            }

            if (verifiacacionVacio == true && verificacionNumeral == true)
            {
                tProductos.Rows.Add(true, codigoBarra.Text, nombreProducto.Text,
                                    codigo.Text, cantidadProducto.Text, precioCosto.Text, precioVenta.Text,
                                    utilidad.Text, metrosCubicos.Text, peso.Text, fecha.Text, vendedor.Text,cE.Tag.ToString(),cmbUnidadMedida.Text);

                precioanterior = precioanterior + double.Parse(precioCosto.Text);
                label13.Text = "₡: " + precioanterior;

                reset();

            }
            else
            {

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void minimizar_MouseEnter(object sender, EventArgs e)
        {
            this.minimizar.Image = ((System.Drawing.Image)(Properties.Resources.minimizar_over));
        }

        private void minimizar_MouseLeave(object sender, EventArgs e)
        {
            this.minimizar.Image = ((System.Drawing.Image)(Properties.Resources.minimizar));
        }


        private void c10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (c10.Checked == true)
                {
                    vprecioCosto10 = Math.Ceiling(vprecioCosto * 1.10);
                    precioCostoGeneral = double.Parse(precioCosto.Text);
                    precioCosto.Text = vprecioCosto10.ToString();
                    precioVenta.Text = vprecioCosto10.ToString();
                    c13.Enabled = false;
                    cE.Enabled = false;

                }
                else
                {
                    c13.Enabled = true;
                    cE.Enabled = true;
                    precioCosto.Text = precioCostoGeneral.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor Numerico Incorrecto");
            }

        }

        private void c13_CheckedChanged(object sender, EventArgs e)
        {
            if (c13.Checked == true)
            {
                vprecioCosto13 = Math.Ceiling(vprecioCosto * 1.13);
                precioCostoGeneral = double.Parse(precioCosto.Text);
                precioCosto.Text = Math.Ceiling(vprecioCosto13).ToString();
                precioVenta.Text = Math.Ceiling(vprecioCosto13).ToString();
                c10.Enabled = false;
                cE.Enabled = false;

            }
            else
            {
                c10.Enabled = true;
                cE.Enabled = true;
                precioCosto.Text = precioCostoGeneral.ToString();
            }
        }

        private void cE_CheckedChanged(object sender, EventArgs e)
        {
            if (cE.Checked == true)
            {
                c10.Enabled = false;
                c13.Enabled = false;
                cE.Tag = "EX";
            }
            else
            {
                c10.Enabled = true;
                c13.Enabled = true;
                cE.Tag = "GR";
            }
        }

        private void precioCosto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vprecioCosto = double.Parse(precioCosto.Text);
            }
            catch (Exception ex)
            {
              
            }
            
        }

        private void utilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double utilidadS = (double.Parse(utilidad.Text)/100)+1;
            precioVentaUtilidad = Math.Ceiling(double.Parse(precioCosto.Text) * utilidadS);

            precioVenta.Text = precioVentaUtilidad.ToString();

        }

        private void ingresarDatos_Click(object sender, EventArgs e)
        {

        }

        private void ingresarDatos_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, string> Lproductos = new Dictionary<string, string>();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            
            foreach (DataGridViewRow fila in tProductos.Rows)
            {
                if (Convert.ToBoolean(fila.Cells["check"].Value))
                {
                    Lproductos.Add("CodigoBarra", fila.Cells["tCodigoBarra"].Value.ToString());
                    Lproductos.Add("NombreProducto", fila.Cells["tNombreProducto"].Value.ToString());
                    Lproductos.Add("Codigo", fila.Cells["tCodigo"].Value.ToString());
                    Lproductos.Add("Cantidad", fila.Cells["tCantidad"].Value.ToString());
                    Lproductos.Add("PrecioCosto", fila.Cells["tPrecioCosto"].Value.ToString());
                    Lproductos.Add("PrecioVenta", fila.Cells["tPrecioVenta"].Value.ToString());
                    Lproductos.Add("Utilidad", fila.Cells["tUtilidad"].Value.ToString());
                    Lproductos.Add("MetrosCubicos", fila.Cells["tMetrosCubicos"].Value.ToString());
                    Lproductos.Add("Peso", fila.Cells["tPeso"].Value.ToString());
                    Lproductos.Add("TipoProducto", fila.Cells["ttproducto"].Value.ToString());
                    Lproductos.Add("UnidadMedida", fila.Cells["tunidadmedida"].Value.ToString());

                    objG.ingresarProductos(Lproductos);
                    Lproductos.Clear();
                    productos = 0;

                

                }
                else
                {
                    
                }
            }
        }

        private void reset()
        {
            codigoBarra.Enabled = true;
            codigoBarra.Text = "";
            nombreProducto.Enabled = false;
            nombreProducto.Text = "";
            codigo.Enabled = false;
            codigo.Text = "";
            cantidadProducto.Enabled = false;
            cantidadProducto.Text = "";
            precioCosto.Enabled = false;
            precioCosto.Text = "";
            c10.Enabled = false;
            c10.Checked = false;
            c13.Enabled = false;
            c13.Checked = false;
            cE.Enabled = false;
            cE.Checked = false;
            utilidad.Enabled = false;
            utilidad.Text = "0";
            precioVenta.Enabled = false;
            precioVenta.Text = "";
            metrosCubicos.Enabled = false;
            metrosCubicos.Text = "";
            peso.Enabled = false;
            peso.Text = "";
            fecha.Enabled = false;
            vendedor.Enabled = false;
            tProductos.Enabled = false;
        }

        private void cargardatos()
        {
            String pcodigoBarra = codigoBarra.Text;
            int maxCodigo = 0;
            Dictionary<string, string> Dproducto = new Dictionary<string, string>();

            CapaLogica.gestor objG = new CapaLogica.gestor();

            Dproducto = objG.obtenerProductoXCodigoBarra(pcodigoBarra);
           

            if (Dproducto.Count > 0)
            {
                nombreProducto.Enabled = false;
                nombreProducto.Text = Dproducto["NombreProducto"];
                codigo.Enabled = false;
                codigo.Text = Dproducto["Codigo"];
            }
            else
            {
                maxCodigo = objG.obetnerUltimoCodigo();
                maxCodigo = maxCodigo + 1;
                productos = productos + 1;
                maxCodigo = productos + maxCodigo-1;

                    codigo.Text = maxCodigo.ToString();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigoBarra.Enabled = false;
            nombreProducto.Enabled = true;
            codigo.Enabled = true;
            cantidadProducto.Enabled = true;
            precioCosto.Enabled = true;
            c10.Enabled = true;
            c13.Enabled = true;
            cE.Enabled = true;
            utilidad.Enabled = true;
            precioVenta.Enabled = true;
            metrosCubicos.Enabled = true;
            peso.Enabled = true;
            fecha.Enabled = true;
            vendedor.Enabled = true;
            tProductos.Enabled = true;
        }

        private void Ingresar_Productos_Resize(object sender, EventArgs e)
        {

        }
    }
}
