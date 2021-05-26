using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public class IterativeSolution
    {
        //Pre requisite : Array must be sorted
        //Return index of item if it is present in the array [0....l]
        //else return -1
        //Complexity O(log2n)
        public int BinarySearch(int[] data, int lowerBound, int upperBound, int item)
        {
            int begin = lowerBound;
            int end = upperBound;
            int mid = (begin + end) / 2;

            while(begin <= end && data[mid] != item)
            {
                //if item is greater, ignore left half
                if(item > data[mid])
                {
                    begin = mid + 1;
                }

                //if item is smaller, ignore right half
                else
                { 
                    end = mid - 1;
                }

                mid = (begin + end) / 2;
            }

            //Check item is present in the data[mid]
            if (data[mid] == item)
                return mid;
            else
                return -1; //Means not found
        }
    }
}
