using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forlystelsespark
{
    class Slave : Employee
    {
        private int workHours;

        public Slave(int id, string name, string city, int age, string position, int salary, int workHours)
            :base(id,name,city,age,position,salary)
        {
            this.workHours = workHours;
        }



    }
}
