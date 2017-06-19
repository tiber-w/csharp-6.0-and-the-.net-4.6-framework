using System;

namespace Employees
{
    abstract partial class Employee
    {
        #region Nested class

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard,
                Gold,
                Platinum
            }

            // Assume we have other members that represent
            // dental/health benefits, and so on.
            public double ComputePayDeduction()
            {
                return 1.0;
            }
        }

        #endregion

        #region Field data

        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN = String.Empty;

        // Contain a BenefitPackage object.
        protected BenefitPackage empBenefits = new BenefitPackage();

        #endregion

        #region Constructors

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
            // Better! Use properties when setting class data.
            // This reduces the amount of duplicate error checks.
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            empSSN = ssn;
        }

        #endregion
    }
}
