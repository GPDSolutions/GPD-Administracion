using FirmaXadesNet;
using FirmaXadesNet.Signature.Parameters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ace_Super_Market.CapaLogica
{
    class firmarDocsXML
    {

        public String firmadoFactura(String ppathArchivo, String pconsecutivo)
        {
            String pathCert = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\Certificado\310176938728.p12";
            X509Certificate2 certificado = new X509Certificate2(pathCert, "1502");
            XadesService xadesService = new XadesService();
            SignatureParameters parametros = new SignatureParameters();
            parametros.SignaturePolicyInfo = new SignaturePolicyInfo();
            parametros.SignaturePolicyInfo.PolicyIdentifier =
            "https://tribunet.hacienda.go.cr/docs/esquemas/2016/v4.1/Resolucion_Comprobantes_Electronicos_DGT-R-48-2016.pdf";
            parametros.SignaturePolicyInfo.PolicyHash = "Ohixl6upD6av8N7pEvDABhEL6hM=";
            parametros.SignaturePackaging = SignaturePackaging.ENVELOPED;
            parametros.DataFormat = new FirmaXadesNet.Signature.Parameters.DataFormat();
            parametros.Signer = new FirmaXadesNet.Crypto.Signer(certificado);
            FileStream fs = new FileStream((ppathArchivo), FileMode.Open);
            FirmaXadesNet.Signature.SignatureDocument docFirmado = xadesService.Sign(fs, parametros);
            String XMLFirmado = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\XMLFirmados\FacturaCF" + pconsecutivo + ".xml";
            docFirmado.Save((XMLFirmado));

            return XMLFirmado;
        }
        public String firmadoMensajeReceptor(String ppathArchivo, String pconsecutivo)
        {
            String pathCert = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\Certificado\310176938728.p12";
            X509Certificate2 certificado = new X509Certificate2(pathCert, "1502");
            XadesService xadesService = new XadesService();
            SignatureParameters parametros = new SignatureParameters();
            parametros.SignaturePolicyInfo = new SignaturePolicyInfo();
            parametros.SignaturePolicyInfo.PolicyIdentifier =
            "https://tribunet.hacienda.go.cr/docs/esquemas/2016/v4.1/Resolucion_Comprobantes_Electronicos_DGT-R-48-2016.pdf";
            parametros.SignaturePolicyInfo.PolicyHash = "Ohixl6upD6av8N7pEvDABhEL6hM=";
            parametros.SignaturePackaging = SignaturePackaging.ENVELOPED;
            parametros.DataFormat = new FirmaXadesNet.Signature.Parameters.DataFormat();
            parametros.Signer = new FirmaXadesNet.Crypto.Signer(certificado);
            FileStream fs = new FileStream((ppathArchivo), FileMode.Open);
            FirmaXadesNet.Signature.SignatureDocument docFirmado = xadesService.Sign(fs, parametros);
            String XMLFirmado = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\XMLFirmados\MensajeReceptorCF" + pconsecutivo + ".xml";
            docFirmado.Save((XMLFirmado));

            return XMLFirmado;
        }

        public String firmadoTiqueteElectronico(String ppathArchivo, String pconsecutivo)
        {
            String pathCert = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\Certificado\310176938728.p12";
            X509Certificate2 certificado = new X509Certificate2(pathCert, "1502");
            XadesService xadesService = new XadesService();
            SignatureParameters parametros = new SignatureParameters();
            parametros.SignaturePolicyInfo = new SignaturePolicyInfo();
            parametros.SignaturePolicyInfo.PolicyIdentifier =
            "https://tribunet.hacienda.go.cr/docs/esquemas/2016/v4.1/Resolucion_Comprobantes_Electronicos_DGT-R-48-2016.pdf";
            parametros.SignaturePolicyInfo.PolicyHash = "V8lVVNGDCPen6VELRD1Ja8HARFk=";
            parametros.SignaturePackaging = SignaturePackaging.ENVELOPED;
            parametros.DataFormat = new FirmaXadesNet.Signature.Parameters.DataFormat();
            parametros.Signer = new FirmaXadesNet.Crypto.Signer(certificado);
            FileStream fs = new FileStream((ppathArchivo), FileMode.Open);
            FirmaXadesNet.Signature.SignatureDocument docFirmado = xadesService.Sign(fs, parametros);
            String XMLFirmado = @"C:\Program Files (x86)\GPD Soluciones\Ace Super Market\XML\XMLFirmados\TiqueteElectronicoCF" + pconsecutivo + ".xml";
            docFirmado.Save((XMLFirmado));

            return XMLFirmado;
        }
    }
}
