using System.Security.Cryptography;

const int penalidadeRecuo = 2;
const int bonusAvancoExtra = 3;
const int chegada = 30;

while (true)
{
    int jogadorPosicao = 0;
    int computadorPosicao = 0;

    while (true)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("Corrida de Dados");
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("Vez do Jogador");
        Console.WriteLine("--------------------------------------------------------------------------------------------");

        Console.Write("Pressione ENTER para rolar o dado.");
        Console.ReadLine();

        int jogadorResultado = RandomNumberGenerator.GetInt32(1, 7);
        jogadorPosicao += jogadorResultado;   // soma o resultado à posição do jogador

        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine($"O número sorteado é: {jogadorResultado}");
        Console.WriteLine($"Você tirou: {jogadorResultado}");
        Console.WriteLine($"Você está na posição: {jogadorPosicao} de {chegada}!");
        Console.WriteLine("--------------------------------------------------------------------------------------------");

        // jogador
        if (jogadorPosicao == 5 || jogadorPosicao == 10 || jogadorPosicao == 15 || jogadorPosicao == 25)
        {
            Console.WriteLine($"\nEvento: Avanço de {bonusAvancoExtra} casas!");
            jogadorPosicao += bonusAvancoExtra; // avança mais 3 casas
            Console.WriteLine($"\nVocê está na posição: {jogadorPosicao} de {chegada}!");
        }
        else if (jogadorPosicao == 7 || jogadorPosicao == 13 || jogadorPosicao == 20)
        {
            Console.WriteLine($"\nEvento: Recuo de {penalidadeRecuo} casas!");
            jogadorPosicao -= penalidadeRecuo; // recua 2 casas
            Console.WriteLine($"Você está na posição: {jogadorPosicao} de {chegada}!");
        }

        // jogador ganhou
        if (jogadorPosicao >= chegada)
        {
            Console.WriteLine("Parabéns, você ganhou! :)");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.Write("Pressione ENTER para continuar.");
            Console.ReadLine();
            break;
        }

        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("Pressione ENTER para continuar.");
        Console.ReadLine();

        // computador
        Console.Clear();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("Corrida de Dados");
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("Vez do Computador");

        int computadorResultado = RandomNumberGenerator.GetInt32(1, 7);
        computadorPosicao += computadorResultado;

        Thread.Sleep(1000); // pausa de 1 segundo para simular suspense

        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine($"O número sorteado é: {computadorResultado}");
        Console.WriteLine($"O computador está na posição: {computadorPosicao} de {chegada}!");
        Console.WriteLine("--------------------------------------------------------------------------------------------");

        // computador
        if (computadorPosicao == 5 || computadorPosicao == 10 || computadorPosicao == 15 || computadorPosicao == 25)
        {
            Console.WriteLine($"\nEvento: Avanço de {bonusAvancoExtra} casas!");
            computadorPosicao += bonusAvancoExtra;
            Console.WriteLine($"O computador está na posição: {computadorPosicao} de {chegada}!");
        }
        else if (computadorPosicao == 7 || computadorPosicao == 13 || computadorPosicao == 20)
        {
            Console.WriteLine($"\nEvento: Recuo de {penalidadeRecuo} casas!");
            computadorPosicao -= penalidadeRecuo;
            Console.WriteLine($"\nO computador está na posição: {computadorPosicao} de {chegada}!");
        }

        // computador ganhou
        if (computadorPosicao >= chegada)
        {
            Console.WriteLine("Que pena! O computador alcançou a linha de chegada, você perdeu!");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("Pressione ENTER para continuar.");
            Console.ReadLine();
            break;
        }

        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.Write("Pressione ENTER para continuar.");
        Console.ReadLine();
    }

    Console.WriteLine("--------------------------------------------------------------------------------------------");
    Console.Write("Deseja continuar? (s/n)");
    string? opcao = Console.ReadLine()?.ToUpper();

    if (opcao != "S")
        break;
}

