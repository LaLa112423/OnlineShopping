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
   public class menudata:Imenudata
    {
        //显示
        dapper<menutable> dappers = new dapper<menutable>();
        public List<menutable> menushow(int id)
        {
            string sql = $"select menutable.menuid,menutable.menuname,menutable.menupid from rouletable join roulemenutable on rouletable.rouleid = roulemenutable.rouleid join menutable on menutable.menuid = roulemenutable.menuid   where rouletable.rouleid = @id and menutable.menupid=0";
            return dappers.ExecQuery(sql, new { @id= id});
        }
        public List<menutable> menuindex(int id,int iid)
        {
            string sql = $"select menutable.menuurl, menutable.menuid, menutable.menuname,menutable.menupid from rouletable join roulemenutable on rouletable.rouleid = roulemenutable.rouleid join menutable on menutable.menuid = roulemenutable.menuid   where rouletable.rouleid = @id and menutable.menupid=@iid";
            return  dappers.ExecQuery(sql, new { @id = id,@iid = iid });
        }

    }
}
