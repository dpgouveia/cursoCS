using System;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores!");
            
            int resInt = 10 + 5;
            Console.WriteLine("Valor de res: " + resInt);
            Console.WriteLine("Valor da '(10 + 5) * 2': " + ((10 + 5) * 2));
            Console.WriteLine("Valor da '10 + 5 * 2': " + (10 + 5 * 2));
            
            bool resBool = 10 < 5;
            Console.WriteLine("Valor da resBool: " + resBool);
            Console.WriteLine("Valor da expressao '10 > 5': " + (10 > 5));
            Console.WriteLine("Valor da expressao '10 != 5': " + (10 != 5));
            Console.WriteLine("Valor da expressao '2 == 2': " + (2 == 2));

            int incrInt = 10;
            Console.WriteLine("incrInt: " + incrInt);
            incrInt = incrInt + 1;
            Console.WriteLine("incrInt: " + incrInt);
            incrInt += 1;
            Console.WriteLine("incrInt: " + incrInt);
            incrInt++;
            Console.WriteLine("incrInt: " + incrInt);
            incrInt = incrInt + 2;
            Console.WriteLine("incrInt: " + incrInt);
            incrInt += 2;
            Console.WriteLine("incrInt: " + incrInt);
            incrInt *= 2;
            Console.WriteLine("incrInt: " + incrInt);
            incrInt /= 2;
            Console.WriteLine("incrInt: " + incrInt);
            incrInt -= 2;
            Console.WriteLine("incrInt: " + incrInt);
            incrInt -= 2;
            Console.WriteLine("incrInt: " + incrInt);

            Console.WriteLine("Valor da expressao '(5 > 3)': " + ( (5 > 3) ));
            Console.WriteLine("Valor da expressao '(5 > 3) | (10 < 5)': " + ( (5 > 3) | (10 < 5) ));
            Console.WriteLine("Valor da expressao '(5 > 7) | (10 < 5)': " + ( (5 > 7) | (10 < 5) ));
            Console.WriteLine("Valor da expressao '(5 > 7) & (10 < 5)': " + ( (5 > 7) & (10 < 5) ));
            Console.WriteLine("Valor da expressao '(5 > 3) & (10 < 5)': " + ( (5 > 3) & (10 < 5) ));
            Console.WriteLine("Valor da expressao '(5 > 3) & (10 > 5)': " + ( (5 > 3) & (10 > 5) ));

        }
    }
}
