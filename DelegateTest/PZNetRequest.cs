using DelegateTest.PZNetRequestEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateTest
{
    public class PZNetRequest
    {

        /// <summary>
        /// 定义成功代理
        /// </summary>
        event RequestSuccessHandler RequestSuccess;
        /// <summary>
        /// 定义失败代理
        /// </summary>
        event RequestFailerHanlder RequestFailer;

        public void init(PZNetRequestDelegate target)
        {
            //注册代理事件
            RequestSuccess += target.PZNetRequest_RequestSuccess;
            RequestFailer += target.PZNetRequest_RequestFailer;
        }
        /// <summary>
        /// 开始请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        public void StartRequest(string url, Dictionary<string, object> parameters)
        {
            Console.WriteLine("发起请求。。。");
            Thread.Sleep(1000);//模拟网络请求一秒

            if (url == "success")
            {
                RequestSuccess("success");
            }
            else
            {
                RequestFailer("error");
            }
        }
    }
}
