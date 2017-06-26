using System;

namespace CustomInterface
{
    class PointyTestClass : IPointy
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
