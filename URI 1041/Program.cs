using System;

namespace _1041
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] entrada = Console.ReadLine().Split(' ');
        double x = double.Parse(entrada[0]);
        double y = double.Parse(entrada[1]);

        if (x == 0.0 && y ==0.0)
        {
            Console.WriteLine("Origem");
        }
        else if (x == 0.0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (y == 0.0)
        {
            Console.WriteLine("Eixo X");
        }
        if (x>0.0 && y>0.0)
        {
            Console.WriteLine("Q1");
        }
        if (x<0.0 && y > 0.0)
        {
            Console.WriteLine("Q2");
        }
        if (x< 0 && y < 0)
        {
            Console.WriteLine("Q3");
        }
        if (x > 0 && y < 0)
        {
            Console.WriteLine("Q4");
        }
        }
    }    
}
        


