using System;
 
// 1. Adicionado o registro de "Humor" em cada Entrada, permitindo salvar outras informações além do texto básico.
// 2. Adicionada verificação de segurança (File.Exists) ao carregar o arquivo para evitar o encerramento do programa.
// 3. Utilização do separador seguro "~|~" para permitir o uso livre de vírgulas e aspas pelo usuário.

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDeComandos gerador = new GeradorDeComandos();
        bool executando = true;

        Console.WriteLine("Bem-vindo ao programa Diário!");

        while (executando)
        {
            Console.WriteLine("\nPor favor, selecione uma das seguintes opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");
            
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                string pergunta = gerador.ObterComandoAleatorio();
                Console.WriteLine($"\nPergunta: {pergunta}");
                Console.Write("> ");
                string texto = Console.ReadLine();
                
                // Recurso extra: Pedir o humor atual
                Console.Write("Qual é o seu humor/emoção atual? ");
                string humor = Console.ReadLine();

                Entrada novaEntrada = new Entrada();
                novaEntrada._data = DateTime.Now.ToShortDateString();
                novaEntrada._pergunta = pergunta;
                novaEntrada._texto = texto;
                novaEntrada._humor = humor;

                diario.AdicionarEntrada(novaEntrada);
            }
            else if (escolha == "2")
            {
                diario.ExibirTodos();
            }
            else if (escolha == "3")
            {
                Console.Write("Qual é o nome do arquivo para carregar? ");
                string nomeArquivo = Console.ReadLine();
                diario.CarregarArquivo(nomeArquivo);
            }
            else if (escolha == "4")
            {
                Console.Write("Qual é o nome do arquivo para salvar? ");
                string nomeArquivo = Console.ReadLine();
                diario.SalvarArquivo(nomeArquivo);
            }
            else if (escolha == "5")
            {
                executando = false;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}