using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public class ThickCrust : Pizza
    {

        public ThickCrust()
        {
            this.Name = "Thick Crust";
            this.Price = this.GetPizzaCost();
        }

        public ThickCrust(int size)
        {
            this.Name = "Thick Crust";
            this.PizzaSize = size;
            this.Price = this.GetPizzaCost();
        }

        public override double GetPizzaCost()
        {
            return base.GetPizzaCost() + 1.00;
        }

    }
}
