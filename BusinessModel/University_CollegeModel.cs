using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class University_CollegeModel
    {
        public long ID { get; set; }
        public string University_CollegeName { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
    }
}