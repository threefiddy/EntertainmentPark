using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forlystelsespark
{
    class TorTureEntertainment : Entertainment
    {
        private int noOfPplTortured;
        public TorTureEntertainment(int noOfPplWatching, string name, double areaCovered, int noOfPplTortured)
            :base(noOfPplWatching,name,areaCovered)
        {
            this.noOfPplTortured = noOfPplTortured;
        }

        public int NoOfPpltortured
        {
            get { return noOfPplTortured; }
            set { noOfPplTortured = value; }
        }
        
    }

}
