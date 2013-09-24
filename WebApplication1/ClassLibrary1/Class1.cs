using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        static int i = 0;
        public string ComputeButtonText()
        {
            return String.Format("X{0} {1}", i++, DateTime.Now.ToString());
        }
    }
}
