namespace atv9_PosFixada;

public class Pilha
{   
    private No? _topo;
    public int Quantidade { get; private set; }
    public void Empilhar(int valor)
    {
        No novoNo = new No();
        novoNo.Valor = valor;
        _topo = novoNo;
        novoNo.Proximo = _topo;
        Quantidade++;
    }

    public int Desempilhar()
    {
        if (_topo == null)
            throw new InvalidOperationException("A pilha está vazia.");
        
        int valor = _topo.Valor;
        _topo = _topo.Proximo;
        Quantidade--;
        return valor;
    }

    public int ConsultarTopo()
    {
        if (_topo == null)
            throw new InvalidOperationException("A pilha está vazia.");
        
        return _topo.Valor; 
    }

    public bool EstaVazia()
    {
        if (_topo == null)
            return true;
        else 
            return false; 
    }

    public void Limpar()
    {
        _topo = null;
        Quantidade = 0;
    }

    public void ImprimirDoTopoParaBase()
    {
        No? atual = _topo;
            
        while(atual != null)
        {
            Console.WriteLine(atual.Valor);
            atual = atual.Proximo;
        }
    }

    public bool Contem(int valor)
    {
        No? atual = _topo;
        while (atual != null)
        {
            if (atual.Valor == valor)
            {
                return true;
            }
            atual = atual.Proximo;
        }

        return false;
    }
}