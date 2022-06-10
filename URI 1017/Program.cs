using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());
            double litros = (tempo * velocidade) / 12.0;

            Console.WriteLine(litros.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
