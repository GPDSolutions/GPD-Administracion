using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ace_Super_Market.CapaLogica
{
    class clavefacturacionelectronica
    {
        String codigoFacturaInterno;
        String codigopais = "506";
        String dia;
        String mes;
        String anno;
        String identificacion = "003101769387";
        String consecutivo;
        String situacioncomprobante;
        String codigoseguridad;

        public clavefacturacionelectronica(String pcodigoFacturaInterno, String pdia, String pmes, String panno, String pconsecutivo, String psituacioncomprobante, String pcodigoseguridad)
        {
            setcodigoFacturaInterno(pcodigoFacturaInterno);
            setdia(pdia);
            setmes(pmes);
            setanno(panno);
            setconsecutivo(pconsecutivo);
            setsituacioncomprobante(psituacioncomprobante);
            setcodigoseguridad(pcodigoseguridad);
        }
        public void setcodigoFacturaInterno(String pcodigoFacturaInterno)
        {
            codigoFacturaInterno = pcodigoFacturaInterno;
        }
        public void setdia(String pdia)
        {
            dia = pdia;
        }

        public void setmes(String pmes)
        {
            mes = pmes;
        }
        public void setanno(String panno)
        {
            anno = panno;
        }
        public void setconsecutivo(String pconsecutivo)
        {
            consecutivo = pconsecutivo;
        }
        public void setsituacioncomprobante(String psituacioncomprobante)
        {
            situacioncomprobante = psituacioncomprobante;
        }
        public void setcodigoseguridad(String pcodigoseguridad)
        {
            codigoseguridad = pcodigoseguridad;
        }


        public String getcodigoFacturaInterno()
        {
            return codigoFacturaInterno;
        }

        public String getcodigopais()
        {
            return codigopais;
        }

        public String getdia()
        {
            return dia;
        }

        public String getmes()
        {
            return mes;
        }

        public String getanno()
        {
            return anno;
        }

        public String getidentificacion()
        {
            return identificacion;
        }

        public String getconsecutivo()
        {
            return consecutivo;
        }

        public String getsituacioncomprobante()
        {
            return situacioncomprobante;
        }

        public String getcodigoseguridad()
        {
            return codigoseguridad;
        }


        public void guardar(String tipo)
        {
            CapaDatos.multicalvelectronica objM = new CapaDatos.multicalvelectronica();
            if (tipo.Equals("01"))
            {
                objM.crearClaveElectronica(this.getcodigoFacturaInterno(), this.getcodigopais(), this.getdia(), this.getmes(), this.getanno(), this.getidentificacion(),
                           this.getconsecutivo(), this.getsituacioncomprobante(), this.getcodigoseguridad());
            }
            else if (tipo.Equals("02"))
            {

            }
            else if (tipo.Equals("03"))
            {

            }
            else if (tipo.Equals("04"))
            {
                objM.crearClaveElectronicaTiquete(this.getcodigoFacturaInterno(), this.getcodigopais(), this.getdia(), this.getmes(), this.getanno(), this.getidentificacion(),
           this.getconsecutivo(), this.getsituacioncomprobante(), this.getcodigoseguridad());
            }


        }


        public Dictionary<String,String> getEstado()
        {
            Dictionary<String, String> Dclave = new Dictionary<string, string>();

            Dclave.Add("codigoFacturaInterno", this.getcodigoFacturaInterno());
            Dclave.Add("codigopais", this.getcodigopais());
            Dclave.Add("dia",this.getdia());
            Dclave.Add("mes",this.getmes());
            Dclave.Add("anno",this.getanno());
            Dclave.Add("identificacion",this.getidentificacion());
            Dclave.Add("consecutivo",this.getconsecutivo());
            Dclave.Add("situacioncomprobante",this.getsituacioncomprobante());
            Dclave.Add("codigoseguridad", this.getcodigoseguridad());

            return Dclave;
        }

    }
}
