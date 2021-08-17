using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Common;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace OnlineShopping.Dal 
{
   public class dapper<T> where T : class ,new()
    {
        string constr = commonfiled.constr;
        public int Exec(string sql , object obj = null)
        {
            using (IDbConnection con = new MySqlConnection(constr))
            {
                int i = con.Execute(sql,obj);
                return i;
            }
            

            
        }
        public List<T> ExecQuery(string sql, object obj=null)
        {
            using (IDbConnection conn = new MySqlConnection(constr))
            {
                List<T> t = conn.Query<T>(sql, obj).ToList();
                return t;
            }


            
        }
    }
}
