using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiSDKClient;
using BLL;
using BLL.APIRequest;
namespace EcommerceFrom.Controllers
{
    public class UserController : Controller
    {
        UserBll bll = new UserBll();
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            
            
            return View();
        }
        // GET: User
        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public ActionResult AddUser()
        {
           
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
        public JsonResult UserRegist(UserAddRequest userAddRequest)
        {
           var res= bll.AddUser(userAddRequest);

            //GET请求返回
            //return Json(res,JsonRequestBehavior.AllowGet);

            //POST请求返回
            return Json(res);
        }
        /// <summary>
        /// 登录功能
        /// </summary>
        /// <param name="userAddRequest"></param>
        /// <returns></returns>
        public JsonResult UserLogin(UserLoginRequest userLoginRequest)
        {
            var res = bll.UserLogin(userLoginRequest);
            return Json(res);
        }
    }
}