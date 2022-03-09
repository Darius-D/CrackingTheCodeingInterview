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
    }
}
