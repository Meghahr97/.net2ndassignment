using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PizzaOrder> po = new List<PizzaOrder>
            {
                new PizzaOrder
                {OrderID=101, OrderDate=DateTime.Now, PizzaType="veg", PizzaSize='s', toppings="sweetcorn",qty=4,price=100 },
                new PizzaOrder
                { OrderID=102, OrderDate=DateTime.Now, PizzaType="nonveg", PizzaSize='m', toppings="egg",qty=3,price=300},
                new PizzaOrder
                 {OrderID=103, OrderDate=DateTime.Now, PizzaType="veg", PizzaSize='l', toppings="sweetcorn",qty=4,price=50 },

            };
            foreach(var r in po)
            {
                Console.WriteLine(r.OrderID + " " + r.OrderDate + " " + r.PizzaType + " " + r.toppings + " " + r.qty + " " + r.price);
            }
            Console.WriteLine("***********");
            var data1 = po.Select(x => new
            {
                Ptype = x.PizzaType,
                psize = x.PizzaSize
            });

            foreach(var h in data1)
            {
                Console.WriteLine(h.Ptype + " " + h.Ptype);
            }

            var data2 = po.GroupBy(x => x.PizzaType).Select(x => new
            {
                ptype = x.Key,
                sumqty = x.Sum(y => y.qty),
                sumamt = x.Sum(z => z.price),

            });

            foreach (var h in data2)
                Console.WriteLine(h.ptype + " " + h.sumqty + " " + h.sumamt);

            var data3 = po.GroupBy(x => x.PizzaSize).Select(x => new
            {
                Psize = x.Key,
                sumqty = x.Sum(y => y.qty),
                sumamt = x.Sum(z => z.price)


            });

            foreach (var h in data3)
                Console.WriteLine(h.Psize + " " + h.sumqty + " " + h.sumamt);
            Console.WriteLine("****************");

            var data4 = po.Where(x => x.PizzaSize == 'm' || x.PizzaSize == 'm').Select(x => new
            {
                Ptype = x.PizzaType,
                top = x.toppings
            });

            foreach (var h in data4)
                Console.WriteLine(h.Ptype + " " + h.top);
            Console.WriteLine("*****");

            var maxprice = po.Where(x => x.price == po.Max(y => y.price));
            foreach(var r in maxprice)
            {
                Console.WriteLine(r.OrderID + " " + r.OrderDate + " " + r.PizzaType + " " + r.price + " " + r.toppings + " " + r.qty + " " + r.PizzaSize);
            }

            var minprice = po.Where(x => x.price == po.Min(y => y.price));
            foreach (var r in minprice)
            {
                Console.WriteLine(r.OrderID + " " + r.OrderDate + " " + r.PizzaType + " " + r.price + " " + r.toppings + " " + r.qty + " " + r.PizzaSize);
            }



        }
    }
}
