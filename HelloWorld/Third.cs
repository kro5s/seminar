using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Third
    {
        public static void Main()
        {
            int height, time, velocity, extremalSpeed;

            height = Int32.Parse(Console.ReadLine());
            time = Int32.Parse(Console.ReadLine());
            velocity = Int32.Parse(Console.ReadLine());
            extremalSpeed = Int32.Parse(Console.ReadLine());

            double maxTime = time;

            double minTime = (height - (extremalSpeed) * time) / (double)(velocity - extremalSpeed);

            Console.WriteLine($"{minTime} {maxTime}");
        }
    }
}
