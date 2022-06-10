using System;
using System.Globalization;

namespace _1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++){
                string[]  vetor = Console.ReadLine().Split(' ');

                double A = double.Parse(vetor[0],CultureInfo.InvariantCulture);
                double B = double.Parse(vetor[1],CultureInfo.InvariantCulture);
                double C = double.Parse(vetor[2],CultureInfo.InvariantCulture);

                double media = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));

            }
        }
    }
}
