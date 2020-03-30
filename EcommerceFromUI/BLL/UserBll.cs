using ApiSDKClient;
using BLL.APIRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBll
    {
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="userAddRequest"></param>
        /// <returns></returns>
        public UserAddResponse AddUser(UserAddRequest userAddRequest)
        {
            return ApiRequestHelper.Post<UserAddRequest, UserAddResponse>(userAddRequest);
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userAddRequest"></param>
        /// <returns></returns>
        public UserLoginResponse UserLogin(UserLoginRequest userLoginRequest)
        {
            return ApiRequestHelper.Post<UserLoginRequest, UserLoginResponse>(userLoginRequest);
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="userFindRequest"></param>
        /// <returns></returns>
        public UserFindResponse UserFind(UserFindRequest userFindRequest)
        {
            return ApiRequestHelper.Post<UserFindRequest, UserFindResponse>(userFindRequest);
        }
        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="userGetRequest"></param>
        /// <returns></returns>
        public UserGetResponse GetUser(UserGetRequest userGetRequest)
        {
            return ApiRequestHelper.Post<UserGetRequest, UserGetResponse>(userGetRequest);
        }
    }
}
