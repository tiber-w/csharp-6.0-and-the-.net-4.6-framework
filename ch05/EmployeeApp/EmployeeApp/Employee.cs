using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
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

        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        // We could add additional business rules to the sets of these properties;
        // however, there is no need to do so fro this example.
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        // New field and property.
        private int empAge;
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        private string empSSN;
        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }

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

        // Methods.
        public void GiveBonus(float amount)
        {
            //currPay += amount;
            Pay += amount;
        }

        public void DisplayStats()
        {
            //Console.WriteLine("Name: {0}", empName);
            //Console.WriteLine("Age: {0}", empAge);
            //Console.WriteLine("ID: {0}", empID);
            //Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
        }
    }
}
