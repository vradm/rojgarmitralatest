using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class CountryModel
    {
        public long CountryID { get; set; }
        public string CountryName { get; set; }
        public bool IsActive { get; set; }
    }
}