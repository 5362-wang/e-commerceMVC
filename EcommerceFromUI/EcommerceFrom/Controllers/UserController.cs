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
        public ActionResult Index()
        {
            //UserAddRequest userAddRequest = new UserAddRequest();
            //bll.AddUser(userAddRequest);
            return View();
        }
        /// <summary>
        /// 注册功能
        /// </summary>
        public void UserRegist()
        {

        }
    }
}