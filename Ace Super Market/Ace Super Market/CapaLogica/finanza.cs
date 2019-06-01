using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ace_Super_Market.CapaLogica
{
    class finanza
    {

        String nombre;
        Double saldo;
        String fechaUltMovimiento;

        public finanza(String pnombre, Double psaldo, String pfechaUltMovimiento)
        {
            setnombre(pnombre);
            setsaldo(psaldo);
            setfechaUltMovimiento(pfechaUltMovimiento);
        }


        /*INICIO DE LOS SETS*/
        public void setnombre(String pnombre)
        {
            nombre = pnombre;
        }

        public void setsaldo(Double psaldo)
        {
            saldo = psaldo;
        }

        public void setfechaUltMovimiento(String pfechaUltMovimiento)
        {
            fechaUltMovimiento = pfechaUltMovimiento;
        }
        /*FINAL DE LOS SETS*/

        /*INICIO DE LOS GETS*/

        public String getnombre()
        {
            return nombre;
        }

        public Double getsaldo()
        {
            return saldo;
        }

        public String getfechaUltMovimiento()
        {
            return fechaUltMovimiento;
        }
        /*FINAL DE LOS GETS*/

        /*INICIO DE METODOS*/

        public void guardarRetiro()
        {
            CapaDatos.multiFinanza objM = new CapaDatos.multiFinanza();

            objM.crearRetiro(this.getnombre(),this.getsaldo(),this.getfechaUltMovimiento());
        }

        public void guardarDeposito()
        {
            CapaDatos.multiFinanza objM = new CapaDatos.multiFinanza();

            objM.crearDeposito(this.getnombre(), this.getsaldo(), this.getfechaUltMovimiento());
        }




        public Dictionary<String,String> getEstado()
        {
            Dictionary<String, String> Dfinanza = new Dictionary<string, string>();

            Dfinanza.Add("nombre",this.getnombre());
            Dfinanza.Add("saldo",this.getsaldo().ToString());
            Dfinanza.Add("fechaUltMovimiento",this.getfechaUltMovimiento());

            return Dfinanza;
        }
       /*FINAL DE METODOS*/
    }
}
