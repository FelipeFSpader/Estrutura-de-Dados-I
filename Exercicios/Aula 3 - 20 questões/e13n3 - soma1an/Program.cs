Console.WriteLine("Diga um número: ");
int n = int.Parse(Console.ReadLine());

int soma = 0;

for (int i = 1; i <= n; i++)
{
    soma += i;
}

Console.WriteLine($"soma de 1 até {n} é: {soma}");