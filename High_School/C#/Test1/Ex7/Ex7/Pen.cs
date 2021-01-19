using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    public class Pen
    {
        private string color;
        private string made;
        private double price;
        private double weight;
        
        public Pen(string made)
        {
            color = "red";
            this.made = made;
            price = 10.0;
            weight = 25.0;
        } 
        public Pen(string color, string made, double price, double weight)
        {
            this.color = color;
            this.made = made;
            this.price = price;
            this.weight = weight;
        }
        public string GetMade()
        {
            return made;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetPrice(double x)
        {
            price = x;
        }

        public bool IsSameMade(Pen other)
        {
            if (made == other.GetMade())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsSamePrice(Pen other)
        {
            if (price == other.GetPrice())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
