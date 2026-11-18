namespace atv7_PainelPrioridade;

public class FilaPainel
{
    private No? _inicio { get; set; }
    private No? _fim { get; set; }
    private int quantidade { get; set; }

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
        quantidade++;
    }

    public int Desenfileirar()
    {

        if (_inicio == null)
            throw new InvalidOperationException("Fila vazia");
        int valorMostra = _inicio.Valor;
        _inicio = _inicio.Proximo;
        if (_inicio == null)
            _fim = null;
        quantidade--;
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
