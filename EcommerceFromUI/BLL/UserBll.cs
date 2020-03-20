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
        public UserAddResponse AddUser(UserAddRequest userAddRequest)
        {
            return ApiRequestHelper.Post<UserAddRequest, UserAddResponse>(userAddRequest);
        }
    }
}
