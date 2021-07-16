using System;

namespace _012 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Comando IF");

			Console.WriteLine("Exemplo de Aula 01");
			Console.Write("Digite a nota do aluno (0-100): ");
			int nota = readNota();
			string resultado = "Reprovado";
			if(nota >= 60) {
				resultado = "Aprovado";
			}
			Console.WriteLine("Nota {0} - Aluno {1}", nota, resultado);

			Console.WriteLine("Exemplo de Aula 02");
			int res, n1, n2, n3, n4;
			res = n2 = n3 = n4 = 0; 

			Console.Write("Digite a nota 1 (0-25): ");
			n1 = readNota2();

			Console.Write("Digite a nota 2 (0-25): ");
			n2 = readNota2();

			Console.Write("Digite a nota 3 (0-25): ");
			n3 = readNota2();

			Console.Write("Digite a nota 4 (0-25): ");
			n4 = readNota2();

			res = n1 + n2 + n3 + n4;
			resultado = "Reprovado";
			if (res >= 60) {
				resultado = "Aprovado";
			}
			Console.WriteLine("Nota {0} - Aluno {1}", res, resultado);
		}

		static int readNota() {
			while(true) {
				try {
					int intValue = 0;
					string strValue = Console.ReadLine();
					intValue = int.Parse(strValue);

					bool vldNum = true;
					char[] strChValue = strValue.ToCharArray();
					foreach(char ch in strChValue) {
						if(char.IsLetter(ch)) {
							vldNum = false;
						}
					}
					
					if (vldNum && intValue >= 0 && intValue <= 100) {
						return intValue;
					}                       
				} catch (FormatException) { }
			}
		}

		static int readNota2() {
			while (true) {
				try {
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

					if (vldNum && intValue >= 0 && intValue <= 25)
					{
						return intValue;
					}
				}
				catch (FormatException) { }
			}
		}

	}
}
