using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stone
{
    class USERTRAIL
    {
        int val1, val2, result;
        public void show()
        {
            Console.WriteLine("enter the value for val1 and val2");
            val1 = int.Parse(Console.ReadLine());
            val2 = int.Parse(Console.ReadLine());
            if(val1 < 0)
            {
                throw new Exceptions();
            }
            if (val2<0)
            {
                throw new Exceptions();
            }
        }
        public void calculate()
        {
            result = val1 - val2;
            if (result < 0)
            {
                throw new Exceptions();
            }
            else
                Console.WriteLine("result is:" + result);

        }
    }
}
