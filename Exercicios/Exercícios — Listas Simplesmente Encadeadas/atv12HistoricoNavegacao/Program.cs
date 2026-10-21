namespace AtividadeDoze;

public class Program
{
    static void Main()
    {
        HistoricoNavegacao historico = new();
        
        historico.visitar(1);
        historico.visitar(2);
        historico.visitar(3);
        
        Console.WriteLine($"Volta: {historico.voltar()}");
        
        historico.visitar(4);
        
        Console.WriteLine($"Volta: {historico.voltar()}");
        Console.WriteLine($"Volta: {historico.voltar()}");
        Console.WriteLine($"Volta: {historico.voltar()}");
    }
}