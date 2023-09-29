using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Fourth
    {
        static void Main()
        {
            string size = Console.ReadLine();
            string length = Console.ReadLine();

            Console.WriteLine(CountSquare(double.Parse(size, CultureInfo.InvariantCulture), double.Parse(length, CultureInfo.InvariantCulture)));
        }
        public static double CountSquare(double size, double length)
        {
            double result = 0;
            if (length <= (size / 2))
            {
                result = Math.PI * Math.Pow(length, 2);
            }
            else if (length >= ((size * Math.Sqrt(2)) / 2))
            {
                result = size * size;
            }
            else
            {
                double alpha = 2 * Math.Acos(1 - ((length - (size / 2)) / length));
                double squareToDelete = 0.5 * Math.Pow(length, 2) * (alpha - Math.Sin(alpha));
                result = (Math.PI * Math.Pow(length, 2)) - 4 * squareToDelete;
            };
            return Math.Round(result, 3);
        }

    }
}
