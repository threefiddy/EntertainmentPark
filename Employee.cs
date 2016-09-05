using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forlystelsespark
{
    class Employee
    {
        private int id;
        private string name;
        private string city;
        private int age;
        private string position;
        private double salary;

        public Employee(int id, string name, string city, int age, string position, double salary)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.age = age;
            this.position = position;
            this.salary = salary;
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return Name;
        }

        public virtual void GiveBonus(double amount)
        {
            this.salary += amount;
        }
    }
}
