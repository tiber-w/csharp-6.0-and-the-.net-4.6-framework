using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);

            // Error! Can't change a constant!
            //MyMathClass.PI = 3.1444;

            LocalConstStringVariable();

            Console.WriteLine("The value of PI3 is: {0}", MyMathClass.PI3);

            Console.ReadLine();
        }

        static void LocalConstStringVariable()
        {
            // A local constant data point can be directly accessed.
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);

            // Error!
            //fixedStr = "This will not work!";
        }
    }
}
