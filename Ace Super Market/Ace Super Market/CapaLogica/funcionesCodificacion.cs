using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ace_Super_Market.CapaLogica
{
    class funcionesCodificacion
    {

        public String XMLtoBase64(String ppathArchivo)
        {
            byte[] arrayDeBytes = System.IO.File.ReadAllBytes(ppathArchivo);
            string codificado = Convert.ToBase64String(arrayDeBytes);

            return codificado;
        }
    }
}
