using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public JsonResult CommodityPageShow(CommodityShowRequest request)
        {
            var res = bll.CommodityShow(request);

            return Json(res);
        }

        /// <summary>
        ///添加颜色
        /// </summary>
        /// <returns></returns>
        public ActionResult CommodityColor()
        {
            return View();
        }
        public JsonResult CommodityColorAdd(CommColorAddRequest request)
        {
            var res = bll.ColorAdd(request);
            return Json(res);
        }
        /// <summary>
        ///添加商品
        /// </summary>
        /// <returns></returns>
        public ActionResult CommodityAdd()
        {
            return View();
        }
        public JsonResult CommodityAddadd(CommodityAddRequest request)
        {
            var res = bll.CommodityAdd(request);

            return Json(res);
        }

        /// <summary>
        /// 显示商品
        /// </summary>
        /// <returns></returns>
        public ActionResult CommodityShows()
        {

            return View();
        }
        public JsonResult CommodityShow(CommodityShowRequest request)
        {
            var res = bll.CommodityShow(request);

            return Json(res);
        }


        /// <summary>
        /// 添加类别
        /// </summary>
        /// <returns></returns>
        public ActionResult CommodityType()
        {
            return View();
        }
        public JsonResult CommodityTypeAdd(CommTypeAddRequest request)
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

        /// <summary>
        /// 商品查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult ComodityInquire(CommodityInquireRequest request)
        {
            var res = bll.InquireCommodity(request);
            return Json(res);
        }

        /// <summary>
        /// 绑定颜色
        /// </summary>
        /// <returns></returns>
        public JsonResult CommodityBindColor(CommColorShowRequest request)
        {
            var res = bll.ColorShow(request);
            return Json(res);
        }

        /// <summary>
        /// 修改上架状态
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult CommodityUpt(CommodityUptRequest request)
        {
            var res = bll.CommodityUpt(request);
            return Json(res);
        }

        /// <summary>
        /// 编辑方法 
        /// </summary>
        /// <returns></returns>
        public ActionResult UpdateComodity()
        {
            return View();
        }
        public JsonResult CommodityUpdate(CommodityUpdateReq request)
        {
            var res = bll.UpdateCommodityInfo(request);
            return Json(res);
        }
        /// <summary>
        /// 获取单条信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CommodityUpdateOne(CommodityUptReq request)
        {
            var res = bll.GetCommodityInfo(request);
            return Json(res);
        }



    }
}