using System;
using static System.Console;
using static System.DateTime;

namespace SimpleUtilityClass
{
    // Static classes can only contain static members!
    static class TimeUtilClass
    {
        public static void PrintTime()
        {
            WriteLine(Now.ToShortTimeString());
        }

        public static void PrintDate()
        {
            WriteLine(Today.ToShortDateString());
        }
    }
}
