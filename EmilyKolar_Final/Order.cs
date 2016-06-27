using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmilyKolar_Final
{
    public class Order
    {

        public List<Pizza> Pizzas;
        public List<Wings> Wings;
        public string Name;
        public bool Delivery;

        public Order()
        {
            this.Name = "Carry-Out";
            this.Pizzas = new List<Pizza>();
            this.Wings = new List<Wings>();
            this.Delivery = false;
        }

        public Order(bool isDelivery)
        {
            this.Pizzas = new List<Pizza>();
            this.Wings = new List<Wings>();
            this.Delivery = isDelivery;
            if (isDelivery)
            {
                this.Name = "Delivery";
            }
            else
            {
                this.Name = "Carry-Out";
            }
        }

        public void MakeDelivery()
        {
            this.Delivery = true;
        }


        public void AddPizza(Pizza p)
        {
            this.Pizzas.Add(p);
        }

        public void AddWings(Wings w)
        {
            this.Wings.Add(w);
        }

        public double SubTotal()
        {
            double cost = 0;
            foreach (Pizza pizza in Pizzas)
            {
                cost += pizza.GetTotalCost();
            }
            foreach (Wings wings in Wings)
            {
                cost += wings.Price;
            }
            return cost;
        }

        public double AfterFees()
        {
            double total = 0;
            if (this.Delivery)
            {
                total += 3.00;
            }
            total += this.SubTotal() + (this.SubTotal() * 0.115);
            return total;
        }


    }
}
