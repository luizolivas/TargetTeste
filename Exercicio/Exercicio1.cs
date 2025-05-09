using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnicoTargetErp.Exercicio
{
    public class Exercicio1
    {
        public static void Executar()
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while(k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }
            Console.WriteLine($"Valor soma: {soma}");
            Console.ReadLine();
        }
    }
}
