using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmilyKolar_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //make first pizza
            ThinCrust p1 = new ThinCrust(10);
            Pepperoni pepp = new Pepperoni();
            Mushroom mush = new Mushroom();
            p1.AddTopping(pepp);
            p1.AddTopping(mush);

            Console.WriteLine(p1.About());
            Console.ReadKey();

            //make second pizza
            ThickCrust p2 = new ThickCrust(17);
            ExtraCheese cheese = new ExtraCheese();
            p2.AddTopping(pepp);
            p2.AddTopping(cheese);

            Console.WriteLine(p2.About());
            Console.ReadKey();

            //make third pizza
            DeepDish p3 = new DeepDish(14);
            GreenPeppers green = new GreenPeppers();
            Sausage ssg = new Sausage();
            p3.AddTopping(pepp);
            p3.AddTopping(green);
            p3.AddTopping(ssg);

            Console.WriteLine(p3.About());
            Console.ReadKey();

            //make a fourth pizza (with stuffed crust)
            StuffedCrust p4 = new StuffedCrust(21);
            //using the price of toppings varying by size
            Mushroom mush2 = new Mushroom(21);
            ExtraCheese cheese2 = new ExtraCheese(21);
            p4.AddTopping(cheese2);
            p4.AddTopping(mush2);

            Console.WriteLine(p4.About());
            Console.ReadKey();

            //make some wings
            Boneless w = new Boneless();

            Console.WriteLine(w.About());
            Console.ReadKey();

            //add everything to a new order
            Order order = new Order();
            order.AddPizza(p1);
            order.AddPizza(p2);
            order.AddPizza(p3);
            order.AddPizza(p4);
            order.AddWings(w);

            //get the subtotal
            Console.WriteLine();
            Console.WriteLine("Subtotal: " + order.SubTotal().ToString());

            //get the total after tax
            Console.WriteLine("After Fees: " + order.AfterFees().ToString());

            //make the order for delivery
            order.MakeDelivery();

            //get the total after tax and delivery charge
            Console.WriteLine("After Fees & Delivery Charge: " + order.AfterFees().ToString());

            Console.ReadKey();

            Console.WriteLine();

            //testing more toppings cost (varying by size)
            Console.WriteLine("Cost of mushrooms for small pizza: " + mush.GetCost(10).ToString());
            Console.WriteLine("Cost of mushrooms for medium pizza: " + mush.GetCost(14).ToString());
            Console.WriteLine("Cost of sausage for small pizza: " + ssg.GetCost(10).ToString());
            Console.WriteLine("Cost of sausage for medium pizza: " + ssg.GetCost(14).ToString());
            Console.ReadKey();
            

        }
    }
}
