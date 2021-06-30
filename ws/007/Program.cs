using System;

namespace _007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constantes!");
            const string canal = "CFB Cursos";
            const double pi = 3.1415;

            Console.WriteLine("Valor da variavel stringVar: {0}", canal);
            Console.WriteLine("Valor da variavel pi: {0}", pi);

            // canal = "Outro canal"; // nao rola mudar conteudo de constantes


        }
    }
}
