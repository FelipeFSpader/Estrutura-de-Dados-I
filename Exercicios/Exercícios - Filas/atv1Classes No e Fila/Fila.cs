namespace atvUm;

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
}