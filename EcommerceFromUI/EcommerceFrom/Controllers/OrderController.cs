using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceFrom.Controllers
{
    public class OrderController : Controller
    {
        UserBll bll = new UserBll();
        // GET: Order
        public ActionResult ShowOrderInfo()
        {
            return View();
        }
    }
}