using System;

namespace CustomInterface
{
    // This struct implicitly derives from System.ValueType and
    // implements two interfaces.
    public struct PitchFork : ICloneable, IPointy
    {
        public byte Points
        {
            get
            {
                return 8;
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
