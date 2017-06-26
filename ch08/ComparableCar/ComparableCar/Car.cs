using System;
using System.Collections;

namespace ComparableCar
{
    // The iteration of the Car can be ordered
    // based on the CarID.
    class Car : IComparable
    {
        // Constant for maximum speed.
        public const int MaxSpeed = 100;

        // Car properties.
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = String.Empty;
        public int CarID { get; set; }
        public static IComparer SortByPetName
        {
            get
            {
                return (IComparer)new PetNameComparer();
            }
        }

        // Is the car still operational?
        private bool carIsDead;

        // A car has-a radio.
        private Radio theMusicBox = new Radio();

        // Constructors.
        public Car()
        {
        }

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public Car(string name, int currSp, int id)
        {
            CurrentSpeed = currSp;
            PetName = name;
            CarID = id;
        }

        public void CrankTunes(bool state)
        {
            // Delegate request to inner object.
            theMusicBox.TurnOn(state);
        }

        // See if Car has overheated.
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    //Console.WriteLine("{0} has overheated!", PetName);
                    carIsDead = true;
                    CurrentSpeed = 0;

                    // Use the "throw" keyword to raise an exception.
                    //throw new Exception(String.Format("{0} has overheated!", PetName));

                    // We need to call the HelpLink property, thus we need to
                    // create a local variable before throwing the Exception object.
                    Exception ex = new Exception(String.Format("{0} has overheated!", PetName));
                    ex.HelpLink = "http://www.CarsRUs.com";

                    // Stuff in custom data regarding the error.
                    ex.Data.Add("TimeStamp", String.Format("The car exploded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "You have a lead foot.");
                    throw ex;
                }
                else
                {
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }

        // IComparable implementation.
        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
            {
                if (this.CarID > temp.CarID)
                {
                    return 1;
                }
                else if (this.CarID < temp.CarID)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
                //return this.CarID.CompareTo(temp.CarID);
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
        }
    }
}
