using MySql.Data.MySqlClient;
using System;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using RestSharp;
using System.Xml;
using System.Xml.Linq;
using FirmaXadesNet;
using FirmaXadesNet.Signature.Parameters;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Net.Http;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net;

namespace Ace_Super_Market.CapaPresentacionLocal
{
    public partial class Pruebas : Form
    {

        String refresh_token;
        String token;
        String xmlcodificado;
        int id=0;
        public Pruebas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add("xmora777@gmail.com");
            msg.Subject = "Prueba correo";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            // msg.Bcc.Add(); copia de correo
            msg.Body = "AVER SI ESTA VERGA SIRVE";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;
            System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(@"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\PDFFactura\FacturaPDF10000001010000000098.pdf");
            msg.Attachments.Add(archivo);
            msg.From = new  System.Net.Mail.MailAddress("compras@aceservicex.com");
            

             System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient("mail.aceservicex.com ",2525);
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new System.Net.NetworkCredential("compras@aceservicex.com", "Compras.2019");





            try
            {


                cliente.Send(msg);



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                txtRazon.Text =  ex.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccesoDB.conector conector = new AccesoDB.conector();
            String url = "C:\\Users\\Greivin\\Desktop\\backup\\backup.sql";

            try
            {
                using (MySqlConnection conexcion = conector.Getconector())
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        using (MySqlBackup backup = new MySqlBackup(comando))
                        {
                            comando.Connection = conexcion;
                            conexcion.Open();
                            backup.ExportToFile(url);
                            conexcion.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void Pruebas_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("https://idp.comprobanteselectronicos.go.cr/auth/realms/rut-stag/protocol/openid-connect/token");
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("header1", "headerval");
                request.AddHeader("Accept", "application/json");
                request.AddParameter("client_id", "api-stag");
                request.AddParameter("username", "cpj-3-101-769387@stag.comprobanteselectronicos.go.cr");
                request.AddParameter("password", "/i=l#={e/b5#cs|Dg:D!");
                request.AddParameter("grant_type", "password");
                request.RequestFormat = RestSharp.DataFormat.Json;
                var response = client.Execute(request);
                 txtRazon.Text = response.Content;

                JObject json = JObject.Parse(txtRazon.Text);

                refresh_token = json.GetValue("refresh_token").ToString();
                token = json.GetValue("access_token").ToString();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }


        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                var client = new RestClient("https://idp.comprobanteselectronicos.go.cr/auth/realms/rut-stag/protocol/openid-connect/token");
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("header1", "headerval");
                request.AddParameter("client_id", "api-stag");
                request.AddParameter("refresh_token", refresh_token);
                request.AddParameter("grant_type", "refresh_token");
                request.RequestFormat = RestSharp.DataFormat.Json;
                var response = client.Execute(request);
                txtRazon.Text = "";
                txtRazon.Text = response.Content;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                var client = new RestClient("https://idp.comprobanteselectronicos.go.cr/auth/realms/rut-stag/protocol/openid-connect/logout");
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("header1", "headerval");
                request.AddParameter("client_id", "api-stag");
                request.AddParameter("refresh_token", refresh_token);
                request.RequestFormat = RestSharp.DataFormat.Json;
                var response = client.Execute(request);
                txtRazon.Text = "";
                txtRazon.Text = response.Content;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            DateTime thisDay = DateTime.Today;

           
            XDocument doc = new XDocument();

            XmlDocument d = new XmlDocument();
           

            XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
            XNamespace xsd = "http://www.w3.org/2001/XMLSchema";
            XNamespace xmlns = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica";
            XNamespace schemaLocation = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica.xsd";


            XElement raiz = new XElement(xmlns+"FacturaElectronica");
            raiz.SetAttributeValue(XNamespace.Xmlns + "xsi", xsi);
            raiz.SetAttributeValue(XNamespace.Xmlns + "xsd", xsd);           
            raiz.SetAttributeValue(XNamespace.Xmlns + "schemaLocation", schemaLocation);
            raiz.SetAttributeValue("xmlns", xmlns);
            XElement clave = new XElement(xmlns+"Clave", "50605091900310176938701000001010000001803100001816");
            XElement NumeroConsecutivo = new XElement(xmlns+ "NumeroConsecutivo", "01000001010000001803");
            XElement FechaEmision = new XElement(xmlns+ "FechaEmision", thisDay.ToString("yyyy-MM-ddTHH:mm:ss"));
            XElement Emisor = new XElement(xmlns+"Emisor", 
                                new XElement(xmlns+"Nombre", "ACESERVICES SOCIEDAD ANONIMA"), 
                                new XElement(xmlns+"Identificacion", 
                                    new XElement(xmlns + "Tipo", "02"), 
                                    new XElement(xmlns + "Numero", "3101769387")),
                                new XElement(xmlns+ "NombreComercial", "ACESERVICES SOCIEDAD ANONIMA"),
                                new XElement(xmlns+ "Ubicacion",
                                    new XElement(xmlns+ "Provincia","6"),
                                    new XElement(xmlns+ "Canton","05"),
                                    new XElement(xmlns+"Distrito","01"),
                                    new XElement(xmlns+"Barrio", "01"),
                                    new XElement(xmlns + "OtrasSenas", "Frente a Escuela Nieborowsky, Ciudad Cortes, Osa, Puntarenas")),
                                new XElement(xmlns+ "Telefono",
                                    new XElement(xmlns+ "CodigoPais","506"),
                                    new XElement(xmlns+ "NumTelefono","87800047")),
                                new XElement(xmlns + "Fax",
                                    new XElement(xmlns + "CodigoPais", "0"),
                                    new XElement(xmlns + "NumTelefono", "0")),
                                new XElement(xmlns+ "CorreoElectronico","greivin.gff@gmail.com"));

            XElement Receptor = new  XElement(xmlns + "Receptor",
                                new XElement(xmlns + "Nombre", "GREIVIN GAMBOA FLORES"),
                                new XElement(xmlns + "Identificacion",
                                    new XElement(xmlns + "Tipo", "01"),
                                    new XElement(xmlns + "Numero", "604150895")),
                                new XElement(xmlns + "IdentificacionExtranjero", "N/A"),
                                new XElement(xmlns + "NombreComercial", "GPD"),
                                new XElement(xmlns + "Ubicacion",
                                    new XElement(xmlns + "Provincia", "6"),
                                    new XElement(xmlns + "Canton", "05"),
                                    new XElement(xmlns + "Distrito", "01"),
                                    new XElement(xmlns + "Barrio", "01"),
                                    new XElement(xmlns + "OtrasSenas", "Frente a Escuela Nieborowsky, Ciudad Cortes, Osa, Puntarenas")),
                                new XElement(xmlns + "Telefono",
                                    new XElement(xmlns + "CodigoPais", "506"),
                                    new XElement(xmlns + "NumTelefono", "87800047")),
                                new XElement(xmlns + "CorreoElectronico", "greivin.gff@gmail.com"));

            XElement CondicionVenta  = new XElement(xmlns+ "CondicionVenta","01");

            XElement MedioPago = new XElement(xmlns+ "MedioPago","01");

            XElement DetalleServicio = new XElement(xmlns+ "DetalleServicio", 
                                        new XElement(xmlns+ "LineaDetalle", 
                                            new XElement(xmlns+ "NumeroLinea", "1"),
                                            new XElement(xmlns + "Codigo", 
                                                 new XElement(xmlns + "Tipo", "01"),
                                                 new XElement(xmlns + "Codigo", "1")),
                                            new XElement(xmlns + "Cantidad", "38.825"),
                                            new XElement(xmlns + "UnidadMedida", "Unid"),
                                            new XElement(xmlns + "Detalle", "MATERIALES GRABADO"),
                                            new XElement(xmlns + "PrecioUnitario", "884.956"),
                                            new XElement(xmlns + "MontoTotal", "34358.42"),
                                            new XElement(xmlns + "SubTotal", "34358.42"),
                                            new XElement(xmlns + "Impuesto",
                                                   new XElement(xmlns + "Codigo", "01"),
                                                   new XElement(xmlns + "Tarifa", "13.00"),
                                                   new XElement(xmlns + "Monto", "4466.59")),
                                            new XElement(xmlns + "MontoTotalLinea", "38825.01")));


            XElement ResumenFactura = new XElement(xmlns+ "ResumenFactura",
                                          new XElement(xmlns+ "CodigoMoneda", "CRC"),
                                          new XElement(xmlns + "TipoCambio", "562.00"),
                                          new XElement(xmlns + "TotalServGravados", "0"),
                                          new XElement(xmlns + "TotalServExentos", "0.00"),
                                          new XElement(xmlns + "TotalMercanciasGravadas", "34358.41"),
                                          new XElement(xmlns + "TotalMercanciasExentas", "0"),
                                          new XElement(xmlns + "TotalGravado", "34358.41"),
                                          new XElement(xmlns + "TotalExento", "0"),
                                          new XElement(xmlns + "TotalVenta", "34358.41"),
                                          new XElement(xmlns + "TotalDescuentos", "0"),
                                          new XElement(xmlns + "TotalVentaNeta", "34358.41"),
                                          new XElement(xmlns + "TotalImpuesto", "4466.59"),
                                          new XElement(xmlns + "TotalComprobante", "38825.00"));

            XElement Normativa = new XElement(xmlns+ "Normativa",
                                    new XElement(xmlns + "NumeroResolucion", "DGT-R-48-2016"),
                                    new XElement(xmlns + "FechaResolucion", "07-10-2016 00:00:00"));

            XElement Otros = new XElement(xmlns + "Otros",
                        new XElement(xmlns + "OtroTexto", "N.A."));


            raiz.Add(clave);
            raiz.Add(NumeroConsecutivo);
            raiz.Add(FechaEmision);
            raiz.Add(Emisor);
            raiz.Add(Receptor);
            raiz.Add(CondicionVenta);
            raiz.Add(MedioPago);
            raiz.Add(DetalleServicio);
            raiz.Add(ResumenFactura);
            raiz.Add(Normativa);
            raiz.Add(Otros);
            doc.Add(raiz);

            doc.Save("C:\\Users\\Greivin\\Desktop\\xml\\archivo"+id+".xml");
            id = id + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] arrayDeBytes = System.IO.File.ReadAllBytes(@"C:\Users\Greivin\Desktop\xml\firmado\archivofirmado.xml");

            string codificado = Convert.ToBase64String(arrayDeBytes);
            txtRazon.Text = "";
            txtRazon.Text = codificado;
            xmlcodificado = codificado;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            firmado();
        }

