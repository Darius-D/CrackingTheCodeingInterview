using System;


namespace CrackingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = ArraysAndStrings.StringCompression("abcd");
            var a2 = ArraysAndStrings.StringCompression("aabbccdd");
            var a3 = ArraysAndStrings.StringCompression("aaabbbcccddd");
            var a4 = ArraysAndStrings.StringCompression("aaabbbcccddd");
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
        }
    }
}
