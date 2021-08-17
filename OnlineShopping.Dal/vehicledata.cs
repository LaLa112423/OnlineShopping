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
    public class vehicledata : Ivehicle
    {
        //车辆显示
        dapper<vehicletable> dappers = new dapper<vehicletable>();
        public List<vehicletable> vehicleshow(int id)
        {
            if (id == 6)
            {
                string sql = $"select  vehicleid, vehiclemodel, vehiclenumber,vehiclename,vehiclecompany,vehicletype,vehiclecolor,vehicledate,vehiclecardid,vehicleinsurance,vehicleannual,vehiclemaintain,vehiclesale,vehicleuid from vehicletable  ";
                return dappers.ExecQuery(sql);
            }
            else
            {
                string sql = $"select  vehicleid, vehiclemodel, vehiclenumber,vehiclename,vehiclecompany,vehicletype,vehiclecolor,vehicledate,vehiclecardid,vehicleinsurance,vehicleannual,vehiclemaintain,vehiclesale,vehicleuid from vehicletable where vehicleuid=@id ";
                return dappers.ExecQuery(sql, new { @id = id });
            }

        }
        //车辆管理添加
        public int vehicleadd(vehicletable u)
        {
            string sql = $"insert into vehicletable values (null,@vehiclemodel,@vehiclenumber,@vehiclename,@vehiclecompany,@vehicletype,@vehiclecolor,@vehicledate,@vehiclecardid,@vehicleinsurance,@vehicleannual,@vehiclemaintain,@vehiclesale,@vehiclephotograph,@vehiclecard,@vehicleuid)";
            return dappers.Exec(sql, new
            {
                @vehiclemodel = u.vehiclemodel,
                @vehiclenumber = u.vehiclenumber,
                @vehiclename = u.vehiclename,
                @vehiclecompany = u.vehiclecompany,
                @vehicletype = u.vehicletype,
                @vehiclecolor = u.vehiclecolor,
                @vehicledate = u.vehicledate,
                @vehiclecardid = u.vehiclecardid,
                @vehicleinsurance = u.vehicleinsurance,
                @vehicleannual = u.vehicleannual,
                @vehiclemaintain = u.vehiclemaintain,
                @vehiclesale = u.vehiclesale,
                @vehiclephotograph = u.vehiclephotograph,
                @vehiclecard = u.vehiclecard,
                @vehicleuid = commonfiled.uid
            });
        }
        //车辆管理删除
        public int vehicledel(int id)
        {
            string sql = $"delete from vehicletable where vehicleid = @id";
            return dappers.Exec(sql, new { @id = id });
        }
        //车辆管理反填
        public List<vehicletable> vehiclealt(int id)
        {
            string sql = $"select vehiclemodel, vehiclenumber,vehiclename,vehiclecompany,vehicletype,vehiclecolor from vehicletable where vehicleid=@id";
            return dappers.ExecQuery(sql, new { @id=id });
        }
        //车辆修改
        public int vehicleupt(vehicletable u)
        {
            string sql = $"update vehicletable set vehiclemodel=@vehiclemodel,vehiclenumber=@vehiclenumber,vehiclename=@vehiclename,vehiclecompany=@vehiclecompany,vehicletype=@vehicletype,vehiclecolor=@vehiclecolor where vehicleid = @vehicleid";
            return dappers.Exec(sql, new
            {
                @vehiclemodel = u.vehiclemodel,
                @vehiclenumber = u.vehiclenumber,
                @vehiclename = u.vehiclename,
                @vehiclecompany = u.vehiclecompany,
                @vehicletype = u.vehicletype,
                @vehiclecolor = u.vehiclecolor,
                @vehicleid = u.vehicleid
            });
        }
    }
}
