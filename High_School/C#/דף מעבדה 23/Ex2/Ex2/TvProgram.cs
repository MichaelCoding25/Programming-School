using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class TvProgram
    {
        private int code;
        private int day;
        private bool isSport;

        public TvProgram(int code, int day, bool isSport)
        {
            this.code = code;
            this.day = day;
            this.isSport = isSport;
        }

        public void SetCode(int code)
        {
            this.code = code;
        }
        public void SetDay(int day)
        {
            this.day = day;
        }
        public void SetIsSport(bool isSport)
        {
            this.isSport = isSport;
        }

        public int GetCode()
        {
            return code;
        }
        public int GetDay()
        {
            return day;
        }
        public bool GetIsSport()
        {
            return isSport;
        }
    }
}
