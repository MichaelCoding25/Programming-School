using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Building
    {
        private string address;
        private int numAps;

        public Building(string address, int numAps)
        {
            this.address = address;
            this.numAps = numAps;
        }

        public bool houseCommity()
        {
            if (numAps > 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
