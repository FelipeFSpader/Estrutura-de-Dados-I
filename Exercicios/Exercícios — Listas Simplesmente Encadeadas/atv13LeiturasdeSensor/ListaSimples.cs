namespace AtividadeTreze;

public class ListaSimples
{
    
    No Inicio { get; set; }
    
    public void RemoverDuplicados()
    {
        if (Inicio == null)
        {
            return;
        }
        
        No atual = Inicio;
        
        while (atual != null)
        {
            No comparador = atual.Proximo;
            No antesComparador = atual;

            while (comparador != null)
            {
                if (comparador.Valor == atual.Valor)
                {
                    antesComparador.Proximo = comparador.Proximo;
                    comparador = comparador.Proximo;
                }
                else
                {
                    antesComparador = comparador;
                    comparador = comparador.Proximo;
                } 
            }  
            atual = atual.Proximo;
        }
    }
    
    public void Exibir()            
    {
        while (Inicio != null)
        {
            Console.Write($"{Inicio.Valor} ");
            Inicio = Inicio.Proximo;
        }
        
        Console.WriteLine(); 
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
}