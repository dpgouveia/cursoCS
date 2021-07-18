using System;

namespace _018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrizes!");

            Console.WriteLine("\n\n\n**** Exemplo 01");
            int[,] matrizInt = new int[3,5];
            matrizInt[0,0] = 10; matrizInt[0,1] = 20; matrizInt[0,2] = 30; matrizInt[0,3] = 40; matrizInt[0,4] = 50;
            matrizInt[1,0] = 60; matrizInt[1,1] = 70; matrizInt[1,2] = 80; matrizInt[1,3] = 90; matrizInt[1,4] = 100;
            matrizInt[2,0] = 25; matrizInt[2,1] = 35; matrizInt[2,2] = 45; matrizInt[2,3] = 55; matrizInt[2,4] = 65;
            Console.WriteLine("Imprimindo alguns valores da matriz no console: {0}, {1}", matrizInt[1,3], matrizInt[2,1]);

            Console.WriteLine("Nova matriz do tipo int. Quantidade de posicoes na matriz: {0}", matrizInt.Length);
            Console.Write("Imprimindo matriz no console: ");
            foreach (int num in matrizInt)
            {
                Console.Write(" {0} ", num);
            }

            Console.WriteLine("\n\n\n**** Exemplo 02");
            int[,] matrizInt2 = new int[2, 2] { {10,20}, {30,40} };
            Console.WriteLine("Nova matriz do tipo int. Quantidade de posicoes na matriz: {0}", matrizInt2.Length);
            Console.Write("Imprimindo matriz no console: ");
            foreach (int num in matrizInt2)
            {
                Console.Write(" {0} ", num);
            }

            Console.WriteLine("\n\n\n**** Exemplo 03");
            int[,] matrizInt3 = { {111,222,333 }, {777,888,999} };
            Console.WriteLine("Nova matriz do tipo int. Quantidade de posicoes na matriz: {0}", matrizInt3.Length);
            Console.Write("Imprimindo matriz no console: ");
            foreach (int num in matrizInt3)
            {
                Console.Write(" {0} ", num);
            }

            Console.WriteLine("\n\n\n**** FIM DO PROGRAMA");
        }
    }
}
