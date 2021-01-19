using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    public class City
    {
        private string name;
        private int popul;
        private int numOfSchools;

        public City(string name, int popul, int numOfSchools)
        {
            this.name = name;
            this.popul = popul;
            this.numOfSchools = numOfSchools;
        }
        
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetPopul(int popul)
        {
            this.popul = popul;
        }
        public void SetNumOfSchools(int numOfSchools)
        {
            this.numOfSchools = numOfSchools;
        }
        public string GetName()
        {
            return name;
        }
        public int GetPopul()
        {
            return popul;
        }
        public int GetNumOfSchools()
        {
            return numOfSchools;
        }
        public bool IsFit()
        {
            if (numOfSchools > 3 && popul > 5000)
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
