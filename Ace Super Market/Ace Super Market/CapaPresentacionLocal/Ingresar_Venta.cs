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
using Microsoft.VisualBasic;
using System.Threading;

namespace Ace_Super_Market.CapaPresentacionLocal
{
    public partial class Ingresar_Venta : Form
    {
        String Etotal;
        int index;
        public Ingresar_Venta()
        {
            InitializeComponent();
            cargarNFactura();
        }

        public void cargarNFactura()
        {
            CapaLogica.gestor objG = new CapaLogica.gestor();
            DateTime thisDay = DateTime.Today;
            String ultNumFactura = objG.ultNumeroFactura();
            txtFecha.Text = thisDay.ToString("yyyy-MM-dd");
            NFactura.Text = ultNumFactura;

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



        private void codigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cargardatos();
               

            }
        }

        private void cargardatos()
        {
        
            double canidadProducto = 1;
            double total = 1;
            Boolean verificarProducto = true;
            String pcodigoBarra = codigoBarra.Text;
            Dictionary<string, string> Dproducto = new Dictionary<string, string>();
            List<double> productosTabla = new List<double>();

            CapaLogica.gestor objG = new CapaLogica.gestor();

            if (String.IsNullOrEmpty(pcodigoBarra))
            {
                Dproducto = objG.obtenerProductoXCodigoInterno(txtCodigoInterno.Text);
            }
            else
            {
                Dproducto = objG.obtenerProductoXCodigoBarra(pcodigoBarra);
            }
            

            try
            {
                for (int a = 0; a < tventa.Rows.Count - 1; a++)
                {
                    if (Dproducto["Codigo"].Equals(tventa[0, a].Value.ToString()))
                    {
                        double cantidad = Convert.ToDouble(tventa[3, a].Value.ToString()) + 1;
                        double precio = double.Parse(Dproducto["PrecioVenta"]) * cantidad;
                        tventa[3, a].Value = cantidad;
                        tventa[4, a].Value = precio;                      
                        verificarProducto = false;
                    }


                }
                if (Dproducto["Codigo"].Equals("1535") || Dproducto["Codigo"].Equals("1536") )
                {
                    String precio = Interaction.InputBox("", "Valor de producto", "", 10, 10);
                    tventa.Rows.Add(Dproducto["Codigo"], Dproducto["NombreProducto"], precio, canidadProducto.ToString(), precio, true, Dproducto["tipoProducto"]);
                }
                else if (tventa.Rows.Count == 1)
                {

                    tventa.Rows.Add(Dproducto["Codigo"], Dproducto["NombreProducto"], Dproducto["PrecioVenta"], canidadProducto.ToString(), Dproducto["PrecioVenta"], true, Dproducto["tipoProducto"], Dproducto["unidadMedida"]);
                }
                else if (verificarProducto == true)
                {

                    tventa.Rows.Add(Dproducto["Codigo"], Dproducto["NombreProducto"], Dproducto["PrecioVenta"], canidadProducto.ToString(), Dproducto["PrecioVenta"], true, Dproducto["tipoProducto"], Dproducto["unidadMedida"]);
                }



            }catch(Exception ex)
            {
                MessageBox.Show("Producto no ingresado");
            }

            cargarPrecio();
            txtCodigoInterno.Text = "";
            codigoBarra.Text = "";
            
        }

