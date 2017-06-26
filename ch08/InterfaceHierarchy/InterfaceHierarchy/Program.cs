using System;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Interface Hierarchy *****");

            // Call from object level.
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            // Get IAdvanceDraw explicitly.
            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
            {
                iAdvDraw.DrawUpsideDown();
            }

            Console.ReadLine();
        }
    }
}
