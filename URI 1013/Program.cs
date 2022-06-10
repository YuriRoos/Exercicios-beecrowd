using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int maiorAB, maior;

            string[] vetor = Console.ReadLine().Split(' ');
            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);
            int c = int.Parse(vetor[2]);

            maiorAB = (a + b + Math.Abs (a - b)) / 2;

            maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
