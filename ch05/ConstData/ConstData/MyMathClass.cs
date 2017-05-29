namespace ConstData
{
    class MyMathClass
    {
        public const double PI = 3.14;

        // Readonly fields can be assigned in ctors,
        // but nowhere else.
        public readonly double PI2;

        public static readonly double PI3 = 3.14;

        public static readonly double PI4;

        static MyMathClass()
        {
            PI4 = 3.14;
        }

        public MyMathClass()
        {
            // Not possible, must assign at time of declaration.
            //PI = 3.1415;

            PI2 = 3.14;
        }

        //// Error!
        //public void ChangePI2()
        //{
        //    PI2 = 3.14444;
        //}
    }
}
