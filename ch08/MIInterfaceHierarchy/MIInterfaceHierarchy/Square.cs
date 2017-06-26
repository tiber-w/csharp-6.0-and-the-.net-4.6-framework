using System;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
        // Using explicit implementation to handle member name clash.
        void IPrintable.Draw()
        {
            Console.WriteLine("Draw to printer...");
        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Draw to screen...");
        }

        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Print()
        {
            Console.WriteLine("Print...");
        }
    }
}
