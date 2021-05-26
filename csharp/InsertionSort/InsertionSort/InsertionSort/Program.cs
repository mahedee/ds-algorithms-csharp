// C# program for implementation of Insertion Sort 
// Time complexity : O(n^2)

using System;

namespace InsertionSort
{
    class Program
    {
        // Method to sort array using insertion sort 
        public static void InsertionSort(int[] arr)
        {
            
            int n = arr.Length;

            // Started from second element
            // Array is zeor indexed so last element is n-1
            for(int i = 1; i < n; i++)
            {
                int key = arr[i];

                // Will be consider, left elements accept key
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key, 
                // to one position ahead of their current position 
            
                // if last element of left side elements of array is less than key
                // then no need to swap. Because key is in appropriate position
                // Check left elements of key from right to left

                while (j >= 0 && arr[j] > key)
                {
                    // Move arr[j] to arr[j + 1]
                    // arr[j + 1] is in key. So no way to replace
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Key placed in its position.
                arr[j + 1] = key;
            }
        }

        // Prints the array
        public static void Print(int[] arra)
        {
            for (int i = 0; i < arra.Length; i++)
                Console.Write(arra[i] + "  ");
        }


        // Driver method for test
        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6 };
            InsertionSort(arr);

            Console.WriteLine("Print the sorted array. Algorithm applied : Insertion Sort");
            Print(arr);

            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
