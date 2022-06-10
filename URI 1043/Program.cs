using System;
using System.Globalization;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            double A = Convert.ToDouble(nums[0],CultureInfo.InvariantCulture);
            double B = Convert.ToDouble(nums[1],CultureInfo.InvariantCulture);
            double C = Convert.ToDouble(nums[2],CultureInfo.InvariantCulture);

            if (A<B+ C&&B<C +A&&C<A +B)
            {
            Double perimetro = A + B + C;
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1"),CultureInfo.InvariantCulture);
            }
            else
            {
            Double area = ((A + B) * C)/2;
            Console.WriteLine("Area = " + area.ToString("F1"),CultureInfo.InvariantCulture);
            }
        }
    }
}

