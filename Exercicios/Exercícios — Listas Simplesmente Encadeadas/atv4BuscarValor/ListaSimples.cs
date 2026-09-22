
using System;
using QuartaAtv;

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


    public No Buscar(int valor)
    {
        No atual = Inicio;

        while (atual != null)
        {
            // "Se ele for igual o que eu quero"
            // (O número dentro do nó é igual ao número que pedi na busca?)
            if (atual.Valor == valor)
            {
                // "ele retorna o atual"
                // (Devolve o objeto inteiro e encerra o método na mesma hora)
                return atual;
            }

            // "senão ele continua, daí o atual, vai receber o próximo"
            // (Pega o endereço que aponta para o próximo da fila e atualiza nossa variável)
            atual = atual.Proximo;
        }

        // Se o while terminar de rodar a fila inteira e não achar nada, 
        // ele cai aqui fora e devolve o vazio que o exercício pede
        return null;
    }

}