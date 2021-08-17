using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Model;
using OnlineShopping.IDal;
using Common;
namespace OnlineShopping.Dal
{
   public class ownerdata:Iownerdata
    {
        //车辆显示
        dapper<ownertable> dappers = new dapper<ownertable>();
        public List<ownertable> ownershow(int id)
        {
            if (id == 6)
            {
                string sql = $"select ownerid,ownername,ownerphone,ownerunit,owneraddress,ownervalid,ownerremark,ownerimg,ownerdate from ownertable ";
                return dappers.ExecQuery(sql);
            }
            else
            {
                string sql = $"select ownerid, ownername, ownerphone, ownerunit, owneraddress, ownervalid, ownerremark, ownerimg, ownerdate from ownertable where owneruid = @id ";
                return dappers.ExecQuery(sql, new { @id = id });
            }

        }
        //车辆管理添加
        public int owneradd(ownertable u)
        {
            string sql = $"insert into ownertable values (null,ownername,ownerphone,ownerunit,owneraddress,ownervalid,ownerremark,ownerimg,ownerdate,ownersale,owneruid)";
            return dappers.Exec(sql, new
            {
                @ownername = u.ownername,
                @ownerphone = u.ownerphone,
                @ownerunit = u.ownerunit,
                @owneraddress = u.owneraddress,
                @ownervalid = u.ownervalid,
                @ownerremark = u.ownerremark,
                @ownerimg = u.ownerimg,
                @ownerdate = u.ownerdate,
                @ownersale = u.ownersale,
                @owneruid = commonfiled.uid
            });
        }
        //车辆管理删除
        public int ownerdel(int id)
        {
            string sql = $"delete from ownertable where ownerid = @id";
            return dappers.Exec(sql, new { @id = id });
        }
        //车辆管理反填
        public List<ownertable> owneralt(int id)
        {
            string sql = $"select ownername,ownerphone,ownerunit,owneraddress,ownervalid,ownerremark,ownerimg from ownertable where ownerid = @id";
            return dappers.ExecQuery(sql, new { @id = id });
        }
        //车辆修改
        public int ownerupt(ownertable u)
        {
            string sql = $"update ownertable set ownername=@ownername,ownerphone=@ownerphone,ownerunit=@ownerunit,owneraddress=@owneraddress,ownervalid=@ownervalid,ownerremark=@ownerremark,ownerimg=@ownerimg where ownerid = @ownerid";
            return dappers.Exec(sql, new
            {
                @ownername = u.ownername,
                @ownerphone = u.ownerphone,
                @ownerunit = u.ownerunit,
                @owneraddress = u.owneraddress,
                @ownervalid = u.ownervalid,
                @ownerremark = u.ownerremark,
                @ownerimg = u.ownerimg,
                @ownerid = u.ownerid
            });
        }
    }
}
