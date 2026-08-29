using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a média: ");
        double mediaAluno = double.Parse(Console.ReadLine());

        bool aprovado = EstaAprovado(mediaAluno);
        
        if (aprovado)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
    static bool EstaAprovado(double media)
    {
        if (media >= 7.0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}