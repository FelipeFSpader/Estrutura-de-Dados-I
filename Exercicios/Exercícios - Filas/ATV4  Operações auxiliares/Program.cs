namespace ATV4__Operações_auxiliares;

public class Program
{
    static void Main()
    {
        Fila fila4 = new();
        
        fila4.Enfileirar(101);
        fila4.Enfileirar(121);
        fila4.Enfileirar(131);
        fila4.ListarDaFrenteParaOFim();
        fila4.Limpar();
        if (fila4.TentarDesenfileirar(out int itemRemovido))
        {
            Console.WriteLine($"Saiu da fila: {itemRemovido}");
        }
        else
        {
            Console.WriteLine("vazia");
        }
        
        fila4.Enfileirar(201);
        fila4.Enfileirar(202);
        // Você pode declarar a variável ali mesmo dentro dos parênteses:
        if (fila4.TentarDesenfileirar(out int itemRemovidoDois))
        {
            Console.WriteLine($"Saiu da fila: {itemRemovidoDois}");
        }
        else
        {
            Console.WriteLine("A fila estava vazia, nada saiu!");
        }
    }
}