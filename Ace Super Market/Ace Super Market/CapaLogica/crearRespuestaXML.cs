using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ace_Super_Market.CapaLogica
{
    class crearRespuestaXML
    {

        public Boolean crearRespuesHaciendataXML(Dictionary<String, String> DdatosFactura)
        {
            XDocument doc = new XDocument();

            XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
            XNamespace xs = "http://www.w3.org/2001/XMLSchema";
            XNamespace xmlns = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/mensajeReceptor";


            XElement raiz = new XElement(xmlns + "MensajeReceptor");
            raiz.SetAttributeValue(XNamespace.Xmlns + "xsi", xsi);
            raiz.SetAttributeValue(XNamespace.Xmlns + "xs", xs);
            raiz.SetAttributeValue("xmlns", xmlns);



            XElement clave = new XElement(xmlns + "Clave", DdatosFactura["clave"]);
            raiz.Add(clave);

            XElement NumeroCedulaEmisor = new XElement(xmlns + "NumeroCedulaEmisor", DdatosFactura["numerocedulaemisor"]);
            raiz.Add(NumeroCedulaEmisor);

            XElement FechaEmisionDoc = new XElement(xmlns + "FechaEmisionDoc", DdatosFactura["fechaemisiondoc"]);
            raiz.Add(FechaEmisionDoc);

            XElement Mensaje = new XElement(xmlns + "Mensaje", DdatosFactura["mensaje"]);
            raiz.Add(Mensaje);


            XElement MontoTotalImpuesto = new XElement(xmlns + "MontoTotalImpuesto", DdatosFactura["montototalimpuesto"]);
            raiz.Add(MontoTotalImpuesto);

            XElement TotalFactura = new XElement(xmlns + "TotalFactura", DdatosFactura["totalfactura"]);
            raiz.Add(TotalFactura);

            XElement NumeroCedulaReceptor = new XElement(xmlns + "NumeroCedulaReceptor", DdatosFactura["numerocedulareceptor"]);
            raiz.Add(NumeroCedulaReceptor);

            XElement NumeroConsecutivoReceptor = new XElement(xmlns + "NumeroConsecutivoReceptor", DdatosFactura["numeroconsecutivoreceptor"]);
            raiz.Add(NumeroConsecutivoReceptor);

            doc.Add(raiz);
            String pathMensajeReceptor = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\XMLSinFirma\MensajeReceptorSF" + DdatosFactura["numeroconsecutivoreceptor"] + ".xml";
            doc.Save(pathMensajeReceptor);

            CapaLogica.firmarDocsXML objFD = new firmarDocsXML();
            CapaLogica.funcionesCodificacion objCOD = new funcionesCodificacion();
            CapaLogica.envioCorreo objEC = new envioCorreo();
            String apthMensajeReceptorFirmado = objFD.firmadoMensajeReceptor(pathMensajeReceptor, DdatosFactura["numeroconsecutivoreceptor"]);

            String xmlMensajeReceptorCodificado = objCOD.XMLtoBase64(apthMensajeReceptorFirmado);
            CapaLogica.gestor objG = new gestor();
            CapaLogica.envioHacienda objEH = new envioHacienda();
          Boolean result =  objEH.verificacionMensajeReceptor(xmlMensajeReceptorCodificado, objG.optenerToken(), DdatosFactura);


             if (result == true)
             {
                 objEC.sendCorreoConfirmacion(apthMensajeReceptorFirmado,DdatosFactura);
             }

            return true;
        }
    }
}
