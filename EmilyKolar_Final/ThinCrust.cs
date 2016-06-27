using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public class ThinCrust : Pizza
    {
        public ThinCrust()
        {
            this.Name = "Thin Crust";
            this.Price = this.GetPizzaCost();
        }

        public ThinCrust(int size)
        {
            this.Name = "Thin Crust";
            this.PizzaSize = size;
            this.Price = this.GetPizzaCost();
        }

    }
}
