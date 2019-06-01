using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ace_Super_Market.CapaLogica
{
    class generarPDFs
    {

        public String generarPDF(String clave, String pconsecutivo, Dictionary<String, String> Dcliente, List<String> precioProducto, List<String> cantidad, List<String> total, List<String> nombreProducto,
                       List<String> tipoProducto,String codSeguridad,String tipoDoc)
        {
            Document doc = new Document(PageSize.LETTER);
            String pathPDF = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\PDFFactura\FacturaPDF" + pconsecutivo + ".pdf";
            PdfWriter writer = PdfWriter.GetInstance(doc,
                            new FileStream(pathPDF, FileMode.Create));

            DateTime thisDay = DateTime.Today;

            doc.AddTitle("Factura Electronica" + pconsecutivo);

            doc.Open();
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            // Escribimos el encabezamiento en el documento

            Paragraph lblfecha = new Paragraph("Fecha");
            lblfecha.Alignment = Element.ALIGN_RIGHT;
            Paragraph fecha = new Paragraph(thisDay.ToString("yyyy-MM-dd"));
            fecha.Alignment = Element.ALIGN_RIGHT;

            doc.Add(lblfecha);
            doc.Add(fecha);


            Paragraph nombre = new Paragraph("ACESERVICES SOCIEDAD ANONIMA");
            nombre.Alignment = Element.ALIGN_CENTER;
            Paragraph identificacion = new Paragraph("RUC / NIT : 601950392");
            identificacion.Alignment = Element.ALIGN_CENTER;
            Paragraph Direccion = new Paragraph("Direccion : Calle del Comercio, Frente a Tienda el Aterrizaje");
            Direccion.Alignment = Element.ALIGN_CENTER;
            Paragraph Telefono = new Paragraph("Telefono : 85221875");
            Telefono.Alignment = Element.ALIGN_CENTER;
            Paragraph Email = new Paragraph("Email : info@aceservicex.com");
            Email.Alignment = Element.ALIGN_CENTER;


            doc.Add(nombre);
            doc.Add(identificacion);
            doc.Add(Direccion);
            doc.Add(Telefono);
            doc.Add(Email);
            doc.Add(Chunk.NEWLINE);

            Paragraph tipoNum = new Paragraph(tipoDoc+" : "+ codSeguridad);
            tipoNum.Alignment = Element.ALIGN_RIGHT;

            doc.Add(tipoNum);
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(4);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clCloiente = new PdfPCell(new Phrase("Cliente : " + Dcliente["nombreCliente"], _standardFont));
            clCloiente.BorderWidth = 0;
            clCloiente.BorderWidthBottom = 0.75f;

            PdfPCell clCedula = new PdfPCell(new Phrase("Cédula : " + Dcliente["identificacion"], _standardFont));
            clCedula.BorderWidth = 0;
            clCedula.BorderWidthBottom = 0.75f;

            PdfPCell clPais = new PdfPCell(new Phrase("País: COSTA RICA", _standardFont));
            clPais.BorderWidth = 0;
            clPais.BorderWidthBottom = 0.75f;

            PdfPCell clContado = new PdfPCell(new Phrase("Contado", _standardFont));
            clContado.BorderWidth = 0;
            clContado.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clCloiente);
            tblPrueba.AddCell(clCedula);
            tblPrueba.AddCell(clPais);
            tblPrueba.AddCell(clContado);

            PdfPTable tblProductos = new PdfPTable(4);
            tblPrueba.WidthPercentage = 100;

            PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad : ", _standardFont));
            clCloiente.BorderWidth = 0;
            clCloiente.BorderWidthBottom = 0.75f;

            PdfPCell clArticulo = new PdfPCell(new Phrase("Articulo", _standardFont));
            clCedula.BorderWidth = 0;
            clCedula.BorderWidthBottom = 0.75f;

            PdfPCell clPU = new PdfPCell(new Phrase("Precio Unitario", _standardFont));
            clPais.BorderWidth = 0;
            clPais.BorderWidthBottom = 0.75f;

            PdfPCell clTotal = new PdfPCell(new Phrase("Total", _standardFont));
            clContado.BorderWidth = 0;
            clContado.BorderWidthBottom = 0.75f;

            tblProductos.AddCell(clCantidad);
            tblProductos.AddCell(clArticulo);
            tblProductos.AddCell(clPU);
            tblProductos.AddCell(clTotal);

            // Llenamos la tabla con información
            for (int a = 0; a < cantidad.Count; a++)
            {
                clCantidad = new PdfPCell(new Phrase(cantidad[a], _standardFont));
                clCantidad.BorderWidth = 0;

                clArticulo = new PdfPCell(new Phrase(nombreProducto[a], _standardFont));
                clArticulo.BorderWidth = 0;
                if (tipoProducto[a].Equals("GR"))
                {
                    String precio = (double.Parse(precioProducto[a]) - (double.Parse(precioProducto[a]) * 0.115)).ToString("00.00", CultureInfo.InvariantCulture);
                    clPU = new PdfPCell(new Phrase(precio, _standardFont));
                    clPU.BorderWidth = 0;
                    String totall = ((double.Parse(precio)) * double.Parse(cantidad[a])).ToString("00.00", CultureInfo.InvariantCulture);
                    clTotal = new PdfPCell(new Phrase(totall, _standardFont));

                }
                else
                {
                    String precio = (double.Parse(precioProducto[a])).ToString("00.00", CultureInfo.InvariantCulture);
                    clPU = new PdfPCell(new Phrase(precio, _standardFont));
                    clPU.BorderWidth = 0;
                    String totall = ((double.Parse(precio)) * double.Parse(cantidad[a])).ToString("00.00", CultureInfo.InvariantCulture);
                    clTotal = new PdfPCell(new Phrase(totall, _standardFont));

                }

                clTotal.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tblProductos.AddCell(clCantidad);
                tblProductos.AddCell(clArticulo);
                tblProductos.AddCell(clPU);
                tblProductos.AddCell(clTotal);
            }
            double totalGR = 0;
            double totalEX = 0;
            double totalIM = 0;
            for (int a = 0; a < cantidad.Count; a++)
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

            Paragraph descuento = new Paragraph("DESCUENTO" + "     " + "0");
            descuento.Alignment = Element.ALIGN_RIGHT;
            Paragraph sub = new Paragraph("SUB-TOTAL" + "     " + ((totalGR + totalEX) - totalIM).ToString("00.00", CultureInfo.InvariantCulture));
            sub.Alignment = Element.ALIGN_RIGHT;
            Paragraph imp = new Paragraph("IMP-VENTA" + "     " + (totalIM).ToString("00.00", CultureInfo.InvariantCulture));
            imp.Alignment = Element.ALIGN_RIGHT;
            Paragraph tota = new Paragraph("TOTAL" + "     " + (totalGR + totalEX + totalIM).ToString("00.00", CultureInfo.InvariantCulture));
            tota.Alignment = Element.ALIGN_RIGHT;




            Paragraph observaciones = new Paragraph("OBSERVACIONES");
            observaciones.Alignment = Element.ALIGN_CENTER;

            Paragraph txtobservaciones = new Paragraph("-------");
            txtobservaciones.Alignment = Element.ALIGN_CENTER;

            Paragraph FE = new Paragraph(tipoDoc + "Electrónica : " + pconsecutivo);

            Paragraph Clave = new Paragraph("Clave "+ tipoDoc + " Electrónica : " + clave);


            Paragraph formaPago = new Paragraph("Forma de Pago: Efectivo");


            Paragraph agrade = new Paragraph("¡GRACIAS POR SU COMPRA!");
            agrade.Alignment = Element.ALIGN_CENTER;

            Paragraph autori = new Paragraph("Autorizada mediante resolución Nº DGT-R-48-2016 del 7 de octubre de 2016");
            autori.Alignment = Element.ALIGN_CENTER;


            doc.Add(tblPrueba);
            doc.Add(tblProductos);
            doc.Add(descuento);
            doc.Add(sub);
            doc.Add(imp);
            doc.Add(tota);
            doc.Add(observaciones);
            doc.Add(txtobservaciones);
            doc.Add(FE);
            doc.Add(Clave);
            doc.Add(formaPago);
            doc.Add(agrade);
            doc.Add(autori);

            doc.Close();
            writer.Close();

            return pathPDF;
        }
    }
}
