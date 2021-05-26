// C# program for implementation  
// of Bubble Sort 

using System;

namespace BubbleSort
{
    class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            
            // Number of pass
            // n-1 because, start from 0, zeror indexed

            for (int i = 0; i < n-1; i++) 
            {

                // For swaping
                // For each pass last element is the big bubble means biggest
                // So, no need to consider that element for the next iteration
                // Because that element or elements already sorted.

                for(int j = 0; j < n-i-1; j++)
                {
                    int temp;
                    if(arr[j] > arr[j +1 ])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        // Prints the array
        public static void Print(int[] arra)
        {
            for (int i = 0; i < arra.Length - 1; i++)
                Console.Write(arra[i] + "  ");
        }

        // Driver method for test
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort(arr);

            Console.WriteLine("Print the sorted array");
            Print(arr);

            Console.ReadKey();
        }
    }
}
