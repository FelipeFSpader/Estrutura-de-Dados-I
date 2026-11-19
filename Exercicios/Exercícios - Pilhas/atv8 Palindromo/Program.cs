namespace atv8_Palindromo;

public class Program
{
    static void Main()
    {
        Console.WriteLine(EhPalindromo("arara")); // True
        Console.WriteLine(EhPalindromo("Socorram me subi no onibus em Marrocos")); // True
        Console.WriteLine(EhPalindromo("arubaluba")); // False
    }
    
    static bool EhPalindromo(string texto)
    {
        Pilha palindromo = new();
        
        string limpo = texto.ToLower().Replace(" ", "");

        foreach (char c in limpo)
        {
            palindromo.Empilhar(c);
        }

        foreach (char c in limpo)
        {
            char topo = (char)palindromo.Desempilhar();
            if (c != topo)
                return false;
        }

        return true;
    }
}