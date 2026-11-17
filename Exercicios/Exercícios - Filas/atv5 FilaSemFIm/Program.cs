namespace atv5_FilaSemFIm;

//101, 102 e 103
//consulte a frente
//desenfileire uma vez
//104
//desenfileire até esvaziar.

public class Program
{
    static void Main()
    {
        FilaSemFim fila5 = new();
        
        fila5.Enfileirar(101);
        fila5.Enfileirar(102);
        fila5.Enfileirar(103);
        
        Console.WriteLine(fila5.ConsultarFrente());
        Console.WriteLine(fila5.Desenfileirar());
        fila5.Enfileirar(104);
        Console.WriteLine(fila5.Desenfileirar());
        Console.WriteLine(fila5.Desenfileirar());
        Console.WriteLine(fila5.Desenfileirar());
    }
}

//O(n) e O(1)
//não vale a pena, pois o gasto seria maior 0(n),
//realocar números muito grandes custa demais. 