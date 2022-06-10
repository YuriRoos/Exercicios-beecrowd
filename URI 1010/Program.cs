using System;
using System.Globalization;
namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vetor[0]);
            int qtd1 = int.Parse(vetor[1]);
            double prec1 = double.Parse(vetor[2],CultureInfo.InvariantCulture);

            vetor = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vetor[0]);
            int qtd2 = int.Parse(vetor[1]);
            double prec2 = double.Parse(vetor[2],CultureInfo.InvariantCulture);

            double total = ( qtd1 * prec1 ) + ( qtd2 * prec2);

            Console.WriteLine("VALOR A PAGAR: R$ "+ total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
