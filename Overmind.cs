using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forlystelsespark
{
    class Overmind : Employee
    {
        private int tortureHours;

        public Overmind(int id, string name, string city, int age, string position, int salary, int tortureHours)
            :base(id, name, city, age, position, salary)
        {
            this.tortureHours = tortureHours;
        }
    }
}
