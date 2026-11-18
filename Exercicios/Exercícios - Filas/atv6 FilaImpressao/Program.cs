namespace atv6_Fila_de_impressão;

public class Program
{
    static void Main()
    {
        FilaImpressao filaum = new();

        filaum.Enfileirar(3);
        filaum.Enfileirar(1);
        filaum.Enfileirar(5);
        filaum.Enfileirar(2);

        int tempoAtual = 0; 
        int somaTempo = 0;
        int total = filaum.quantidade;  

        while (!filaum.EstaVazia())
        {
            int paginas = filaum.Desinfileirar();
            int espera = tempoAtual;

            somaTempo += espera;
            tempoAtual += paginas;

            Console.WriteLine($"{paginas}, esperou {espera}, pronto em {tempoAtual}");
        }

        double media = somaTempo/ total;
        Console.WriteLine($"Média: {media}");
    }
}

/*
Se 5 fosse enviado por último, ele seria o último a sair. Levaria 6 segundos pra iniciar e se completaria com 11
*/