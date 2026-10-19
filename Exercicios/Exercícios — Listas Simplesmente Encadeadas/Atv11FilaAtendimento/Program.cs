using System;
namespace AtividadeOnze;

class Program 
{
    static void Main()
    {
        FilaAtendimento fila = new();

        fila.EmitirSenha(101);
        fila.EmitirSenha(102);
        fila.EmitirSenha(103);
        
        Console.WriteLine($"Senha chamada: {fila.ChamarProxima()}");
        Console.WriteLine($"Senha chamada: {fila.ChamarProxima()}");
        
        fila.EmitirSenha(104);
        
        Console.WriteLine($"Quantidade de senhas aguardando: {fila.QuantidadeAguardando()}");
    }
}