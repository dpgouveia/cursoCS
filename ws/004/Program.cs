using System;

namespace _004
{
    class Program
    {
        static int num = 64;

        static void Main(string[] args)
        {
            Console.WriteLine("Escopo de variaveis!");
            int num = 256;
            Console.WriteLine("Valor de num no metodo Main(): " + num);
            Program.teste();
            Console.WriteLine("Valor de num na class Program: " + Program.num);
        }

        static void teste() {
            int num = 128;
            Console.WriteLine("Valor de num em metodo teste(): " + num);
        }

    }
}
