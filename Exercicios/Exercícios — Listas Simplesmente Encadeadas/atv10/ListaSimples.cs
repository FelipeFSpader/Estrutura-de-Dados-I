using System;
namespace DezAtv;

public class ListaSimples
{
    No Inicio { get; set; }

    //Novos 
    public void InserirNoInicio(int valor)
    {
        No n = new();
        n.Valor = valor;
        n.Proximo = Inicio; // o novo nó aponta para quem era o primeiro
        Inicio = n;         // A lista começa pelo novo nó
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
    //Novos

    //já feitos
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

    public bool Buscar(int valor)
    {
        No atual = Inicio;
        while (atual != null)
        {
            if (atual.Valor == valor) return true;
            atual = atual.Proximo;
        }
        return false;
    }

    public bool RemoverDoInicio()
    {
        if (Inicio != null)
        {
            Inicio = Inicio.Proximo;
            return true;
        } 
        return false;
    }

    public bool Remover(int valor)
    {
        if (Inicio == null) return false;
        if (Inicio.Valor == valor)
        {
            Inicio = Inicio.Proximo;
            return true;
        }

        No anterior = Inicio;
        No atual = Inicio.Proximo;

        while (atual != null)
        {
            if (atual.Valor == valor)
            {
                anterior.Proximo = atual.Proximo;
                return true;
            }
            anterior = atual;
            atual = atual.Proximo;
        }
        return false;
    }

    public bool InserirDepoisDe(int valorReferencia, int novoValor)
    {
        if (Inicio == null) return false;
        No atual = Inicio;

        while (atual != null)
        {
            if (atual.Valor == valorReferencia)
            {
                No n = new();
                n.Valor = novoValor;
                n.Proximo = atual.Proximo;
                atual.Proximo = n;
                return true; 
            }
            atual = atual.Proximo;
        }
        return false;
    }

    public No ObterPorPosicao(int posicao)
    {
        if (posicao < 0) return null;
        No atual = Inicio;
        int contador = 0; 

        while (atual != null)
        {
            if (contador == posicao) return atual;
            atual = atual.Proximo;
            contador++;
        }
        return null; 
    }

    public void Inverter()
    {
        No anterior = null;
        No atual = Inicio;
        No proximoTemp = null;

        while (atual != null)
        {
            proximoTemp = atual.Proximo; 
            atual.Proximo = anterior;    
            anterior = atual;            
            atual = proximoTemp;         
        }
        Inicio = anterior;
    }

    public void Listar()            
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