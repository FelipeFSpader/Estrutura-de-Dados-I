using System;
namespace QuartaAtv;

public class Program
{
    static void Main()
    {
        ListaSimples listaBuscar = new();

        listaBuscar.InserirNoFinal(10);
        listaBuscar.InserirNoFinal(20);
        listaBuscar.InserirNoFinal(30);

        //no meio 
        No resultado = listaBuscar.Buscar(20);

        if (resultado != null)
        {
            Console.WriteLine($"Valor encontrado: {resultado.Valor}");
        }
        else
        {
            Console.WriteLine("Valor não encontrado.");
        }

        //no inicio
        //  No resultado = listaBuscar.Buscar(10);
        //  
        //  if (resultado != null)
        //  {
        //      Console.WriteLine($"Valor encontrado: {resultado.Valor}");
        //  }
        //  else
        //  {
        //      Console.WriteLine("Valor não encontrado.");
        //  }
        //  
        //no fim
        //  No resultado = listaBuscar.Buscar(30);
        //  
        //  if (resultado != null)
        //  {
        //      Console.WriteLine($"Valor encontrado: {resultado.Valor}");
        //  }
        //  else
        //  {
        //      Console.WriteLine("Valor não encontrado.");
        //  }
        //  
        //inexistente 
        //  No resultado = listaBuscar.Buscar(100);
        //  
        //  if (resultado != null)
        //  {
        //      Console.WriteLine($"Valor encontrado: {resultado.Valor}");
        //  }
        //  else
        //  {
        //      Console.WriteLine("Valor não encontrado.");
        //  }


    }
}