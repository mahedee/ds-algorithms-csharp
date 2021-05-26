using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public class RecursiveSolution
    {
        //Pre requisite : Array must be sorted
        //Return index of item if it is present in the array [0....l]
        //else return -1
        //Complexity O(log2n)
        public int BinarySearch(int[] data, int lowerBound, int upperBound, int item)
        {
            
            if (lowerBound > upperBound) return -1; //location not found

            int mid = (lowerBound + upperBound) / 2;

            if (data[mid] == item) return mid;

            //if item is greater, ignore left half
            if (data[mid] < item)
            {
                lowerBound = mid + 1;
            }

            //if item is smaller, ignore right half
            else
            {
                upperBound = mid - 1;
            }

            //Call the method recursively
            return BinarySearch(data, lowerBound, upperBound, item);
        }
    }
}
