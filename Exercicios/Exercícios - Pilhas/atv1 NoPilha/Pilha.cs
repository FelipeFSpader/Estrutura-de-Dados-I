namespace atv1_NoPilha;

using System.Data;

public class Pilha
{   
    private No? _topo;
    public int Quantidade { get; private set; }
    public void Empilhar(int valor)
    {
        No novoNo = new No();
        novoNo.Valor = valor;
        novoNo.Proximo = _topo;
        _topo = novoNo;
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
        
}