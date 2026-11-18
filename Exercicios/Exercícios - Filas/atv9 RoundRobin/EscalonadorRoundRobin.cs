namespace atv9_RoundRobin; 

public class EscalonadorRoundRobin
{
    private Fila _ids = new();
    private Fila _tempos = new();

    public void AdicionarProcesso(int id, int tempoNecessario)
    {
        _ids.Enfileirar(id);
        _tempos.Enfileirar(tempoNecessario);
    }

    public void Executar(int quantum)
    {
        int tempoAtual = 0;
        while (!_ids.EstaVazia())
        {
            int idAtual = _ids.Desenfileirar();
            int tempoRestante = _tempos.Desenfileirar();
            
            int tempoExecutado;
            if (tempoRestante <= quantum)
                tempoExecutado = tempoRestante;
            else
                tempoExecutado = quantum;

            tempoAtual += tempoExecutado;
            tempoRestante -= tempoExecutado;

            if (tempoRestante == 0)
            {
                Console.WriteLine($"P{idAtual} termina em {tempoAtual}");
            }
            else
            {
                _ids.Enfileirar(idAtual);
                _tempos.Enfileirar(tempoRestante);
            }
        }
    }
}