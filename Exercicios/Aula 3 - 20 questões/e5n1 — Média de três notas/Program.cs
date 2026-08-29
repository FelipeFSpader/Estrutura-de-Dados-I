Console.WriteLine("Diga um número");
double nUm = double.Parse(Console.ReadLine());

Console.WriteLine("Diga um segundo número");
double nDois = double.Parse(Console.ReadLine());

Console.WriteLine("Diga um terceiro número");
double nTres = double.Parse(Console.ReadLine());

double soma = nUm + nDois + nTres;
double media = soma / 3;

Console.WriteLine($"A média dos números é: {media:F1}");