        public Dictionary<string,string> cargarPrecio()
        {
            Dictionary<string, string> Dprecio = new Dictionary<string, string>();
            double montoGravado = 0;
            double montoExento = 0;
            double montoTotal = 0;
            String smonto = "";
            String slivi = "";
            String stotal = "";
            for (int a = 0; a < tventa.Rows.Count - 1; a++)
            {

                montoTotal = montoTotal + Double.Parse(tventa[4, a].Value.ToString());
                if (tventa[6,a].Value.ToString().Equals("EX"))
                {
                    montoExento = montoExento+double.Parse(tventa[4, a].Value.ToString());
                }
                if (tventa[6, a].Value.ToString().Equals("GR"))
                {
                    montoGravado = montoGravado+ double.Parse(tventa[4, a].Value.ToString());
                }

            }
            lmonto.Text = "Subtotal : ₡ " + (montoExento+(montoGravado - (montoGravado * 0.13))).ToString("0,0.0", CultureInfo.InvariantCulture);
            livi.Text = "IVI : ₡ "+ (montoGravado*0.115).ToString("0,0.0", CultureInfo.InvariantCulture);
            ltotal.Text = "Total : ₡" + montoTotal.ToString("0,0.0", CultureInfo.InvariantCulture);
            stotal = "₡" + montoTotal.ToString("0,0.0", CultureInfo.InvariantCulture);
            Etotal = montoTotal.ToString();
            smonto = "₡ " + (montoExento+(montoGravado - (montoGravado * 0.13))).ToString("0,0.0", CultureInfo.InvariantCulture);
            slivi = "₡ " + (montoGravado * 0.13).ToString("0,0.0", CultureInfo.InvariantCulture); ;

            Dprecio.Add("Subtotal", smonto);
            Dprecio.Add("IVI",slivi);
            Dprecio.Add("Total",stotal);
            return Dprecio;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarPrecio();
            double vueelto = (double.Parse(txtVuelto.Text) - double.Parse(Etotal));
            if (vueelto>0)
            {
                MessageBox.Show("El vuelto es : " + (double.Parse(txtVuelto.Text) - double.Parse(Etotal)).ToString());
            }
            else
            {
                MessageBox.Show("El vuelto es : 0" );
            }
            
            CapaLogica.gestor objG = new CapaLogica.gestor();
            List<String> codigoInterno = new List<String>();
            List<String> codigoProducto = new List<String>();
            List<String> precioProducto = new List<String>();
            List<String> cantidad = new List<String>();
            List<String> total = new List<String>();
            List<String> idCliente = new List<String>();
            List<String> fechaFactura = new List<String>();
            List<String> tipoProducto = new List<string>();
            List<String> nombreProducto = new List<string>();
            List<String> unidadMedida = new List<string>();

            for (int a = 0;a<tventa.Rows.Count - 1;a++)
            {
                codigoInterno.Add(NFactura.Text);
                codigoProducto.Add(tventa[0, a].Value.ToString());
                precioProducto.Add(tventa[2, a].Value.ToString());
                cantidad.Add(tventa[3, a].Value.ToString());
                total.Add(tventa[4, a].Value.ToString());
                idCliente.Add(lid.Text);
                fechaFactura.Add(txtFecha.Text);
                tipoProducto.Add(tventa[6, a].Value.ToString());
                nombreProducto.Add(tventa[1, a].Value.ToString());
                unidadMedida.Add(tventa["tunidadmedida", a].Value.ToString());

            }
            objG.crearFactura(codigoInterno, codigoProducto, precioProducto, cantidad, total, idCliente, fechaFactura);

            DateTime thisDay = DateTime.Today;
            String pdia = thisDay.ToString("dd");
            String pmes = thisDay.ToString("MM");
            String panno = thisDay.ToString("yy");

            
            
            int numFactura = int.Parse(NFactura.Text);
            
            Dictionary<string, string> Dprecio = new Dictionary<string, string>();
            Dictionary<string, string> Dcliente = new Dictionary<string, string>();
            
            Dprecio = cargarPrecio();
            Dcliente = objG.buscarClienteXid(lid.Text);
            CapaLogica.crearFacturaXML objXML = new CapaLogica.crearFacturaXML();

            if (lid.Text.Equals("0"))
            {
                Dictionary<string, string> Dclave2 = new Dictionary<string, string>();
                Principal objP = new Principal();
                CapaPresentacionLocal.VisualizacionFactura objF = new CapaPresentacionLocal.VisualizacionFactura();
                objF.setDatos(objP.getnombreUsuario(), numFactura, Dprecio, Dclave2);
                objF.Show();

                cargarNFactura();
                tventa.Rows.Clear();
                lmonto.Text = "Subtotal  :";
                livi.Text = "IVI :";
                ltotal.Text = "Total :";

            }
            if (lid.Text.Equals("3"))
            {
                Dictionary<string, string> Dclave = new Dictionary<string, string>();
                Dclave = objG.optenerClaveTiquete(pdia, pmes, panno, NFactura.Text);
                Thread factura = new Thread(() => ejecutarXMLTiquete(Dclave, Dcliente, codigoProducto, precioProducto, cantidad, total, tipoProducto, nombreProducto, unidadMedida));
                factura.Start();
                Principal objP = new Principal();
                CapaPresentacionLocal.VisualizacionFactura objF = new CapaPresentacionLocal.VisualizacionFactura();
                objF.setDatos(objP.getnombreUsuario(), numFactura, Dprecio, Dclave);
                objF.Show();

                cargarNFactura();
                tventa.Rows.Clear();
                lmonto.Text = "Subtotal  :";
                livi.Text = "IVI :";
                ltotal.Text = "Total :";
            }
            else {
                Dictionary<string, string> Dclave = new Dictionary<string, string>();
                Dclave = objG.optenerClave(pdia, pmes, panno, NFactura.Text);
                Thread factura = new Thread(() => ejecutarXML(Dclave, Dcliente, codigoProducto, precioProducto, cantidad, total, tipoProducto, nombreProducto, unidadMedida));
                factura.Start();
                Principal objP = new Principal();
                CapaPresentacionLocal.VisualizacionFactura objF = new CapaPresentacionLocal.VisualizacionFactura();
                objF.setDatos(objP.getnombreUsuario(), numFactura, Dprecio, Dclave);
                objF.Show();

                cargarNFactura();
                tventa.Rows.Clear();
                lmonto.Text = "Subtotal  :";
                livi.Text = "IVI :";
                ltotal.Text = "Total :";
            }


            
        }

