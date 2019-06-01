using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaLogica
{
    class factura
    {

        List<String> codigoInterno;
        List<String> codigoProducto;
        List<String> precioProducto;
        List<String> cantidad;
        List<String> total;
        List<String> idCliente;
        List<String> fechaFactura;

        public factura(List<String> pcodigoInterno, List<String> pcodigoProducto, List<String> pprecioProducto, List<String> pcantidad, List<String> ptotal, List<String> pidCliente, List<String> pfechaFactura)
        {
            setcodigoInterno(pcodigoInterno);
            setcodigoProducto(pcodigoProducto);
            setprecioProducto(pprecioProducto);
            setcantidad(pcantidad);
            settotal(ptotal);
            setidCliente(pidCliente);
            setfechaFactura(pfechaFactura);

        }


        /*INICIO DE SETS*/
        public void setcodigoInterno(List<String> pcodigoInterno)
        {
            codigoInterno = pcodigoInterno;
        }

        public void setcodigoProducto(List<String> pcodigoProducto)
        {
            codigoProducto = pcodigoProducto;
        }

        public void setprecioProducto(List<String> pprecioProducto)
        {
            precioProducto = pprecioProducto;
        }

        public void setcantidad(List<String> pcantidad)
        {
            cantidad = pcantidad;
        }

        public void settotal(List<String> ptotal)
        {
            total = ptotal;
        }

        public void setidCliente(List<String> pidCliente)
        {
            idCliente = pidCliente;
        }

        public void setfechaFactura(List<String> pfechaFactura)
        {
            fechaFactura = pfechaFactura;
        }
        /*FIN DE SETS*/

        /*INICIO DE GETS*/

        public List<String> getcodigoInterno()
        {
            return codigoInterno;
        }

        public List<String> getcodigoProducto()
        {
            return codigoProducto;
        }

        public List<String> getprecioProducto()
        {
            return precioProducto;
        }

        public List<String> getcantidad()
        {
            return cantidad;
        }

        public List<String> gettotal()
        {
            return total;
        }

        public List<String> getidCliente()
        {
            return idCliente;
        }

        public List<String> getfechaFactura()
        {
            return fechaFactura;
        }
        /*FIN DE GETS*/

        /*INICIO DE METODOS*/

        public Boolean guardar()
        {
            Boolean verificacion = false;

            CapaDatos.multiFactura objMF = new CapaDatos.multiFactura();

            if (objMF.consultarProductoXCodigo(this.getcodigoInterno()).Equals("1"))
            {
               // objMF.modificarProducto(getcodigoInterno(), getcodigoProducto(), getprecioProducto(), getcantidad(), getcantidad(), gettotal(), getidCliente(), getfechaFactura());
            }
            else
            {
                objMF.crearFactura(getcodigoInterno(), getcodigoProducto(), getprecioProducto(), getcantidad(),gettotal(), getidCliente(), getfechaFactura());
            }



            return verificacion;
        }

        public Dictionary<String, List<String>> getEstado()
        {

            Dictionary<String,List<String>> Dfactura = new Dictionary<String, List<String>>();

            Dfactura.Add("codigoFactura", this.getcodigoInterno());
            Dfactura.Add("codigoProducto", this.getcodigoProducto());
            Dfactura.Add("precioProducto", this.getprecioProducto());
            Dfactura.Add("cantidad", this.getcantidad());
            Dfactura.Add("total", this.gettotal());
            Dfactura.Add("idCliente", this.getidCliente());
            Dfactura.Add("fechaFactura", this.getfechaFactura());
            return Dfactura;
        }
        /*FIN DE METODOS*/
    }
}
