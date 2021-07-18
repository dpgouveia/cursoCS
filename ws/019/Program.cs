using System;

namespace _019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loop FOR");

            /*
             * e1 - expressao para inicializar o loop
             * e2 - expressao para avaliar a continuidade da repeticao
             * e3 - expressao a serem executadas apos a repeticao
            for(e1;e2;e3)
            {
                comando1;
                comando2;
                .....;
            }
            */

            Console.WriteLine("\n\n\n**** Exemplo 01");
            for(int num = 1; num <= 10; num++)
            {
                Console.WriteLine("CFB Cursos");
            }

            Console.WriteLine("\n\n\n**** Exemplo 02");
            for (int num = 1; num <= 10; num++)
            {
                Console.WriteLine("{0,2} - CFB Cursos", num);
            }

            Console.WriteLine("\n\n\n**** Exemplo 03");
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++) // inseguro acessar o vetor desta forma
            {
                vetor[i] = 0;
                // Console.WriteLine("vetor[{0}]: {1}", i, vetor[i]);
            }
            for (int i = 0; i < 10; i++) // inseguro acessar o vetor desta forma
            {
                Console.WriteLine("vetor[{0}]: {1}", i, vetor[i]);
            }

            Console.WriteLine("\n\n\n**** Exemplo 04");
            int[] vetor2 = new int[6];
            for (int i = 0; i < vetor2.Length; i++)
            {
                vetor2[i] = 0;
                Console.WriteLine("vetor[{0}]: {1}", i, vetor2[i]);
            }



            Console.WriteLine("\n\n\n**** FIM DO PROGRAMA");
        }
    }
}
