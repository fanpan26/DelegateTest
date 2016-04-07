using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //new一个网络请求类
            PZNetRequest request = new PZNetRequest();
            //new 一个delegate
            PZNetRequestDelegate requestDelegate = new PzDelegateRequestDemo();
            //将delegate 传入 request 初始化
            request.init(requestDelegate);
            //开始发送请求，请求成功和失败，将在delegate中处理
            request.StartRequest("success", null);
            request.StartRequest("failer", null);

            Console.Read();
        }
    }
}
