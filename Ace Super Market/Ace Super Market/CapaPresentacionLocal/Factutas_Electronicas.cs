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
using System.Xml;

namespace Ace_Super_Market.CapaPresentacionLocal
{
    public partial class Factutas_Electronicas : Form
    {

        List<String> LconsecutivoReceptor = new List<string>();
        public Factutas_Electronicas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = buscar.FileName;
                XmlTextReader xml = new XmlTextReader(@buscar.FileName);
                String elemento = "";
                Dictionary<String, String> v = new Dictionary<string, string>();
                List<String> datosXML = new List<string>();
                List<String> datosXML2 = new List<string>();
                while (xml.Read())
                {
                    if(xml.NodeType == XmlNodeType.Element )
                    {
                        elemento = xml.Name;
                    }
                    if (xml.NodeType == XmlNodeType.Text)
                    {

                        datosXML.Add(elemento);
                        datosXML2.Add(xml.ReadContentAsString());
                    }
                }
                Boolean vEmisorNombre = true;
                Boolean vEmisorNumero = true;
                Boolean vEmisorTipoIdentificacoion = true;
                Boolean vEmisorCorreo = true;
                Boolean vReceptorNumero = true;
                for (int a = 0;a<datosXML.Count;a++)
                {
                    if (datosXML[a].Equals("Clave"))
                    {
                        txtClave.Text = datosXML2[a];
                    }
                    if (datosXML[a].Equals("Tipo") && vEmisorTipoIdentificacoion==true)
                    {
                        cmbTipoIdentificacion.SelectedIndex = (int.Parse(datosXML2[a]) - 1);
                        vEmisorTipoIdentificacoion = false;
                    }
                    if (datosXML[a].Equals("Nombre") && vEmisorNombre == true)
                    {
                        txtNombreEmisor.Text = datosXML2[a];
                        vEmisorNombre = false;
                    }
                    if (datosXML[a].Equals("Numero") && vEmisorNumero==true)
                    {
                        txtCedulaEmisor.Text = datosXML2[a];
                        vEmisorNumero = false;
                    }
                    if (datosXML[a].Equals("CorreoElectronico") && vEmisorCorreo == true )
                    {
                        txtCorreoEmisor.Text = datosXML2[a];
                        vEmisorCorreo = false;
                    }

                    if (datosXML[a].Equals("TotalImpuesto"))
                    {
                        Double tim = double.Parse(datosXML2[a]);
                        txtTotalImpuesto.Text = tim.ToString("00.00", CultureInfo.InvariantCulture);
                    }
                    if (datosXML[a].Equals("TotalComprobante"))
                    {
                        Double tcom = double.Parse(datosXML2[a]);
                        txtTotalFactura.Text = tcom.ToString("00.00", CultureInfo.InvariantCulture);
                    }

                }
                txtCedulaReceptor.Text = "3101769387";
                txtFechaEmisor.Text = DateTime.Now.ToString("yyyy-MM-dd") + "T" + DateTime.Now.ToString("HH:mm:ssK");

