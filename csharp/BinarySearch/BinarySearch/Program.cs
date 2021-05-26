using System;

namespace BinarySearch
{
    class Program
    {

        //Driver method to test
        static void Main(string[] args)
        {
            int[] data = { 2, 3, 4, 10, 40 };
            int lowerBound = 0;
            int upperBound = data.Length - 1;
            int item = 10;
            int index = new RecursiveSolution().BinarySearch(data, lowerBound, upperBound, item);
            if (index < 0)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element found at index: " + index);

            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
