using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forlystelsespark
{
    class Department
    {
        private string name;
        private List<WorksOn> worksOnList;

        public Department(string name)
        {
            this.name = name;
            this.worksOnList = new List<WorksOn>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddEmployee(Employee e, int hours)
        {
            WorksOn wo = new WorksOn(hours,this,e);
            this.worksOnList.Add(wo);
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> retList = new List<Employee>();
            foreach(WorksOn wo in this.worksOnList)
            {
                retList.Add(wo.Employee);
            }
            return retList;
        }

        public void GiveBonus(double amount)
        {
            for (int i = 0; i < this.worksOnList.Count; i++)
            {
                this.worksOnList[i].Employee.GiveBonus(amount);
            }
        }
        
    }
}