        static void ejecutarXML(Dictionary<String, String> Dclave, Dictionary<String, String> Dcliente,
                                        List<String> codigoProducto, List<String> precioProducto, List<String> cantidad, List<String> total, List<String> tipoProducto,
                                        List<String> nombreProducto, List<String> unidadMedida)
        {
            CapaLogica.crearFacturaXML objXML = new CapaLogica.crearFacturaXML();
            objXML.generarXMLFactura(Dclave, Dcliente, codigoProducto, precioProducto, cantidad, total, tipoProducto, nombreProducto, unidadMedida);
        }

        static void ejecutarXMLTiquete(Dictionary<String, String> Dclave, Dictionary<String, String> Dcliente,
                                List<String> codigoProducto, List<String> precioProducto, List<String> cantidad, List<String> total, List<String> tipoProducto,
                                List<String> nombreProducto, List<String> unidadMedida)
        {
            CapaLogica.crearTiqueteElectronico objXML = new CapaLogica.crearTiqueteElectronico();
            objXML.generarXMLTiquete(Dclave, Dcliente, codigoProducto, precioProducto, cantidad, total, tipoProducto, nombreProducto, unidadMedida);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CapaLogica.gestor objG = new CapaLogica.gestor();
            List<CapaLogica.cliente> Dclientes = new List<CapaLogica.cliente>();
            Dictionary<string, string> Dresult = new Dictionary<string, string>();

            Dclientes =  objG.buscarCliente(textCliente.Text);

            cCliente.Items.Clear();

            for (int a = 0;a<Dclientes.Count;a++)
            {

                cCliente.Items.Insert(a,Dclientes[a].getnombreCliente());
            }
        }

        private void cCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            CapaLogica.gestor objG = new CapaLogica.gestor();
            List<CapaLogica.cliente> Dclientes = new List<CapaLogica.cliente>();
            Dictionary<string, string> Dresult = new Dictionary<string, string>();

            Dclientes = objG.buscarCliente(textCliente.Text);

            for (int a = 0;a<Dclientes.Count;a++)
            {
                if (cCliente.Text.Equals(Dclientes[a].getnombreCliente()))
                {
                    lDirecion.Text = "Direcion : "+Dclientes[a].getdireccion();
                    lid.Text = Dclientes[a].getidCliente();
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                tventa.Rows.RemoveAt(index);
                cargarPrecio();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No existen filas para eliminar");
            }
            
        }

        private void tventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = tventa.CurrentCell.RowIndex;
        }
    }
}
;