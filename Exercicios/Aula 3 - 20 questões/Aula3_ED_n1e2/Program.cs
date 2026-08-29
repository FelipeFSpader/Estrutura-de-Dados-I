Console.WriteLine("Qual seu nome");
string nome = Console.ReadLine();
Console.WriteLine("Qual sua idade?");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Onde mora?");
string cidade = Console.ReadLine();

Console.WriteLine("Prazer, eu sou " + nome + ", tenho " + idade + " anos e moro em " + cidade);