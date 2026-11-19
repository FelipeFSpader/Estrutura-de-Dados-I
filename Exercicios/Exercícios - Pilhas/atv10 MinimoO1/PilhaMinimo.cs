namespace atv10_MinimoO1;

using System;

public class PilhaMinimo
{
    private Pilha _principal = new();
    private Pilha _minimos = new();

    public void Empilhar(int valor)
    {
        _principal.Empilhar(valor);

        if (_minimos.EstaVazia() || valor <= _minimos.ConsultarTopo())
        {
            _minimos.Empilhar(valor);
        }
    }

    public int Desempilhar()
    {
        if (_principal.EstaVazia())
            throw new InvalidOperationException("A pilha está vazia.");

        int removido = _principal.Desempilhar();

        if (removido == _minimos.ConsultarTopo())
        {
            _minimos.Desempilhar();
        }

        return removido;
    }

    public int ObterMinimo()
    {
        if (_minimos.EstaVazia())
            throw new InvalidOperationException("A pilha está vazia.");

        return _minimos.ConsultarTopo();
    }
}

