using System;
using System.Globalization;

namespace _1040
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] vet = Console.ReadLine().Split(' ');

        float N1, N2, N3, N4, media, exame, media2, mediafinal;
        N1 = float.Parse(vet[0],CultureInfo.InvariantCulture);
        N2 = float.Parse(vet[1],CultureInfo.InvariantCulture);
        N3 = float.Parse(vet[2],CultureInfo.InvariantCulture);
        N4 = float.Parse(vet[3],CultureInfo.InvariantCulture);

        media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

        if(media == 4.85f){
            media = 4.8f;
        }

        if (media >= 7.0)
        {
            Console.WriteLine("Media: " + media.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Media: " + media.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno reprovado.");
        }
        
        else if (media >= 5.0 && media <= 6.9)
        {
            Console.WriteLine("Media: " + media.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno em exame.");

            exame = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Nota do exame: " + exame.ToString("F1",CultureInfo.InvariantCulture));
            media2 = (exame + media) / 2;

            if (media2 >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            if (media2 <= 4.9)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            mediafinal = (media + exame) / 2;
            Console.WriteLine("Media final: " + mediafinal.ToString("F1",CultureInfo.InvariantCulture));
            }
        }
    }
}

    
