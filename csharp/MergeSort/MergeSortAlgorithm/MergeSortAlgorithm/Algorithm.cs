using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSortAlgorithm
{
    public class Algorithm
    {
        // Merges two subarrays of arr[]. 
        // First subarray is arr[l..m] 
        // Second subarray is arr[m+1..r] 
        // Here l is left, m is middle, r is right
        private static void Merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two subarrays to be merged 
            int n1 = m - l + 1;
            int n2 = r - m;

            /* Create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /*Copy data to temp arrays*/
            for (int a = 0; a < n1; ++a)
                L[a] = arr[l + a];

            for (int b = 0; b < n2; ++b)
                R[b] = arr[m + 1 + b];


            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays 
            int i = 0, j = 0;

            // Initial index of merged subarry array 
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }


        // Main function that sorts arr[l..r] using 
        // merge() 
        public static void MergeSort(int[] array, int start, int end)
        {
            if(start < end)
            {
                // divide the current array in 2 parts
                int mid = (start + end) / 2;

                // sort the 1st part of array .
                MergeSort(array, start, mid);

                // sort the 2nd part of array .
                MergeSort(array, mid + 1, end);

                // merge the both parts by comparing elements of both the parts.
                Merge(array, start, mid, end);
            }
        }

      
    }
}