                cargarConsecutivo();
            }
        }

        public void cargarConsecutivo()
        {
            int numCaracteres = 10;
            CapaLogica.gestor objG = new CapaLogica.gestor();         
            LconsecutivoReceptor = objG.cargarConsecutivoReceptor();

            if (cmbMensaje.Text.Equals("Aceptado"))
            {
                LconsecutivoReceptor[2] = "05";

            }
            if (cmbMensaje.Text.Equals("Aceptado Parcialmente"))
            {
                LconsecutivoReceptor[2] = "06";

            }
            if (cmbMensaje.Text.Equals("Rechazado"))
            {
                LconsecutivoReceptor[2] = "07";

            }

            LconsecutivoReceptor[3] = (int.Parse(LconsecutivoReceptor[3]) + 1).ToString();

            int a = LconsecutivoReceptor[3].Length;
            LconsecutivoReceptor[3] = LconsecutivoReceptor[3].PadLeft(numCaracteres, '0');

            txtNumConsecutivo.Text = LconsecutivoReceptor[0]+ LconsecutivoReceptor[1]+ LconsecutivoReceptor[2]+ LconsecutivoReceptor[3];
        }

        private void cmbMensaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarConsecutivo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> Drecepcion = new Dictionary<string, string>();
            Dictionary<String, String> Dconsecutivo = new Dictionary<string, string>();
            CapaLogica.gestor objG = new CapaLogica.gestor();
            String mensaje = "";
            if (cmbMensaje.Text.Equals("Aceptado"))
            {
                mensaje = "1";

            }
            if (cmbMensaje.Text.Equals("Aceptado Parcialmente"))
            {
                mensaje = "2";

            }
            if (cmbMensaje.Text.Equals("Rechazado"))
            {
                mensaje = "3";

            }

            Drecepcion.Add("estado","0");
            Drecepcion.Add("clave",txtClave.Text);
            Drecepcion.Add("tipoidentificacion", (cmbTipoIdentificacion.SelectedIndex+1).ToString().PadLeft(2, '0'));
            Drecepcion.Add("numerocedulaemisor",txtCedulaEmisor.Text);
            Drecepcion.Add("fechaemisiondoc",txtFechaEmisor.Text);
            Drecepcion.Add("mensaje", mensaje);
            Drecepcion.Add("detallemensaje",txtDetalleMensaje.Text);
            Drecepcion.Add("montototalimpuesto",txtTotalImpuesto.Text);
            Drecepcion.Add("totalfactura",txtTotalFactura.Text);
            Drecepcion.Add("numerocedulareceptor",txtCedulaReceptor.Text);
            Drecepcion.Add("numeroconsecutivoreceptor",txtNumConsecutivo.Text);
            Drecepcion.Add("nombrecliente", txtNombreEmisor.Text);
            Drecepcion.Add("corerocliente", txtCorreoEmisor.Text);

            Dconsecutivo.Add("claveFactura", txtClave.Text);
            Dconsecutivo.Add("locall", LconsecutivoReceptor[0]);
            Dconsecutivo.Add("terminal", LconsecutivoReceptor[1]);
            Dconsecutivo.Add("tipodocumento", LconsecutivoReceptor[2]);
            Dconsecutivo.Add("consecutivo", LconsecutivoReceptor[3]);
            objG.guardarConsecutivoReceptor(Dconsecutivo);
            objG.crearDatosFactura(Drecepcion);

            txtClave.Text = "";
            txtCedulaEmisor.Text = "";
            txtFechaEmisor.Text = "";
            txtDetalleMensaje.Text = "";
            txtTotalImpuesto.Text = "";
            txtTotalFactura.Text = "";
            txtCedulaReceptor.Text = "";
            txtNombreEmisor.Text = "";
            txtNumConsecutivo.Text = "";
            txtRutaArchivo.Text = "";


        }

        private void rdbAceptadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAceptadas.Checked)
            {
                btnProcesar.Enabled = false;
                CapaLogica.gestor objG = new CapaLogica.gestor();
                List<Dictionary<String, String>> LdatosFactura = new List<Dictionary<String, String>>();
                Dictionary<String, String> DdatosFactura = new Dictionary<string, string>();

                LdatosFactura = objG.optenerDatosFactura();

                for(int a = 0;a<LdatosFactura.Count;a++)
                {
                    DdatosFactura = LdatosFactura[a];
                    if (DdatosFactura["estado"].Equals("1"))
                    {
                        tblDatosFactura.Rows.Add(DdatosFactura["estado"], DdatosFactura["clave"], DdatosFactura["tipoidentificacion"], DdatosFactura["numerocedulaemisor"], DdatosFactura["fechaemisiondoc"], DdatosFactura["mensaje"],
                                             DdatosFactura["detallemensaje"], DdatosFactura["montototalimpuesto"], DdatosFactura["totalfactura"], DdatosFactura["numerocedulareceptor"], DdatosFactura["numeroconsecutivoreceptor"],
                                             DdatosFactura["nombrecliente"], DdatosFactura["correocliente"], true);
                    }
                    
                }
            }
            else
            {
                tblDatosFactura.Rows.Clear();
            }
            
        }

        private void rdbPendientes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPendientes.Checked)
            {
                btnProcesar.Enabled = true;
                CapaLogica.gestor objG = new CapaLogica.gestor();
                List<Dictionary<String, String>> LdatosFactura = new List<Dictionary<String, String>>();
                Dictionary<String, String> DdatosFactura = new Dictionary<string, string>();

                LdatosFactura = objG.optenerDatosFactura();

                for (int a = 0; a < LdatosFactura.Count; a++)
                {
                    DdatosFactura = LdatosFactura[a];
                    if (DdatosFactura["estado"].Equals("0"))
                    {
                        tblDatosFactura.Rows.Add(DdatosFactura["estado"], DdatosFactura["clave"], DdatosFactura["tipoidentificacion"], DdatosFactura["numerocedulaemisor"], DdatosFactura["fechaemisiondoc"], DdatosFactura["mensaje"],
                                             DdatosFactura["detallemensaje"], DdatosFactura["montototalimpuesto"], DdatosFactura["totalfactura"], DdatosFactura["numerocedulareceptor"], DdatosFactura["numeroconsecutivoreceptor"],
                                             DdatosFactura["nombrecliente"], DdatosFactura["correocliente"],true);
                    }

                }
            }
            else
            {
                tblDatosFactura.Rows.Clear();
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            
            
            foreach (DataGridViewRow fila in tblDatosFactura.Rows)
            {
                
                if (Convert.ToBoolean(fila.Cells["check"].Value))
                {
                    Dictionary<String, String> Drecepcion = new Dictionary<string, string>();
                    Drecepcion.Add("estado", fila.Cells["testado"].Value.ToString());
                    Drecepcion.Add("clave", fila.Cells["tclave"].Value.ToString());
                    Drecepcion.Add("tipoidentificacion", fila.Cells["ttipoidentificacion"].Value.ToString());
                    Drecepcion.Add("numerocedulaemisor", fila.Cells["tnumerocedulaemisor"].Value.ToString());
                    Drecepcion.Add("fechaemisiondoc", fila.Cells["tfechaemisiondoc"].Value.ToString());
                    Drecepcion.Add("mensaje", fila.Cells["tmensaje"].Value.ToString());
                    Drecepcion.Add("detallemensaje", fila.Cells["tdetallemensaje"].Value.ToString());
                    Drecepcion.Add("montototalimpuesto", fila.Cells["tmontototalimpuesto"].Value.ToString());
                    Drecepcion.Add("totalfactura", fila.Cells["ttotalfactura"].Value.ToString());
                    Drecepcion.Add("numerocedulareceptor", fila.Cells["tnumerocedulareceptor"].Value.ToString());
                    Drecepcion.Add("numeroconsecutivoreceptor", fila.Cells["tnumeroconsecutivoreceptor"].Value.ToString());
                    Drecepcion.Add("tnombrecliente", fila.Cells["tnumeroconsecutivoreceptor"].Value.ToString());
                    Drecepcion.Add("tcorerocliente", fila.Cells["tnumeroconsecutivoreceptor"].Value.ToString());


                    CapaLogica.crearRespuestaXML objXML = new CapaLogica.crearRespuestaXML();
                     objXML.crearRespuesHaciendataXML(Drecepcion);

                }


            }
        }

    }
}
