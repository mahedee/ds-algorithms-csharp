// Time Complexity: Time complexity of heapify is O(Logn). 
// Time complexity of createAndBuildHeap() is O(n) 
// and overall time complexity of Heap Sort is O(nLogn).

using System;

namespace HeapSortNS
{
    public class HeapSort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            // We will run the heapify function up to index 2 (0...2)
            // (0...2) it is actually the just before the last level of the tree
            // Actually a binary tree can have n/2 number of parent 
            // We actually heapify up to C
            /*            
             *             A
             *           /   \
             *          B      C
             *      ------------------
             *        /  \    /  \
             *       D    E  F    G
             */         

            // After the following iteration the top value will be in root, i,e A
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // One by one extract an element from heap
            // The idea hear is every time we call Heapify.
            // It put the largest value to the root 
            // Then we replace arr[i] = root and root = arr[i]
            // Every time Heapify bubble the largest value among n - i,
            // i,e among 0..5, then 0...4, then 0...3... etc]

            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end 
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap 
                Heapify(arr, i, 0);
            }
        } 


        // To heapify a subtree rooted with node i which is 
        // an index in arr[]. n is size of heap 
        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;    // Initialize largest as root
            int l = i * 2 + 1;  // left node of i is i * 2 + 1
            int r = i * 2 + 2;  // right node of i is  i * 2 + 1

            // If left child is larger than root
            // Then largest is l for this node
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than root 
            // Then largest is r for this node
            if (r < n && arr[r] > arr[largest])
                largest = r;

            //If largest is not root
            if(largest != i)
            {
                // Swap largest value with root
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree 
                Heapify(arr, n, largest);
            }

        }

        public void Print(int[] arr)
        {
            int length = arr.Length;
            for(int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
        }
    }


    class Program
    {

        //Driver method for testing

        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };

            HeapSort heapSort = new HeapSort();
            heapSort.Sort(arr);
            heapSort.Print(arr);

            Console.ReadKey();
        }
    }
}
