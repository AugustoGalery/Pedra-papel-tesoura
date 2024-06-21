using System;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] opcoes = { "Pedra", "Papel", "Tesoura" };
            Random random = new Random();
            bool jogarNovamente = true;

            while (jogarNovamente)
            {
                Console.WriteLine("Escolha: Pedra, Papel ou Tesoura?");
                string escolhaJogador = Console.ReadLine().ToLower();
                int escolhaComputador = random.Next(0, 3);

                Console.WriteLine($"Computador escolheu: {opcoes[escolhaComputador]}");

                if ((escolhaJogador == "pedra" && opcoes[escolhaComputador] == "Tesoura") ||
                    (escolhaJogador == "papel" && opcoes[escolhaComputador] == "Pedra") ||
                    (escolhaJogador == "tesoura" && opcoes[escolhaComputador] == "Papel"))
                {
                    Console.WriteLine("Você venceu!");
                }
                else if (escolhaJogador == opcoes[escolhaComputador].ToLower())
                {
                    Console.WriteLine("Empate!");
                }
                else
                {
                    Console.WriteLine("Você perdeu!");
                }

                Console.WriteLine("Deseja jogar novamente? (s/n)");
                string resposta = Console.ReadLine().ToLower();
                jogarNovamente = resposta == "s";
            }
        }
    }
}
