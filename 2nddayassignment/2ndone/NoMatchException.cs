using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndone
{
    class NoMatchException:Exception
    {
        string msg;
        public NoMatchException()
        {
            msg = "it should be Deloitte training";
        }
        public NoMatchException(string m)
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
