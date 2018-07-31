using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stone
{
    class Program
    {
        static void Main(string[] args)
        {
            USERTRAIL u = new USERTRAIL();

            try
            { u.show();
                u.calculate();
            }
            catch (Exceptions e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
       


    }
    
}
