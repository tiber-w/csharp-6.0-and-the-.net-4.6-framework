using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    // A custom enumeration.
    //enum EmpType
    //{
    //    Manager,        // = 0
    //    Grunt,          // = 1
    //    Contractor,     // = 2
    //    VicePresident   // = 3
    //}
    //enum EmpType
    //{
    //    Manager = 102,  // Begin with 102
    //    Grunt,          // = 103
    //    Contractor,     // = 104
    //    VicePresident   // = 105
    //}
    //enum EmpType
    //{
    //    Manager = 10,
    //    Grunt = 1,
    //    Contractor = 100,
    //    VicePresident = 9
    //}
    // This time, EmpType maps to an underlying byte.
    enum EmpType : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }
    // Compile-time error! 999 is too big for a byte!
    //enum EmpType : byte
    //{
    //    Manager = 10,
    //    Grunt = 1,
    //    Contractor = 100,
    //    VicePresident = 999
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Enums *****");

            // Make an EmpType variable.
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);

            // Print storage for the enum.
            //Console.WriteLine("EmpType uses a {0} for storage",
            //    Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine("EmpType uses a {0} for storage",
                Enum.GetUnderlyingType(typeof(EmpType)));

            // Prints out "emp is a Contractor".
            Console.WriteLine("emp is a {0}", emp.ToString());

            // Prints out "Contractor = 100".
            Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);

            // These types are enums in the System namespace.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;

            EvaluateEnum(emp);
            EvaluateEnum(day);
            EvaluateEnum(cc);

            Console.ReadLine();
        }

        private static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough case...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }

        //private static void ThisMethodWillNotCompile()
        //{
        //    // Error! SalesManager is not in the EmpType enum!
        //    EmpType emp = EmpType.SalesManager;

        //    // Error! Forgot to scope Grunt value to EmpType enum!
        //    emp = Grunt;
        //}

        // This method will print out the details of any enum.
        private static void EvaluateEnum(Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",
                Enum.GetUnderlyingType(e.GetType()));

            // Get all name/value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);

            // Now show the string name and associated value, using the D format
            // flag.
            for (int i=0;i<enumData.Length;i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}
