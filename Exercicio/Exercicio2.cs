using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnicoTargetErp.Exercicio
{
    public class Exercicio2
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            bool isFibonacci = false;

            while (a < numero)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            if (a == numero)
            {
                isFibonacci = true;
            }

            if ( isFibonacci )
            {
                Console.WriteLine($"Número {numero} está na sequência de Fibonacci");
            }
            else
            {
                Console.WriteLine($"Número {numero} NÃO está na sequência de Fibonacci");

            }
        }
    }
}
