using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();

            // Error! Cannot directly access private members
            // from an object!
            //emp.empName = "Marv";

            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            //// Use the get/set methods to interact with the object's name.
            //emp.SetName("Marv");
            //Console.WriteLine("Employee is named: {0}", emp.GetName());

            // Reset and then get the Name property.
            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.Name);

            // Longer than 15 characters! Error will print to console.
            Employee emp2 = new Employee();
            emp2.Name = "Xena the warrior princess";
            //emp2.SetName("Xena the warrior princess");

            Employee joe = new Employee();
            joe.Age++;

            Console.ReadLine();
        }
    }
}
