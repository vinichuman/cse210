using System;

class Program
{
    static void Main(string[] args)
    {
        string jogarNovamente = "sim";

        // Ciclo externo para permitir jogar novamente
        while (jogarNovamente.ToLower() == "sim")
        {
            // Gerar um número aleatório entre 1 e 100
            Random randomGenerator = new Random();
            int numeroMagico = randomGenerator.Next(1, 101); 
            
            int palpite = -1;
            int contadorPalpites = 0;

            while (palpite != numeroMagico)
            {
                Console.Write("Qual é o seu palpite? ");
                string input = Console.ReadLine();
                palpite = int.Parse(input);
                
                // Contabilizar os palpites
                contadorPalpites++;

                // Lógica de dicas
                if (palpite > numeroMagico)
                {
                    Console.WriteLine("Mais baixo");
                }
                else if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }
                else
                {
                    Console.WriteLine("Você adivinhou!");
                }
            }

            // Mostrar o total de palpites no final do jogo
            Console.WriteLine($"Foram precisos {contadorPalpites} palpites.");

            // Perguntar ao utilizador se quer jogar novamente
            Console.Write("Deseja jogar de novo? (sim/nao): ");
            jogarNovamente = Console.ReadLine();
        }
    }
}