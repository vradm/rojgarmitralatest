using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class DesignationModel
    {
        public long DesignationID { get; set; }
        public string DesignationName { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}