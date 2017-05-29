using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");

            // Add two shorts and print the result.
            short numb1 = 30000, numb2 = 30000;
            
            // Explicitly cast the int into a short (and allow loss of data).
            short answer = (short)Add(numb1, numb2);

            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            NarrowingAttempt();
            ProcessBytes();
            Console.ReadLine();
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;

            // Explicitly cast the int into a byte (and allow loss of data).
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        private static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;

            //// sum should hold the value 350. However, we find the value 94!
            //byte sum = (byte)Add(b1, b2);
            //Console.WriteLine("sum = {0}", sum);

            // This time, tell the compiler to add CIL code
            // to throw an exception if overflow/underflow
            // takes place.
            try
            {
                //byte sum = checked((byte)Add(b1, b2));
                //Console.WriteLine("sum = {0}", sum);
                checked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Assuming /checked is enabled,
            // this block will not trigger
            // a runtime exception.
            //unchecked
            //{
            //    byte sum = (byte)(b1 + b2);
            //    Console.WriteLine("sum = {0}", sum);
            //}

            Console.WriteLine();
        }
    }
}
