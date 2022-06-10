using System;
using System.Globalization;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R,VOLUME, pi = 3.14159;

            R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            VOLUME = (4.0 / 3) * pi * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + VOLUME.ToString("F3"),CultureInfo.InvariantCulture);

        }
    }
}
