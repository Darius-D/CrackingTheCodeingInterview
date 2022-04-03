using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCode
{
   public static class Problems
    {

        //Given the hour and min on a clock return the given angle of the two hands 

        // clock is 360 degrees
        // 12 hours on a clock = 360 /12 = 30 deg per = hour .5 deg every min
        //60 min on a clock = 360/60 = 6 deg / min
        //hour hand moves 

        //This is my simple solution that writes two values to the console.
        //I can also have this method return a truple if I wanted a return value. 
        public static void ClockAngle(int hour, int min)
        {
            var hourAngle = (hour * 30) + (.5 * min);
            var minAngle = min * 6;

            var angleOne = hourAngle - minAngle;
            var angleTwo = minAngle - hourAngle;

            var SolutionAngle1 = hourAngle > minAngle ?  hourAngle - minAngle : minAngle - hourAngle;
            var SolutionAngle2 = 360 - SolutionAngle1;

            var innerAngle = SolutionAngle1 <= SolutionAngle2 ? SolutionAngle1 : SolutionAngle2;
            var outerAngle = SolutionAngle2 < SolutionAngle1 ? SolutionAngle1 : SolutionAngle2;

            Console.WriteLine($"innerAngle:{innerAngle}");
            Console.WriteLine($"outterAngle:{outerAngle}");
        }

        //Giving a string with repeating values, compress the string if the compressed value is shorter than the input. 
        // IE: Input: aaabbcddaab output: a3b2cd2a2b

        //For this problem I want to use a stack to track the previous value.

        //Edge cases: input == null; input and compression are same length; number in string?

        //Tests: aaabbbccc = a3b3c3

        public static string compressString(string input)
        {
            StringBuilder output = new();

            int counter = 0;

            for(int i = 0, j = 0; j < input.Length; j++)
            {
                if(input[i] == input[j])
                {
                    counter++;
                }
                else
                {
                    
                    output.Append(input[i]);
                    if(counter > 1)
                    {
                        output.Append(counter);
                    }
                    counter = 0;
                    i = j;
                    j--;
                }
                if(j == input.Length -1)
                {
                    output.Append(input[i]);
                    output.Append(counter);
                }
            }
            return output.ToString();
        }
        //Reverse Fibonacci series when the first two numbers are provided. Example" 80, 50,30.20,10,10,0
    }
}
