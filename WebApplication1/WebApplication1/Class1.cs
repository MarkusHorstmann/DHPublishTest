using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassLibrary1;

namespace WebApplication1
{
    public class Class2
    {
        static int i = 0;
        public string ComputeButtonText()
        {
            return String.Format("Y{0} {1}", i++, new Class1().ComputeButtonText());
        }

    }
}