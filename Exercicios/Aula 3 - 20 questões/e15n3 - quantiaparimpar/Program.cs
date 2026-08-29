//saudades de declarar <stdio.h> e <stdlib.h>

int pares = 0;
int impares = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i}º número:");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        pares++; 
    }
    else
    {
        impares++; 
    }
}
Console.WriteLine($"\nTotal de números pares: {pares}");
Console.WriteLine($"Total de números ímpares: {impares}");