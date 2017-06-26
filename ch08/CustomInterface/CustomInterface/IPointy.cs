namespace CustomInterface
{
    // This interface defines the behavior of "having points"
    public interface IPointy
    {
        // Implicitly public and abstract.
        //byte GetNumberOfPoints();

        // Error! Interfaces cannot have data fields!
        //public int numbOfPoints;

        // Error! Interfaces do not have constructors!
        //public IPointy()
        //{
        //    numbOfPoints = 0;
        //}

        // Error! Interfaces don't provide an implementation of members!
        //byte GetNumberOfPoints()
        //{
        //    return numbOfPoints;
        //}

        // A read-write property in an interface would look like:
        // retType PropName { get; set; }
        //
        // while a write-only property in an interface would be:
        // retType PropName { set; }
        byte Points { get; }
    }
}
