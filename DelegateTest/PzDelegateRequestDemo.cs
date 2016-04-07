using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    public class PzDelegateRequestDemo : PZNetRequestDelegate
    {
        public void PZNetRequest_RequestFailer(object error)
        {
            Console.WriteLine("请求失败：" + error.ToString());
        }

        public void PZNetRequest_RequestSuccess(object result)
        {
            Console.WriteLine("请求成功：" + result.ToString());
        }
    }
}
