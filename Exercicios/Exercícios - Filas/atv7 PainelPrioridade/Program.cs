namespace atv7_PainelPrioridade;

public class Program
{
    static void Main()
    {
        PainelAtendimento painel = new();
        
        painel.EmitirNormal(1);
        painel.EmitirNormal(2);
        painel.EmitirNormal(3);
        painel.EmitirNormal(4);
        painel.EmitirNormal(5);
        
        painel.EmitirPrioritaria(101);
        painel.EmitirPrioritaria(102);
        
        int? senhaChamada = painel.ChamarProxima();

        while (senhaChamada != null)
        {
            Console.Write($"{senhaChamada} ");
            senhaChamada = painel.ChamarProxima();
        }

        Console.WriteLine();
    }
}

//101 1 2 102 3 4 5
