using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaLogica
{
    class gestor
    {

        /*INICIO DE GESTION DE USUARIOS*/
        public Boolean verificarUsuario(String pnombreUsuario, String pcontrasenna)
        {
            Boolean verificacion = false;
            CapaDatos.multiUsuario objMultiUsuario = new CapaDatos.multiUsuario();

            String result = objMultiUsuario.consultarUsuario(pnombreUsuario, pcontrasenna);

            if (result.Equals("1"))
            {
                verificacion = true;
            }
            return verificacion;
        }

        public Boolean crearUsuario(Dictionary<string,string> Dusuario)
        {
            Boolean verificacion = false;
                
                CapaLogica.usuario objP = new CapaLogica.usuario(Dusuario["nombre"], Dusuario["usuario"], Dusuario["contrasenna"], Dusuario["rol"]);
                verificacion = objP.guardar();
            

            return verificacion;
        }

        public Boolean modificarContrasenna(String pnombre,String pcontrasenna)
        {
            Boolean verificacion = false;
            CapaLogica.usuario objU = new CapaLogica.usuario(pnombre,pcontrasenna);
            verificacion = objU.modificarContrasenna();
            return verificacion;

        }



        public Dictionary<string,string> buscarUsuario(string pusuario)
        {
            Dictionary<string, string> Dusuario = new Dictionary<string, string>();
            CapaLogica.usuario objU = new CapaLogica.usuario(pusuario);
            Dusuario = objU.getEstado();
            return Dusuario;
        }
        /*FINAL DE GESTION DE USUARIOS*/


        /*INICIO DE GESTION DE PRODUCTOS*/

        public Boolean ingresarProductos(Dictionary<string, string> Lprodcutos)
        {
            CapaLogica.producto objP = new CapaLogica.producto(Lprodcutos["CodigoBarra"], Lprodcutos["NombreProducto"], Lprodcutos["Codigo"], double.Parse(Lprodcutos["Cantidad"]), double.Parse(Lprodcutos["PrecioCosto"]), double.Parse(Lprodcutos["PrecioVenta"]), double.Parse(Lprodcutos["Utilidad"]), double.Parse(Lprodcutos["MetrosCubicos"]), double.Parse(Lprodcutos["Peso"]), Lprodcutos["TipoProducto"],Lprodcutos["UnidadMedida"]);
            objP.guardar();
            return true;
        }

        public Boolean setCantidad(Dictionary<string, string> Lprodcutos)
        {
            CapaDatos.multiProductos objM = new CapaDatos.multiProductos();
            objM.setCantidad(double.Parse(Lprodcutos["Cantidad"]),Lprodcutos["CodigoBarra"], Lprodcutos["Codigo"]);
            return true;
        }

        public Dictionary<string,string> obtenerProductoXCodigoBarra(string pCodigoBarra)
        {
            Dictionary<string, string> Dproducto = new Dictionary<string, string>();
            CapaDatos.multiProductos objP = new CapaDatos.multiProductos();

            Dproducto = objP.consultarProductoXCodigoBarra(pCodigoBarra);

            return Dproducto;
        }

        public Dictionary<string, string> obtenerProductoXCodigoInterno(string pCodigoInterno)
        {
            Dictionary<string, string> Dproducto = new Dictionary<string, string>();
            CapaDatos.multiProductos objP = new CapaDatos.multiProductos();

            Dproducto = objP.consultarProductoXCodigoInterno(pCodigoInterno);

            return Dproducto;
        }

        public int obetnerUltimoCodigo()
        {
            int maxCodigo = 0;
            CapaDatos.multiProductos objP = new CapaDatos.multiProductos();
            maxCodigo = objP.ultimoCodigo();
            return maxCodigo;
        }

        public List<Dictionary<string,string>> listarProductos()
        {
            CapaDatos.multiProductos objM = new CapaDatos.multiProductos();
            List<Dictionary<string, string>> Lproductos = new List<Dictionary<string, string>>();
            List<producto> LproductosOBJ = new List<producto>();

            LproductosOBJ = objM.listarProductos();

            
            for (int a = 0;a<LproductosOBJ.Count;a++)
            {
               Lproductos.Add(LproductosOBJ[a].getEstado());
            }

            return Lproductos;
        }


        /*FINAL DE GESTION DE PRODUCTOS*/

        /*INICIO DE GESTION DE FACTURA*/

       public Boolean crearFactura(List<String> pcodigoInterno, List<String> pcodigoProducto, List<String> pprecioProducto, List<String> pcantidad, List<String> ptotal, List<String> pidCliente, List<String> pfechaFactura)
        {
            Boolean verificacion = false;
   
            CapaLogica.factura objF = new CapaLogica.factura(pcodigoInterno,pcodigoProducto,pprecioProducto,pcantidad,ptotal,pidCliente,pfechaFactura);

            objF.guardar();
            return verificacion;
        }

        public List<Dictionary<String, String>> cargarFacturaElectro(String pfecha)
        {
            List<Dictionary<String, String>> Lfactura = new List<Dictionary<String, String>>();
            CapaDatos.multiFactura objF = new CapaDatos.multiFactura();

            Lfactura = objF.cargaFacturasElec(pfecha);


            return Lfactura;
        }

        public string ultNumeroFactura()
        {
            String result;
            CapaDatos.multiFactura objM = new CapaDatos.multiFactura();

            result = objM.cargarUltNumeroFactura();
            return result;
        }

        public Dictionary<String,String> optenerClave(String pdia,String pmes,String panno,String pnunFactura)
        {
            Dictionary<String, String> Dclave = new Dictionary<string, string>();
            CapaDatos.multicalvelectronica objM = new CapaDatos.multicalvelectronica();
            CapaLogica.clavefacturacionelectronica objC = objM.cargarClaveElectronica();

            Dclave = objC.getEstado();
            String consecutivoSUB = Dclave["consecutivo"].Substring(10, 10);
            decimal consecutivo = decimal.Parse(consecutivoSUB) +1;
            decimal seguridad = decimal.Parse(Dclave["codigoseguridad"]) + 1;

            Dclave["codigoFacturaInterno"] = pnunFactura;
            Dclave["dia"] = pdia;
            Dclave["mes"] = pmes;
            Dclave["anno"] = panno;           
            Dclave["consecutivo"] = "0010000101" + (consecutivo.ToString().PadLeft(10, '0'));
            Dclave["codigoseguridad"] = seguridad.ToString().PadLeft(8, '0');

            CapaLogica.clavefacturacionelectronica objCG = new clavefacturacionelectronica(Dclave["codigoFacturaInterno"],Dclave["dia"],
                                                                                           Dclave["mes"], Dclave["anno"],
                                                                                           Dclave["consecutivo"], Dclave["situacioncomprobante"], Dclave["codigoseguridad"]);

            objCG.guardar("01");
            return Dclave;


        }

        public Dictionary<String, String> optenerClaveTiquete(String pdia, String pmes, String panno, String pnunFactura)
        {
            Dictionary<String, String> Dclave = new Dictionary<string, string>();
            CapaDatos.multicalvelectronica objM = new CapaDatos.multicalvelectronica();
            CapaLogica.clavefacturacionelectronica objC = objM.cargarClaveElectronicaTiquete();

            Dclave = objC.getEstado();


            String consecutivoSUB = Dclave["consecutivo"].Substring(10,10);
            decimal consecutivo = decimal.Parse(consecutivoSUB) + 1;
            decimal seguridad = decimal.Parse(Dclave["codigoseguridad"]) + 1;

            Dclave["codigoFacturaInterno"] = pnunFactura;
            Dclave["dia"] = pdia;
            Dclave["mes"] = pmes;
            Dclave["anno"] = panno;
            Dclave["consecutivo"] = "0010000104"+(consecutivo.ToString().PadLeft(10,'0'));
            Dclave["codigoseguridad"] = seguridad.ToString().PadLeft(8,'0');
            CapaLogica.clavefacturacionelectronica objCG = new clavefacturacionelectronica(Dclave["codigoFacturaInterno"], Dclave["dia"],
                                                                                           Dclave["mes"], Dclave["anno"],
                                                                                           Dclave["consecutivo"], Dclave["situacioncomprobante"], Dclave["codigoseguridad"]);

            objCG.guardar("04");
            return Dclave;


        }

        public List<String> cargarConsecutivoReceptor()
        {
            List<String> LconsecutivoReceptor = new List<string>();
            CapaDatos.multicalvelectronica objM = new CapaDatos.multicalvelectronica();

            LconsecutivoReceptor = objM.cargarConsecutivoReceptor();
            return LconsecutivoReceptor;

        }

        public void crearDatosFactura(Dictionary<String,String> Drecepcion)
        {
            CapaDatos.multicalvelectronica objM = new CapaDatos.multicalvelectronica();

            objM.crearDatosFactura(Drecepcion);

        }

        public void guardarConsecutivoReceptor(Dictionary<String,String> Dconsecutivo)
        {
            CapaDatos.multicalvelectronica objM = new CapaDatos.multicalvelectronica();

            objM.guardarConsecutivoReceptor(Dconsecutivo);

        }

        public List<Dictionary<String, String>> optenerDatosFactura()
        {
            List<Dictionary<String, String>> LdatosFactura = new List<Dictionary<String, String>>();
            CapaDatos.multicalvelectronica objG = new CapaDatos.multicalvelectronica();

            LdatosFactura = objG.optenerDatosFactura();

            return LdatosFactura;
        }

        public String optenerToken()
        {
            String token;
            CapaDatos.multicalvelectronica objM = new CapaDatos.multicalvelectronica();
            token = objM.optenerToken();

            return token;
        }


        /*FINAL DE GESTION DE FACTURA*/

        /*INICIO DE GESTION DE CLIENTE*/
        public void crearCliente(Dictionary<string,string> Dcliente)
        {
            CapaLogica.cliente objC = new CapaLogica.cliente(Dcliente["idCliente"], Dcliente["NombreCliente"], Dcliente["Identificacion"], Dcliente["TipoIdentificacion"],
                                                             Dcliente["Telefono"], Dcliente["Direccion"], Dcliente["Email"], Dcliente["CodigoClienteF"]);

            objC.guardar();
        }
        public List<CapaLogica.cliente> buscarCliente(string pnombre)
        {
            CapaDatos.multiCliente objC = new CapaDatos.multiCliente();
            List<CapaLogica.cliente> Lclientes = new List<CapaLogica.cliente>();

            Lclientes =  objC.buscarCliente(pnombre);
            return Lclientes;
        }

        public Dictionary<String,string> buscarClienteXid(string pid)
        {
            CapaDatos.multiCliente objC = new CapaDatos.multiCliente();
            List<CapaLogica.cliente> Lclientes = new List<CapaLogica.cliente>();
            Dictionary<String, string> Dcliente = new Dictionary<string, string>();

            Lclientes = objC.buscarClienteXid(pid);
            Dcliente = Lclientes[0].getEstado();
            return Dcliente;
        }

        public String buscarUltimoIdCliente()
        {
            string result;
            CapaDatos.multiCliente objC = new CapaDatos.multiCliente();
            result = objC.buscarUltimoIdCliente();
            return result;
        }
        public List<Dictionary<string, string>> listarClientes()
        {
            CapaDatos.multiCliente objM = new CapaDatos.multiCliente();
            List<Dictionary<string, string>> LClientes = new List<Dictionary<string, string>>();
            List<cliente> LproductosOBJ = new List<cliente>();

            LproductosOBJ = objM.listarClientes();


            for (int a = 0; a < LproductosOBJ.Count; a++)
            {
                LClientes.Add(LproductosOBJ[a].getEstado());
            }

            return LClientes;
        }


        /*FINAL DE GESTION DE CLIENTE*/

        /*INICIO DE GESTION DE FINANZAS */
        public List<String> optenerTipoSalidas()
        {
            List<String> LtipoSalidas = new List<String>();
            Dictionary<String, String> Dfinanza = new Dictionary<String, String>();
           
            CapaDatos.multiFinanza objMF = new CapaDatos.multiFinanza();


            List<CapaLogica.finanza> LobjFinanza = objMF.optenerFinanzas();

            for (int a = 0;a<LobjFinanza.Count;a++)
            {
                Dfinanza = (LobjFinanza[a].getEstado());

                LtipoSalidas.Add(Dfinanza["nombre"]);
            }


            return LtipoSalidas;
        }

        public Dictionary<String,String> optenerFinanza(String pfinanza)
        {

            Dictionary<String, String> Dfinanza = new Dictionary<String, String>();

            CapaDatos.multiFinanza objMF = new CapaDatos.multiFinanza();


            List<CapaLogica.finanza> LobjFinanza = objMF.optenerFinanzas();

            for (int a = 0;a<LobjFinanza.Count;a++)
            {
                if (LobjFinanza[a].getnombre().Equals(pfinanza))
                {
                    Dfinanza = LobjFinanza[a].getEstado();
                }
            }


            return Dfinanza;

        }



        /*FINAL DE GESTION DE FINANZAS*/


        /*INICIO DE GESTION DE MOVIMIENTOS */

        public void crearMovimiento(Dictionary<String,String> pDmovimiento)
        {

            CapaLogica.movimiento objM = new CapaLogica.movimiento(pDmovimiento["tipoMovimiento"], pDmovimiento["finanzaAfectada"],
                                                                   Double.Parse(pDmovimiento["montoMovimiento"]), pDmovimiento["razonMovimiento"],
                                                                   pDmovimiento["usuarioMovimiento"], pDmovimiento["fechaMovimiento"]);

            objM.guardar();

            CapaLogica.finanza objF = new CapaLogica.finanza(pDmovimiento["finanzaAfectada"], 
                                                             Double.Parse(pDmovimiento["montoMovimiento"]),
                                                             pDmovimiento["fechaMovimiento"]);

            if (pDmovimiento["tipoMovimiento"].Equals("Retiro"))
            {
                objF.guardarRetiro();
            }
            else if(pDmovimiento["tipoMovimiento"].Equals("Deposito"))
            {
                objF.guardarDeposito();
            }
         
        }

        public List<Dictionary<String, String>> cargarMovimentos(String pmovimientoFinanza)
        {
            List<Dictionary<String, String>> Lmovimientos = new List<Dictionary<String,String>>();
            List<CapaLogica.movimiento> Lmovimiento = new List<movimiento>();

            CapaDatos.multiMovimiento objMM = new CapaDatos.multiMovimiento();

            Lmovimiento = objMM.cargarMovimientos(pmovimientoFinanza);

            for (int a = 0;a<Lmovimiento.Count();a++)
            {
                Lmovimientos.Add(Lmovimiento[a].getEstado());
            }

            return Lmovimientos;
        }


        /*FINAL DE GESTION DE MOVIMIENTOS*/







        /*INICIO DE GESTION */

        public Dictionary<string,string> getDatos()
        {
            Dictionary<string, string> Ddatos = new Dictionary<string, string>();
            CapaDatos.multiDatos objM = new CapaDatos.multiDatos();

            Ddatos = objM.getDatos();

            return Ddatos;
        }


        public List<Dictionary<String, String>> getCanton(String pprovincia)
        {
            List<Dictionary<String, String>> Lcanton = new List<Dictionary<String, String>>();
            CapaDatos.multiDatos objM = new CapaDatos.multiDatos();

            Lcanton = objM.getCanton(pprovincia);

            return Lcanton;
        }

        public List<Dictionary<String, String>> getDistrito(String pdistrito)
        {
            List<Dictionary<String, String>> Ldistrito = new List<Dictionary<String, String>>();
            CapaDatos.multiDatos objM = new CapaDatos.multiDatos();

            Ldistrito = objM.getDistrito(pdistrito);

            return Ldistrito;
        }


        /*FINAL DE GESTION */

    }
}
