using System;
using System.Globalization;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int qt = int.Parse(Console.ReadLine());
            while ((qt >= 1 && qt<= 15))
            {
            qt = int.Parse(Console.ReadLine());
            }

            int rato = 0;
            int sapo = 0;
            int coelho = 0; 
            for (int i = 0; i < qt; i++)
            {
                string[] cobaias = Console.ReadLine().Split(' ');
                string sigla = cobaias[1];
                int qtCobaia = int.Parse(cobaias[0]);
                if (sigla.Equals("C"))
                {
                    coelho += qtCobaia;
                }
                if (sigla.Equals("R"))
                {
                    rato += qtCobaia;
                }
                if (sigla.Equals("S"))
                {
                    sapo += qtCobaia;
                }
            }
            double totalCobaia = (coelho + rato + sapo) * 1.00;
            Console.WriteLine("Total: " + totalCobaia.ToString("F0") + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho.ToString("F0"));
            Console.WriteLine("Total de ratos: " + rato.ToString("F0"));
            Console.WriteLine("Total de sapos: " + sapo.ToString("F0"));
            double percCoelhos = (coelho / totalCobaia) * 100.00;
            double percRatos = (rato / totalCobaia) * 100.00;
            double percSapos = (sapo / totalCobaia) * 100.00;
            Console.WriteLine("Percentual de coelhos: " + percCoelhos.ToString("F2",CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percRatos.ToString("F2",CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percSapos.ToString("F2",CultureInfo.InvariantCulture) + " %");
        }
    }
}
        
    
