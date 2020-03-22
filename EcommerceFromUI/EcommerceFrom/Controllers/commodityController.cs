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
    public class CommodityController : Controller
    {
        // GET: commodity
        public ActionResult HomePage()
        {
            return View();
        }
    }
}