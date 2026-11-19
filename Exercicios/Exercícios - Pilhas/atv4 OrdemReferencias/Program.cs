namespace atv4_OrdemReferencias;

public class Program
{
    static void Main()
    {
        Pilha pilha = new();

        pilha.Empilhar(10);
        pilha.Empilhar(20);
        pilha.Empilhar(30);
    }

    /*
    pilha.Empilhar(10); _topo -> 10
    pilha.Empilhar(20); _topo -> 20
    pilha.Empilhar(30); _topo -> 30

        O topo perde a referência e o garbage coletor limpa
        A ordem original é correta pois não perde a referencia,
         apontando pro nó que atualmente o ocupa o topo antes da referencia de _topo
          mirar nele e largar o anterior
    */
}