using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public class StuffedCrust : Pizza
    {

        public StuffedCrust()
        {
            this.Name = "Stuffed Crust";
            this.Price = this.GetPizzaCost();
        }

        public StuffedCrust(int size)
        {
            this.PizzaSize = size;
            this.Name = "Stuffed Crust";
            this.Price = this.GetPizzaCost();
        }

        public override double GetPizzaCost()
        {
            return base.GetPizzaCost() + 3.00;
        }
        
    }
}
