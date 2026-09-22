using System;
namespace TerceiraaAtv;

public class ListaSimples 
{
    No Inicio { get; set; }

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

    public int Contar()
    {
        int quantidade = 0;
        No atual = Inicio;

        while (atual != null)
        {
            quantidade++;
            atual = atual.Proximo;
        }

        return quantidade;
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