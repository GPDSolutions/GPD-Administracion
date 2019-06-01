using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ace_Super_Market.CapaLogica
{
    class tokenHacienda
    {
        public string ApiVersion { get; set; }
        public Data Data { get; set; }
    }

    public class Data
    {
        public String access_token { get; set; }
        public String expires_in { get; set; }
        public String refresh_expires_in { get; set; }
        public String refresh_token { get; set; }
        public String token_type { get; set; }
        public String id_token { get; set; }
        public String not_before_policy { get; set; }
        public String session_state { get; set; }




    }
}
