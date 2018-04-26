using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class OtherMasterModel
    {
        public int MasterID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string MasterType { get; set; }
        public bool IsActive { get; set; }
    }
}