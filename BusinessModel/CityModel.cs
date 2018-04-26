using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class CityModel
    {
        public long CityID { get; set; }
        public string CityName { get; set; }
        public long StateID { get; set; }
        public bool IsActive { get; set; }
    }
}