using ApiSDKClient;
using BLL.APIRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderBll
    {
        /// <summary>
        /// 查询订单表（并且可根据订单类型【快递到哪了】和商品名称进行查询）
        /// </summary>
        /// <param name="name"></param>
        /// <param name="OrderTypeId"></param>
        /// <returns></returns>
        public OrderGetResponse QueryOrderInfo(OrderGetRequest request)
        {
            return ApiRequestHelper.Post<OrderGetRequest, OrderGetResponse>(request);
        }
        /// <summary>
        /// 查询优惠信息表[9折  7折  5折  免单]
        /// </summary>
        /// <returns></returns>
        public OrderQueryDiscountsInfoResponse QueryDiscountsInfo(OrderQueryDiscountsInfoRequest request)
        {
            return ApiRequestHelper.Post<OrderQueryDiscountsInfoRequest, OrderQueryDiscountsInfoResponse>(request);
        }
        /// <summary>
        /// 查询商品规格表[S  M  L  XL]
        /// </summary>
        /// <returns></returns>
        public OrderQueryCommodityTypeResponse QueryCommodityType(OrderQueryCommodityTypeRequest request)
        {
            return ApiRequestHelper.Post<OrderQueryCommodityTypeRequest, OrderQueryCommodityTypeResponse>(request);
        }
        /// <summary>
        /// 查询订单类型表[看快递走到哪了]
        /// </summary>
        /// <returns></returns>
        public OrderQueryOrderTypeResponse QueryOrderType(OrderQueryOrderTypeRequest request)
        {
            return ApiRequestHelper.Post<OrderQueryOrderTypeRequest, OrderQueryOrderTypeResponse>(request);
        }
        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public OrderAddResponse AddOrderInfo(OrderAddRequest request)
        {
            return ApiRequestHelper.Post<OrderAddRequest, OrderAddResponse>(request);
        }

        /// <summary>
        /// 逻辑删除订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderDeleteResponse DelOrderInfo(OrderDeleteRequest request)
        {
            return ApiRequestHelper.Post<OrderDeleteRequest, OrderDeleteResponse>(request);
        }

        /// <summary>
        /// 根据用户id获取单条信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderGetOneOrderInfoResponse GetOneOrderInfo(OrderGetOneOrderInfoRequest request)
        {
            return ApiRequestHelper.Post<OrderGetOneOrderInfoRequest, OrderGetOneOrderInfoResponse>(request);
        }

        /// <summary>
        /// 编辑方法
        /// </summary>
        /// <param name="info"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderUpdateResponse UpdateOrderInfo(OrderUpdateRequest request)
        {

            return ApiRequestHelper.Post<OrderUpdateRequest,OrderUpdateResponse>(request);
        }

        /// <summary>
        /// 点击发货修改成为发货状态
        /// </summary>
        /// <returns></returns>
        public OrderUpdateStausGoGoodsResponse UpdateStausGoGoods(OrderUpdateStausGoGoodsRequest request)
        {
            return ApiRequestHelper.Post<OrderUpdateStausGoGoodsRequest,OrderUpdateStausGoGoodsResponse>(request);
        }
    }
}
