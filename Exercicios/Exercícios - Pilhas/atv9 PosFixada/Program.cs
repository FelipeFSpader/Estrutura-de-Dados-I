namespace atv9_PosFixada;
using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine($"5 3 + 2 *         -> {AvaliarPosFixada("5 3 + 2 *")}");         // 16
        Console.WriteLine($"4 2 - 3 *         -> {AvaliarPosFixada("4 2 - 3 *")}");         // 6
        Console.WriteLine($"10 2 8 * + 3 -    -> {AvaliarPosFixada("10 2 8 * + 3 -")}");    // 23
    }

    static int AvaliarPosFixada(string expressao)
    {
        Pilha pilha = new();
        string numeroAtual = "";

        foreach (char c in expressao)
        {
            if (char.IsDigit(c))
            {
                // Vai juntando os dígitos 1 e 0 vira 10
                numeroAtual += c;
            }
            else if (c == ' ')
            {
                if (numeroAtual != "")
                {
                    pilha.Empilhar(int.Parse(numeroAtual));
                    numeroAtual = "";
                }
            }
            else if (c == '+' || c == '-' || c == '*' || c == '/')
            {
                if (numeroAtual != "")
                {
                    pilha.Empilhar(int.Parse(numeroAtual));
                    numeroAtual = "";
                }

                if (pilha.Quantidade < 2)
                    throw new ArgumentException("Expressão inválida: faltam operandos.");

                int direita = pilha.Desempilhar();
                int esquerda = pilha.Desempilhar();

                int resultado = c switch
                {
                    '+' => esquerda + direita,
                    '-' => esquerda - direita,
                    '*' => esquerda * direita,
                    '/' => direita == 0 
                            ? throw new DivideByZeroException("Divisão por zero.") 
                            : esquerda / direita,
                    _ => 0
                };

                pilha.Empilhar(resultado);
            }
            else
            {
                throw new ArgumentException($"Caractere inválido na expressão: '{c}'");
            }
        }

        if (numeroAtual != "")
        {
            pilha.Empilhar(int.Parse(numeroAtual));
        }

        if (pilha.Quantidade != 1)
            throw new ArgumentException("Expressão inválida: sobraram operandos sem operador.");

        return pilha.Desempilhar();
    }
}