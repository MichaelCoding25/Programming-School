using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    public class Family
    {
        private int num;
        private string familyName;
        public Family(int num, string familyName)
        {
            this.num = num;
            this.familyName = familyName;
        }
        public int CalcPrice()
        {
            if (num <= 3)
            {
                return 100 + 30 * num;
            }
            else if(num == 4 || num == 5)
            {
                return 100 + 28 * num;
            }
            else
            {
                return 100 + 26 * num;
            }
        }

    }
}
