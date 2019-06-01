using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ace_Super_Market.CapaLogica
{
    class envioCorreo
    {

        public void sendCorreo(String pathFactura, String pathMensaje, String pathPDF, Dictionary<String, String> Dcliente, String consecutivo)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(Dcliente["email"]);
            msg.Subject = "ACE SUPER MARKET : Factura Electrónica #" + consecutivo;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "Estimado cliente." + Dcliente["nombreCliente"] +"\r"+
                        "Reciba un cordial saludo de ACE SUPER MARKET." + "\r" +
                        "Adjunto encontrara su factura electrónica #" + consecutivo + "." + "\r" +
                        "Gracias por preferirnos, saludos cordiales." + "\r";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;
            System.Net.Mail.Attachment PDF = new System.Net.Mail.Attachment(pathPDF);
            msg.Attachments.Add(PDF);
            System.Net.Mail.Attachment Factura = new System.Net.Mail.Attachment(pathFactura);
            msg.Attachments.Add(Factura);
            System.Net.Mail.Attachment MensajeHacienda = new System.Net.Mail.Attachment(pathMensaje);
            msg.Attachments.Add(MensajeHacienda);
            msg.From = new System.Net.Mail.MailAddress("ventas@aceservicex.com");


            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient("mail.aceservicex.com ", 2525);
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new System.Net.NetworkCredential("ventas@aceservicex.com", "Ventas.2019");



            try
            {
                cliente.Send(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void sendCorreoConfirmacion(String pathRespuesta,Dictionary<String, String> Dcliente)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(Dcliente["tcorerocliente"]);
            msg.Subject = "ACE SUPER MARKET : Respuesta de Factura Electrónica #" + Dcliente["clave"];
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "Estimado cliente." + Dcliente["tnombrecliente"] + "\r" +
                        "Reciba un cordial saludo de ACE SUPER MARKET." + "\r" +
                        "Adjunto encontrara su Confirmacion de factura electrónica #" + Dcliente["clave"] + "." + "\r";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;

            System.Net.Mail.Attachment Respuesta = new System.Net.Mail.Attachment(pathRespuesta);
            msg.Attachments.Add(Respuesta);

            msg.From = new System.Net.Mail.MailAddress("ventas@aceservicex.com");


            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient("mail.aceservicex.com ", 2525);
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new System.Net.NetworkCredential("ventas@aceservicex.com", "Ventas.2019");



            try
            {
                cliente.Send(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
