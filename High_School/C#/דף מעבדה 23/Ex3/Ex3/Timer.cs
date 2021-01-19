using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Timer
    {
        private int hour;
        private int minute;

        public Timer(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }
        public void SetHour(int hour)
        {
            this.hour = hour;
        }
        public void SetMinute(int minute)
        {
            this.minute = minute;
        }
        public int GetHour()
        {
            return hour;
        }
        public int GetMinute()
        {
            return minute;
        }
    }
}
