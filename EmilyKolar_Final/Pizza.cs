using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public abstract class Pizza
    {

        public int MaxToppings;
        public int PizzaSize;
        private double price;
        public List<ITopping> Toppings;
        public string Name;

        public Pizza()
        {
            this.Name = "Pizza";
            this.MaxToppings = 5;
            this.PizzaSize = 14;
            this.Price = this.GetPizzaCost();
            this.Toppings = new List<ITopping>();
        }

        public Pizza (int size)
        {
            this.Name = "Pizza";
            this.MaxToppings = 5;
            this.PizzaSize = size;
            this.Price = this.GetPizzaCost();
            this.Toppings = new List<ITopping>();

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

        public void AddTopping(ITopping top)
        {
            if (this.Toppings.Count <= this.MaxToppings)
            {
                this.Toppings.Add(top);
            }
        }

        public virtual double GetPizzaCost()
        {
            if (this.PizzaSize == 10)
            {
                return 10.99;
            }
            if (this.PizzaSize == 17)
            {
                return 15.99;
            }
            if (this.PizzaSize == 21)
            {
                return 17.99;
            }
            else
            {
                return 12.99;
            }
        }

        public double GetToppingsCost()
        {
            double cost = 0;
            foreach (ITopping topping in this.Toppings)
            {
                cost += topping.Price;
            }
            return cost;

        }

        public Size GetSize()
        {
            if (this.PizzaSize == 10)
            {
                return Size.Small;
            }
            if (this.PizzaSize == 17)
            {
                return Size.Large;
            }
            if (this.PizzaSize == 21)
            {
                return Size.Family;
            }
            else
            {
                return Size.Medium;
            }
        }

        public double GetTotalCost()
        {
            return this.Price + this.GetToppingsCost();
        }

        public string About()
        {
            string about = string.Empty;
            about += string.Format("{0} {1} with ", this.GetSize().ToString(), this.Name);
            foreach (ITopping topping in Toppings)
            {
                about += string.Format(topping.Name + " ");
            }
            about += string.Format(" for {0}", this.GetTotalCost().ToString());
            return about;
        }

    }
}
