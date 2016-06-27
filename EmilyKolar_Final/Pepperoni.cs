using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public class Pepperoni : ITopping
    {
        private string name;
        private double price;

        public Pepperoni()
        {
            this.name = "Pepperoni";
            this.price = 1.00;
        }

        public Pepperoni(int size)
        {
            this.name = "Pepperoni";
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
