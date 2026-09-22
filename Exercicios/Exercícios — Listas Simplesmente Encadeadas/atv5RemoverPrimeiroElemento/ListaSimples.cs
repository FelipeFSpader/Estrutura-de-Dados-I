
using System;
namespace QuintaAtv;

public class ListaSimples
{

    No Inicio { get; set; }

    public bool RemoverDoInicio()
    {
        if (Inicio != null)
        {
            Inicio = Inicio.Proximo;
            return true;
                
        } 
        else 
        {
            return false;
        }
    }

    public void InserirNoFinal(int valor)
    {
        No n = new();
        n.Valor = valor;       

        if (Inicio == null)
        {
            Inicio = n;
        }
        else
        {
            No atual = Inicio;
            while (atual.Proximo != null)
            {
                atual = atual.Proximo; 
            }
            atual.Proximo = n;
        }
    }

    public void Exibir()            
    {
        No atual = Inicio;
        while (atual != null)
        {
            Console.Write($"{atual.Valor} ");
            atual = atual.Proximo;
        }
        Console.WriteLine(); 
    }
} 
