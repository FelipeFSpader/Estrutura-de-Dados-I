using System;
namespace PrimeiraAtv;

class Program 
{
    static void Main()
    {
        ListaSimples ListaUm = new();

        ListaUm.InserirNoInicio(30);
        ListaUm.InserirNoInicio(20);
        ListaUm.InserirNoInicio(10);

        ListaUm.Exibir();
    }
}