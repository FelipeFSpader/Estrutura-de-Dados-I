namespace atv5_FilaSemFIm;

public class FilaSemFim
{
    private No? _inicio;
    public int Quantidade { get; private set; }
    
    public void Enfileirar(int valor)
    {
        No NovoNo = new();
        NovoNo.Valor = valor;       

        if (_inicio == null)
        {
            _inicio = NovoNo;
        }
        else
        {
            No atual = _inicio;

            while (atual.Proximo != null)
            {
                atual = atual.Proximo; 
            }

            atual.Proximo = NovoNo;
        }
        Quantidade++;
    }
    
    public int Desenfileirar()
    {
        if (_inicio == null)
            throw new InvalidOperationException("Fila vazia");
        else
        {
            int valor = _inicio.Valor;
            _inicio = _inicio.Proximo;
            Quantidade--;
            return valor;
        }
    }
    
    public int ConsultarFrente()
    {
        if (_inicio == null)
            throw new InvalidOperationException("Fila vazia");
        return _inicio.Valor;
    }
}