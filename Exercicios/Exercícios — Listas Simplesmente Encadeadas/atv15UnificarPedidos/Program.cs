namespace AtividadeQuinze;

public class Program
{
    static void Main()
    {
        ListaSimples um = new();
        um.InserirNoFinal(3);
        um.InserirNoFinal(8);
        um.InserirNoFinal(12);
        um.InserirNoFinal(20);
        
        ListaSimples dois = new();
        dois.InserirNoFinal(5);
        dois.InserirNoFinal(8);
        dois.InserirNoFinal(15);

        ListaSimples unificado = ListaSimples.Mesclar(um, dois);
        
        Console.Write("Mescla: ");
        unificado.Exibir();
    }
}

//reflexao.
//usando o no ultimo eu evito ter que percorere a lista intera para fazer novas insercoes
//reduz custo e tempo 