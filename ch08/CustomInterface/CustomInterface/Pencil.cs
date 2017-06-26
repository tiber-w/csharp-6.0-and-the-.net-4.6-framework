using System;

namespace CustomInterface
{
    // This class derives from System.Object and
    // implements a single interface.
    public class Pencil : IPointy
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
