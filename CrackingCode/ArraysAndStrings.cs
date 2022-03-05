using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCode
{
    class ArraysAndStrings
    {
        public static bool IsUnique(string value)
        {
            /*Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures? pg.90*/

            var ascii = new bool[128];

            for(var i = 0; i < value.Length; i++)
            {
                int asciiValue = value[i];
                if (ascii[asciiValue]) return false;
                ascii[asciiValue] = true;
            }
            return true;

            //This solution has the time complexity of O(n) if the number of characters being checked is unknown, ie unicode. For Ascii, since the
            // max number of unique characters is 128 the time complexity would be O(1). This soultion takes the ascii value of the character
            //and checks the corresponding value. IE 'a' would be 97 so array[97] by default would be false. The first time a value is
            //spotted it would chage that bool value to true. The second time around it will return true which will meet the condition statement and 
            //return false as the answer to the string not being unique. 
        }
        public static bool IsPermutation(string value1, string value2)
        {
            //Given two strings, write a method to decide if one is a premutation of the other.
            if (value1.Length != value2.Length) return false;

            var charArr1 = new int[128];
            var charArr2 = new int[128];

            for (var i = 0; i < value1.Length; i++)
            {
                var charVal1 = value1[i];
                var charVal2 = value2[i];
                charArr1[charVal1]++;
                charArr2[charVal2]++;
            }

            for(var i = 0; i < charArr1.Length; i++)
            {
                if (charArr1[i] != charArr2[i]) return false;
            }

            return true;

            //My solution has the time complexity of O(n). This is because the two values must be the same length (n) in order for the 
            // method to check if they are permutations. This solution used two arrays to set the character count for the encountered value +1 every time
            // the character is seen. The second loop will then go through the arrays and compare them. if they are the same then the values are
            //premutation, else they are not. 
        }
        public static string Urlify(string value)
        {
            var input = value.Trim();
            var output = new StringBuilder();
            foreach(var c in input)
            {
                if (c.ToString() == " ")
                {
                    output.Append("%20");
                }
                else output.Append(c);
            }
            return output.ToString();
        }
        public static bool OneAway(string x, string y)
        {
            //There are three types of edits that can be done to strings, insert, remove, replace.
            //Given two strings, write a function to check if they are one edit(or zero edits) away.
            //IE: pale,ple -> true
            //pales, pale -> true
            //pale, bale -> true
            //pale, bake -> false
            if (x == y) return true;
            if ((x.Length - y.Length) > 1 || (x.Length - y.Length) < -1) return false;

            var maxLength = x.Length > y.Length ? x.Length :  y.Length;
            var counter = 0;
            var c1 = new int[128];
            for(var i = 0; i < maxLength; i++)
            {
                if(i < x.Length) c1[x[i]] += 1;
                if (i < y.Length) c1[y[i]] -=1;
            }
            foreach(var n in c1)
            {
                if(n != 0)
                {
                    counter++;
                }
            }
            if(counter > 2)
            {
                return false;
            }
            return true;
        }
        public static string StringCompression(string value)
        {
            //aaabbccd = a3b2c2d1 this will only happen if compressing the string returns a shorter string than the original. 

            var compressedValues = new Dictionary<char, int>();
            if (string.IsNullOrEmpty(value)) return value;

            for (int i = 0; i < value.Length; i++)
            {
                if(!compressedValues.ContainsKey(value[i]))
                {
                    compressedValues.Add(value[i], 1);
                }
                else
                {
                    compressedValues[value[i]]++;
                }
            }
            //O(n+m)
            var output = new StringBuilder();
            foreach (var t in compressedValues)
            {
                output.Append(t.Key.ToString());
                output.Append(t.Value.ToString());
            }

            if (output.Length > value.Length) return value;
            return output.ToString();
        }
    }
}
