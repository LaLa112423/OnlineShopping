using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using OnlineShopping.Model;
namespace OnlineShopping.API.Controllers
{
    /// <summary>
    /// 菜单组件
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        private Imenudata _imenudata;
        private Iemployeedate _iemployeedate;
        private Ivehicle _ivehicle1;
        private Iownerdata _iownerdata;
        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="imenudata"></param>
        public ValuesController(Imenudata imenudata,Iemployeedate iemployeedate,Ivehicle ivehicle, Iownerdata iownerdata)
        {
            _imenudata = imenudata;
            _iemployeedate = iemployeedate;
            _ivehicle1 = ivehicle;
            _iownerdata = iownerdata;
        }

        /// <summary>
        /// 头部菜单显示
        /// </summary>
        /// <returns></returns>
        [Route("/menutop")]
        [HttpGet]
       
        public IActionResult Getmenutop(int id)
        {
            if (id!=null)
            {
                commonfiled.uid = id;
                return Ok(_imenudata.menushow(id));
            }
            else
            {
                return Ok("请判断是否登录");
            }
           
        }
        /// <summary>
        /// 菜单查询显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/menueindex")]
        [HttpGet]
        public IActionResult Getmenuindex(int id,int iid)
        {
            return Ok(_imenudata.menuindex(id,iid));
        }

        /// <summary>
        /// 员工登录界面
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [Route("/employeelogo")]
        [HttpGet]
        public IActionResult getemployeelogo(string name,string pwd)
        {
            if (name==null||pwd==null)
            {
                return Ok("用户名和密码不可为空");
            }
            else
            {
                if (_iemployeedate.Logo(name, pwd).Count <= 0)
                {
                    return Ok("很抱歉登陆失败");
                }
                else
                {
                    return Ok(_iemployeedate.Logo(name, pwd));
                }
            }


        }
        /// <summary>
        /// 车辆管理显示
        /// </summary>
        /// <returns></returns>
        #region
        [Route("/vehicleshow")]
        [HttpGet]
        public IActionResult Getvehicleshow()
        {
            return Ok(_ivehicle1.vehicleshow(commonfiled.uid));
        }

        /// <summary>
        /// 车辆管理添加
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [Route("/vehicleadd")]
        [HttpPost]
        public IActionResult Postvehicleadd(vehicletable u)
        {
            return Ok(_ivehicle1.vehicleadd(u));
        }
        /// <summary>
        /// 车辆管理反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/vehiclealt")]
        [HttpGet]
        public IActionResult Getvehiclealt(int id)
        {
            return Ok(_ivehicle1.vehiclealt(id));
        }
        /// <summary>
        /// 车辆管理修改
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [Route("/vehicleupt")]
        [HttpPost]
        public IActionResult Postvehicleupt(vehicletable u)
        {
            return Ok(_ivehicle1.vehicleupt(u));
        }
        /// <summary>
        /// 车辆管理管理删除真删
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/vehicledel")]
        [HttpGet]
        public IActionResult Getvehicledel(int id)
        {
            return Ok(_ivehicle1.vehicledel(id));
        }
        #endregion
        /// <summary>
        /// 货主管理显示
        /// </summary>
        /// <returns></returns>
        [Route("/ownershow")]
        [HttpGet]
        public IActionResult Getownershow()
        {
            return Ok(_iownerdata.ownershow(commonfiled.uid));
        }

        /// <summary>
        /// 货主管理添加
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [Route("/owneradd")]
        [HttpPost]
        public IActionResult Postowneradd(ownertable u)
        {
            return Ok(_iownerdata.owneradd(u));
        }
        /// <summary>
        /// 货主管理反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/owneralt")]
        [HttpGet]
        public IActionResult Getowneralt(int id)
        {
            return Ok(_iownerdata.owneralt(id));
        }
        /// <summary>
        /// 货主管理反填
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [Route("/ownerupt")]
        [HttpPost]
        public IActionResult Postownerupt(ownertable u)
        {
            return Ok(_iownerdata.ownerupt(u));
        }
        /// <summary>
        /// 货主管理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/ownerdel")]
        [HttpGet]
        public IActionResult Getownerdel(int id)
        {
            return Ok(_iownerdata.ownerdel(id));
        }
    }
}
