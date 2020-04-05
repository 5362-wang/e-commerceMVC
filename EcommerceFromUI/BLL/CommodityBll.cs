
using ApiSDKClient.FApi.Request.Comt;
using ApiSDKClient.FApi.Response.Comt;
using BLL.APIRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Comt
{
    /// <summary>
    /// 商品Bll
    /// </summary>
    public class CommodityBll
    {
        /// <summary>
        /// 添加颜色
        /// </summary>
        /// <returns></returns>
        public CommColorAddResponse ColorAdd(CommColorAddRequest request)
        {
            return ApiRequestHelper.Post<CommColorAddRequest, CommColorAddResponse>(request);
        }
        /// <summary>
        /// 显示颜色
        /// </summary>
        /// <returns></returns>
        public CommColorShowResponse ColorShow(CommColorShowRequest request)
        {
            return ApiRequestHelper.Post<CommColorShowRequest, CommColorShowResponse>(request);
        }
        /// <summary>
        /// 修改颜色
        /// </summary>
        /// <returns></returns>
        public CommColorUptResponse ColorUpt(CommColorUptRequest request)
        {
            return ApiRequestHelper.Post<CommColorUptRequest, CommColorUptResponse>(request);
        }


        /// <summary>
        /// 添加商品
        /// </summary>
        /// <returns></returns>
        public CommodityAddResponse CommodityAdd(CommodityAddRequest request)
        {
            return ApiRequestHelper.Post<CommodityAddRequest, CommodityAddResponse>(request);
        }
        /// <summary>                                                              
        /// 显示商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public CommodityShowResponse CommodityShow(CommodityShowRequest request)
        {
            return ApiRequestHelper.Post<CommodityShowRequest, CommodityShowResponse>(request);
        }
        /// <summary>                                                              
        /// 查询商品                                                                    
        /// </summary>                                                                    
        /// <returns></returns>                                                 
        public CommodityInquireResponse InquireCommodity(CommodityInquireRequest request)
        {
            return ApiRequestHelper.Post<CommodityInquireRequest, CommodityInquireResponse>(request);
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommodityDelResponse CommodityDel(CommodityDelRequest  request)
        {
            return ApiRequestHelper.Post<CommodityDelRequest, CommodityDelResponse>(request);
        }

        /// <summary>
        /// 修改上架状态
        /// </summary>
        /// <returns></returns>
        public CommodityUptResponse CommodityUpt(CommodityUptRequest  request)
        {
            return ApiRequestHelper.Post<CommodityUptRequest, CommodityUptResponse>(request);
        }

        /// <summary>
        /// 获取单条信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CommodityUptRes GetCommodityInfo(CommodityUptReq request)
        {
            return ApiRequestHelper.Post<CommodityUptReq, CommodityUptRes>(request);
        }
        /// <summary>
        /// 编辑商品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CommodityUpdateRes UpdateCommodityInfo(CommodityUpdateReq request)
        {
            return ApiRequestHelper.Post<CommodityUpdateReq, CommodityUpdateRes>(request);
        }

        /// <summary>
        /// 添加类别
        /// </summary>
        /// <returns></returns>
        public CommTypeAddResponse TypeAdd(CommTypeAddRequest  request)
        {
            return ApiRequestHelper.Post<CommTypeAddRequest, CommTypeAddResponse>(request);
        }

        /// <summary>
        /// 显示类别
        /// </summary>
        /// <returns></returns>
        public CommTypeShowResponse TypeShow(CommTypeShowRequest request)
        {
            return ApiRequestHelper.Post<CommTypeShowRequest, CommTypeShowResponse>(request);
        }
    }
}
