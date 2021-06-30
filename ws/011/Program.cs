using System;

namespace _011 { 
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Typecast!");

            int i1 = 10;
            float f1 = i1;
            Console.WriteLine("Valor de i1: {0}", i1);
            Console.WriteLine("Valor de f1: {0}", f1);

            int i2 = (int) (f1 + 2.567); // typecast
            Console.WriteLine("Valor de i2: {0}", i2);

            long l1 = i2;
            short s1 = (short) i2; // typecast
            Console.WriteLine("Valor de l1: {0}", l1);
            Console.WriteLine("Valor de s1: {0}", s1);

        }
    }
}
