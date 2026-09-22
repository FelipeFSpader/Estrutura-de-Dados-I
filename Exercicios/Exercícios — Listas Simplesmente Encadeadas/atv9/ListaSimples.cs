using System;
namespace NonaAtv;

public class ListaSimples
{

    No Inicio { get; set; }


    public void Inverter()
    {
    No anterior = null;
    No atual = Inicio;
    No proximoTemp = null;

    while (atual != null)
        {
            proximoTemp = atual.Proximo; // guarda pra não perder 
            atual.Proximo = anterior;    // no atual solta a frente e aponta pro de trás
            
            anterior = atual;            // anterior avança um e vira o atual
            atual = proximoTemp;         //atual avança e vira o proximo
        }

        Inicio = anterior; // último nó no anterior vira o inicio
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