using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using OnlineShopping.IDal;
using OnlineShopping.Model;
using Dapper;
namespace OnlineShopping.Dal
{
   public class employeedate:Iemployeedate
    {
        dapper<employeetable> dappers = new dapper<employeetable>();
        //用户登录
        public List<employeetable> Logo(string name, string pwd)
        {
            string sql = $"select  *  from employeetable where employeename=@name and employepwd=@pwd";
            return dappers.ExecQuery(sql, new { @name = name, @pwd = pwd });
        }
    }
}
