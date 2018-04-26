using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.DBManager
{
    public class SpHelper<T> where T : class
    {
        private static DBManager.RojgarMitraEntities _context = new RojgarMitraEntities();
        public SpHelper()
        {
            _context = new DBManager.RojgarMitraEntities();
        }
        public static IEnumerable<T> GetListWithRawSql(string query, params object[] parameters)
        {
            return _context.Database.SqlQuery<T>(query, parameters).ToList();
        }
    }
}