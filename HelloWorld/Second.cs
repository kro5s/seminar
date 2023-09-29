using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Second
    {
        static void Main()
        {
            string timeInput = Console.ReadLine();
            Console.WriteLine(CountAngle(timeInput));
        }
        public static double CountAngle(string time)
        {
            string[] parsedTime = time.Split(':');
            double hours = double.Parse(parsedTime[0]);
            double minutes = double.Parse(parsedTime[1]);
            if (hours > 12) hours = hours - 12;
            else if (hours == 12) hours = 0;
            double partOfHour = minutes / 60;
            double angle = (minutes * 6) - (hours * 30) - (partOfHour * 30);
            angle = angle >= 0 ? angle : -angle;
            return angle > 180 ? 360 - angle : angle;
        }

    }
}
