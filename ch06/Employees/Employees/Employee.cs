using System;

namespace Employees
{
    partial class Employee
    {
        #region Properties

        public string Name
        {
            get
            {
                return empName;
            }
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

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }

        // Expose object through a custom property.
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        #endregion

        #region Methods

        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }

        // Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }

        #endregion

        #region Traditional Get / Set method

        // Accessor (get method)
        public string GetName()
        {
            return empName;
        }

        // Mutator (set method)
        public void SetName(string name)
        {
            // Do a check on incoming value
            // before making assignment.
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name must be less than 15 characters!");
            }
            else
            {
                empName = name;
            }
        }

        #endregion
    }
}
