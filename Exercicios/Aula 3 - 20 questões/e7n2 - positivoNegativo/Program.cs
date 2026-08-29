Console.WriteLine("diga um número");
int nUm = int.Parse(Console.ReadLine());

if (nUm > 0)
{
    Console.WriteLine("Número positivo");
}
else if (nUm < 0)
{
    Console.WriteLine("Número negativo");
}
else{
    Console.WriteLine("É zero");
}

