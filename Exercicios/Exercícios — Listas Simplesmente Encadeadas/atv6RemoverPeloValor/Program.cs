using System;
namespace SextaAtv;

public class Program
{
    static void Main()
    {
        ListaSimples listaseis = new();

        //Lista vazia
        bool resultadoVazia = listaseis.RemoverValor(10);
        Console.WriteLine($"{resultadoVazia}"); // Deve dar false

        listaseis.InserirNoFinal(10);
        listaseis.InserirNoFinal(20);
        listaseis.InserirNoFinal(30);


        //remover inicio
        bool resultadoInicio = listaseis.RemoverValor(10);
        Console.WriteLine($"{resultadoInicio}"); // Deve dar true


        //remover do meio
        bool resultadoMeio = listaseis.RemoverValor(20);
        Console.WriteLine($"{resultadoMeio}"); // Deve dar true

        //remover do fim
        bool resultadoUltimo = listaseis.RemoverValor(30);
        Console.WriteLine($"{resultadoUltimo}"); // Deve dar true

        // A lista está vazia
        bool resultadoInexistente = listaseis.RemoverValor(99);
        Console.WriteLine($"{resultadoInexistente}"); // Deve dar false
    }
}