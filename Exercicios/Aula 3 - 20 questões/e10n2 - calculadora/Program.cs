Console.WriteLine("Diga um número");
double nUm = double.Parse(Console.ReadLine());

Console.WriteLine("Diga o operador que quer usar");
Console.WriteLine("1.Somar +\n2.Subtrair -\n3.Multiplicar *\n4.Dividir /");
char operador = char.Parse(Console.ReadLine());

Console.WriteLine($"Diga um número para fazer operações com {nUm}");
double nDois = double.Parse(Console.ReadLine());

switch (operador)
{

    case '+':
        double soma = nUm + nDois;
        Console.WriteLine($"A soma dos números é {soma}");
        break;

    case '-':
        double sub = nUm - nDois;
        Console.WriteLine($"A subtração dos números é {sub}");
        break;

    case '*':
        double mul = nUm * nDois;
        Console.WriteLine($"A multiplicação dos números é {mul}");
        break;

    case '/':
        if (nDois == 0)
        {
            Console.WriteLine("Não dá pra dividir por 0");    
        }
        else
        {
        double div = nUm / nDois;
        Console.WriteLine($"A divisão dos números é {div}");
        }
        break;
        

    default:
    Console.WriteLine("Inválido");
    break;

}