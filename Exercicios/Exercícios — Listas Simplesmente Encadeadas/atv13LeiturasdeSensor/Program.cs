namespace AtividadeTreze;

public class Program
{
    static void Main()
    {
        ListaSimples LeiturasSensor = new();
        
        //22 23 22 25 23 23 26
        LeiturasSensor.InserirNoFinal(22);
        LeiturasSensor.InserirNoFinal(23);
        LeiturasSensor.InserirNoFinal(22);
        LeiturasSensor.InserirNoFinal(25);
        LeiturasSensor.InserirNoFinal(23);
        LeiturasSensor.InserirNoFinal(23);
        LeiturasSensor.InserirNoFinal(26);
        
        LeiturasSensor.RemoverDuplicados();
        LeiturasSensor.Exibir();
    }
}