using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TesteTecnicoTargetErp.Models;

namespace TesteTecnicoTargetErp.Exercicio
{
    internal class Exercicio3
    {
        public static void Executar()
        {
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data", "dados.json");
            if (File.Exists(caminhoArquivo))
            {
                string jsonString = File.ReadAllText(caminhoArquivo);

                Dado[] dados = JsonConvert.DeserializeObject<Dado[]>(jsonString);

                double menorValorEncontrado = dados[0].Valor;
                double maiorValorEncontrado = 0;
                var vendasPorDia = new List<double>();

                foreach (var dado in dados)
                {
                    if(dado.Valor < menorValorEncontrado)
                    {
                        menorValorEncontrado = dado.Valor;
                    }
                    if(dado.Valor > maiorValorEncontrado)
                    {
                        maiorValorEncontrado = dado.Valor;
                    }
                    vendasPorDia.Add(dado.Valor);
                }

                double media = ObtemMediaValor(vendasPorDia);

                Console.WriteLine($"Valor média: {media}");
                Console.WriteLine("Valores acima da média: ");
                foreach (var valor in vendasPorDia)
                {
                    if (valor > media)
                    {
                        Console.WriteLine(valor);
                    }
                }
                Console.WriteLine($"Menor valor: {menorValorEncontrado}");
                Console.WriteLine($"Maior valor: {maiorValorEncontrado}");

            }
            else
            {
                Console.WriteLine("O arquivo JSON não foi encontrado.");
            }

        } 

        public static double ObtemMediaValor(List<Double> doubles)
        {
            double soma = doubles.Sum();
            int quantidade = doubles.Count;
            double media = soma / quantidade;

            return media;
        }
    }
}
