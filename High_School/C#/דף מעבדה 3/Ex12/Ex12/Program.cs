using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            double diesel = 3.65, benzin95 = 4.45, benzin96 = 4.85, carWash = 45.00, userGas, gasType, fuelPrice, total, discount, userCarWash;
            char response;
            string strGasType;
            Console.WriteLine("Please enter you preffered fuel type: 1. diesel 2. benzin95 3. benzin96");
            gasType = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how many liters of fuel you need:");
            userGas = double.Parse(Console.ReadLine());
            switch (gasType)
            {
                case 1:
                    fuelPrice = userGas * diesel;
                    break;
                case 2:
                    fuelPrice = userGas * benzin95;
                    break;
                case 3:
                    fuelPrice = userGas * benzin96;
                    break;
                default:
                    fuelPrice = 0;
                    break;
                    
            }
            if (userGas > 10)
                discount = 1.50 * (userGas - 10);
            else
                discount = 0;
            userCarWash = carWash - discount;
            if (userCarWash < 0)
                userCarWash = 0;
            switch (gasType)
            {
                case 1:
                    strGasType = "diesel";
                    break;
                case 2:
                    strGasType = "benzin95";
                    break;
                case 3:
                    strGasType = "benzin96";
                    break;
                default:
                    strGasType = "";
                    break;
            }
            Console.WriteLine("You filled up " + userGas + " liters of " + strGasType +  " and your price for the fuel is: " + fuelPrice + ". Your price for the carwash if you want it is: " + userCarWash);
            Console.WriteLine("Would you like to use the carwash? Answer with Y or N:");
            response = char.Parse(Console.ReadLine());
            if (response == 'Y')
            {
                total = fuelPrice + userCarWash;
                Console.WriteLine("Your total is: " + total);
            }
            else
            {
                Console.WriteLine("Your total is: " + fuelPrice);
            }
            
            Console.ReadLine();
        }
    }
}
