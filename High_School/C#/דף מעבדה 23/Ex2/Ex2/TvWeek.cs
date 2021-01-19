using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class TvWeek
    {
        private TvProgram[] arrProg;
        private int amount;

        public TvWeek()
        {
            arrProg = new TvProgram[100];
            amount = 0;
        }

        public void AddProgram(TvProgram p1)
        {
            if (amount < 100)
            {
                arrProg[amount] = p1;
                amount++;
            }
            else
            {
                Console.WriteLine("Too many programs this week.");
            }
        }

        public int GetSportsPrograms()
        {
            int counter = 0;
            for (int i = 0; i < amount; i++)
            {
                if (arrProg[i].GetIsSport())
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
