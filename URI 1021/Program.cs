using System;
using System.Globalization;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            decimal[] notas = { 100.00M, 50.00M, 20.00M, 10.00M, 5.00M, 2.00M };
            int[] qtdenotas = { 0, 0, 0, 0, 0, 0 };
            decimal[] moedas = { 1.00M, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M };
            int[] qtdemoedas = { 0, 0, 0, 0, 0, 0 };
            decimal entrada = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //notas
            if (entrada >= notas[0])
            {
                qtdenotas[0] = (int)Math.Floor(entrada / 100);
                entrada = entrada % 100;
            }

            if (entrada >= notas[1])
            {
                qtdenotas[1] = (int)Math.Floor(entrada / 50);
                entrada = entrada % 50;
            }

            if (entrada >= notas[2])
            {
                qtdenotas[2] = (int)Math.Floor(entrada / 20);
                entrada = entrada % 20;
            }

            if (entrada >= notas[3])
            {
                qtdenotas[3] = (int)Math.Floor(entrada / 10);
                entrada = entrada % 1;
            }

            if (entrada >= notas[4])
            {
                qtdenotas[4] = (int)Math.Floor(entrada / 5);
                entrada = entrada % 5;
            }

            if (entrada >= notas[5])
            {
                qtdenotas[5] = (int)Math.Floor(entrada / 2);
                entrada = entrada % 2;
            }

            if (entrada >= moedas[0])
            {
                qtdemoedas[0] = (int)Math.Floor(entrada / moedas[0]);
                entrada = entrada % moedas[0];
            }

            if (entrada >= moedas[1])
            {
                qtdemoedas[1] = (int)Math.Floor(entrada / moedas[1]);
                entrada = entrada % moedas[1];
            }

            if (entrada >= moedas[2])
            {
                qtdemoedas[2] = (int)Math.Floor(entrada / moedas[2]);
                entrada = entrada % moedas[2];
            }

            if (entrada >= moedas[3])
            {
                qtdemoedas[3] = (int)Math.Floor(entrada / moedas[3]);
                entrada = entrada % moedas[3];
            }

            if (entrada >= moedas[4])
            {
                qtdemoedas[4] = (int)Math.Floor(entrada / moedas[4]);
                entrada = entrada % moedas[4];
            }

            if (entrada >= moedas[5])
            {
                qtdemoedas[5] = (int)Math.Floor(entrada / moedas[5]);
                entrada = entrada % moedas[5];
            }
            Console.WriteLine("NOTAS:");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(qtdenotas[i] + " nota(s) de R$ " + notas[i].ToString("F2", CultureInfo.InvariantCulture));
            }
            //Console.WriteLine("NOTAS");
            //Console.WriteLine(qtdenotas[0] + " nota(s) de R$ 100.00");
            //Console.WriteLine(qtdenotas[0] + " nota(s) de R$ 50.00");
            //Console.WriteLine(qtdenotas[0] + " nota(s) de R$ 20.00");
            //Console.WriteLine(qtdenotas[0] + " nota(s) de R$ 10.00");
            //Console.WriteLine(qtdenotas[0] + " nota(s) de R$ 5.00");
            //Console.WriteLine(qtdenotas[0] + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(qtdemoedas[i] + " moeda(s) de R$ " + moedas[i].ToString("F2", CultureInfo.InvariantCulture));
            }
            //Console.WriteLine("MOEDAS");
            //Console.WriteLine(qtdemoedas[0] + " nota(s) de R$ 1.00");
            //Console.WriteLine(qtdemoedas[0] + " nota(s) de R$ 0.50");
            //Console.WriteLine(qtdemoedas[0] + " nota(s) de R$ 0.25");
            //Console.WriteLine(qtdemoedas[0] + " nota(s) de R$ 0.10");
            //Console.WriteLine(qtdemoedas[0] + " nota(s) de R$ 0.05");
            //Console.WriteLine(qtdemoedas[0] + " nota(s) de R$ 0.01");
        }
    }
}
