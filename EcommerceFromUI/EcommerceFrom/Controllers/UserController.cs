using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using ApiSDKClient;
using BLL;
using BLL.APIRequest;
namespace EcommerceFrom.Controllers
{
    public class UserController : Controller
    {
        UserBll bll = new UserBll();
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {      
            
            return View();
        }
        // GET: User
        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public ActionResult AddUser()
        {
           
            return View();
        }
        /// <summary>
        /// 找回密码
        /// </summary>
        /// <returns></returns>
        public ActionResult FindPwd()
        {
            return View();
        }
        /// <summary>
        /// 权限管理
        /// </summary>
        /// <returns></returns>
        public ActionResult Permit()
        {
            return View();
        }
        /// <summary>
        /// 验证码
        /// </summary>
        /// <param name="yzm"></param>
        /// <returns></returns>
        public int CheckValidateCode(string yzm)
        {
            int res = 0;
            string cnum = Session["CheckCode"] == null ? "" : Session["CheckCode"].ToString();

            //验证码
            if (yzm.ToLower() == cnum.ToLower() && !string.IsNullOrEmpty(yzm))
            {
                //验证是否为空
                res = 1;
                return res;
            }
            else
            {
                return res;
            }
        }
        /// <summary>
        /// 邮箱验证 返回验证码hrrqcbxmmjtlddec
        /// </summary>vagbusoowxxgbgfi
        /// <param name="JiShou">接受的邮箱账号</param>
        /// <param name="Count">验证码数量</param>
        /// <returns></returns>
        public string Send(string JiShou, int Count)
        {
            string YZM = CreateBlendCode(Count);
          
            //发件人地址
            MailAddress from = new MailAddress("wxk17625056013@163.com");
            MailMessage message = new MailMessage();
            message.Body = "您本次的验证码为（备注：王玺凯项目邮箱验证测试）" + YZM;
            //message.Body = "恭喜你修改密码成功（备注：王玺凯项目邮箱验证测试）";
            message.IsBodyHtml = true;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            //收件人地址
            message.To.Add(JiShou);
            message.Subject = "邮箱验证";
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.From = from;
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.Host = "smtp.163.com";
            client.Port = 25;
            //邮箱账户和密码pywcpfrcdknwdfbi
            client.Credentials = new System.Net.NetworkCredential("wxk17625056013@163.com", "qxy15824998926");

            try
            {
                client.Send(message);
                return YZM;
            }
            catch (Exception ex)
            {
                string mssage = ex.ToString();
                return "";
            }

        }

        /// <summary>
        /// 这个是使用字母,数字混合
        /// </summary>
        /// <param name="VcodeNum"></param>
        /// <returns></returns>
        public string CreateBlendCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(61);
                if (temp == t)
                {
                    return CreateBlendCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }

            return randomCode;
        }
        /// <summary>
        /// 注册功能
        /// </summary>
        public JsonResult UserRegist(UserAddRequest userAddRequest)
        {
           var res= bll.AddUser(userAddRequest);

            //GET请求返回
            //return Json(res,JsonRequestBehavior.AllowGet);

            //POST请求返回
            return Json(res);
        }
        /// <summary>
        /// 登录功能
        /// </summary>
        /// <param name="userAddRequest"></param>
        /// <returns></returns>
        public JsonResult UserLogin(UserLoginRequest userLoginRequest)
        {
            var res = bll.UserLogin(userLoginRequest);
            Session["DepartmentId"] = res.DepartmentId;
            Session["Uid"] = res.Uid;
            Session["UserName"] = res.UserName;
            Session["UserImg"] = res.UserImg;
            return Json(res);
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="userFindRequest"></param>
        /// <returns></returns>
        public JsonResult UserFind(UserFindRequest userFindRequest)
        {
            var res = bll.UserFind(userFindRequest);
            return Json(res);
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userGetRequest"></param>
        /// <returns></returns>
        public JsonResult GetUser(UserGetRequest userGetRequest)
        {
            var res = bll.GetUser(userGetRequest);
            return Json(res);
        }
    }
}