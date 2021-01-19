using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = 0, player2 = 0;
            int maxPoints = 28;
            Deck p1 = new Deck();
            Deck p2 = new Deck();
            Random rnd = new Random();
            while (player1 < maxPoints && player2 < maxPoints)
            {
                int rndP1 = rnd.Next(35);
                int rndP2 = rnd.Next(35);
                if (p1.SeeCard(rndP1).CompareVal(p2.SeeCard(rndP2)) == 1)
                {
                    player1+= 3;
                   
                }
                else if (p1.SeeCard(rndP1).CompareVal(p2.SeeCard(rndP2)) == 2)
                {
                    player2 += 3;
                }
                else
                {
                    player1++;
                    player2++;
                }
                if (p1.SeeCard(rndP1).GetColor() == 3)
                {
                    player1 += 2;
                }
                else if (p2.SeeCard(rndP2).GetColor() == 3)
                {
                    player2 += 2;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Player 1 has " + player1 + " points.");
            Console.WriteLine("Player 2 has " + player2 + " points.");

            Console.ReadLine();
        }
    }
}
