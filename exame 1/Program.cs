using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exame_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, media;

            Console.WriteLine("digite o nome do aluno");
            nome = Console.ReadLine();

            Console.WriteLine("digite a nota 1 do aluno");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota 2 do aluno");
            nota2 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;


            if (media >= 8.05)
            {
                Console.WriteLine("sua média é A");

            }

            if (media >= 7.0 && media <= 8.04)
            {
                Console.WriteLine("sua média é B");

            }

            if (media >= 6.0 && media <= 6.9)
            {
                Console.WriteLine("sua média é C");

            }
            if (media >= 1.0 && media <= 5.09)
            {
                Console.WriteLine("sua média é D");
            }
            if (media == 0.0)
            {
                Console.WriteLine("sua média é E");
            }

            Console.ReadKey();
        }
    
    }
}
