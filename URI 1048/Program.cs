using System;
using System.Globalization;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double percentual;
            double salario;

            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if(salario <= 400.00){
                percentual = 15.00;
            }else if(salario <=800.00){
                percentual = 12.00;
            }else if(salario <= 1200.00){
                percentual = 10.00;
            }else if(salario <= 2000.00){
                percentual = 7.00;
            }else{
                percentual = 4.00;
            }

            double reajuste = salario * percentual / 100.0;
            double novosalario = salario + reajuste;
            
            Console.WriteLine("Novo salario: " + novosalario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual  + " %");

        }
    }
}
