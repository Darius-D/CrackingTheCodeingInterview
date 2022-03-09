using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCode
{
    public static class  Sorting <T>
    {
        public static void BubbleSort(int[] arr, int length)
        {
            //this uses recursion. In one calling of the methdod it will move the largest value to the very end of the array
            // the array length will then be reduced by 1 because the last value of the array is already sorted. 

            //this is best case and is also what will end the recursion. 
            if (length == 1) return;
            
            for(var i = 0; i < length -1; i++)
            {
                if(arr[i] > arr[i+1])
                {
                    var temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }

            BubbleSort(arr, length - 1);
            
        }

        public static void MergeSort(int[] arr)
        {
            if (arr.Length < 2) return;

            int arrLength = arr.Length;
            int middleIndex = arr.Length / 2;
            // Makes two new arrays. 
            var left = new int[middleIndex];
            var right = new int[arrLength - middleIndex];
            //Fills the new arrays into the left and right arrays
            for(var i = 0; i < middleIndex; i++)
            {
                left[i] = arr[i];
            }
            for(var i = middleIndex; i < arrLength; i++)
            {
                right[i - middleIndex] = arr[i];
            }
            //will break down the left and right arrays into halves again until they are a length of 1.
            MergeSort(left);
            MergeSort(right);

            Merge(arr, left, right);

        }

        private static void Merge(int[] orgArray, int[]leftArray, int[]rightArray)
        {
            var leftLength = leftArray.Length;
            var rightLength = rightArray.Length;

            int l = 0, r = 0, k = 0;

            while(l < leftLength && r < rightLength)
            {
                if(leftArray[l] <= rightArray[r])
                {
                    orgArray[k] = leftArray[l];
                    l++;
                }
                else
                {
                    orgArray[k] = rightArray[r];
                    r++;
                }
                k++;
            }
            while(l < leftLength)
            {
                orgArray[k] = leftArray[l];
                l++;
                k++;
            }
            while (r < rightLength)
            {
                orgArray[k] = rightArray[r];
                r++;
                k++;
            }
        }
        public static void Print(int[] arr)
        {
            foreach(var i in arr)
            {
                Console.Write(i + ",");
            }
        }

        public static void SortStack(Stack<T> stack)
        {
           
        }
    }
}
