namespace atv10_MinimoO1;

public class Program
{
    static void Main()
    {
        PilhaMinimo pilha = new();

        pilha.Empilhar(5);
        pilha.Empilhar(3);
        pilha.Empilhar(7);
        pilha.Empilhar(3);
        pilha.Empilhar(8);

        Console.WriteLine($"Mínimo inicial: {pilha.ObterMinimo()}"); //3

        Console.WriteLine($"Removeu {pilha.Desempilhar()} -> Mínimo: {pilha.ObterMinimo()}"); // 3
        Console.WriteLine($"Removeu {pilha.Desempilhar()} -> Mínimo: {pilha.ObterMinimo()}"); // 3
        Console.WriteLine($"Removeu {pilha.Desempilhar()} -> Mínimo: {pilha.ObterMinimo()}"); // 3
        Console.WriteLine($"Removeu {pilha.Desempilhar()} -> Mínimo: {pilha.ObterMinimo()}"); // 5

        pilha.Desempilhar(); //5
    }
}