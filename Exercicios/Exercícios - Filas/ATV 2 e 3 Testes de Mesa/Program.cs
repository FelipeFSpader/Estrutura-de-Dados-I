/*

ATIVIDADE DOIS

Enfileirar(10)
inicio fim
 |      |
 v      |
 10 <----

Desenfileirar()
inicio fim
nulo

Enfileirar(20)
inicio fim
 |      |
 v      |
 20 <----

Enfileirar(30)
inicio    fim
 |         |
 v         v
 20        30

Desenfileirar()
retorna 20
inicio fim
 |      |
 v      |
 30 <----

*/

/*
public int Desenfileirar()
{
    if (_inicio == null)
        throw new InvalidOperationException("A fila está vazia.");
    int valor = _inicio.Valor;
    _inicio = _inicio.Proximo;
    
    Quantidade--;
    return valor;
}

public void Enfileirar(int valor)
{
    No novoNo = new No();
    novoNo.Valor = valor;
    if (_fim == null) //caga aqui, fim não é nulo, vai ficar sujo com o 10
    {
        _inicio = novoNo;
        _fim = novoNo;
    }
    else
    {
        _fim.Proximo = novoNo;
        _fim = novoNo;
    }
    Quantidade++;
}

*/



/*

Enfileirar(10)
inicio fim
 |      |
 v      |
 10 <----

Desenfileirar() fim não limpa, continua mirado no dez

inicio fim
 |      |
 v      v
nulo    10


Enfileirar(20) Quebra aqui

inicio fim fim.proximo
 |      |      |
 v      v      v
nulo    10 --> 20

*/




/*
ATIVIDADE 3

Enfileirar(5)                            5
Enfileirar(8)                            58
Desenfileirar()                          8          Retorna 5
Enfileirar(3)                            83
Enfileirar(9)                            839
ConsultarFrente()                        839        Retorna 8
Desenfileirar()                          39         Retorna 8
Desenfileirar()                          9          Retorna 3
Enfileirar(7)                            97

*/