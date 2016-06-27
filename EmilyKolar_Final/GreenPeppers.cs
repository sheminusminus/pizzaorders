using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public class GreenPeppers : ITopping
    {
        private string name;
        private double price;

        public GreenPeppers()
        {
            this.name = "Green Peppers";
            this.price = 0.75;
        }

        public GreenPeppers(int size)
        {
            this.name = "Green Peppers";
            this.price = this.GetCost(size);
        }

        public double GetCost(int size)
        {
            if (size == 10)
            {
                return 0.75;
            }
            else
            {
                return 0.75 + (size * 0.05);
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
