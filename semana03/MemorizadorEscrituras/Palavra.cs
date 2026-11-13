using System;

// Representa UMA palavra da escritura.
public class Palavra
{
    private string _texto;
    private bool _estaOculta;

    public Palavra(string texto)
    {
        _texto = texto;
        _estaOculta = false;
    }

    public void Ocultar()
    {
        _estaOculta = true;
    }

    public void Mostrar()
    {
        _estaOculta = false;
    }

    public bool EstaOculta()
    {
        return _estaOculta;
    }

    // Se a palavra estiver oculta, mostra um "_" para cada letra.
    public string ObterTextoExibicao()
    {
        if (_estaOculta)
        {
            return new string('_', _texto.Length);
        }
        else
        {
            return _texto;
        }
    }
}