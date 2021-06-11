using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
              int largura = 0;
            int altura = 0;
            Console.WriteLine("----------------------");
            Console.WriteLine("--Retangulo Contorno--");
            Console.WriteLine("----------------------\n");
            do
            {
                Console.Write("Digte a altura...: ");
                altura = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digte a largura...: ");
                largura = Convert.ToInt32(Console.ReadLine());

                if (largura > 10 || altura > 10)
                {
                    Console.WriteLine("\nDigite numeros de 0 a 10");
                }
            } while (largura > 10 || altura > 10);

            for (int i = 1; i <= largura; i++)
            {
                for (int c = 1; c <= altura; c++)
                {
                    if (i == largura || c == 1 || c == altura || i == 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
