namespace atv2PilhaVazia;

public class Program
{
    static void Main()
    {
        Pilha pilha = new();

        try
        {
            pilha.Desempilhar();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Erro capturado: {ex.Message}");
        }

        pilha.Empilhar(10);
        pilha.Empilhar(20);
        pilha.Empilhar(30);

        Console.Write("Esvaziando: ");
        while (pilha.TentarDesempilhar(out int valor))
        {
            Console.Write($"{valor} ");
        }
        Console.WriteLine();
    }
}