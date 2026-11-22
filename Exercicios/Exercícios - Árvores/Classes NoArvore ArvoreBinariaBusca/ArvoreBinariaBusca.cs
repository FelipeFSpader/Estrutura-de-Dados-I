using System;
using System.Collections.Generic;
    
namespace Classes_NoArvore_ArvoreBinariaBusca;
public class ArvoreBinariaBusca
{
    private NoArvore? _raiz;
    public int Quantidade { get; private set; }

    private NoArvore InserirNaSubarvore(NoArvore? no, int valor)
    {
        if (no == null)
        {
            NoArvore novoNo = new NoArvore();
            novoNo.Valor = valor;
            Quantidade++;
            return novoNo;
        }
        if (valor < no.Valor)
        {
            no.Menor = InserirNaSubarvore(no.Menor, valor);
        }
        else if (valor > no.Valor)
        {
            no.Maior = InserirNaSubarvore(no.Maior, valor);
        }
        return no;
    }

    private bool ContemNaSubarvore(NoArvore? no, int valor)
    {
        if (no == null)
        {
            return false;
        }
        if (valor == no.Valor)
        {
            return true;
        }
        if (valor < no.Valor)
        {
            return ContemNaSubarvore(no.Menor, valor);
        }
        return ContemNaSubarvore(no.Maior, valor);
    }

    public bool Inserir(int valor)
    {
        int quantidadeAnterior = Quantidade;
        _raiz = InserirNaSubarvore(_raiz, valor);
        return Quantidade > quantidadeAnterior;
    }

    public bool Contem(int valor)
    {
        return ContemNaSubarvore(_raiz, valor);
    }

    public int BuscarMinimo()
    {
        if (_raiz == null)
        {
            throw new InvalidOperationException("A árvore está vazia.");
        }
        return BuscarMinimoNaSubarvore(_raiz);
    }

    private int BuscarMinimoNaSubarvore(NoArvore no)
    {
        if (no.Menor == null)
        {
            return no.Valor;
        }
        return BuscarMinimoNaSubarvore(no.Menor);
    }

    public int BuscarMaximo()
    {
        if (_raiz == null)
        {
            throw new InvalidOperationException("A árvore está vazia.");
        }
        return BuscarMaximoNaSubarvore(_raiz);
    }

    private int BuscarMaximoNaSubarvore(NoArvore no)
    {
        if (no.Maior == null)
        {
            return no.Valor;
        }
        return BuscarMaximoNaSubarvore(no.Maior);
    }

    public int ContarComparacoes(int valor)
    {
        return ContarComparacoesNaSubarvore(_raiz, valor);
    }

    private int ContarComparacoesNaSubarvore(NoArvore? no, int valor)
    {
        if (no == null)
        {
            return 0;
        }

        if (valor == no.Valor)
        {
            return 1;
        }

        if (valor < no.Valor)
        {
            return 1 + ContarComparacoesNaSubarvore(no.Menor, valor);
        }

        return 1 + ContarComparacoesNaSubarvore(no.Maior, valor);
    }

    public bool ContemSemRecursao(int valor)
    {
        NoArvore? atual = _raiz;
        while (atual != null)
        {
            if (valor == atual.Valor)
            {
                return true;
            }
            if (valor < atual.Valor)
            {
                atual = atual.Menor;
            }
            else
            {
                atual = atual.Maior;
            }
        }
        return false;
    }

    public int BuscarMaximoSemRecursao()
    {
        if (_raiz == null)
        {
            throw new InvalidOperationException("A árvore está vazia.");
        }

        NoArvore atual = _raiz;
        while (atual.Maior != null)
        {
            atual = atual.Maior;
        }

        return atual.Valor;
    }

    // Exercício 8

    // 1 - Percursos em profundidade
    public List<int> PercorrerPreOrdem()
    {
        List<int> resultado = new List<int>();
        PercorrerPreOrdemNaSubarvore(_raiz, resultado);
        return resultado;
    }

    private void PercorrerPreOrdemNaSubarvore(NoArvore? no, List<int> resultado)
    {
        if (no == null) return;
        resultado.Add(no.Valor);
        PercorrerPreOrdemNaSubarvore(no.Menor, resultado);
        PercorrerPreOrdemNaSubarvore(no.Maior, resultado);
    }

    public List<int> PercorrerEmOrdem()
    {
        List<int> resultado = new List<int>();
        PercorrerEmOrdemNaSubarvore(_raiz, resultado);
        return resultado;
    }

    private void PercorrerEmOrdemNaSubarvore(NoArvore? no, List<int> resultado)
    {
        if (no == null) return;
        PercorrerEmOrdemNaSubarvore(no.Menor, resultado);
        resultado.Add(no.Valor);
        PercorrerEmOrdemNaSubarvore(no.Maior, resultado);
    }

    public List<int> PercorrerPosOrdem()
    {
        List<int> resultado = new List<int>();
        PercorrerPosOrdemNaSubarvore(_raiz, resultado);
        return resultado;
    }

    private void PercorrerPosOrdemNaSubarvore(NoArvore? no, List<int> resultado)
    {
        if (no == null) return;
        PercorrerPosOrdemNaSubarvore(no.Menor, resultado);
        PercorrerPosOrdemNaSubarvore(no.Maior, resultado);
        resultado.Add(no.Valor);
    }

    // 2 - Altura e contagem de folhas
    public int CalcularAltura()
    {
        return CalcularAlturaNaSubarvore(_raiz);
    }

