using System;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formatacoes de Saida!");

            int n1, n2, n3;
            n1 = 10;
            n2 = 20;
            n3 = 30;
            Console.WriteLine("Valores das variaveis: " + n1 + ", "+ n2 + ", "+ n3);
            Console.WriteLine("n1={0}, n2={1}, n3={2}", n1, n2, n3);
            Console.WriteLine("(Usando indices): valores das variaveis: {0}, {1}, {2}", n1, n2, n3);
            Console.WriteLine("n1={0}, \nn2={1}, \nn3={2}", n1, n2, n3);
            Console.WriteLine("\tn1={0}, \tn2={1}, \tn3={2}", n1, n2, n3);

            double valorCompra = 5.50;
            double lucro = 0.1;
            double valorVenda = valorCompra * (1 + lucro);
            string produto = "Pastel";
            Console.WriteLine("Produto...........:{0,15}", produto);
            Console.WriteLine("Valor de Compra...:{0,15:c}", valorCompra);
            Console.WriteLine("Lucro.............:{0,15:p}", lucro);
            Console.WriteLine("Valor de Venda....:{0,15:c}", valorVenda);
        }
    }
}

