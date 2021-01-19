using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation_18._09._17
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("What is your name?");
            name= Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name);
            Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("You're " + age + " years old " + name);
            Console.ReadLine();
        }
    }
}
