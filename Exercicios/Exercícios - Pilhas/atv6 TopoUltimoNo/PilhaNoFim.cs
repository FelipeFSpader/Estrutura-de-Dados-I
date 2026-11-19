namespace atv6_TopoUltimoNo;

public class PilhaNoFim
{
    private No? _inicio;
    public int Quantidade { get; private set; }

    public void Empilhar(int valor)
    {
        No novoNo = new No();
        novoNo.Valor = valor;

        if (_inicio == null)
        {
            _inicio = novoNo;
        }
        else
        {
            No atual = _inicio;
            while (atual.Proximo != null)
            {
                atual = atual.Proximo;
            }
            atual.Proximo = novoNo;
        }

        Quantidade++;
    }

    public int Desempilhar()
    {
        if (_inicio == null)
            throw new InvalidOperationException("A pilha está vazia.");
        
        if (_inicio.Proximo == null)
        {
            int valorUnico = _inicio.Valor;
            _inicio = null;
            Quantidade--;
            return valorUnico;
        }

        No atual = _inicio;
        while (atual.Proximo!.Proximo != null)
        {
            atual = atual.Proximo;
        }

        int valor = atual.Proximo.Valor;
        atual.Proximo = null;
        Quantidade--;
        return valor;
    }

    public int ConsultarTopo()
    {
        if (_inicio == null)
            throw new InvalidOperationException("A pilha está vazia.");

        No atual = _inicio;
        while (atual.Proximo != null)
        {
            atual = atual.Proximo;
        }
        return atual.Valor;
    }

    public bool EstaVazia() => _inicio == null;
}