using System;
using System.Dynamic;
namespace OitavaAtv;

public class ListaSimples
{
    No Inicio { get; set; }
    public No ObterPorPosicao(int posicao)
    {
        if (posicao < 0) //não existe negativo 
        {
            return null;
        }

        No atual = Inicio;
        int contador = 0; //Diz qual nó está

        while (atual != null)
        {
            if (contador == posicao)// se está na posição pedida
            {
                return atual; // retorna nó inteiro para método
            }

            atual = atual.Proximo;
            contador++;
        }
        return null; 
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
}

//No vetor todos os espaços de valores são criados um do lado do outro 
//Tem uma estrutura que não dá pra mudar 
//Sabe instantâneamente onde é localização de cada coisa

//Em listas os objetos são criados disperços, sem saber o lugar exato
//lista exige que verifique do inicio até o ponto desejado  
//mais demorada 