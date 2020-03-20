using ApiSDKClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace BLL.APIRequest
{
    /// <summary>
    /// 请求api的辅助方法
    /// Post 请求 
    /// </summary>
  public   class ApiRequestHelper
    {
        static string BaseAddress = "http://localhost:10551";
        //public static  string Post<T>(T t )where T: BaseRequest
        //{

        //     var api= t.GetApiName();//拿到接口名称
        //    HttpClient client = new HttpClient();
        //    //设置 API的 基地址
        //    client.BaseAddress = new Uri(BaseAddress);
        //    //设置 默认请求头ACCEPT
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    string token = ConfigurationManager.AppSettings["token"];
        //    //设置消息体
        //    HttpContent content = new StringContent(JsonConvert.SerializeObject(t));
        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    //发送Post请求
        //    HttpResponseMessage msg = client.PostAsync(api, content).Result;
        //    //判断结果是否成功
        //    if (msg.IsSuccessStatusCode)
        //    {
        //        var obj = JsonConvert.DeserializeObject<BaseResponse>(msg.Content.ReadAsStringAsync().Result);

        //        if (obj.Status)
        //        {
        //            //表示请求成功
        //        }
        //        //返回响应结果
        //        return msg.Content.ReadAsStringAsync().Result;
        //    }
        //    //返回空字符串，表示响应错误
        //    return "";
        //}
        //地址+具体接口+参数
        //请求头
        public static TResponse Post<TRequet, TResponse>(TRequet t) where TRequet : BaseRequest where TResponse : BaseResponse //   约束这个泛型T 必须继承BaseRequest
        {
            var api = t.GetApiName();//拿到接口的名称

            HttpClient client = new HttpClient();
            //设置 API的 基地址
            client.BaseAddress = new Uri(BaseAddress);
            //设置 默认请求头ACCEPT 
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string token = ConfigurationManager.AppSettings["token"];
            client.DefaultRequestHeaders.Add("token", token);

            //设置消息体
            HttpContent content = new StringContent(JsonConvert.SerializeObject(t));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //发送Post请求
            HttpResponseMessage msg = client.PostAsync(api, content).Result;
            //判断结果是否成功
            if (msg.IsSuccessStatusCode)
            {
                var obj = JsonConvert.DeserializeObject<TResponse>(msg.Content.ReadAsStringAsync().Result);
                if (obj.Status)
                {
                    //表示请求成功
                }
                //返回响应结果
                return obj;
            }

            return null;
        }
    }
}
