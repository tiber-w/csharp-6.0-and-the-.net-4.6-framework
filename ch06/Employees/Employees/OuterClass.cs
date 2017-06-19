namespace Employees
{
    public class OuterClass
    {
        // A public nested tyep can be used by anybody.
        public class PublicInnerClass
        {
        }

        // A private nested type can only be used by members
        // of the containing class.
        private class PrivateInnerClass
        {
        }
    }
}
