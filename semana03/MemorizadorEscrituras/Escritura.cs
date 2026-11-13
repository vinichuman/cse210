using System;
using System.Collections.Generic;

// Representa a escritura completa: a referência + a lista de palavras.
public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras = new List<Palavra>();

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;

        // Separa o texto em palavras usando o espaço
        // e cria um objeto Palavra para cada uma.
        string[] partes = texto.Split(' ');
        foreach (string parte in partes)
        {
            Palavra palavra = new Palavra(parte);
            _palavras.Add(palavra);
        }
    }

    // Oculta algumas palavras aleatórias.
    // Só escolhe palavras que AINDA NÃO estão ocultas.
    public void OcultarPalavrasAleatorias(int quantidade)
    {
        Random aleatorio = new Random();

        for (int i = 0; i < quantidade; i++)
        {
            // Monta uma lista só com as palavras ainda visíveis
            List<Palavra> palavrasVisiveis = new List<Palavra>();
            foreach (Palavra palavra in _palavras)
            {
                if (!palavra.EstaOculta())
                {
                    palavrasVisiveis.Add(palavra);
                }
            }

            // Se não sobrou nenhuma palavra visível, para aqui
            if (palavrasVisiveis.Count == 0)
            {
                return;
            }

            int indice = aleatorio.Next(palavrasVisiveis.Count);
            palavrasVisiveis[indice].Ocultar();
        }
    }

    public string ObterTextoExibicao()
    {
        string texto = "";
        foreach (Palavra palavra in _palavras)
        {
            texto += palavra.ObterTextoExibicao() + " ";
        }

        return _referencia.ObterTextoExibicao() + " " + texto.Trim();
    }

    public bool EstaTotalmenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }
        return true;
    }
}