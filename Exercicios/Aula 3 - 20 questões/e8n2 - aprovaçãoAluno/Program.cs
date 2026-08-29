Console.WriteLine("Insira a primeira nota: ");
double nUm = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a segunda nota: ");
double nDois = double.Parse(Console.ReadLine());

double media = (nDois + nUm)/2;


if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media > 5 && media < 7)
{
    Console.WriteLine("Recuperação");
}
else{
    Console.WriteLine("Reprovado");
}

Console.Write($"A média do aluno foi: {media}");
