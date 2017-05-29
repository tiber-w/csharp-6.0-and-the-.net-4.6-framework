using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        // New members to represent the name of the driver.
        //public string name;
        public void SetDriverName(string name)
        {
            //this.name = name;
            driverName = name;
        }

        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }

        // Put back the default constructor, which will
        // set all data members to default values.
        //public Motorcycle()
        //{
        //    Console.WriteLine("In default ctor");
        //}

        //public Motorcycle(int intensity)
        //    : this(intensity, String.Empty)
        //{
        //    Console.WriteLine("In ctor taking an int");
        //}

        //public Motorcycle(string name)
        //    : this(0, name)
        //{
        //    Console.WriteLine("In ctor taking an string");
        //}

        //// This is the 'master' constructor that does all ther real work.
        //public Motorcycle(int intensity, string name)
        //{
        //    Console.WriteLine("In master ctor ");
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    driverName = name;
        //}

        // Single constructor using optional args.
        public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }
}
