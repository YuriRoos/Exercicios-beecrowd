using System;
using System.Globalization;

namespace _1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' '); 

            double a = double.Parse(vetor[0],CultureInfo.InvariantCulture);
            double b = double.Parse(vetor[1],CultureInfo.InvariantCulture);
            double c = double.Parse(vetor[2],CultureInfo.InvariantCulture);


            if ((b * b - 4 * a * c) >= 0 && (2 * a) != 0)
            {
            
            double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            Console.WriteLine("R1 = " + x1.ToString("F5",CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + x2.ToString("F5",CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("Impossivel calcular");
            }
            }
        }
    }

        
    

