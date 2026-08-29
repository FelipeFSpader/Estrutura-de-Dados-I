Console.WriteLine("Diga um número");
double nUm = double.Parse(Console.ReadLine());

Console.WriteLine($"Diga um número para fazer operações com {nUm}");
double nDois = double.Parse(Console.ReadLine());

double soma = nUm + nDois;
double sub = nUm - nDois;
double mul = nUm * nDois;
double div = nUm / nDois;
Console.WriteLine($"A soma de {nUm} e {nDois} é: {soma}\nA subtração de {nUm} por {nDois} é: {sub}\nA multiplicação de {nUm} e {nDois} é: {mul}\nA divisão de {nUm} por {nDois} é: {div}");