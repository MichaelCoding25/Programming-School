using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    public class Card
    {
        private int value;
        private int color;

        public Card(int value, int color)
        {
            this.value = value;
            this.color = color;
        }
        public int GetValue()
        {
            return value;
        }
        public int GetColor()
        {
            return color;
        }
        public void SetValue(int value)
        {
            this.value = value;
        }
        public void SetColor(int color)
        {
            this.color = color;
        }
        public bool IsSame(Card other)
        {
            if ((value == other.GetValue())&&(color == other.GetColor()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int CompareVal(Card other)
        {
            if (value > other.GetValue())
            {
                return 1;
            }
            else if(value < other.GetValue())
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
    }
}
