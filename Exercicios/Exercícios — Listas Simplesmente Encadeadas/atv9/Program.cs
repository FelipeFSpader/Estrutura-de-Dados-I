using System;
namespace NonaAtv;

public class Program
{
    static void Main()
    {
        ListaSimples listaNove = new();

        listaNove.InserirNoFinal(10); 
        listaNove.InserirNoFinal(20); 
        listaNove.InserirNoFinal(30);
        listaNove.InserirNoFinal(40);

        //normal
        listaNove.Exibir(); //10 20 30 40

        listaNove.Inverter();

        //invertida 
        listaNove.Exibir(); //40 30 20 10
    }
}