using TesteTecnicoTargetErp.Exercicio;

internal class Program
{
    public static void Main(string[] args)
    {
        int opcao;

        do
        {
            // Menu de escolha
            Console.WriteLine("Escolha um exercício para executar:");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Exercicio1.Executar(); 
                    break;
                case 2:
                    Exercicio2.Executar();
                    break;
                case 3:
                    Exercicio3.Executar();
                    break;
                case 4:
                    Exercicio4.Executar();
                    break;
                case 5:
                    Exercicio5.Executar();

                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

        } while (opcao != 0);  
    }
}
