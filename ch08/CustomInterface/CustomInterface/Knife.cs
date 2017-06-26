namespace CustomInterface
{
    class Knife : Utensil, IPointy
    {
        public byte Points
        {
            get
            {
                return 1;
            }
        }
    }
}
