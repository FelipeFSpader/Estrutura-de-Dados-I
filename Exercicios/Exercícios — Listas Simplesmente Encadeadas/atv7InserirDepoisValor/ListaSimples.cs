using System;
namespace SetimaAtv;

public class ListaSimples
{

    No Inicio { get; set; }
    public bool InserirDepoisDe(int valorReferencia, int novoValor)
    {
        if (Inicio == null)
        {
            return false;
        }

        No atual = Inicio;

        while (atual != null)
        {
            if (atual.Valor == valorReferencia)
            {
                No novo = new();
                novo.Valor = novoValor;

                novo.Proximo = atual.Proximo; //aponta para o seguinte da referencia 

                atual.Proximo = novo; //apontar para o número de referencia 

                return true;

            }
            atual = atual.Proximo;
        }
        return false;
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