using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Time
    {
        private int hour = 0;	
        private int minute = 0;	

        
        public void SetTime(int h, int m)
        {
            hour = h;
            minute = m;
        }

        
        public string GetTime()
        {
            return hour + ":" + minute;
        }

        public void AddMinute()
        {
            if (minute + 1 == 60)
            {
                minute = 0;
                if (hour == 23)
                {
                    hour = 0;
                }
                else
                {
                    hour++;
                }
            }
            else
            {
                minute++;
            }
        }

    }
}
