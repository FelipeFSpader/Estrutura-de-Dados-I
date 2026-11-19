namespace atv1_NoPilha;
    
public class Program
{
    static void Main()
    {
        Pilha pilha = new();

        pilha.Empilhar(10);
        pilha.Empilhar(20);
        pilha.Empilhar(30);
        pilha.ConsultarTopo();
        pilha.Desempilhar();
        pilha.Empilhar(40);
        pilha.Desempilhar();
        pilha.Desempilhar();
        pilha.Desempilhar();      
    }
}