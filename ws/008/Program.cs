using System;

namespace _008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lendo valores do teclado!");

            /*
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Nome digitado: {0}", nome);*/

            /*
            int valor1, valor2, soma;
            Console.Write("Digite o valor 1: ");
            valor1 = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o valor 2: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            soma = valor1 + valor2;
            Console.WriteLine("{0} + {1} = {2}", valor1, valor2, soma);
            */

            /* Improved ReadLine function (for integer numeric input)  */
            int valor1, valor2, soma;
            Console.Write("Digite um valor inteiro para a variavel valor 1: ");
            valor1 = readInt();
            Console.Write("Digite um valor inteiro para a variavel valor 2: ");
            valor2 = readInt();
            soma = valor1 + valor2;
            Console.WriteLine("{0} + {1} = {2}", valor1, valor2, soma);
        }

        static int readInt()
        {
            bool repeat = true;
            int number = 0;

            while (repeat)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    repeat = false;
                }
                catch (System.FormatException) { }
            }

            return number;
        }

    }
}