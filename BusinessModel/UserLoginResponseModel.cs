using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class UserLoginResponseModel
    {
        public string Role { get; set; }
        public long UserID { get; set; }
        public string AuthTocken { get; set; }       
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Logo { get; set; }
        public int? LoginCount { get; set; } = 0;
    }
}