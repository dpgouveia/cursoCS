using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CFB Cursos!");
            if(args.GetLength(0) > 0) { 
                Console.WriteLine("args[0] = " + args.GetValue(0));
            } else { 
                Console.WriteLine("Sem parametros");
            }
        }
    }
}
