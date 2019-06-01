using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ace_Super_Market.CapaLogica
{
    class crearFacturaXML
    {

        public void generarXMLFactura(Dictionary<String, String> Dclave, Dictionary<String, String> Dcliente,
                                        List<String> codigoProducto, List<String> precioProducto, List<String> cantidad, List<String> total, List<String> tipoProducto,
                                        List<String> nombreProducto, List<String> unidadMedida)
        {

            String Clave = Dclave["codigopais"] + Dclave["dia"] + Dclave["mes"] + Dclave["anno"] + Dclave["identificacion"] + Dclave["consecutivo"] + Dclave["situacioncomprobante"] + Dclave["codigoseguridad"];
            DateTime thisDay = DateTime.Today;
            String[] codUbicacion = Dcliente["codigoClienteF"].Split(',');



            XDocument doc = new XDocument();

            XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
            XNamespace xsd = "http://www.w3.org/2001/XMLSchema";
            XNamespace xmlns = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica";
            XNamespace schemaLocation = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica.xsd";


            XElement raiz = new XElement(xmlns + "FacturaElectronica");
            raiz.SetAttributeValue(XNamespace.Xmlns + "xsi", xsi);
            raiz.SetAttributeValue(XNamespace.Xmlns + "xsd", xsd);
            raiz.SetAttributeValue(XNamespace.Xmlns + "schemaLocation", schemaLocation);
            raiz.SetAttributeValue("xmlns", xmlns);
            XElement clave = new XElement(xmlns + "Clave", Clave);
            raiz.Add(clave);
            XElement NumeroConsecutivo = new XElement(xmlns + "NumeroConsecutivo", Dclave["consecutivo"]);
            raiz.Add(NumeroConsecutivo);
            XElement FechaEmision = new XElement(xmlns + "FechaEmision", thisDay.ToString("yyyy-MM-dd") + "T" + DateTime.Now.ToString("HH:mm:ss"));
            raiz.Add(FechaEmision);
            XElement Emisor = new XElement(xmlns + "Emisor",
                                new XElement(xmlns + "Nombre", "ACESERVICES SOCIEDAD ANONIMA"),
                                new XElement(xmlns + "Identificacion",
                                    new XElement(xmlns + "Tipo", "02"),
                                    new XElement(xmlns + "Numero", "3101769387")),
                                new XElement(xmlns + "NombreComercial", "Ace Super Market"),
                                new XElement(xmlns + "Ubicacion",
                                    new XElement(xmlns + "Provincia", "6"),
                                    new XElement(xmlns + "Canton", "05"),
                                    new XElement(xmlns + "Distrito", "01"),
                                    new XElement(xmlns + "Barrio", "01"),
                                    new XElement(xmlns + "OtrasSenas", "Calle del Comercio, Frente a Tienda el Aterrizaje")),
                                new XElement(xmlns + "Telefono",
                                    new XElement(xmlns + "CodigoPais", "506"),
                                    new XElement(xmlns + "NumTelefono", "85221875")),
                                new XElement(xmlns + "Fax",
                                    new XElement(xmlns + "CodigoPais", "0"),
                                    new XElement(xmlns + "NumTelefono", "0")),
                                new XElement(xmlns + "CorreoElectronico", "info@aceservicex.com"));
            raiz.Add(Emisor);

            XElement Receptor = new XElement(xmlns + "Receptor",
                                new XElement(xmlns + "Nombre", Dcliente["nombreCliente"]),
                                new XElement(xmlns + "Identificacion",
                                    new XElement(xmlns + "Tipo", Dcliente["tipoIdentificacion"]),
                                    new XElement(xmlns + "Numero", Dcliente["identificacion"])),
                                new XElement(xmlns + "IdentificacionExtranjero", "N/A"),
                                new XElement(xmlns + "NombreComercial", Dcliente["nombreCliente"]),
                                new XElement(xmlns + "Ubicacion",
                                    new XElement(xmlns + "Provincia", codUbicacion[0]),
                                    new XElement(xmlns + "Canton", codUbicacion[1]),
                                    new XElement(xmlns + "Distrito", codUbicacion[2]),
                                    new XElement(xmlns + "Barrio", codUbicacion[3]),
                                    new XElement(xmlns + "OtrasSenas", Dcliente["direccion"])),
                                new XElement(xmlns + "Telefono",
                                    new XElement(xmlns + "CodigoPais", "506"),
                                    new XElement(xmlns + "NumTelefono", Dcliente["telefono"])),
                                new XElement(xmlns + "CorreoElectronico", Dcliente["email"]));
            raiz.Add(Receptor);

            XElement CondicionVenta = new XElement(xmlns + "CondicionVenta", "01");
            raiz.Add(CondicionVenta);

            XElement MedioPago = new XElement(xmlns + "MedioPago", "01");
            raiz.Add(MedioPago);

            XElement DetalleServicio = new XElement(xmlns + "DetalleServicio");
            for (int a = 0; a < codigoProducto.Count; a++)
            {
                if (tipoProducto[a].Equals("GR"))
                {
                    DetalleServicio.Add(new XElement(xmlns + "LineaDetalle",
                                 new XElement(xmlns + "NumeroLinea", a + 1),
                                 new XElement(xmlns + "Codigo",
                                     new XElement(xmlns + "Tipo", "01"),
                                     new XElement(xmlns + "Codigo", codigoProducto[a])),
                             new XElement(xmlns + "Cantidad", cantidad[a]),
                             new XElement(xmlns + "UnidadMedida", unidadMedida[a]),
                             new XElement(xmlns + "Detalle", nombreProducto[a]),
                             new XElement(xmlns + "PrecioUnitario", (double.Parse(precioProducto[a]) - (double.Parse(precioProducto[a]) * 0.115)).ToString("00.00", CultureInfo.InvariantCulture)),
                             new XElement(xmlns + "MontoTotal", (double.Parse(total[a]) - (double.Parse(total[a]) * 0.115)).ToString("00.00", CultureInfo.InvariantCulture)),
                             new XElement(xmlns + "SubTotal", (double.Parse(total[a]) - (double.Parse(total[a]) * 0.115)).ToString("00.00", CultureInfo.InvariantCulture)),
                             new XElement(xmlns + "Impuesto",
                                  new XElement(xmlns + "Codigo", "01"),
                                  new XElement(xmlns + "Tarifa", "13.00"),
                                  new XElement(xmlns + "Monto", ((double.Parse(precioProducto[a]) - (double.Parse(precioProducto[a]) * 0.115)) * 0.13).ToString("00.00", CultureInfo.InvariantCulture))),
                            new XElement(xmlns + "MontoTotalLinea", (((double.Parse(precioProducto[a]) - (double.Parse(precioProducto[a]) * 0.115)) * 0.13) + (double.Parse(total[a]) - (double.Parse(total[a]) * 0.115))).ToString("00.00", CultureInfo.InvariantCulture))));

                }
                else
                {
                    DetalleServicio.Add(new XElement(xmlns + "LineaDetalle",
                                new XElement(xmlns + "NumeroLinea", a + 1),
                                new XElement(xmlns + "Codigo",
                                    new XElement(xmlns + "Tipo", "01"),
                                    new XElement(xmlns + "Codigo", codigoProducto[a])),
                            new XElement(xmlns + "Cantidad", cantidad[a]),
                            new XElement(xmlns + "UnidadMedida", unidadMedida[a]),
                            new XElement(xmlns + "Detalle", nombreProducto[a]),
                            new XElement(xmlns + "PrecioUnitario", precioProducto[a]),
                            new XElement(xmlns + "MontoTotal", total[a]),
                            new XElement(xmlns + "SubTotal", total[a]),
                                new XElement(xmlns + "MontoTotalLinea", total[a])));



                }


            }

            raiz.Add(DetalleServicio);
            double totalGR = 0;
            double totalEX = 0;
            double totalIM = 0;
            for (int a = 0; a < tipoProducto.Count; a++)
            {
                if (tipoProducto[a].Equals("GR"))
                {
                    totalGR = totalGR + double.Parse(total[a]) - (double.Parse(total[a]) * 0.115);
                    totalIM = totalIM + ((double.Parse(precioProducto[a]) - (double.Parse(precioProducto[a]) * 0.115)) * 0.13);
                }
                else
                {
                    totalEX = totalEX + double.Parse(total[a]);
                }

            }

            XElement ResumenFactura = new XElement(xmlns + "ResumenFactura",
                                          new XElement(xmlns + "CodigoMoneda", "CRC"),
                                          new XElement(xmlns + "TipoCambio", "562.00"),
                                          new XElement(xmlns + "TotalServGravados", "0"),
                                          new XElement(xmlns + "TotalServExentos", "0.00"),
                                          new XElement(xmlns + "TotalMercanciasGravadas", totalGR.ToString("00.00", CultureInfo.InvariantCulture)),
                                          new XElement(xmlns + "TotalMercanciasExentas", totalEX),
                                          new XElement(xmlns + "TotalGravado", totalGR.ToString("00.00", CultureInfo.InvariantCulture)),
                                          new XElement(xmlns + "TotalExento", totalEX),
                                          new XElement(xmlns + "TotalVenta", (totalEX + totalGR).ToString("00.00", CultureInfo.InvariantCulture)),
                                          new XElement(xmlns + "TotalDescuentos", "0"),
                                          new XElement(xmlns + "TotalVentaNeta", (totalEX + totalGR).ToString("00.00", CultureInfo.InvariantCulture)),
                                          new XElement(xmlns + "TotalImpuesto", totalIM.ToString("00.00", CultureInfo.InvariantCulture)),
                                          new XElement(xmlns + "TotalComprobante", (totalEX + totalGR + totalIM).ToString("00.00", CultureInfo.InvariantCulture)));
            raiz.Add(ResumenFactura);

            XElement Normativa = new XElement(xmlns + "Normativa",
                                    new XElement(xmlns + "NumeroResolucion", "DGT-R-48-2016"),
                                    new XElement(xmlns + "FechaResolucion", "07-10-2016 00:00:00"));
            raiz.Add(Normativa);

            XElement Otros = new XElement(xmlns + "Otros",
                        new XElement(xmlns + "OtroTexto", "N.A."));
            raiz.Add(Otros);


            doc.Add(raiz);

            String pathFactura = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\XMLSinFirma\FacturaSF" + Dclave["consecutivo"] + ".xml";
            doc.Save(pathFactura);

            CapaLogica.gestor objG = new gestor();
            CapaLogica.firmarDocsXML objF = new firmarDocsXML();
            CapaLogica.funcionesCodificacion objC = new funcionesCodificacion();
            CapaLogica.envioHacienda objE = new envioHacienda();
            CapaLogica.consultaHacienda objCon = new consultaHacienda();
            CapaLogica.generarPDFs objPDF = new generarPDFs();
            CapaLogica.envioCorreo objEC = new envioCorreo();
            String XMLFirmado = objF.firmadoFactura(pathFactura, Dclave["consecutivo"]);

            String XMLCodificado = objC.XMLtoBase64(XMLFirmado);
            
            objE.envioFacturaXML(XMLCodificado, objG.optenerToken(), Clave, thisDay.ToString("yyyy-MM-ddTHH:mm:ss"),
                                                               Dcliente["tipoIdentificacion"], Dcliente["identificacion"]);

           Boolean result =  objCon.verificacionEstatus(Clave, objG.optenerToken(), Dclave["consecutivo"]);

            String pathMensaje = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\XMLMensajeHacienda\MensaHacienda" + Dclave["consecutivo"] + ".xml";
            String FacturaFirmada = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\XMLFirmados\FacturaCF" + Dclave["consecutivo"] + ".xml";


            String pathPDF = objPDF.generarPDF(Clave, Dclave["consecutivo"], Dcliente, precioProducto, cantidad, total, nombreProducto, tipoProducto,Dclave["codigoseguridad"],"Factura");


            if (result == true)
            {
                objEC.sendCorreo(FacturaFirmada, pathMensaje, pathPDF, Dcliente, Dclave["consecutivo"]);
            }
            else
            {

            }


        }
    }
}
