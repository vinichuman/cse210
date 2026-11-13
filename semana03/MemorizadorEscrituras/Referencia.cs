using System;

// Representa a referência da escritura, por exemplo "João 3:16"
// ou "Provérbios 3:5-6".
public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _versiculoFinal;
    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _versiculoFinal = versiculo;
    }

    // Construtor para VÁRIOS versículos. Ex: Provérbios 3:5-6
    public Referencia(string livro, int capitulo, int versiculoInicial, int versiculoFinal)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculoInicial;
        _versiculoFinal = versiculoFinal;
    }

    public string ObterTextoExibicao()
    {
        if (_versiculo == _versiculoFinal)
        {
            return $"{_livro} {_capitulo}:{_versiculo}";
        }
        else
        {
            return $"{_livro} {_capitulo}:{_versiculo}-{_versiculoFinal}";
        }
    }
}