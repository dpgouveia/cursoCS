using System;

namespace _009 { 
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Operadores de Bitwise ou shift (deslocamento)!");

            /* tabela binária de números */
            /*
             * 00 - 000000
             * 01 - 000001
             * 02 - 000010
             * 03 - 000011
             * 04 - 000100
             * 05 - 000101
             * 06 - 000110
             * 07 - 000111
             * 08 - 001000
             * 09 - 001001
             * 10 - 001010
             * 11 - 001011
             * 12 - 001100
             * 13 - 001101
             * 14 - 001110
             * 15 - 001111
             * 16 - 010000
             * 17 - 010001
             * 18 - 010010
             * 19 - 010011
             * 20 - 010100
             * 21 - 010101
             * 22 - 010110
             * 23 - 010111
             * 24 - 011000
             * 25 - 011001
             * 26 - 011010
             * 27 - 011011
             * 28 - 011100
             * 29 - 011101
             */

            int num = 10;
            Console.WriteLine("\nValor de num   : {0}", num);
            Console.WriteLine("Deslocamento binario a esquerda num<<1: {0}", (num<<1) );
            Console.WriteLine("Deslocamento binario a esquerda num<<2: {0}", (num<<2) );

            Console.WriteLine("\nValor de num   : {0}", num);
            Console.WriteLine("Deslocamento binario a direita num>>1: {0}", (num>>1) );
            Console.WriteLine("Deslocamento binario a direita  num>>2: {0}", (num>>2) );
        }
    }
}
