using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class AccountModel
    {
        
        public long UserID { get; set; }
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string StdCode { get; set; }
        public string MobileNumber { get; set; }        
        public string Role { get; set; }
        public string AuthTocken { get; set; }        
        public bool Active { get; set; }
        public bool Rememberme { get; set; } = false;
        public string message { get; set; }
       public bool status { get; set; } = false;
        public object data { get; set; }
    }

   
}
