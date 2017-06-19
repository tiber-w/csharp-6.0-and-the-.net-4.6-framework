using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                // Trip Arg out of range exception.
                myCar.Accelerate(-10);
            }
            //catch (Exception e)
            //{
            //    // Process all other exceptions?
            //    Console.WriteLine(e.Message);
            //}
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // This will catch any other exception
            // beyond CarIsDeadException or
            // ArgumentOutOfRangeException
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // A generic catch
            myCar = new Car("Rusty", 90);
            try
            {
                myCar.Accelerate(90);
            }
            catch
            {
                Console.WriteLine("Something bad happened...");
            }

            // Passing the buck
            //myCar = new Car("Rusty", 90);
            //try
            //{
            //    myCar.Accelerate(90);
            //}
            //catch (CarIsDeadException e)
            //{
            //    // Do any partial processing of this error and pass the buck.
            //    throw;
            //}

            // Inner exception
            //myCar = new Car("Rusty", 90);
            //try
            //{
            //    myCar.Accelerate(90);
            //}
            //catch (CarIsDeadException e)
            //{
            //    try
            //    {
            //        FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
            //    }
            //    catch (Exception e2)
            //    {
            //        // Throw an exception that records the new exception,
            //        // as well as the message of the first exception.
            //        throw new CarIsDeadException(e.Message, e2);
            //    }
            //}

            myCar = new Car("Rusty", 90);
            myCar.CrankTunes(true);
            try
            {
                myCar.Accelerate(90);
            }
            catch (CarIsDeadException e)
            when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                // This new line will only print if the when clause evaluates to true.
                Console.WriteLine("Catching car is dead!");

                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // This will always occur. Exception or not.
                myCar.CrankTunes(false);
            }

            myCar = new Car("Rusty", 90);
            myCar.Accelerate(2000);

            Console.ReadLine();
        }
    }
}
