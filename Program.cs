using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forlystelsespark
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp0  = new Overmind(1, "Helle", "Torsted", 26, "commander", 50000, 999999);
            Employee emp1 = new Employee(2, "Torben", "Holsted", 111, "Assistant", 45000);
            Employee emp2 = new Employee(3, "Johanson", "Brønderslev", 14, "worker", 30000);
            Employee emp3 = new Employee(4, "Frank", "Frankfurt", 22, "worker", 25000);
            Employee emp4 = new Employee(5, "Gustav", "Luxemborg", 16, "idiot", 20000);

            Department d1 = new Department("Maintainence");
            Department d2 = new Department("Slavery");

            Entertainment e1 = new TorTureEntertainment(100, "watersport", 50.5, 5);
            Entertainment e2 = new Rides(30, "HelvedsTuren", 20, 3);
            Entertainment e3 = new Rides(50, "Ride of Death!", 30, 5);

            //WorksOn w1 = new WorksOn(300, d1, emp0);

            d1.AddEmployee(emp3, 50);
            d1.AddEmployee(emp4, 25);

            d2.AddEmployee(emp1, 150);
            d2.AddEmployee(emp2, 250);

            List<Employee> d1Emps = d1.GetEmployees();

            //Console.WriteLine("Project 1 is named " + d1.Name);

            foreach (Employee emp in d1Emps)
            {
                Console.WriteLine("\n Employee in department " + d1.Name + " are named {0} and is {1} years old \n and live in {2}. \n {0}'s position is {3} \n {0} makes {4} Kr a week", 
                    emp.Name, emp.Age, emp.City, emp.Position, emp.Salary);
            }

            d1.GiveBonus(1000);

            foreach (Employee emp in d1Emps)
            {
                Console.WriteLine("\nNew salary for " + emp.Name + " is : " + emp.Salary);
            }

            List<Employee> d2Emps = d2.GetEmployees();  
            foreach (Employee emps in d2Emps)

            {
                Console.WriteLine("\nProject 2 is named " + d2.Name);
                Console.WriteLine("Name " + emps + " City " + emps.City + " Payment " + emps.Salary);
            }



            Console.WriteLine("\n Name of Entertainment 1 is called " + e1.Name + "and has \n" + e1.NoOfPplWatching +" people watching currently");




            Console.ReadLine();
        }
    }
}
