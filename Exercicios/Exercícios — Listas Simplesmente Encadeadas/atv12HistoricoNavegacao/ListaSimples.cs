namespace AtividadeDoze;

public class ListaSimples
{
    No Inicio { get; set; }
    
    public void InserirNoInicio(int valor)
    {
        No novo = new No();
        novo.Valor = valor;
        
        novo.Proximo = Inicio; 
    
        Inicio = novo; 
    }

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
}