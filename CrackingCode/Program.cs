using System;


namespace CrackingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = ArraysAndStrings.IsPermutation("test", "tset");
            var a2 = ArraysAndStrings.IsPermutation("test","tstt");
            var a3 = ArraysAndStrings.IsPermutation("re","ree");

            Console.WriteLine($"{a1} {a2} {a3}");
        }
    }
}
