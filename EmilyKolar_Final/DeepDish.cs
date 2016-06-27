using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public class DeepDish : Pizza
    {

        public DeepDish()
        {
            this.Name = "Deep Dish";
            this.Price = this.GetPizzaCost();
        }

        public DeepDish(int size)
        {
            this.Name = "Deep Dish";
            this.PizzaSize = size;
            this.Price = this.GetPizzaCost();
        }

        public override double GetPizzaCost()
        {
            return base.GetPizzaCost() + 4.00;
        }
    }
}
