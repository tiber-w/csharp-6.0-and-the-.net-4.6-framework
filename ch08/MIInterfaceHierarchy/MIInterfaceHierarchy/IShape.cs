namespace MIInterfaceHierarchy
{
    // Multiple interface inheritance. OK!
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
