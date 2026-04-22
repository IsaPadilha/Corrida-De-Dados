namespace CorridaDeDados.ConsoleApp;

using CorridaDeDados.ConsoleApp.Entidades;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            jogador.posicao = 0;
            computador.posicao = 0;

            while (true)
            {
                jogador.ExecutarRodada();

                if (jogador.VenceuPartida())
                    break;

                computador.ExecutarRodada();

                if (computador.VenceuPartida())
                    break;
            }

            Console.WriteLine("-------------------------------");
            Console.Write("Deseja continuar? (s/n)");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}