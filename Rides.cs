using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forlystelsespark
{
    class Rides : Entertainment
    {
        private double rideLength;

        public Rides(int noOfPplWatching, string name, double areaCovered, double rideLength)
            : base(noOfPplWatching, name, areaCovered)
        {
            this.rideLength = rideLength;
        }

        public double RideLength
        {
            get { return rideLength; }
            set { rideLength = value; }
        }
        
    }
}
