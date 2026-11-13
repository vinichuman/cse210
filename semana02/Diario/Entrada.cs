using System;

public class Entrada
{
    public string _data;
    public string _pergunta;
    public string _texto;
    public string _humor; // Atributo extra para criatividade

    public void Exibir()
    {
        Console.WriteLine($"\nData: {_data} - Humor: {_humor}");
        Console.WriteLine($"Pergunta: {_pergunta}");
        Console.WriteLine($"Resposta: {_texto}");
    }
}