using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public class Sausage : ITopping
    {
        private string name;
        private double price;

        public Sausage()
        {
            this.name = "Sausage";
            this.price = 1.75;
        }

        public Sausage(int size)
        {
            this.name = "Sausage";
            this.price = this.GetCost(size);
        }

        public double GetCost(int size)
        {
            if (size == 10)
            {
                return 1.75;
            }
            else
            {
                return 1.75 + (size * 0.05);
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
