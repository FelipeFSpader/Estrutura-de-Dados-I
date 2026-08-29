Console.WriteLine("Idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Habilitação? [S][N] ");
string hab = Console.ReadLine();


if (idade >= 18 && hab=="S")
{
    Console.WriteLine("Pode dirijir");
}
else 
{
    Console.WriteLine("Não pode dirigir");
}
