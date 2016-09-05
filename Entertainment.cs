using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forlystelsespark
{
    class Entertainment
    {
        private int noOfPplWatching;
        private string name;
        private double areaCovered;
        public List<Entertainment> entList;

        public Entertainment(int noOfPplWatching, string name, double areaCovered)
        {
            this.noOfPplWatching = noOfPplWatching;
            this.name = name;
            this.areaCovered = areaCovered;
            this.entList = new List<Entertainment>();
        }

        public int NoOfPplWatching
        {
            get { return noOfPplWatching; }
            set { noOfPplWatching = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double AreaCovered
        {
            get { return areaCovered; }
            set { areaCovered = value; }
        }

        public void AddEntertainment(string name)
        {
            
        }
    }
}
