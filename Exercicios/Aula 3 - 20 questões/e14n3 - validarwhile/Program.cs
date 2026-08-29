Console.WriteLine("Diga um número entre 0 e 10:");
int nUm = int.Parse(Console.ReadLine());

while (nUm < 0 || nUm > 10)
{
    Console.WriteLine("Errado, repita");
    nUm = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Nota é {nUm}");