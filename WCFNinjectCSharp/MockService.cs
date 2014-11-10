using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WCFNinjectCSharp
{
    public class MockService : IService
    {
        public void DoStuff()
        {
            Debug.WriteLine("Service doing stuff");
        }
    }
}