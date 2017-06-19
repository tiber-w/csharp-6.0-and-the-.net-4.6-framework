namespace Employees
{
    sealed class PTSalesPerson : SalesPerson
    {
        #region Ctors

        public PTSalesPerson()
        {
        }

        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn, numbOfSales)
        {
        }

        #endregion

        // Compiler error! Can't override this method
        // in the PTSalesPerson class, as it was sealed.
        //public override void GiveBonus(float amount)
        //{
        //}
    }
}
