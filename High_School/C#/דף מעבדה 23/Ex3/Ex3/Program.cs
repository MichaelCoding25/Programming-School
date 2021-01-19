using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static Timer Shorter(Timer timer1, Timer timer2)
        {
            if (timer1.GetHour() * 60 + timer1.GetMinute() > timer2.GetHour() * 60 + timer2.GetMinute())
            {
                return timer2;
            }
            else
            {
                return timer1;
            }
        }


        static void Main(string[] args)
        {
            Timer t1 = new Timer(5, 45);
            Timer t2 = new Timer(7, 5);

            Timer shortest = Shorter(t1, t2);

            Console.WriteLine("The shortest time is: " + shortest.GetHour() + ":" + shortest.GetMinute());
            Console.ReadLine();
        }
    }
}
