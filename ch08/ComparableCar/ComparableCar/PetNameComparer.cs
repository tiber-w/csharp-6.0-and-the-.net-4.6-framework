using System;
using System.Collections;

namespace ComparableCar
{
    // This helper class is used to sort an array of Cars by pet name.
    public class PetNameComparer : IComparer
    {
        // Test the pet name of each object.
        int IComparer.Compare(object x, object y)
        {
            Car c1 = x as Car;
            Car c2 = y as Car;
            if ((c1 != null) && (c2 != null))
            {
                return String.Compare(c1.PetName, c2.PetName);
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
        }
    }
}
