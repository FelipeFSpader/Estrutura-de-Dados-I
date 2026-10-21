using System;
namespace PrimeiraAtv;
public class ListaSimples 
{

    No Inicio { get; set; }


    public void Exibir()            
    {
        while (Inicio != null)
        {
            Console.Write($"{Inicio.Valor} ");
            Inicio = Inicio.Proximo;
        }
        
        Console.WriteLine(); 
    }

    public void InserirNoInicio(int valor)
    {
        No n = new();
        n.Valor = valor;        

            n.Proximo = Inicio;
            Inicio = n;
    }
}    