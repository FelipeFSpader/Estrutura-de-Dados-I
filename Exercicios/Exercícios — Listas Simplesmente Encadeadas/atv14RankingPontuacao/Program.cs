namespace AtividadeQuatorze;

public class Program
{
    static void Main()
    {
        ListaSimples ranking = new();
        
        ranking.InserirOrdenadoDecrescente(150);
        ranking.InserirOrdenadoDecrescente(300);
        ranking.InserirOrdenadoDecrescente(90);
        ranking.InserirOrdenadoDecrescente(300);
        ranking.InserirOrdenadoDecrescente(200);
        
        ranking.ExibirTop(3);
    }
}

/*
Reflexao 
Entendi que o vetor pra colocar no meio vai precisar deslocar todos elementos, o que pode custar demais
e na lista, apessar de ter que percorrer as referencias ate posicao, apenas se faz uma reatribuiucao na "mira"
*/