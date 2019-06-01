using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Ace_Super_Market.CapaLogica
{
    class envioHacienda
    {
        Boolean verificacion = false;
        public Boolean verificacionMensajeReceptor(String xmlcodificado, String token, Dictionary<String, String> DdatosFactura)
        {

            envioMensajeReceptorXML(xmlcodificado,token,DdatosFactura);
            return verificacion;
        }

         public async void envioFacturaXML(String xmlcodificado, String token, String Clave, String fecha, String tipoidentifiacion, String numidentificacion)
        {

            string URL_RECEPCION = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/";

            HttpClient http = new HttpClient();
            Newtonsoft.Json.Linq.JObject JsonObject = new Newtonsoft.Json.Linq.JObject();
            JsonObject.Add(new JProperty("clave", Clave));
            JsonObject.Add(new JProperty("fecha", fecha));
            JsonObject.Add(new JProperty("emisor",
                                         new JObject(new JProperty("tipoIdentificacion", "02"),
                                                     new JProperty("numeroIdentificacion", "3101769387"))));


            JsonObject.Add(new JProperty("receptor",
                                     new JObject(new JProperty("tipoIdentificacion", tipoidentifiacion),
                                                 new JProperty("numeroIdentificacion", numidentificacion))));


            JsonObject.Add(new JProperty("comprobanteXml", xmlcodificado));



            StringContent oString = new StringContent(JsonObject.ToString());

            http.DefaultRequestHeaders.Add("Authorization", ("Bearer " + token));

            HttpResponseMessage response = http.PostAsync((URL_RECEPCION + "recepcion"), oString).Result;
            string res = await response.Content.ReadAsStringAsync();

            object Localizacion = response.StatusCode;



            http = new HttpClient();
            http.DefaultRequestHeaders.Add("authorization", ("Bearer " + token));
            response = http.GetAsync((URL_RECEPCION + ("recepcion/" + Clave))).Result;
            res = await response.Content.ReadAsStringAsync();
            String a = res;

            CapaLogica.RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<CapaLogica.RespuestaHacienda>(a);

            JObject json = JObject.Parse(res);

        }

        public async void envioTiqueteXML(String xmlcodificado, String token, String Clave, String fecha)
        {

            string URL_RECEPCION = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/";

            HttpClient http = new HttpClient();
            Newtonsoft.Json.Linq.JObject JsonObject = new Newtonsoft.Json.Linq.JObject();
            JsonObject.Add(new JProperty("clave", Clave));
            JsonObject.Add(new JProperty("fecha", fecha));
            JsonObject.Add(new JProperty("emisor",
                                         new JObject(new JProperty("tipoIdentificacion", "02"),
                                                     new JProperty("numeroIdentificacion", "3101769387"))));

            JsonObject.Add(new JProperty("comprobanteXml", xmlcodificado));



            StringContent oString = new StringContent(JsonObject.ToString());

            http.DefaultRequestHeaders.Add("Authorization", ("Bearer " + token));

            HttpResponseMessage response = http.PostAsync((URL_RECEPCION + "recepcion"), oString).Result;
            string res = await response.Content.ReadAsStringAsync();

            object Localizacion = response.StatusCode;



            http = new HttpClient();
            http.DefaultRequestHeaders.Add("authorization", ("Bearer " + token));
            response = http.GetAsync((URL_RECEPCION + ("recepcion/" + Clave))).Result;
            res = await response.Content.ReadAsStringAsync();
            String a = res;

            CapaLogica.RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<CapaLogica.RespuestaHacienda>(a);

            JObject json = JObject.Parse(res);

        }

        public async void envioMensajeReceptorXML(String xmlcodificado, String token, Dictionary<String, String> DdatosFactura)
        {


             string URL_RECEPCION = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/";

             HttpClient http = new HttpClient();
             Newtonsoft.Json.Linq.JObject JsonObject = new Newtonsoft.Json.Linq.JObject();
             JsonObject.Add(new JProperty("clave", DdatosFactura["clave"]));
             JsonObject.Add(new JProperty("fecha", DdatosFactura["fechaemisiondoc"]));
             JsonObject.Add(new JProperty("emisor",
                                          new JObject(new JProperty("tipoIdentificacion", DdatosFactura["tipoidentificacion"]),
                                                      new JProperty("numeroIdentificacion", DdatosFactura["numerocedulaemisor"]))));


             JsonObject.Add(new JProperty("receptor",
                                      new JObject(new JProperty("tipoIdentificacion", "02"),
                                                  new JProperty("numeroIdentificacion", DdatosFactura["numerocedulareceptor"]))));

             JsonObject.Add(new JProperty("consecutivoReceptor", DdatosFactura["numeroconsecutivoreceptor"]));


             JsonObject.Add(new JProperty("comprobanteXml", xmlcodificado));
             MessageBox.Show(JsonObject.ToString());

             StringContent oString = new StringContent(JsonObject.ToString());

             http.DefaultRequestHeaders.Add("Authorization", ("Bearer " + token));
            string res = "";
             HttpResponseMessage response = http.PostAsync((URL_RECEPCION + "recepcion"), oString).Result;
            
           
              res = await response.Content.ReadAsStringAsync();

            object Localizacion = response.Headers;


            MessageBox.Show(Localizacion.ToString());


            
            string session="";
            Boolean veri = false;
             IEnumerable<string> values;
             HttpHeaders headers = response.Headers;
             if (headers.TryGetValues("Location", out values))
             {
                session = values.First();



                while (veri == false)
                {
                    var result = await http.GetStringAsync(session);
                    JObject json = JObject.Parse(result);
                    if (json.GetValue("ind-estado").ToString().Equals("aceptado"))
                    {
                        String respuestaXMLB64 = json.GetValue("respuesta-xml").ToString();
                        byte[] myBase64ret = Convert.FromBase64String(respuestaXMLB64);
                        string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(myStr);
                        String XMLMEnsajeHacienda = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\XMLMensajeHacienda\MensaHaciendaMR" + DdatosFactura["numeroconsecutivoreceptor"] + ".xml";
                        xmlDoc.Save(XMLMEnsajeHacienda);
                        veri = true;


                    }
                    Thread.Sleep(40000);
                }


            }


        }
    }
}
