using System;
class Program
{
    static void Main()
    {
        
        string[] nomes = new string[5];
        double[] medias = new double[5];

        double somaMediasTurma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Cadastro do Aluno {i + 1} ---");
            
            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine();

            Console.Write("1ª nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("2ª nota: ");
            double n2 = double.Parse(Console.ReadLine());

            medias[i] = CalcularMedia(n1, n2);
            somaMediasTurma += medias[i];

            Console.WriteLine();
        }

        Console.WriteLine("BOLETIM DA TURMA");

        for (int i = 0; i < 5; i++)
        {
            string situacao = ObterSituacao(medias[i]);

            Console.WriteLine($"Aluno: {nomes[i]} | Média: {medias[i]} | Situação: {situacao}");
        }

       double mediaGeral = somaMediasTurma / 5;
        Console.WriteLine($"\nMédia Geral da Turma: {mediaGeral}");
    }
    static double CalcularMedia(double nota1, double nota2)
    {
        return (nota1 + nota2) / 2;
    }
    static string ObterSituacao(double media)
    {
        if (media >= 7.0)
        {
            return "Aprovado";
        }
        else if (media >= 5.0)
        {
            return "Recuperação";
        }
        else
        {
            return "Reprovado";
        }
    }
}