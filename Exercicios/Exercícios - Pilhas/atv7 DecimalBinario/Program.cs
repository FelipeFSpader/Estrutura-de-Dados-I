namespace atv7_DecimalBinario;

public class Program
{
    static void Main()
    {
        Console.WriteLine($"13 -> {ConverterParaBinario(13)}"); //1101
        Console.WriteLine($"8  -> {ConverterParaBinario(8)}");  //1000
        Console.WriteLine($"0  -> {ConverterParaBinario(0)}");  //0
    }
    
    static string ConverterParaBinario(int numero)
    {
        if (numero == 0)
            return "0";

        Pilha pilhaBinarios = new();
        
        while (numero > 0)
        {
            int restoDivisao = numero % 2;
            pilhaBinarios.Empilhar(restoDivisao);
            numero = numero / 2;
        }

        string resultado = "";
        while (!pilhaBinarios.EstaVazia())
        {
            resultado += pilhaBinarios.Desempilhar();
        }

        return resultado;
    }
} 
