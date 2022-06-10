using System;

namespace _1113
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel
            string[] vetor;
            int X,Y;

            //entrada
            vetor = Console.ReadLine().Split(' ');
            X = int.Parse(vetor[0]);
            Y = int.Parse(vetor[1]);          
            //enquanto x for diferente de y
            while(X!=Y){
            //se x é menor que y
                if(X < Y){
                    //saida
                    Console.WriteLine("Crescente");
                }else{
                    //saida
                    Console.WriteLine("Decrescente");
                }
                //ler valores novamentes
                vetor = Console.ReadLine().Split(' ');
                X = int.Parse(vetor[0]);
                Y = int.Parse(vetor[1]);
                
            }
        }
    }
}