        public void firmado()
        {
            String pathCert = @"C:\Users\Greivin\Documents\Visual Studio 2017\Projects\Ace Super Market\Ace Super Market\Recursos\llave\310176938728.p12";
            X509Certificate2 certificado =  new X509Certificate2(pathCert, "1502");
            XadesService xadesService = new XadesService();
            SignatureParameters parametros = new SignatureParameters();
            parametros.SignaturePolicyInfo = new SignaturePolicyInfo();
            parametros.SignaturePolicyInfo.PolicyIdentifier =
            "https://tribunet.hacienda.go.cr/docs/esquemas/2016/v4.1/Resolucion_Comprobantes_Electronicos_DGT-R-48-2016.pdf";
            parametros.SignaturePolicyInfo.PolicyHash = "Ohixl6upD6av8N7pEvDABhEL6hM=";
            parametros.SignaturePackaging = SignaturePackaging.ENVELOPED;
            parametros.DataFormat = new FirmaXadesNet.Signature.Parameters.DataFormat();
            parametros.Signer = new FirmaXadesNet.Crypto.Signer(certificado);
            FileStream fs = new FileStream(("C:\\Users\\Greivin\\Desktop\\xml\\archivo0.xml"), FileMode.Open);
            FirmaXadesNet.Signature.SignatureDocument docFirmado = xadesService.Sign(fs, parametros);
            docFirmado.Save((@"C:\Users\Greivin\Desktop\xml\firmado\archivofirmado.xml"));
        }


