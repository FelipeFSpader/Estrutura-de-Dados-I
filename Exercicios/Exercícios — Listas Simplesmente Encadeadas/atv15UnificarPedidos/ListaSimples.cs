namespace AtividadeQuinze;

public class ListaSimples
{
    No Inicio;
    
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
    
    public static ListaSimples Mesclar(ListaSimples um, ListaSimples dois)
    {
        ListaSimples resultado = new();
        
        No atualUm = um.Inicio;
        No atualDois = dois.Inicio;
        No ultimo = null;

        while (atualUm != null && atualDois != null)
        {
            int valorEscolhido;

            if (atualUm.Valor <= atualDois.Valor)
            {
                valorEscolhido = atualUm.Valor;
                atualUm = atualUm.Proximo;
            }
            else
            {
                valorEscolhido = atualDois.Valor;
                atualDois = atualDois.Proximo;
            }
            
            //um no novo pra não mexer na lista original
            No novo = new No { Valor = valorEscolhido };

            if (resultado.Inicio == null)
            {
                resultado.Inicio = novo;
                ultimo = novo;
            }
            else
            {
                ultimo.Proximo = novo;
                ultimo = novo; 
            }
        }
        
        //se sobrar elementos em UM coloca pro fim
        while (atualUm != null)
        {
            No novo = new No { Valor = atualUm.Valor };
            
            if (resultado.Inicio == null)
            {
                resultado.Inicio = novo;
                ultimo = novo;
            }
            else
            {
                ultimo.Proximo = novo;
                ultimo = novo; 
            }
            atualUm = atualUm.Proximo;
        }
        
        //se sobrar elementos em Dois coloca pro fim
        while (atualDois != null)
        {
            No novo = new No { Valor = atualDois.Valor };
            
            if (resultado.Inicio == null)
            {
                resultado.Inicio = novo;
                ultimo = novo;
            }
            else
            {
                ultimo.Proximo = novo;
                ultimo = novo; 
            }
            atualDois = atualDois.Proximo;
        }
        
        return resultado;
    }
}