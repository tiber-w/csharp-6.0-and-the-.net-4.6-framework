using System;

namespace CloneablePoint
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point()
        {
        }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public Point(int xPos, int yPos, string petName)
        {
            X = xPos;
            Y = yPos;
            desc.PetName = petName;
        }

        // Override Object.ToString().
        public override string ToString()
        {
            return String.Format("X = {0}; Y = {1}; Name = {2};\nID={3}\n", X, Y, desc.PetName, desc.PointID);
        }

        // Return a copy of the current object.
        public object Clone()
        {
            //return new Point(this.X, this.Y);

            // Copy each field of the Point member by member.
            //return this.MemberwiseClone();

            // First get a shallow copy.
            Point newPoint = (Point)this.MemberwiseClone();

            // Then fill in the gaps.
            PointDescription currentDesc = new CloneablePoint.PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
