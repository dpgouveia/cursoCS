using System;

namespace _017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vetores (Arrays)!");

            /// Criando arrays
            Console.WriteLine("\n\n\n**** Exemplo 01");
            int[] arrayInt = new int[5]; // Indices para acessar o array (0-4)
            Console.WriteLine("Novo array do tipo int. Quantidade de posicoes: {0}", arrayInt.Length);

            // Atribuindo valores
            arrayInt[0] = 111;
            arrayInt[1] = 222;
            arrayInt[2] = 333;
            arrayInt[3] = 444;
            arrayInt[4] = 555;
            Console.WriteLine("Valores inseridos no array: ");
            for(int i=0; i < arrayInt.Length; i++)
            {
                Console.Write(" {0} ", arrayInt[i]);
            }

            Console.WriteLine("\n\n\n**** Exemplo 02");
            // int[] arrayInt2 = new int[4]{55, 77, 99}; // errado, pois espera a iniciailzacao de 4 valores
            int[] arrayInt2 = new int[]{55, 77, 99};
            Console.WriteLine("Novo array do tipo int. Quantidade de posicoes: {0}", arrayInt2.Length);
            for (int i = 0; i < arrayInt2.Length; i++)
            {
                Console.Write(" {0} ", arrayInt2[i]);
            }

            Console.WriteLine("\n\n\n**** Exemplo 03");
            int[] arrayInt3 = {-11, -22, -55, -99}; // outra forma de criar arrays inicializados
            Console.WriteLine("Novo array do tipo int. Quantidade de posicoes: {0}", arrayInt3.Length);
            foreach(int num in arrayInt3) // outra forma de imprimir (mais easy)
            {
                Console.Write(" {0} ", num);
            }

            Console.WriteLine("\n\n\n**** Exemplo 04");
            string[] veiculos = { "Aviao", "Navio" };
            Console.WriteLine("Novo array do tipo string. Quantidade de posicoes: {0}", veiculos.Length);
            foreach (string veiculo in veiculos) // outra forma de imprimir (mais easy)
            {
                Console.Write(" {0} ", veiculo);
            }

            Console.WriteLine("\n\n\n**** FIM DO PROGRAMA ****");


        }
    }
}
