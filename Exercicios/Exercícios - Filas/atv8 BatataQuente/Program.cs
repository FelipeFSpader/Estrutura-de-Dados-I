namespace atv8_BatataQuente;

public class Program
{
    static void Main()
    {
        int vencedor = BatataQuente(5, 2);
        Console.WriteLine($"Vencedor: {vencedor}");
    }
    
    static int BatataQuente(int quantidadeJogadores, int passes)
    {
        Fila ciclo = new();

        for (int i = 1; i <= quantidadeJogadores; i++)
        {
            ciclo.Enfileirar(i);
        }

        Console.Write("Eliminados: ");
        while (ciclo.Quantidade > 1)
        {
            for (int p = 0; p < passes; p++)
            {
                ciclo.Enfileirar(ciclo.Desenfileirar());
            }

            int eliminado = ciclo.Desenfileirar();
            Console.Write($"{eliminado} ");
        }

        Console.WriteLine();
        return ciclo.Desenfileirar();
    }
}

//Eliminados: 3 1 5 2 
//Vencedor: 4

