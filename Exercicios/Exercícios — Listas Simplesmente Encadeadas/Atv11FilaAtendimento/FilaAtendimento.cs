namespace AtividadeOnze;

public class FilaAtendimento
{
    private ListaSimples senhas = new ListaSimples();

    //Coloca senha no fim da fila
    public void EmitirSenha(int numero)
    {
        senhas.InserirNoFinal(numero);
    }
    
    public int QuantidadeAguardando()
    {
        return senhas.Contar();
    }

    //chamar a próxima senha e remover da fila
    public int? ChamarProxima()
    {
        No primeiroNo = senhas.ObterPorPosicao(0);

        if (primeiroNo != null)
        {
            int senhaDaVez = primeiroNo.Valor;
            
            senhas.RemoverInicio();
            
            return senhaDaVez;
        }
        else
        {
            //se estiver vazia 
            return null;
        }
    }
}

