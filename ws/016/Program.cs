using System;

namespace _016
{
    class Program
    {
        static void Main(string[] args)
        {

        INICIO:
            Console.Clear();
            Console.WriteLine("GO TO");

            Console.WriteLine("Viagem de Belo Horizonte (MG) a Vitória (ES)");
            Console.WriteLine("Meios de transporte disponveís: \n");
            Console.WriteLine("A = Avião");
            Console.WriteLine("C = Carro");
            Console.WriteLine("O = Onibus");

            int tempo;
            char escolha = informarMeioTransporte("Escolha o meio de transporte desejado (A/C/O): ");
            switch (escolha)
            {
                case 'A':
                    tempo = 60;
                    break;
                case 'C':
                    tempo = 480;
                    break;
                case 'O':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
            }

            if (tempo == -1)
            {
                Console.WriteLine("Transporte selecionado inexistente!");
            }
            else
            {
                Console.WriteLine("Transporte escolhido foi         : {0}", escolha);
                Console.WriteLine("Tempo para o transporte escolhido: {0} minutos", tempo);
            }

            char repetir = repetirExercicio("Realizar nova simulação? (Y/N): ");
            if (repetir == 'Y')
            {
                goto INICIO;
            }
            else
            {
                Console.WriteLine("\n**** Fim do programa ****");
            }

        }

        static char repetirExercicio(string displayText)
        {
            while (true)
            {
                Console.Write(displayText);
                string strValue = Console.ReadLine();
                if (strValue.Length == 1)
                {
                    char[] chStrValue;
                    chStrValue = strValue.ToCharArray();
                    char chValue = Char.ToUpper(chStrValue[0]);
                    if (chValue == 'Y' || chValue == 'N')
                    {
                        return chValue;
                    }
                }
            }
        }

        static char informarMeioTransporte(string displayText)
        {
            while (true)
            {
                Console.Write(displayText);
                string strValue = Console.ReadLine();
                if (strValue.Length == 1)
                {
                    char[] chStrValue;
                    chStrValue = strValue.ToCharArray();
                    char chValue = Char.ToUpper(chStrValue[0]);
                    if (chValue == 'A' || chValue == 'C' || chValue == 'O' || chValue == 'E') // valor E aceito somente para fins didáticos do comando SWITCH para poder mostrar uma modalidade de transporte inválida
                    {
                        return chValue;
                    }
                }
            }
        }

    }
}
