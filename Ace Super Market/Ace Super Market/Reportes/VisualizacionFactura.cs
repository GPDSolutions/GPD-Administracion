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
    public partial class VisualizacionFactura : Form
    {

        private int numFactura;
        private String nombreCajero;
        private Dictionary<string, string> Dprecio;
        private Dictionary<string, string> Dclave;
        public VisualizacionFactura()
        {
            InitializeComponent();
        }

        public void setDatos(String pnombreUsuario,int pnumFactura, Dictionary<string, string> pprecio, Dictionary<string, string> pDclave)
        {
            numFactura = pnumFactura;
            nombreCajero = pnombreUsuario;
            Dprecio = pprecio;
            Dclave = pDclave;

        }

        private void VisualizacionFactura_Load(object sender, EventArgs e)
        {
            Reportes.Factura objR = new Reportes.Factura();
            objR.Refresh();
            objR.SetParameterValue("pcod_factura", numFactura);
            objR.SetParameterValue("Cajero", nombreCajero);
            objR.SetParameterValue("SubTotal", Dprecio["Subtotal"].ToString());
            objR.SetParameterValue("IVI",Dprecio["IVI"].ToString());
            objR.SetParameterValue("Total", Dprecio["Total"].ToString());
            if (Dclave.Count == 0)
            {
                objR.SetParameterValue("Clave", "");
                objR.SetParameterValue("Consecutivo", "");
            }
            else
            {
                objR.SetParameterValue("Clave", "Clave  FE :" + "\r" + Dclave["codigopais"] + Dclave["dia"] + Dclave["mes"] + Dclave["anno"] + Dclave["identificacion"] + Dclave["consecutivo"] + Dclave["situacioncomprobante"] + Dclave["codigoseguridad"]);
                objR.SetParameterValue("Consecutivo", "Consecutivo  FE :" + "" + Dclave["consecutivo"]);
            }

            crystalReportViewer1.ReportSource = objR;
        }
    }
}
