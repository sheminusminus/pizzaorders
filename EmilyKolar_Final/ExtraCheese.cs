using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public class ExtraCheese : ITopping
    {

        private string name;
        private double price;

        public ExtraCheese()
        {
            this.name = "Extra Cheese";
            this.price = 1.00;
        }

        public ExtraCheese(int size)
        {
            this.name = "Extra Cheese";
            this.price = this.GetCost(size);
        }

        public double GetCost(int size)
        {
            if (size == 10)
            {
                return 1.00;
            }
            else
            {
                return 1.00 + (size * 0.05);
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
    }
}
