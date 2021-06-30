using System;

namespace _010 {
    class Program {

        enum DiasSemana { Dom, Seg, Ter, Qua, Qui, Sex, Sab };

        static void Main(string[] args) {
            Console.WriteLine("Enumeradores!");

            DiasSemana ds = DiasSemana.Dom;
            DiasSemana ds2 = (DiasSemana) 3; // Qua
            Console.WriteLine("Valor de ds       : {0}", ds);
            Console.WriteLine("Valor de ds2      : {0}", ds2);
            Console.WriteLine("Valor de (int) ds2: {0}", (int) ds2);

        }
        
    }
}
