using System.Xml.Schema;

namespace AtividadeDoze;

public class HistoricoNavegacao
{
    private ListaSimples paginas = new ListaSimples();
    
    public void visitar(int idPagina)
    {
        paginas.InserirNoInicio(idPagina);
    }
    
    public int? PaginaAtual()
    {
        if (paginas.Contar() == 0)
        {
            return null;
        }

        No atual = paginas.ObterPorPosicao(0);
        if (atual != null)
        {
            return atual.Valor;
        }
        else
        {
            return null;
        }
    }

    public int? voltar()
    {
        if (paginas.Contar() <= 1)
        {
            return null;
        }

        paginas.RemoverDoInicio();

        return PaginaAtual();
    }
    
}