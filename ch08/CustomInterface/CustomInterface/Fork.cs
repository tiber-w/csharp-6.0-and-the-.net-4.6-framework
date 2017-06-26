using System;

namespace CustomInterface
{
    public class Utensil
    {
    }

    // This class derives from a custom base class
    // and implements a single interface.
    class Fork : Utensil, IPointy
    {
        public byte Points
        {
            get
            {
                return 3;
            }
        }
    }
}
