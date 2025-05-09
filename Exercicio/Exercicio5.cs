using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnicoTargetErp.Exercicio
{
    internal class Exercicio5
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o texto que será invertido: ");
            string entrada = Console.ReadLine();

            while (string.IsNullOrEmpty(entrada))
            {
                Console.WriteLine("Digite o texto que será invertido: ");
                entrada = Console.ReadLine();

                if (string.IsNullOrEmpty(entrada))
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            }

            char[] stringDividida = SeparaString(entrada);
            string stringInvertida = InverteString(stringDividida);
            Console.WriteLine(stringInvertida);
            Console.ReadLine();
            
            
        }

        public static char[] SeparaString(string input)
        {
            List<char> letras = new List<char>();

            foreach (char letra in input)
            {
                letras.Add(letra);
            }

            return letras.ToArray();
        }

        public static string InverteString(char[] input)
        {
            string resultado = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                resultado += input[i]; 
            }

            return resultado;
        }
    }
}
