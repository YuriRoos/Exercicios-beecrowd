using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');

            int horainicial, horafinal, duracao;

            horainicial = int.Parse(vetor[0]);
            horafinal = int.Parse(vetor[1]);

            if(horainicial < horafinal){
                duracao = horafinal- horainicial;
            }else{
                duracao = 24 - horainicial + horafinal;
            }
            
            Console.WriteLine("O JOGO DUROU "+ duracao +" HORA(S)");
        }
    }
}
