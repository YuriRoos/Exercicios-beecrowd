using System;
using System.Globalization;

namespace _1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, A, B, C;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a >= b && a >= c && b >= c)
            {
                A = a;
                B = b;
                C = c;
            }
            else if (a >= b && a >= c && c >= b)
            {
                A = a;
                B = c;
                C = b;
            }
            else if (b >= a && b >= c && a >= c)
            {
                A = b;
                B = a;
                C = c;
            }
            else if (b >= a && b >= c && c >= a)
            {
                A = b;
                B = c;
                C = a;
            }
            else if (c >= a && c >= b && a >= b)
            {
                A = c;
                B = a;
                C = b;
            }
            else
            {
                A = c;
                B = b;
                C = a;
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");

            }
            else if (A * A == B * B + C * C)
            {
                Console.WriteLine("TRIANGULO RETANGULO");

            }
            else if (A * A >= B * B + C * C)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (A * A <= B * B + C * C)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || B == C || C == A)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");

            }
        }
    }
}
        