        public X509Certificate2 GetCertificateByThumbprint(string thumbprintCertificado)
        {
            X509Certificate2 cert = null;
            X509Store store = new X509Store("My", StoreLocation.CurrentUser);

            
            try
            {
                store.Open((OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly));
                X509Certificate2Collection CertCol = store.Certificates;
                foreach (X509Certificate2 c in CertCol)
                {
                    if ((c.Thumbprint == thumbprintCertificado))
                    {
                        cert = c;
                        break;
                    }
                }

                if ((cert == null))
                {
                    store = new X509Store("My", StoreLocation.LocalMachine);
                    CertCol = store.Certificates;
                    foreach (X509Certificate2 c in CertCol)
                    {
                        if ((c.Thumbprint == thumbprintCertificado))
                        {
                            cert = c;
                            break;
                        }
                    }
                }

                if ((cert == null))
                {
                    throw new CryptographicException("El certificado no se encuentra registrado");
                }
            }
            finally
            {
                store.Close();
            }
            return cert;
        }


        private async void button11_Click(object sender, EventArgs e)
        {
            string URL_RECEPCION = "https://api.comprobanteselectronicos.go.cr/recepcion-sandbox/v1/";

            MessageBox.Show(token);
            MessageBox.Show(xmlcodificado);

            HttpClient http = new HttpClient();
            Newtonsoft.Json.Linq.JObject JsonObject =  new Newtonsoft.Json.Linq.JObject();
            JsonObject.Add(new JProperty("clave", "50605091900310176938701000001010000001803100001816"));
            JsonObject.Add(new JProperty("fecha", "2019-05-09T00:00:00"));
            JsonObject.Add(new JProperty("emisor",
                                         new JObject(new JProperty("tipoIdentificacion", "02"),
                                                     new JProperty("numeroIdentificacion", "3101769387"))));


                JsonObject.Add(new JProperty("receptor",
                                         new JObject(new JProperty("tipoIdentificacion", "01"),
                                                     new JProperty("numeroIdentificacion", "604150895"))));
            

            JsonObject.Add(new JProperty("comprobanteXml",xmlcodificado));



            StringContent oString = new StringContent(JsonObject.ToString());

            http.DefaultRequestHeaders.Add("Authorization", ("Bearer " + token));

            HttpResponseMessage response = http.PostAsync((URL_RECEPCION + "recepcion"), oString).Result;
            string res = await response.Content.ReadAsStringAsync();

            object Localizacion = response.StatusCode;

            http = new HttpClient();
            http.DefaultRequestHeaders.Add("authorization", ("Bearer " + token));
            response = http.GetAsync((URL_RECEPCION + ("recepcion/" + "50605091900310176938701000001010000001803100001816"))).Result;
            res = await response.Content.ReadAsStringAsync();

            CapaLogica.RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<CapaLogica.RespuestaHacienda>(res);

            txtRazon.Text = "";
            txtRazon.Text = res;
            MessageBox.Show("estado : " + RH.clave);
            MessageBox.Show("estado : " + RH.fecha);
            MessageBox.Show("estado : " + RH.ind_estado);
            MessageBox.Show(response.StatusCode.ToString());
            //JObject json = JObject.Parse(response.Content.ToString());
            JObject json = JObject.Parse(txtRazon.Text);


            token = json.GetValue("respuesta-xml").ToString(); 


                   byte[] myBase64ret = Convert.FromBase64String(token);
                   string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
                   XmlDocument xmlDoc = new XmlDocument();
                   xmlDoc.LoadXml(myStr);

                   xmlDoc.Save(@"C:\Users\Greivin\Desktop\xml\prueba hacienda\prueba.xml");
               

        }

