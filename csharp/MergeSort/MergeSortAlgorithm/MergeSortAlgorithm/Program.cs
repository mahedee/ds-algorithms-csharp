using System;

namespace MergeSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] inputList = { 9, 7, 8, 3, 2, 1};
            Algorithm.MergeSort(inputList, 0, inputList.Length-1);

            foreach (var item in inputList)
            {
                Console.Write(item + "  ");
            }
            Console.ReadKey();
        }
    }
}
