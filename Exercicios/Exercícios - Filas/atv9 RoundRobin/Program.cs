namespace atv9_RoundRobin;

public class Program
{
    static void Main()
    {
        EscalonadorRoundRobin escalonador = new();

        escalonador.AdicionarProcesso(1, 5);
        escalonador.AdicionarProcesso(2, 2);
        escalonador.AdicionarProcesso(3, 4);

        escalonador.Executar(2);
    }
}

//P2 termina em 4
//P3 termina em 10
//P1 termina em 11
