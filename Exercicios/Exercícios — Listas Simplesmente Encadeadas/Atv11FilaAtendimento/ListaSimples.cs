namespace AtividadeOnze;

public class ListaSimples
{


    No Inicio { get; set; }

    public void InserirNoFinal(int numero)
    {
        No n = new();
        n.Valor = numero;

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

    public int RemoverInicio()
    {
        if (Inicio != null)
        {
            int senhaAtual = Inicio.Valor;
            Inicio = Inicio.Proximo;
            return senhaAtual;
        }
        else
        {
            return 0;
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
}
