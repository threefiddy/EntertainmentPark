using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forlystelsespark
{
    class WorksOn
    {
        private int hours;
        private Department d;
        private Employee e;

            public WorksOn(int hours, Department d, Employee e)
            {
                this.hours = hours;
                this.d = d;
                this.e = e;
            }


            public int Hours
            {
                get { return hours; }
                set { hours = value; }
            }


            public Department Department
            {
                get { return d; }
                set { d = value; }
            }

            public Employee Employee
            {
                get { return e; }
                set { e = value; }
            }
        
        

        }
}
