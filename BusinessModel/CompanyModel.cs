using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class CompanyModel
    {
        public long CompanyID { get; set; }
        public string CompanyName { get; set; }
        public bool IsActive { get; set; }
    }
}