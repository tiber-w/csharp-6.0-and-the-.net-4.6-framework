namespace CustomInterface
{
    // The abstract base class of the hierarchy.
    abstract class Shape
    {
        public Shape(string name = "NoName")
        {
            PetName = name;
        }

        public string PetName { get; set; }

        // A single virtual method.
        //public virtual void Draw()
        //{
        //    Console.WriteLine("Inside Shape.Draw()");
        //}

        // Force all child classes to define how to be rendered.
        public abstract void Draw();
    }
}
