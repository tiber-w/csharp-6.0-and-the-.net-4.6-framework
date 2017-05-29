using System;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");

            // Make a Point by setting each property manually.
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // Or make a Point via a custom constructor.
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // Or make a Point using object init syntax.
            // Here, the default constructor is called implicitly.
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();

            // Here, the default constructor is called explicitly.
            Point pt = new Point() { X = 30, Y = 30 };
            pt.DisplayStats();

            // Calling a custom constructor.
            Point pt2 = new Point(10, 16) { X = 100, Y = 100 };
            pt2.DisplayStats();

            // Calling a more interesting custom constructor with init syntax.
            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();

            // Create and initialize a Rectangle.
            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };
            myRect.DisplayStats();

            // Old-school approach.
            Rectangle r = new Rectangle();
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 10;
            r.TopLeft = p1;
            Point p2 = new Point();
            p2.X = 200;
            p2.Y = 200;
            r.BottomRight = p2;
            r.DisplayStats();

            Console.ReadLine();
        }
    }
}
