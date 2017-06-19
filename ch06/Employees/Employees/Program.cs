using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");

            // Create a subclass object and access base class functionality.
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            double cost = chucky.GetBenefitCost();

            // Create and use the public inner class. OK!
            OuterClass.PublicInnerClass inner;
            inner = new OuterClass.PublicInnerClass();

            // Compiler Error! Cannot access the private class.
            //OuterClass.PrivateInnerClass inner2;
            //inner2 = new OuterClass.PrivateInnerClass();

            // Define my benefit level.
            Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            Console.WriteLine("BenefitPackageLevel: {0}", myBenefitLevel);
            Console.WriteLine();

            // Give each employee a bonus?
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.WriteLine();

            // Error! Cannot create an instance of an abstract class!
            //Employee X = new Employee();

            CastingExamples();

            Console.ReadLine();
        }

        static void CastingExamples()
        {
            // A Manager "is-a" System.Object, so we can
            // store a Manager reference in an object variable just fine.
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            // Error!
            //GivePromotion(frank);
            // OK!
            GivePromotion((Manager)frank);

            // Ack! You can't cast frank to a Hexagon, but this compiles fine!
            //Hexagon hex = (Hexagon)frank;

            // Catach a possible invalid cast.
            Hexagon hex;
            try
            {
                hex = (Hexagon)frank;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Use "as" to test compatability.
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";

            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if (h == null)
                {
                    Console.WriteLine("Item is not a hexagon");
                }
                else
                {
                    h.Draw();
                }
            }

            // A Manager "is-a" Employee too.
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            // A PTSalesPerson "is-a" SalesPerson.
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);
        }

        static void GivePromotion(Employee emp)
        {
            // Increase pay...
            // Give new parking space in company garage...

            Console.WriteLine("{0} was promoted!", emp.Name);

            if (emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sales(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }

            if (emp is Manager)
            {
                Console.WriteLine("{0} has {1} stock options...", emp.Name, ((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }
    }
}
