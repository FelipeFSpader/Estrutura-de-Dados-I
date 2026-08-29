int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número:");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nNo array:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Posição {i+1}: {numeros[i]}");
}