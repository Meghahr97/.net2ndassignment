using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndone
{
    class Program
    {
        static void Main(string[] args)
        {
            workwith w = new workwith();
            try
            {
                w.takedata();
            }
            catch (NoMatchException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
