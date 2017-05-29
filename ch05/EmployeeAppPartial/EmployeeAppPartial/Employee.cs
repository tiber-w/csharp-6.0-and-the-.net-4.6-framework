using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
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
