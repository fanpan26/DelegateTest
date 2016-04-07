using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest.PZNetRequestEvent
{

    /// <summary>
    /// 请求成功
    /// </summary>
    /// <param name="result"></param>
    public delegate void RequestSuccessHandler(object result);
    /// <summary>
    /// 请求失败
    /// </summary>
    /// <param name="error"></param>
    public delegate void RequestFailerHanlder(object error);

}