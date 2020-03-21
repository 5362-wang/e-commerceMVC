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
        public UserLoginResponse UserLogin(UserLoginRequest userLoginResponse)
        {
            return ApiRequestHelper.Post<UserLoginRequest, UserLoginResponse>(userLoginResponse);
        }
    }
}
