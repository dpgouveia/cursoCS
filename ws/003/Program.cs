using System;

namespace _003
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Declaracao de variaveis!");
            
            int tipoInteiro = 5;
            char tipoChar = 'D';
            float tipoFloat = 5.99f;
            byte tipoByte = 10;
            string tipoString = "String grande...";
            Console.WriteLine("tipoInteiro = " + tipoInteiro);
            Console.WriteLine("tipoChar = " + tipoChar);
            Console.WriteLine("tipoFloat = " + tipoFloat);
            Console.WriteLine("tipoByte = " + tipoByte);
            Console.WriteLine("tipoString = " + tipoString);

            var tipoVar = 10; // tipo var e definido pelo compilador durante a execucao
            Console.WriteLine("tipoVar = " + tipoVar);

            string string1, string2, string3;
            string1 = "string1";
            string2 = "string2";
            string3 = "string3";
            Console.WriteLine("Valor das variaveis string: " + string1 + " ... " + string2 + " ... " + string3);

            int num1=10, num2=2, res=0;
            num1 = 10;
            num2 = 2;
            res = num1 * num2;
            Console.WriteLine("A multiplicacao de " + num1 + " com " + num2 + " e igual a: " + res);
            Console.WriteLine("(Calculando na funcao): a multiplicacao de " + 10 + " com " + 2 + " e igual a: " + (10 * 2));



        }
    }
}
