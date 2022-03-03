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
    }
}
