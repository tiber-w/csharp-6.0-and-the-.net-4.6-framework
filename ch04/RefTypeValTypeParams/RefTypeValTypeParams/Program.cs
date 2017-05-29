﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passing ref-types by value.
            Console.WriteLine("***** Passing Person object by value *****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:");
            fred.Display();

            SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call, Person is:");
            fred.Display();

            Console.WriteLine("***** Passing Person object by reference *****");
            Person mel = new Person("Mel", 23);
            Console.WriteLine("\nBefore by ref call, Person is:");
            mel.Display();

            SendAPersonByReference(ref mel);
            Console.WriteLine("\nAfter by ref call, Person is:");
            mel.Display();

            Console.ReadLine();
        }

        static void SendAPersonByValue(Person p)
        {
            // Change the age of "p"?
            p.personAge = 99;

            // Will the caller see this reassignment?
            p = new Person("Nikki", 34);
        }

        static void SendAPersonByReference(ref Person p)
        {
            // Change some data of "p".
            p.personAge = 555;

            // "p" is now pointing to a new object on the heap!
            p = new Person("Nikki", 999);
        }
    }
}
