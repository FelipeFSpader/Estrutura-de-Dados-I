using System;
namespace QuintaAtv;

public class Program
{

    static void Main()
    {

        ListaSimples listaUm = new();

        listaUm.InserirNoFinal(10);
        listaUm.InserirNoFinal(20);
        listaUm.InserirNoFinal(30);

        Console.Write("Antes da remoção");
        listaUm.Exibir(); //10 20 30

        bool resposta = listaUm.RemoverDoInicio();
        
        if (resposta == true)
        {
            Console.WriteLine("removido");
        }

        Console.Write("Depois da remoção: ");
        listaUm.Exibir();

    }

}