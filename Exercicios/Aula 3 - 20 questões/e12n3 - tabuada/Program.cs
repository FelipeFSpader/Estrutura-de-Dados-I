Console.WriteLine("Diga um número");
int nUm = int.Parse(Console.ReadLine());

for (int nMul = 1; nMul <= 10; nMul++)
{
    Console.WriteLine($"{nUm} x {nMul} = {nUm * nMul}");
}