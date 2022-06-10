using System;
using System.Globalization;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y,media;

            X = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (X/Y);

            Console.WriteLine(media.ToString("F3",CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
