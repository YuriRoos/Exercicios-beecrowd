using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutot=0,horat=0;

            string[] linha = Console.ReadLine().Split(' ');
            int hora = int.Parse(linha[0]);
            int minuto = int.Parse(linha[1]);
            int hora2 = int.Parse(linha[2]);
            int minuto2 = int.Parse(linha[3]);

            if (hora == hora2 && minuto == minuto2)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                horat = hora2 - hora;
                minutot = minuto2 - minuto;
            }
                if (horat < 0)
                {
                    horat += 24;
                }
                if (minutot < 0)
                {
                    minutot += 60;
                    horat=horat-1;
                }
                Console.WriteLine("O JOGO DUROU {} HORA(S) E {} MINUTO(S)",horat,minutot);
        }
    }
}
