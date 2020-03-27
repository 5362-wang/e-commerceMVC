using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiSDKClient;
using ApiSDKClient.FApi.Request.Comt;
using BLL;
using BLL.APIRequest;
using BLL.Comt;

namespace EcommerceFrom.Controllers
{
    public class CommodityController : Controller
    {

        CommodityBll bll = new CommodityBll();

        // GET: commodity
        /// <summary>
        /// 显示商品
        /// </summary>
        /// <returns></returns>
        public ActionResult CommodityPage()
        {
            
            return View();
        }

        /// <summary>
        ///添加颜色
        /// </summary>
        /// <returns></returns>
        public JsonResult CommodityColor(CommColorAddRequest request)
        {
            var res = bll.ColorAdd(request);
            return Json(res);
        }
        /// <summary>
        ///添加商品
        /// </summary>
        /// <returns></returns>
        public JsonResult CommodityAdd(CommodityAddRequest request)
        {
            var res = bll.CommodityAdd(request);
            return Json(res);
        }

        /// <summary>
        /// 添加类别
        /// </summary>
        /// <returns></returns>
        public JsonResult CommodityType(CommTypeAddRequest request)
        {
            var res = bll.TypeAdd(request);
            return Json(res);
        }

        /// <summary>
        /// 绑定下拉
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult CommodityBindType(CommTypeShowRequest request)
        {
            var res = bll.TypeShow(request);
            return Json(res);
        }

    }
}