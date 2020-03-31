using ApiSDKClient;
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
        OrderBll bll = new OrderBll();
        /// <summary>
        /// 查询订单表（并且可根据订单类型【快递到哪了】和商品名称进行查询）【页面】
        /// </summary>
        /// <param name="name"></param>
        /// <param name="OrderTypeId"></param>
        /// <returns></returns>
        public ActionResult ShowOrderInfo()
        {
            return View();
        }
        /// <summary>
        /// 查询订单表（并且可根据订单类型【快递到哪了】和商品名称进行查询）【方法】
        /// </summary>
        /// <param name="name"></param>
        /// <param name="OrderTypeId"></param>
        /// <returns></returns>
        public JsonResult ShowOrderInfoMethod(OrderGetRequest request)
        {
            var list = bll.QueryOrderInfo(request);
            return Json(list);
        }
        /// <summary>
        /// 查询优惠信息表[9折  7折  5折  免单]
        /// 【方法】
        /// </summary>
        /// <returns></returns>
        public JsonResult QueryDiscountsInfoMethod(OrderQueryDiscountsInfoRequest request)
        {
            var list = bll.QueryDiscountsInfo(request);
            return Json(list);
        }
        /// <summary>
        /// 查询商品规格表[S  M  L  XL]
        /// 【方法】
        /// </summary>
        /// <returns></returns>
        public JsonResult QueryCommodityTypeMethod(OrderQueryCommodityTypeRequest request)
        {
            var list = bll.QueryCommodityType(request);
            return Json(list);
        }

        /// <summary>
        /// 查询订单类型表[什么状态？代发货？已发货。。。]
        /// 【方法】
        /// </summary>
        /// <returns></returns>
        public JsonResult QueryOrderTypeMethod(OrderQueryOrderTypeRequest request)
        {
            var list = bll.QueryOrderType(request);
            return Json(list);
        }

        /// <summary>
        /// 添加订单信息【页面】
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public ActionResult AddOrderInfo()
        {
            return View();
        }

        /// <summary>
        /// 添加订单信息【方法】
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public JsonResult AddOrderInfoMethod(OrderAddRequest request)
        {
            var res = bll.AddOrderInfo(request);
            return Json(res);
        }
        /// <summary>
        /// 逻辑删除订单信息【方法】
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult DelOrderInfoMethod(OrderDeleteRequest request)
        {
            var res = bll.DelOrderInfo(request);
            return Json(res);
        }


        /// <summary>
        /// 根据用户id获取单条信息【方法】
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult GetOneOrderInfoMethod(OrderGetOneOrderInfoRequest request)
        {
            var res = bll.GetOneOrderInfo(request);
            return Json(res);
        }

        /// <summary>
        /// 编辑方法   【页面】
        /// </summary>
        /// <param name="info"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult UpdateOrderInfo()
        {

            return View();
        }
        /// <summary>
        /// 编辑方法   【方法】
        /// </summary>
        /// <param name="info"></param>
        /// <param name="id"></param>
        public JsonResult UpdateOrderInfoMethod(OrderUpdateRequest request)
        {
            var res = bll.UpdateOrderInfo(request);
            return Json(res);
        }
    }
}