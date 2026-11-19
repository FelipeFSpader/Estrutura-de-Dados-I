namespace atv6_TopoUltimoNo;

public class Program
{
    static void Main()
    {
        PilhaNoFim pilha = new();

        pilha.Empilhar(10);
        pilha.Empilhar(20);
        pilha.Empilhar(30);
        Console.WriteLine($"Topo: {pilha.ConsultarTopo()}");      // Deve ser 30
        Console.WriteLine($"Desempilhou: {pilha.Desempilhar()}"); // Deve ser 30
        pilha.Empilhar(40);
        Console.WriteLine($"Desempilhou: {pilha.Desempilhar()}"); // Deve ser 40
        Console.WriteLine($"Desempilhou: {pilha.Desempilhar()}"); // Deve ser 20
        Console.WriteLine($"Desempilhou: {pilha.Desempilhar()}"); // Deve ser 10
    }
}

//com o topo no inicio as operacoes ficam mais baratas
//tira a necessidade de percorrer a lista inteira. 