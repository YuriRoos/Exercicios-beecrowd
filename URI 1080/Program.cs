using System;

namespace _1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior;
            int posicao = 1;
            int entrada=int.Parse(Console.ReadLine());
            maior=entrada;

            for(int X = 2;X <= 100;X++){
                entrada=int.Parse(Console.ReadLine());

                if(entrada > maior){
                    maior = entrada;
                    posicao = X;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);        
        }
    }
}


