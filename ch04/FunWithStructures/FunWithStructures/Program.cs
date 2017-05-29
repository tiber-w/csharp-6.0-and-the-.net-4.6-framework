using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");

            // Create an initial Point.
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            // Adjust the X and Y values.
            myPoint.Increment();
            myPoint.Display();

            //// Error! Did not assign Y value.
            //Point p1;
            //p1.X = 10;
            //p1.Display();

            // OK! Both fields assigned before use.
            Point p2;
            p2.X = 10;
            p2.Y = 10;
            p2.Display();

            // Set all fields to default values
            // using the default constructor.
            Point p3 = new Point();

            // Prints X=0, Y=0.
            p3.Display();

            // Call custom constructor.
            Point p4 = new Point(50, 60);

            // Prints X=50, Y=60.
            p4.Display();

            Console.ReadLine();
        }
    }
}
