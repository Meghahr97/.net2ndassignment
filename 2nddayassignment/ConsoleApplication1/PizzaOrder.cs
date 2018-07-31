using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PizzaOrder
    {
       

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string PizzaType { get; set; }
        public char PizzaSize { get; set; }
        public string toppings { get; set; }
        public int qty { get; set; }
        public int price { get; set; }


    }
}
