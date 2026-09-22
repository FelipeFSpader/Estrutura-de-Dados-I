using System;
namespace SextaAtv;

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
    public bool RemoverValor(int valor)
    {
        //verifica se está vazia 
        if (Inicio == null)
        {
            return false; //não tem o que remover
        }

        //primeiro no
        if (Inicio.Valor == valor)
        {
            Inicio = Inicio.Proximo;
            return true;
        }

        //mesmo para o meio e último
        No anterior = Inicio;
        No atual = Inicio.Proximo;

        while (atual != null)
        {
            if (atual.Valor == valor)
            {
                //pode ser o do meio e o últmo.
                anterior.Proximo = atual.Proximo;
                return true;
            }

            anterior = atual;
            atual = atual.Proximo;
        }
        //pra caso inexistente 
        return false;
    }
}
