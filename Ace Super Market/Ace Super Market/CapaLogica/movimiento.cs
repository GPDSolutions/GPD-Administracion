using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ace_Super_Market.CapaLogica
{
    class movimiento
    {

        String tipoMovimiento;
        String finanzaAfectada;
        Double montoMovimento;
        String razonMovimiento;
        String usuarioMovimiento;
        String fechaMovimiento;

        public movimiento(String ptipoMovimiento, String pfinanzaAfectada, Double pmontoMovimento, String prazonMovimiento, String pusuarioMovimiento, String pfechaMovimiento)
        {
            settipoMovimiento(ptipoMovimiento);
            setfinanzaAfectada(pfinanzaAfectada);
            setmontoMovimento(pmontoMovimento);
            setrazonMovimiento(prazonMovimiento);
            setusuarioMovimiento(pusuarioMovimiento);
            setfechaMovimiento(pfechaMovimiento);

        }
        /*INICIO DE SETS*/
        public void settipoMovimiento(String ptipoMovimiento)
        {
            tipoMovimiento = ptipoMovimiento;
        }
        public void setfinanzaAfectada(String pfinanzaAfectada)
        {
            finanzaAfectada = pfinanzaAfectada;
        }
        public void setmontoMovimento(Double pmontoMovimento)
        {
            montoMovimento = pmontoMovimento;
        }
        public void setrazonMovimiento(String prazonMovimiento)
        {
            razonMovimiento = prazonMovimiento;
        }
        public void setusuarioMovimiento(String pusuarioMovimiento)
        {
            usuarioMovimiento = pusuarioMovimiento
;
        }
        public void setfechaMovimiento(String pfechaMovimiento)
        {
            fechaMovimiento = pfechaMovimiento;
        }
        /*FINAL DE SETS*/

        /*INICIO DE GETS*/

        public String gettipoMovimiento()
        {
            return tipoMovimiento;
        }
        public String getfinanzaAfectada()
        {
            return finanzaAfectada;
        }
        public Double getmontoMovimento()
        {
            return montoMovimento;
        }
        public String getrazonMovimiento()
        {
            return razonMovimiento;
        }
        public String getusuarioMovimiento()
        {
            return usuarioMovimiento;
        }
        public String getfechaMovimiento()
        {
            return fechaMovimiento;
        }
        /*FINAL DE GETS*/

        /*INICIO DE METODOS*/
        public void guardar()
        {
            CapaDatos.multiMovimiento objMM = new CapaDatos.multiMovimiento();

            objMM.crearMovimiento(this.gettipoMovimiento(),this.getfinanzaAfectada(),this.getmontoMovimento(),this.getrazonMovimiento(),this.getusuarioMovimiento(),this.getfechaMovimiento());
        }



        public Dictionary<String, String> getEstado()
        {
            Dictionary<String, String> Dmovimiento = new Dictionary<string, string>();

            Dmovimiento.Add("tipoMovimiento", this.gettipoMovimiento());
            Dmovimiento.Add("finanzaAfectada",this.getfinanzaAfectada());
            Dmovimiento.Add("montoMovimento", this.getmontoMovimento().ToString());
            Dmovimiento.Add("razonMovimiento", this.getrazonMovimiento());
            Dmovimiento.Add("usuarioMovimiento", this.getusuarioMovimiento());
            Dmovimiento.Add("fechaMovimiento", this.getfechaMovimiento());

            return Dmovimiento;
        }
        /*FINAL DE METODOS*/
    }
}