    private int CalcularAlturaNaSubarvore(NoArvore? no)
    {
        if (no == null)
        {
            return -1;
        }

        int alturaMenor = CalcularAlturaNaSubarvore(no.Menor);
        int alturaMaior = CalcularAlturaNaSubarvore(no.Maior);

        return 1 + Math.Max(alturaMenor, alturaMaior);
    }

    public int ContarFolhas()
    {
        return ContarFolhasNaSubarvore(_raiz);
    }

    private int ContarFolhasNaSubarvore(NoArvore? no)
    {
        if (no == null)
        {
            return 0;
        }

        if (no.Menor == null && no.Maior == null)
        {
            return 1;
        }

        return ContarFolhasNaSubarvore(no.Menor) + ContarFolhasNaSubarvore(no.Maior);
    }

    // 3 - Percurso em largura
    public List<int> PercorrerEmLargura()
    {
        List<int> resultado = new List<int>();
        if (_raiz == null)
        {
            return resultado;
        }

        Queue<NoArvore> fila = new Queue<NoArvore>();
        fila.Enqueue(_raiz);

        while (fila.Count > 0)
        {
            NoArvore atual = fila.Dequeue();
            resultado.Add(atual.Valor);

            if (atual.Menor != null)
            {
                fila.Enqueue(atual.Menor);
            }
            if (atual.Maior != null)
            {
                fila.Enqueue(atual.Maior);
            }
        }

        return resultado;
    }

    // 4 - Em ordem sem recursão
    public List<int> PercorrerEmOrdemSemRecursao()
    {
        List<int> resultado = new List<int>();
        Stack<NoArvore> pilha = new Stack<NoArvore>();
        NoArvore? atual = _raiz;

        while (atual != null || pilha.Count > 0)
        {
            while (atual != null)
            {
                pilha.Push(atual);
                atual = atual.Menor;
            }

            atual = pilha.Pop();
            resultado.Add(atual.Valor);
            atual = atual.Maior;
        }

        return resultado;
    }

    // Exercício 9

    // 1 - Remover
    public bool Remover(int valor)
    {
        int quantidadeAnterior = Quantidade;
        _raiz = RemoverNaSubarvore(_raiz, valor);
        return Quantidade < quantidadeAnterior;
    }

    private NoArvore? RemoverNaSubarvore(NoArvore? no, int valor)
    {
        if (no == null)
        {
            return null;
        }

        if (valor < no.Valor)
        {
            no.Menor = RemoverNaSubarvore(no.Menor, valor);
        }
        else if (valor > no.Valor)
        {
            no.Maior = RemoverNaSubarvore(no.Maior, valor);
        }
        else
        {
            if (no.Menor == null && no.Maior == null)
            {
                Quantidade--;
                return null;
            }

            if (no.Menor == null)
            {
                Quantidade--;
                return no.Maior;
            }

            if (no.Maior == null)
            {
                Quantidade--;
                return no.Menor;
            }

            NoArvore sucessor = EncontrarMenorNo(no.Maior);
            no.Valor = sucessor.Valor;
            no.Maior = RemoverNaSubarvore(no.Maior, sucessor.Valor);
        }

        return no;
    }

    private NoArvore EncontrarMenorNo(NoArvore no)
    {
        if (no.Menor == null)
        {
            return no;
        }
        return EncontrarMenorNo(no.Menor);
    }

    // 2 - Atualizar
    public bool Atualizar(int valorAtual, int novoValor)
    {
        if (!Contem(valorAtual) || Contem(novoValor))
        {
            return false;
        }

        Remover(valorAtual);
        return Inserir(novoValor);
    }

    // Exercício 10

    // 1 - Estritamente binária
    public bool EhEstritamenteBinaria()
    {
        return EhEstritamenteBinariaNaSubarvore(_raiz);
    }

    private bool EhEstritamenteBinariaNaSubarvore(NoArvore? no)
    {
        if (no == null)
        {
            return true;
        }

        if ((no.Menor == null) != (no.Maior == null))
        {
            return false;
        }

        return EhEstritamenteBinariaNaSubarvore(no.Menor) && EhEstritamenteBinariaNaSubarvore(no.Maior);
    }

    // 2 - Completa
    public bool EstaCompleta()
    {
        int altura = CalcularAltura();
        return EstaCompletaNaSubarvore(_raiz, 0, altura);
    }

    private bool EstaCompletaNaSubarvore(NoArvore? no, int nivel, int altura)
    {
        if (no == null)
        {
            return true;
        }

        if ((no.Menor == null || no.Maior == null) && nivel < altura - 1)
        {
            return false;
        }

        return EstaCompletaNaSubarvore(no.Menor, nivel + 1, altura) &&
               EstaCompletaNaSubarvore(no.Maior, nivel + 1, altura);
    }

    // 3 - Balanceada
    public bool EstaBalanceada()
    {
        return EstaBalanceadaNaSubarvore(_raiz);
    }

    private bool EstaBalanceadaNaSubarvore(NoArvore? no)
    {
        if (no == null)
        {
            return true;
        }

        int fb = CalcularAlturaNaSubarvore(no.Menor) - CalcularAlturaNaSubarvore(no.Maior);
        if (fb < -1 || fb > 1)
        {
            return false;
        }

        return EstaBalanceadaNaSubarvore(no.Menor) && EstaBalanceadaNaSubarvore(no.Maior);
    }
}