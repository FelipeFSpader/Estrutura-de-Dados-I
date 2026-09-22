using System;
namespace TerceiraaAtv;
    class Program 
    {
        static void Main()
        {

            ListaSimples ListaUm = new();
            ListaUm.InserirNoFinal(10);
            ListaUm.InserirNoFinal(20);
            ListaUm.InserirNoFinal(30);

            Console.Write("A lista é: ");
            ListaUm.Exibir();

            int total = ListaUm.Contar();

            Console.WriteLine($"Resultado esperado: {total}");
        }
    }