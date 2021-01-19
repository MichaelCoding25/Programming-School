using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string st;
            int countch = 0, i;
            Console.WriteLine("Please enter a number:");
            st = Console.ReadLine();
            for (i = 0; i < st.Length; i++)
                if (Char.IsDigit(st[i])) countch++;
            Console.WriteLine("Number of digits:{0}", countch);
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
