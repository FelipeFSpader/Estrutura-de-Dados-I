using System;
using System.ComponentModel.DataAnnotations;
namespace SegundaAtv;
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
            //temporio
            No atual = Inicio;

            //roda até achar o que não tem ninguem na frente
            while (atual.Proximo != null)
            {
                atual = atual.Proximo; 
            }

            //faz o lugar que não tem nada na frente apontar para n
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