        public async void ConsultaEstatus()
        {
            try
            {
                string URL_RECEPCION = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/";
                HttpClient http = new HttpClient();
                CapaLogica.gestor objG = new CapaLogica.gestor();
                

                http.DefaultRequestHeaders.Add("authorization", ("Bearer " + objG.optenerToken()));

                HttpResponseMessage response = http.GetAsync((URL_RECEPCION + ("recepcion/" + "50622051900310176938710000001010000000115110000915"))).Result;
                string res = await response.Content.ReadAsStringAsync();

                object Localizacion = response.StatusCode;



                CapaLogica.RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<CapaLogica.RespuestaHacienda>(res);
                MessageBox.Show(RH.ind_estado);
                if (RH.ind_estado.Equals("procesando"))
                {
                    ConsultaEstatus();
                }
                else
                {
                    txtRazon.Text = "";
                    txtRazon.Text = res;
                    JObject json = JObject.Parse(txtRazon.Text);
                    token = json.GetValue("respuesta-xml").ToString();
                    byte[] myBase64ret = Convert.FromBase64String(token);
                    string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(myStr);

                    xmlDoc.Save(@"C:\Users\Greivin\Desktop\xml\prueba hacienda\prueba.xml");

                    MessageBox.Show("estado : " + RH.ind_estado);

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ConsultaEstatus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CapaLogica.gestor objG = new CapaLogica.gestor();
            objG.optenerClaveTiquete("0","1","2","3");
        }
        public async void ConsultaEstatusMR(String clave, String token, String consecutivo)
        {


                string URL_RECEPCION = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/";
                HttpClient http = new HttpClient();

                http.DefaultRequestHeaders.Add("authorization", ("Bearer " + token));

                HttpResponseMessage response = http.GetAsync((URL_RECEPCION + ("comprobantes/" + clave))).Result;
                string res = await response.Content.ReadAsStringAsync();

                object Localizacion = response.RequestMessage;
            MessageBox.Show(res);


            /*CapaLogica.RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<CapaLogica.RespuestaHacienda>(res);

            if (RH.ind_estado.Equals("procesando"))
            {
                ConsultaEstatusMR(clave, token, consecutivo);
            }
            else
            {

                JObject json = JObject.Parse(res);
                token = json.GetValue("respuesta-xml").ToString();
                byte[] myBase64ret = Convert.FromBase64String(token);
                string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(myStr);


                String XMLMEnsajeHacienda = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\XMLMensajeHacienda\MensaHacienda" + consecutivo + ".xml";
                String XMLMEnsajeHaciendaError = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\XMLMensajeHaciendaError\MensaHaciendaError" + consecutivo + ".xml";
                if (RH.ind_estado.Equals("aceptado"))
                {
                    xmlDoc.Save(XMLMEnsajeHacienda);

                    if (RH.ind_estado.Equals("rechazado"))
                    {
                        xmlDoc.Save(XMLMEnsajeHaciendaError);

                    }
                }
            }*/
        }

        public void pruebapdf()
        {
            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc,
                            new FileStream(@"C:\Users\Greivin\Desktop\xml\pruebapdf.pdf", FileMode.Create));

            doc.AddTitle("Factura");
            doc.AddCreator("Greivin Gamboa");

            doc.Open();
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            // Escribimos el encabezamiento en el documento

            Paragraph lblfecha = new Paragraph("Fecha");
            lblfecha.Alignment = Element.ALIGN_RIGHT;
            Paragraph fecha = new Paragraph("17/05/2019 ");
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

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(4);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clCloiente = new PdfPCell(new Phrase("Cliente : ", _standardFont));
            clCloiente.BorderWidth = 0;
            clCloiente.BorderWidthBottom = 0.75f;

            PdfPCell clCedula = new PdfPCell(new Phrase("Cédula", _standardFont));
            clCedula.BorderWidth = 0;
            clCedula.BorderWidthBottom = 0.75f;

            PdfPCell clPais = new PdfPCell(new Phrase("País", _standardFont));
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
            for (int a = 0;a<10;a++)
            {
                clCantidad = new PdfPCell(new Phrase("1", _standardFont));
                clCantidad.BorderWidth = 0;

                clArticulo = new PdfPCell(new Phrase("agua", _standardFont));
                clArticulo.BorderWidth = 0;

                clPU = new PdfPCell(new Phrase("1000", _standardFont));
                clPU.BorderWidth = 0;

                clTotal = new PdfPCell(new Phrase("1000", _standardFont));
                clTotal.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tblProductos.AddCell(clCantidad);
                tblProductos.AddCell(clArticulo);
                tblProductos.AddCell(clPU);
                tblProductos.AddCell(clTotal);
            }

            Paragraph descuento = new Paragraph("DESCUENTO"+"     "+"0");
            descuento.Alignment = Element.ALIGN_RIGHT;
            Paragraph sub = new Paragraph("SUB-TOTAL" + "     " + "0");
            sub.Alignment = Element.ALIGN_RIGHT;
            Paragraph imp = new Paragraph("IMP-VENTA" + "     " + "0");
            imp.Alignment = Element.ALIGN_RIGHT;
            Paragraph tota = new Paragraph("TOTAL" + "     " + "0");
            tota.Alignment = Element.ALIGN_RIGHT;




            Paragraph observaciones = new Paragraph("OBSERVACIONES");
            observaciones.Alignment = Element.ALIGN_CENTER;

            Paragraph txtobservaciones = new Paragraph("sdfkjdjygdvcabdckasfkasfvldsybfcsdtflsidf");
            txtobservaciones.Alignment = Element.ALIGN_CENTER;

            Paragraph FE = new Paragraph("Factura Electrónica : ");

            Paragraph Clave = new Paragraph("Clave Factura Electrónica : ");


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
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pruebapdf();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            MessageBox.Show(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
