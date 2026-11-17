namespace atvUm;

public class Program
{
    static void Main()
    {
        Fila filaUm = new();
        
        filaUm.Enfileirar(101);
        filaUm.Enfileirar(102);
        filaUm.Enfileirar(103);
        
        Console.WriteLine(filaUm.ConsultarFrente());
        Console.WriteLine(filaUm.EstaVazia());
        Console.WriteLine(filaUm.Desenfileirar());
        filaUm.Enfileirar(104);
        Console.WriteLine(filaUm.Desenfileirar());
        Console.WriteLine(filaUm.Desenfileirar());
        Console.WriteLine(filaUm.Desenfileirar());
    }
}