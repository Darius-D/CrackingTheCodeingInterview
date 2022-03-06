using System;


namespace CrackingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 7,2,5,1,8,3 };
            Sorting.MergeSort(test);
            Sorting.Print(test);
        }
    }
}
