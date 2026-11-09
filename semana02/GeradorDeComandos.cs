using System;
using System.Collections.Generic;

public class GeradorDeComandos
{
    public List<string> _perguntas = new List<string>
    {
        "Quem foi a pessoa mais interessante com quem interagi hoje?",
        "Qual foi a melhor parte do meu dia?",
        "Como vi a mão do Senhor em minha vida hoje?",
        "Qual foi a emoção mais forte que senti hoje?",
        "Se eu pudesse fazer uma coisa diferente hoje, o que seria?",
        "O que aprendi de novo hoje que me surpreendeu?"
    };

    public string ObterComandoAleatorio()
    {
        Random aleatorio = new Random();
        int indice = aleatorio.Next(_perguntas.Count);
        return _perguntas[indice];
    }
}