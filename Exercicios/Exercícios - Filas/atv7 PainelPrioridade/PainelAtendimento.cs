namespace atv7_PainelPrioridade;

public class PainelAtendimento
{
    private FilaPainel _normais = new();
    private FilaPainel _prioritarias = new();

    private int _normaisAtendidas = 0; 

    public void EmitirNormal(int senha)
    {
        _normais.Enfileirar(senha);
    }

    public void EmitirPrioritaria(int senha)
    {
        _prioritarias.Enfileirar(senha);
    }

    public int ChamarProxima()
    {
        if (_prioritarias.EstaVazia() && _normais.EstaVazia())
            return 0;

        if ((_normaisAtendidas == 2 || _normais.EstaVazia()) && !_prioritarias.EstaVazia())
        {
            _normaisAtendidas = 0; // zera o contador para começar a contar as 2 normais
            return _prioritarias.Desenfileirar();
        }

        _normaisAtendidas++;
        return _normais.Desenfileirar();

    }
    
}