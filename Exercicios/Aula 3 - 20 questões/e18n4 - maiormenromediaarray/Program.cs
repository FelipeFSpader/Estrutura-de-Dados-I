double[] numeros = new double[8];

for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número:");
    numeros[i] = double.Parse(Console.ReadLine());
}

double maior = numeros[0];
double menor = numeros[0];
double soma = 0;

for (int i = 0; i < 8; i++)
{
    soma += numeros[i];

    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }

    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

double media = soma / 8;

Console.WriteLine($"\nMaior valor: {maior}");
Console.WriteLine($"Menor valor: {menor}");
Console.WriteLine($"Média dos valores: {media}");