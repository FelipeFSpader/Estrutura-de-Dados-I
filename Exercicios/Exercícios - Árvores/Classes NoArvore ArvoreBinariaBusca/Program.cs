using Classes_NoArvore_ArvoreBinariaBusca;
using System;

namespace Classes_NoArvore_ArvoreBinariaBusca;

public class Program
{
    static void Main()
    {

        //teste do exercício 10
        TestarSequencia([50, 30, 70, 20, 40, 60, 80]);
        TestarSequencia([50, 30, 70, 20]);
        TestarSequencia([50, 30, 70, 40]);
        TestarSequencia([50, 30, 20]);
        TestarSequencia([50, 30, 70, 20, 40, 60, 10]);
        TestarSequencia([40, 30, 60, 20, 50, 70, 10]);
    }

    static void TestarSequencia(int[] valores)
    {
        ArvoreBinariaBusca arvore = new();

        foreach (int valor in valores)
        {
            arvore.Inserir(valor);
        }

        Console.WriteLine($"Sequência: {string.Join(", ", valores)}");
        Console.WriteLine($"  Estritamente binária: {arvore.EhEstritamenteBinaria()}");
        Console.WriteLine($"  Completa            : {arvore.EstaCompleta()}");
        Console.WriteLine($"  Balanceada          : {arvore.EstaBalanceada()}");
    }
}