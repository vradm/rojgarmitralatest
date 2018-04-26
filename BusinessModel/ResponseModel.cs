using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class ResponseModel
    {
        public long? Id { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public bool Status { get; set; } = false;
        public string RedirectUrl { get; set; }
        public string FileName { get; set; }
    }
}