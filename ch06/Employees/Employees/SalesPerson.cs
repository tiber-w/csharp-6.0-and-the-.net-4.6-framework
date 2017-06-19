namespace Employees
{
    // Salespeople need to know their number of sales.
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        #region Ctors

        public SalesPerson()
        {
        }

        // As a gneral rule, all subclasses should explicitly call an appropriate
        // base class constructor.
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn)
        {
            // This belongs with us!
            SalesNumber = numbOfSales;
        }

        #endregion

        // A salesperson's bonus is influenced by the number of sales.
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if ((SalesNumber >= 0) && (SalesNumber <= 100))
            {
                salesBonus = 10;
            }
            else if ((SalesNumber >= 101) && (SalesNumber <= 200))
            {
                salesBonus = 15;
            }
            else
            {
                salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            System.Console.WriteLine("Number of Sales: {0}", SalesNumber);
        }
    }
}
