using System.Collections;

namespace CustomEnumeratorWithYield
{
    // Garage contains a set of Car objects.
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        // Fill with some Car objects upon startup.
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        //public IEnumerator GetEnumerator()
        IEnumerator IEnumerable.GetEnumerator()
        {
            //foreach (Car c in carArray)
            //{
            //    yield return c;
            //}
            yield return carArray[0];
            yield return carArray[1];
            yield return carArray[2];
            yield return carArray[3];
        }

        public IEnumerable GetTheCars(bool ReturnRevesed)
        {
            if (ReturnRevesed) // Return the items in reverse.
            {
                for (int i = carArray.Length; i != 0; i--)
                {
                    yield return carArray[i - 1];
                }
            }
            else // Return the items as placed in the array.
            {
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
        }
    }
}
