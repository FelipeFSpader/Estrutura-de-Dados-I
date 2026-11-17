namespace ATV4__Operações_auxiliares;

public class Fila
{
    private No? _inicio { get; set; }
    private No? _fim { get; set; }
    public int Quantidade { get; private set; }

    public void Enfileirar(int NovoValor)
    {
        No novoNo = new();
        novoNo.Valor = NovoValor;

        if (_fim == null)
        {
            _inicio = novoNo;
            _fim = novoNo;
        }
        else
        {
            _fim.Proximo = novoNo;
            _fim = novoNo;
        }
        Quantidade++;
    }

    public int Desenfileirar()
    {
        if (_inicio == null)
            throw new InvalidOperationException("Fila vazia");
        int valorMostra = _inicio.Valor;
        _inicio = _inicio.Proximo;

        if (_inicio == null)
            _fim = null;

        Quantidade--;
        return valorMostra;
    }

    public int ConsultarFrente()
    {
        if (_inicio == null)
            throw new InvalidOperationException("Fila vazia");
        return _inicio.Valor;
    }

    public bool EstaVazia()
    {
        if (_inicio == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    // Operações auxiliares
    
    public void ListarDaFrenteParaOFim()
    {
        No? atual = _inicio;

        while (atual != null)
        {
            Console.WriteLine(atual.Valor);
            atual = atual.Proximo;
        }
    }

    public bool TentarDesenfileirar(out int valor)
    {
        if (_inicio == null)
        {
            valor = 0;
            return false;
        }
        else
        {
            valor = _inicio.Valor;
            _inicio = _inicio.Proximo;
            
            if (_inicio == null)
                _fim = null;
            Quantidade--;
            return true;
        }
    }

    public void Limpar()
    {
        if (_inicio == null)
            return;
        _inicio = null;
        _fim = null;
        Quantidade = 0;
    }
    
  
    /*
    public void LimparDiferente()
    {
        No? atual = _inicio;

        while (atual != null)
        {
            No Proximo = atual.Proximo;
            atual.Proximo = null;
            atual = Proximo;
        }
        
        _inicio = null;
        _fim = null;
        Quantidade = 0;
    }
    */
}