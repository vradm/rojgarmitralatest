using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class UserLoginInfoModel
    {
        public long UserID { get; set; }
        public string EmailID { get; set; }
        public string Role { get; set; }
    }
}