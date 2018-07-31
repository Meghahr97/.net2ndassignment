using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndone
{
    class workwith
    {
        string str1 = "Deloitte Training";
        string str2;
        public void takedata()
        {
            Console.WriteLine("type a string for str2");
            str2 = Console.ReadLine();
            if(String.Compare(str1,str2)!=0)
            {
                throw new NoMatchException();
            }
            
            
            
        }

    }
}
