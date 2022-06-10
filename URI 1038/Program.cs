using System;
using System.Globalization;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int codigo, quantidade;
            double total;

            codigo = int.Parse(vetor[0]);
            quantidade = int.Parse(vetor[1]);

            if(codigo == 1){
                total = quantidade * 4.0;
            }else if(codigo == 2){
                total = quantidade * 4.5;
            }else if(codigo == 3){
                total = quantidade * 5.0;
            }else if(codigo == 4){
                total = quantidade * 2.0;
            }else{
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));

            
        }
    }
}
