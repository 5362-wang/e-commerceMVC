using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiSDKClient;
using BLL;
namespace EcommerceFrom.Controllers
{
    public class UserController : Controller
    {
        UserBll bll = new UserBll();
        public ActionResult Login()
        {
            UserAddRequest userAddRequest = new UserAddRequest();
            //bll.AddUser(userAddRequest);
            return View();
        }
        // GET: User
        public ActionResult AddUser()
        {
            //UserAddRequest userAddRequest = new UserAddRequest();
            //bll.AddUser(userAddRequest);
            return View();
        }
        public int CheckValidateCode(string yzm)
        {
            int res = 0;
            string cnum = Session["CheckCode"] == null ? "" : Session["CheckCode"].ToString();

            //验证码
            if (yzm.ToLower() == cnum.ToLower() && !string.IsNullOrEmpty(yzm))
            {
                //验证是否为空
                res = 1;
                return res;
            }
            else
            {
                return res;
            }
        }
        /// <summary>
        /// 注册功能
        /// </summary>
        public void UserRegist()
        {

        }
    }
}