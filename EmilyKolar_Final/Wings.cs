using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public abstract class Wings
    {
        public string Name;
        private double price; 


        public Wings()
        {
            this.Name = "Wings";
            this.Price = 3.99;
            
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

        public virtual string About()
        {
            string about = string.Format("{0} for {1}", this.Name, this.Price.ToString());
            return about;
        }

    }
}
