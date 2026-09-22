using System;
namespace OitavaAtv;

public class Program
{
    static void Main()
    {
        ListaSimples listaOito = new();

        listaOito.InserirNoFinal(10); //0
        listaOito.InserirNoFinal(20); //1
        listaOito.InserirNoFinal(30); //2

        
        No resultado = listaOito.ObterPorPosicao(2);

        if (resultado != null)
        {
            Console.WriteLine($"Valor encontrado: {resultado.Valor}");
        }
        else
        {
            Console.WriteLine("Inválido");
        }
    }
}