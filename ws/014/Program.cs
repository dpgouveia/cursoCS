using System;

namespace _014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comando IF-ANINHADO");

            Console.WriteLine("Exemplo de Aula 01");
            int nota = readNota("Digite a nota do aluno (0-100): ");
            string resultado;
            if (nota >= 60) // Aprovado
            {
                if(nota >= 90)
                {
                    if(nota >= 95)
                    {
                        resultado = "Aprovado com Super Louvor";
                    } else
                    {
                        resultado = "Aprovado com Louvor";
                    }
                } else
                {
                    resultado = "Aprovado";
                }
            }
            else // Não Aprovado
            {
                if(nota >= 40)
                {
                    resultado = "em Recuperacao";
                } else
                {
                    resultado = "Reprovado";
                }
            }
            Console.WriteLine("Nota {0} - Aluno {1}", nota, resultado);

        }

        static int readNota(string displayText)
        {
            while (true)
            {
                try
                {
                    Console.Write(displayText);
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
