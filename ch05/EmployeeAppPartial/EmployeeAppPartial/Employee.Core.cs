using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;

        //// Accessor (get method).
        //public string GetName()
        //{
        //    return empName;
        //}

        //// Mutator (set method).
        //public void SetName(string name)
        //{
        //    // Do a check on incoming value
        //    // before making assignment.
        //    if (name.Length > 15)
        //    {
        //        Console.WriteLine("Error! Name length exceeds 15 characters!");
        //    }
        //    else
        //    {
        //        empName = name;
        //    }
        //}

        // Constructors.
        public Employee()
        {
        }

        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay)
        {
        }

        public Employee(string name, int age, int id, float pay)
            : this(name, age, id, pay, "")
        {
        }

        public Employee(string name, int age, int id, float pay, string ssn)
        {
            //if (name.Length > 15)
            //{
            //    Console.WriteLine("Error! Name length exceeds 15 characters!");
            //}
            //else
            //{
            //    empName = name;
            //}

            //empAge = age;
            //empID = id;
            //currPay = pay;

            // Better! Use properties when setting class data.
            // This reduces the amount of duplicate error checks.
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            empSSN = ssn;
        }
    }
}
