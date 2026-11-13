using System;
using System.Collections.Generic;

// ==========================================================
// MEMORIZADOR DE ESCRITURAS

// 1. O programa tem uma BIBLIOTECA de escrituras (Bíblia e
//    Livro de Mórmon) e escolhe uma aleatoriamente cada vez
//    que é executado, em vez de usar sempre a mesma.
// 2. Ao ocultar palavras, o programa escolhe apenas palavras
//    que ainda NÃO foram ocultadas.
// ==========================================================

class Program
{
    static void Main(string[] args)
    {
        // Biblioteca de escrituras
        List<Escritura> biblioteca = new List<Escritura>();

        biblioteca.Add(new Escritura(
            new Referencia("João", 3, 16),
            "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna."));

        biblioteca.Add(new Escritura(
            new Referencia("Provérbios", 3, 5, 6),
            "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas."));

        biblioteca.Add(new Escritura(
            new Referencia("1 Néfi", 3, 7),
            "E aconteceu que eu, Néfi, disse a meu pai: Eu irei e cumprirei as ordens do Senhor, porque sei que o Senhor nunca dá ordens aos filhos dos homens sem antes preparar um caminho pelo qual suas ordens possam ser cumpridas."));

        biblioteca.Add(new Escritura(
            new Referencia("Mosias", 2, 17),
            "E eis que vos digo estas coisas para que aprendais sabedoria; para que saibais que, quando estais a serviço de vosso próximo, estais somente a serviço de vosso Deus."));

        biblioteca.Add(new Escritura(
            new Referencia("2 Néfi", 2, 25),
            "Adão caiu para que os homens existissem; e os homens existem para que tenham alegria."));

        // Escolhe uma escritura aleatória
        
        Random aleatorio = new Random();
        Escritura escritura = biblioteca[aleatorio.Next(biblioteca.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTextoExibicao());
            Console.WriteLine();

            // Se todas as palavras já estão ocultas, encerra o programa
            if (escritura.EstaTotalmenteOculta())
            {
                Console.WriteLine("Parabéns! Todas as palavras foram ocultadas.");
                break;
            }

            Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para terminar:");
            string entrada = Console.ReadLine();

            if (entrada == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);
        }
    }
}