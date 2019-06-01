using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ace_Super_Market.CapaLogica
{
    class producto
    {
        String codigoBarra;
        String nombreProducto;
        String codigo;
        double cantidadProducto;
        double precioCosto;
        double precioVenta;
        double utilidad;
        double metrosCubicos;
        double peso;
        String tipoProducto;
        String unidadMedida;

        public producto(string pcodigoBarra, string pnombreProducto, string pcodigo, double pcantidadProducto, double pprecioCosto, double pprecioVenta, double putilidad, double pmetrosCubicos, double ppeso, string ptipoProducto,String punidadMedida)
        {
            setcodigoBarra(pcodigoBarra);
            setnombreProducto(pnombreProducto);
            setcodigo(pcodigo);
            setcantidadProducto(pcantidadProducto);
            setprecioCosto(pprecioCosto);
            setprecioVenta(pprecioVenta);
            setutilidad(putilidad);
            setmetrosCubicos(pmetrosCubicos);
            setpeso(ppeso);
            settipoProducto(ptipoProducto);
            setunidadMedida(punidadMedida);
        }
        /*INICIO DE SETS*/
        public void setcodigoBarra(string pcodigoBarra)
        {
            codigoBarra = pcodigoBarra;
        }

        public void setnombreProducto(string pnombreProducto)
        {
            nombreProducto = pnombreProducto;
        }

        public void setcodigo(string ppcodigoBarra)
        {
            codigo = ppcodigoBarra;
        }
        public void setcantidadProducto(double pcantidadProducto)
        {
            cantidadProducto = pcantidadProducto;
        }

        public void setprecioCosto(double pprecioCosto)
        {
            precioCosto = pprecioCosto;
        }

        public void setprecioVenta(double pprecioVenta)
        {
            precioVenta = pprecioVenta;
        }

        public void setutilidad(double putilidad)
        {
            utilidad = putilidad;
        }

        public void setmetrosCubicos(double pmetrosCubicos)
        {
            metrosCubicos = pmetrosCubicos;
        }

        public void setpeso(double ppeso)
        {
            peso = ppeso;
        }

        public void settipoProducto(string ptipoProducto)
        {
            tipoProducto = ptipoProducto;
        }
        public void setunidadMedida(String punidadMedida)
        {
            unidadMedida = punidadMedida;
        }

        /*FINAL DE SETS*/



        /*INICIO DE GETS*/

        public string getcodigoBarra()
        {
            return codigoBarra;
        }

        public string getnombreProducto()
        {
            return nombreProducto;
        }

        public string getcodigo()
        {
            return codigo;
        }
        public double getcantidadProducto()
        {
            return cantidadProducto;
        }

        public double getprecioCosto()
        {
            return precioCosto;
        }

        public double getprecioVenta()
        {
            return precioVenta;
        }

        public double getutilidad()
        {
            return utilidad;
        }

        public double getmetrosCubicos()
        {
            return metrosCubicos;
        }

        public double getpeso()
        {
            return peso;
        }

        public string gettipoProducto()
        {
            return tipoProducto;
        }
        public string getunidadMedida()
        {
            return unidadMedida;
        }



        /*FINAL DE GETS*/


        /*INICIO DE METODOS*/

        public void guardar()
        {
            CapaDatos.multiProductos objM = new CapaDatos.multiProductos();

            if (objM.consultarProductoXCodigo(this.getcodigoBarra(), this.getcodigo()).Equals("1"))
            {
                objM.modificarProducto(getcodigoBarra(), getnombreProducto(), getcodigo(), getcantidadProducto(), getprecioCosto(), getprecioVenta(), getutilidad(), getmetrosCubicos(), getpeso(), gettipoProducto(), getunidadMedida());
            }
            else
            {
                objM.crearProducto(getcodigoBarra(), getnombreProducto(), getcodigo(), getcantidadProducto(), getprecioCosto(), getprecioVenta(), getutilidad(), getmetrosCubicos(), getpeso(), gettipoProducto(),getunidadMedida());
            }
        }


        public Dictionary<string, string> getEstado()
        {

            Dictionary<string, string> Dproducto = new Dictionary<string, string>();

            Dproducto.Add("CodigoBarra",this.getcodigoBarra());
            Dproducto.Add("NombreProducto",this.getnombreProducto());
            Dproducto.Add("Codigo", this.getcodigo());
            Dproducto.Add("Cantidad", this.getcantidadProducto().ToString());
            Dproducto.Add("PrecioCosto", this.getprecioCosto().ToString());
            Dproducto.Add("PrecioVenta", this.getprecioVenta().ToString());
            Dproducto.Add("Utilidad", this.getutilidad().ToString());
            Dproducto.Add("MetrosCubicos", this.getmetrosCubicos().ToString());
            Dproducto.Add("Peso", this.getpeso().ToString());
            Dproducto.Add("TipoProducto", this.gettipoProducto());
            Dproducto.Add("UnidadMedida", this.getunidadMedida());


            return Dproducto;
        }

        /*FINAL DE METODOS*/





    }
}
