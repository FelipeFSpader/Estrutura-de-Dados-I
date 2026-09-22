using System;
namespace SetimaAtv;

public class Program
{
    static void Main()
    {
        ListaSimples lista = new();

        lista.InserirNoFinal(10);
        lista.InserirNoFinal(20);
        lista.InserirNoFinal(30);

        lista.Exibir(); //10 20 30

        //Inserir 25 depois do 20
        bool CasoTrue = lista.InserirDepoisDe(20, 25);
        
        if (CasoTrue == true)
        {
            Console.WriteLine("Inserido");
        }

        //resultado 
        lista.Exibir(); //10 20 25 30

    }
}