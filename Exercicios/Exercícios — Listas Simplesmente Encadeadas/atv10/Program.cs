using System;
namespace DezAtv;

public class Program
{
    static void Main()
    {
        ListaSimples lista = new();

        //insererir 5 valores
        lista.InserirNoFinal(10);
        lista.InserirNoFinal(20);
        lista.InserirNoFinal(30);
        lista.InserirNoFinal(40);
        lista.InserirNoInicio(5); // No início para testar

        //lista 
        lista.Listar(); //5 10 20 30 40
        Console.WriteLine($"Total de nós (Contar): {lista.Contar()}");

        //buscar 20 valor existente
        Console.WriteLine($"Achou o 20? {lista.Buscar(20)}");

        //remover valor int5ermediaro 
        lista.Remover(20);
        lista.Listar(); //5 10 30 40

        //inserir depois de no existtente
        lista.InserirDepoisDe(10, 25);
        lista.Listar(); //5 10 25 30 40

        //Consultar posição do 3 
        No res = lista.ObterPorPosicao(3);
        Console.WriteLine(res != null ? $"Valor na posição 3: {res.Valor}" : "Posição não encontrada"); // Esperado: 30

        //inverter lista 
        lista.Inverter();

        //resultado final 
        lista.Listar(); //40 30 25 10 5
        
        Console.WriteLine("\n" + ExibirComentarioTeorico());
    }

    static string ExibirComentarioTeorico()
    {
        return @"=== COMPARAÇÃO: LISTA ENCADEADA vs VETOR ===
* O vetor acessa dados instantaneamente, já a lista precisa percorrer nó por nó.
* O vetor tem tamanho fixo; para crescer, exige criar um novo vetor e copiar os dados. A lista cresce normalmente, alocando um novo nó na memória.
* No vetor, é preciso mover todos os elementos existentes uma posição para a frente quando inserir um elemento no início, já na lista, tem que instanciar o nó e ajustar dois ponteiros.
* No vetor, é preciso puxar todos os elementos uma posição para trás para fazer uma remoção no início, e na lista, o nó inicial apenas pula para o segundo nó";
    }
}