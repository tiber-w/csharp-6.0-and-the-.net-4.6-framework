﻿using System;

namespace CustomInterface
{
    // Hexagon now implements IPointy.
    class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon()
        {
        }

        public Hexagon(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        // IPointy implementation.
        public byte Points
        {
            get { return 6; }
        }

        // IDraw3D implementation.
        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexagon in 3D!");
        }
    }
}
