using System;

namespace CustomInterface
{
    // This class alse derives from System.Object
    // and implements a single interface.
    public class SwitchBlade : object, IPointy
    {
        public byte Points
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
