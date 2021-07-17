using System;

namespace _013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comando IF-ELSE");

            Console.WriteLine("Exemplo de Aula 01");
            Console.Write("Digite a nota do aluno (0-100): ");
            int nota = readNota();
            string resultado;
            if (nota >= 60)
            {
                resultado = "Aprovado";
            } else if (nota >= 40)
            {
                resultado = "em Recuperacao";
            } else
            {
                resultado = "Reprovado";
            }
            Console.WriteLine("Nota {0} - Aluno {1}", nota, resultado);

        }

        static int readNota()
        {
            while (true)
            {
                try
                {
                    int intValue = 0;
                    string strValue = Console.ReadLine();
                    intValue = int.Parse(strValue);

                    bool vldNum = true;
                    char[] strChValue = strValue.ToCharArray();
                    foreach (char ch in strChValue)
                    {
                        if (char.IsLetter(ch))
                        {
                            vldNum = false;
                        }
                    }

                    if (vldNum && intValue >= 0 && intValue <= 100)
                    {
                        return intValue;
                    }
                }
                catch (FormatException) { }
            }
        }

    }
}
