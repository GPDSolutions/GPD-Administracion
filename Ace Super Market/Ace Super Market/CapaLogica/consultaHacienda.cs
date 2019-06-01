using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ace_Super_Market.CapaLogica
{
    class consultaHacienda
    {
        Boolean result = false;

        public Boolean verificacionEstatus(String clave, String token, String consecutivo)
        {
            ConsultaEstatus(clave,token,consecutivo);
            return result;
        }
        public async void ConsultaEstatus(String clave, String token, String consecutivo)
        {

            try
            {
                string URL_RECEPCION = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/";
                HttpClient http = new HttpClient();

                http.DefaultRequestHeaders.Add("authorization", ("Bearer " + token));

                HttpResponseMessage response = http.GetAsync((URL_RECEPCION + ("recepcion/" + clave))).Result;
                string res = await response.Content.ReadAsStringAsync();

                object Localizacion = response.StatusCode;



                CapaLogica.RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<CapaLogica.RespuestaHacienda>(res);

                if (RH.ind_estado.Equals("procesando"))
                {
                    ConsultaEstatus(clave, token, consecutivo);
                }
                else
                {
                    
                    JObject json = JObject.Parse(res);
                    MessageBox.Show(json.ToString());
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
                        result = true;

                    }
                    if (RH.ind_estado.Equals("rechazado"))
                    {
                        xmlDoc.Save(XMLMEnsajeHaciendaError);
                        result = false;
                    }



                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }       
    }
}
