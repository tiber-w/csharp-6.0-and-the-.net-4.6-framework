using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");

            // All of these invocations call the
            // same Draw() method!
            Octagon oct = new Octagon();

            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            IDrawToMemory itfMemory = (IDrawToMemory)oct;
            itfMemory.Draw();

            IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
            itfPrinter.Draw();

            // Must use casting to access the Draw() when explicitly implemented.
            IDrawToForm itfForm2 = (IDrawToForm)oct;
            itfForm2.Draw();

            // Shorthand notation if you don't need
            // the interface variable for later use.
            ((IDrawToMemory)oct).Draw();

            // Could also use the "is" keyword.
            if (oct is IDrawToPrinter)
            {
                ((IDrawToPrinter)oct).Draw();
            }

            Console.ReadLine();
        }
    }
}
