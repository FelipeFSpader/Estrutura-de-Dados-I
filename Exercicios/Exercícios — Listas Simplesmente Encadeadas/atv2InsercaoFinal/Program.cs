using System;
namespace SegundaAtv;

class Program 
{
    static void Main()
    {
        ListaSimples ListaUm = new();

        ListaUm.InserirNoFinal(10);
        ListaUm.InserirNoFinal(20);
        ListaUm.InserirNoFinal(30);
        ListaUm.InserirNoFinal(40);
        
        ListaUm.Exibir();
    }
}