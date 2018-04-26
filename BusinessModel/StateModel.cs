using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class StateModel
    {
        public long StateID { get; set; }
        public long CountryID { get; set; }
        public string Statename { get; set; }
        public bool IsActive { get; set; }
    }
}