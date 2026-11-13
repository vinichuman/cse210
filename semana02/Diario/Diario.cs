using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Entrada> _entradas = new List<Entrada>();

    public void AdicionarEntrada(Entrada novaEntrada)
    {
        _entradas.Add(novaEntrada);
    }

    public void ExibirTodos()
    {
        if (_entradas.Count == 0)
        {
            Console.WriteLine("\nO diário está vazio.");
            return;
        }

        foreach (Entrada entrada in _entradas)
        {
            entrada.Exibir();
        }
    }

    public void SalvarArquivo(string nomeArquivo)
    {
        // Usa o separador ~|~ conforme sugerido nas simplificações
        using (StreamWriter outputFile = new StreamWriter(nomeArquivo))
        {
            foreach (Entrada entrada in _entradas)
            {
                outputFile.WriteLine($"{entrada._data}~|~{entrada._pergunta}~|~{entrada._texto}~|~{entrada._humor}");
            }
        }
        Console.WriteLine("Diário salvo com sucesso!");
    }

    public void CarregarArquivo(string nomeArquivo)
    {
        if (!File.Exists(nomeArquivo))
        {
            Console.WriteLine("Erro: Arquivo não encontrado.");
            return;
        }

        _entradas.Clear();
        string[] linhas = File.ReadAllLines(nomeArquivo);

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split("~|~");
            
            if (partes.Length == 4)
            {
                Entrada entrada = new Entrada();
                entrada._data = partes[0];
                entrada._pergunta = partes[1];
                entrada._texto = partes[2];
                entrada._humor = partes[3];
                
                _entradas.Add(entrada);
            }
        }
        Console.WriteLine("Diário carregado com sucesso!");
    }
}