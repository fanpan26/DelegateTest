using DelegateTest.PZNetRequestEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    public interface PZNetRequestDelegate
    {
        void PZNetRequest_RequestFailer(object error);
        void PZNetRequest_RequestSuccess(object result);
    }
}
