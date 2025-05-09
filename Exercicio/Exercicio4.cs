using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnicoTargetErp.Exercicio
{
    internal class Exercicio4
    {
        public static void Executar()
        {
            var faturamentoPorEstado = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double total = ObtemTotal(faturamentoPorEstado);

            foreach (var item in faturamentoPorEstado)
            {
                double valorFaturado = item.Value;
                double percentual = (valorFaturado / total) * 100;
                Console.WriteLine($"Percentual para o estado {item.Key}: {percentual}%");
            }

        }

        public static double ObtemTotal(Dictionary<string, double> dict)
        {
            double total = 0;
            foreach (var estado in dict)
            {
                total += estado.Value;
            }

            return total;
        }
    }
}
