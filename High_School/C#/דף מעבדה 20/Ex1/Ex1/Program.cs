using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
	        Time watch;
	        Time launchTime;

            watch = new Time();
	        launchTime = new Time();


	        launchTime.SetTime(12,55);
	        Console.WriteLine("Launch time is at :" + launchTime.GetTime());

            int inputHours;
	        int inputMinutes;
	        Console.Write("Enter the hour (0..23): ");
	        inputHours = int.Parse(Console.ReadLine());
	        Console.Write("Enter the minute (0..59): ");
	        inputMinutes = int.Parse(Console.ReadLine());

	        watch.SetTime(inputHours, inputMinutes);
            Console.WriteLine();
	        Console.WriteLine("The time is: {0}", watch.GetTime());
            Console.WriteLine();
            Console.WriteLine("Enter the number of minutes you would like to advance by:");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                watch.AddMinute();
                launchTime.AddMinute();
            }
            Console.WriteLine();
            Console.WriteLine("Launch time is at :" + launchTime.GetTime());
            Console.WriteLine("The time is: {0}", watch.GetTime());
            Console.ReadLine();
            
        }
    }
}
