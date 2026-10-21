namespace AtividadeQuatorze;

public class ListaSimples
{
    No Inicio;
    
    public void InserirOrdenadoDecrescente(int pontuacao)
    {
        No novo = new No { Valor = pontuacao };
            
        //lista vazia ou maior que a primeira
        if (Inicio == null || pontuacao > Inicio.Valor)
        {
            novo.Proximo = Inicio;
            Inicio = novo;
            return;
        }
        
        No atual = Inicio;
        
        //No meio, no final e empate 
        while (atual.Proximo != null && atual.Proximo.Valor >= pontuacao)
        {
            atual = atual.Proximo; 
        }
        
        novo.Proximo = atual.Proximo; //Novo n[o entra na continuacao da lista
        atual.Proximo = novo; //No atual passa apontar pro novo
    }

    public void ExibirTop(int n)
    {
        No atual = Inicio;
        int contador = 0;

        while (atual != null && contador < n)
        {
            Console.WriteLine($"{atual.Valor}");
            atual = atual.Proximo;
            contador++;
        }
    }
}