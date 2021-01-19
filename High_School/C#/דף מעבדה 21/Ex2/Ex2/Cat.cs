using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Cat
    {
        private string name;
        private string kind;
        private bool waterLikeness;
        private bool meowLikeness;

        public Cat(string n, string k, bool wL, bool mL)
        {
            name = n;
            kind = k;
            waterLikeness = wL;
            meowLikeness = mL;
        }

        public bool IsThirsty()
        {
            if (waterLikeness == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Meow()
        {
            if (meowLikeness == true)
            {
                return "meow meow meow ";
            }
            else
            {
                return "meow";
            }
        }

        public string GetDetails()
        {
            return ("My name is " + name + " and my kind is " + kind + ".");
        }

        public void DrinkWater()
        {
            waterLikeness = false;
        }
    }
}
