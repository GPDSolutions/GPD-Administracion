using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaLogica
{
    class usuario
    {

        String nombreUsuario;
        String loginUsuario;
        String contrasenna;
        String rol;

        public  usuario(String pnombreUsuario, String ploginUsuario,String pcontrasenna, String prol)
        {

            setnombreUsuario(pnombreUsuario);
            setloginUsuario(ploginUsuario);
            setcontrasenna(pcontrasenna);
            setrol(prol);


        }

        public usuario(String ploginUsuario)
        {
            setloginUsuario(ploginUsuario);
            setnombreUsuario(nombreUsuario);
            setcontrasenna(contrasenna);
            setrol(rol);
        }

        public usuario(String ploginUsuario,String pcontrasenna)
        {
            setloginUsuario(ploginUsuario);
            setnombreUsuario(nombreUsuario);
            setcontrasenna(pcontrasenna);
            setrol(rol);
        }


        public usuario(String pnombreUsuario, String ploginUsuario,String prol)
        {
            setloginUsuario(ploginUsuario);
            setnombreUsuario(pnombreUsuario);
            setcontrasenna(contrasenna);
            setrol(prol);
        }




        public void setnombreUsuario(String pnombreUsuario)
        {

            if (pnombreUsuario == null)
            {
                nombreUsuario = (new CapaDatos.multiUsuario().cargarNombreUsuario(this.getlogiUsuario()));
            }
            else
            {
                nombreUsuario = pnombreUsuario;
            }
            
        }

        public void setloginUsuario(String ploginUsuario)
        {
            loginUsuario = ploginUsuario;
        }

        public void setcontrasenna(String pcontrasenna)
        {

            if (pcontrasenna == null)
            {
                contrasenna = (new CapaDatos.multiUsuario().cargarContrasenna(this.getlogiUsuario()));
            }
            else
            {
                contrasenna = pcontrasenna;
            }
            
        }

        public void setrol(String prol)
        {

            if (prol == null)
            {
                rol = (new CapaDatos.multiUsuario().cargarRol(this.getlogiUsuario()));
            }
            else
            {
                rol = prol;
            }
           
        }



        public String getnombreUsuario()
        {
            return nombreUsuario;
        }

        public String getlogiUsuario()
        {
            return loginUsuario;
        }

        public String getcontrasenna()
        {
            return contrasenna;
        }

        public String getrol()
        {
            return rol;
        }


        /*FINAL DE GETS*/


        /*INICIO DE METODOS*/

        public Boolean guardar()
        {
            Boolean verificacion = false;
            CapaDatos.multiUsuario objU = new CapaDatos.multiUsuario();

            if (objU.consultarUsuario(this.getlogiUsuario(), this.getcontrasenna()).Equals("1"))
            {
                verificacion = objU.modificarUsuario(this.getnombreUsuario(), this.getlogiUsuario(), this.getrol(), this.getcontrasenna());
            }
            else
            {

                objU.crearUsuario(this.getnombreUsuario(), this.getlogiUsuario(), this.getrol());
               
            }
            return verificacion;
        }

        public Boolean modificarContrasenna()
        {
            Boolean verificacion = false;
            CapaDatos.multiUsuario objU = new CapaDatos.multiUsuario();
            verificacion = objU.modificarUsuario(this.getnombreUsuario(), this.getlogiUsuario(), this.getrol(), this.getcontrasenna());


            return verificacion;
        }

        public Dictionary<string, string> getEstado()
        {

            Dictionary<string, string> Dusuario = new Dictionary<string, string>();

            Dusuario.Add("nombreUsuario",this.getnombreUsuario());
            Dusuario.Add("usuario",this.getlogiUsuario());
            Dusuario.Add("contrasenna",this.getcontrasenna());
            Dusuario.Add("rol",this.getrol());


            return Dusuario;
        }

        /*FINAL DE METODOS*/




    }
}
