using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número");
        int nUm = int.Parse(Console.ReadLine());

            int resultado = CalcularDobro(nUm);

        Console.WriteLine($"O dobro de {nUm} é {resultado}");
    }
    static int CalcularDobro(int nDois)
    {
        return nDois * 2;
    }
}