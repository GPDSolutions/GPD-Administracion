using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ace_Super_Market.CapaLogica
{
    class cliente
    {
        String idCliente;
        String nombreCliente;
        String identificacion;
        String tipoIdentificacion;
        String telefono;
        String direccion;
        String email;
        String codigoClienteF;

        public cliente(String pidcliente, String pnombre ,String pidentificacion, String ptipoIdenficacion, String ptelefono, String pdireccion, String pemail,String pcodigoClienteF)
        {
            setidCliente(pidcliente);
            setnombreCliente(pnombre);
            setidentificacion(pidentificacion);
            settipoIdentificacion(ptipoIdenficacion);
            settelefono(ptelefono);
            setddireccion(pdireccion);
            setemail(pemail);
            setcodigoClienteF(pcodigoClienteF);
        }

        /*INICIO DE SETS*/

        public void setidCliente(String pidcliente)
        {
            idCliente = pidcliente;
        }
        public void setnombreCliente(String pnombre)
        {
            nombreCliente = pnombre;
        }

        public void setidentificacion(String pidentificacion)
        {
            identificacion = pidentificacion;
        }

        public void settipoIdentificacion(String ptipoIdentificacion)
        {
            tipoIdentificacion = ptipoIdentificacion;
        }

        public void settelefono(String ptelefono)
        {
            telefono = ptelefono;
        }

        public void setddireccion(String pdireccion)
        {
            direccion = pdireccion;
        }

        public void setemail(String pemail)
        {
            email = pemail;
        }

        public void setcodigoClienteF(String pcodigoClienteF)
        {
            codigoClienteF = pcodigoClienteF;
        }
        /*FIN DE SETS*/

        /*INICIO DE GETS*/

        public String getidCliente()
        {
            return idCliente;
        }

        public String getnombreCliente()
        {
            return nombreCliente;
        }

        public String getidentificacion()
        {
            return identificacion;
        }

        public String gettipoIdentificacion()
        {
            return tipoIdentificacion;
        }

        public String gettelefono()
        {
            return telefono;
        }

        public String getdireccion()
        {
            return direccion;
        }

        public String getemail()
        {
            return email;
        }

        public String getcodigoClienteF()
        {
            return codigoClienteF;
        }
        /*FIN DE GETS*/

        /*INICIO DE METODOS*/
        public Boolean guardar()
        {
            Boolean verificacion = false;
            CapaDatos.multiCliente objC = new CapaDatos.multiCliente();

            if (objC.consultarCliente(this.getidCliente()).Equals("1"))
            {
                objC.modificarCliente(this.getidCliente(), this.getnombreCliente(), this.getidentificacion(), this.gettipoIdentificacion(),
                                  this.gettelefono(), this.getdireccion(), this.getemail(), this.getcodigoClienteF());
            }
            else
            {

                objC.crearCliente(this.getidCliente(), this.getnombreCliente(), this.getidentificacion(), this.gettipoIdentificacion(),
                                  this.gettelefono(), this.getdireccion(), this.getemail(), this.getcodigoClienteF());

            }
            return verificacion;
        }

        public Dictionary<string, string> getEstado()
        {

            Dictionary<string, string> Dcliente = new Dictionary<string, string>();

            Dcliente.Add("idCliente",this.getidCliente());
            Dcliente.Add("nombreCliente", this.getnombreCliente());
            Dcliente.Add("identificacion", this.getidentificacion());
            Dcliente.Add("tipoIdentificacion", this.gettipoIdentificacion());
            Dcliente.Add("telefono", this.gettelefono());
            Dcliente.Add("direccion", this.getdireccion());
            Dcliente.Add("email", this.getemail());
            Dcliente.Add("codigoClienteF", this.getcodigoClienteF());
            return Dcliente;
        }

        /*FIN DE METODOS*/
    }
}
