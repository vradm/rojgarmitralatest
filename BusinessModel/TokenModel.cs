using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class TokenModel
    {
        public long TokenID { get; set; }
        public long UserID { get; set; }
        public string AuthToken { get; set; }
        public System.DateTime IssuedOn { get; set; }
        public System.DateTime ExpiresOn { get; set; }
    }
}