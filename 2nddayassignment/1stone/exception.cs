using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stone
{
    class Exceptions:Exception
    {
        string msg;
        public Exceptions()
        {
            msg = "value is less than 0";
        }
        public  Exceptions(string m)
        {
            msg = m;
        }
        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }
}
