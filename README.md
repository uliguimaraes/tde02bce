# tde02bce: Calculadora Aritmética em C#

> Um exercício de entrada, conversão e operações matemáticas básicas no terminal.

## Visão geral

O **tde02bce** solicita dois números ao usuário e calcula soma, subtração, multiplicação e divisão. O projeto é simples, mas importante: ele treina leitura de dados com `Console.ReadLine()`, conversão com `Convert.ToDouble()` e diferentes formas de montar mensagens de saída em C#.[1]

| Operação | Expressão usada |
|---|---|
| Soma | `numero_1 + numero_2` |
| Subtração | `numero_1 - numero_2` |
| Multiplicação | `numero_1 * numero_2` |
| Divisão | `numero_1 / numero_2` |

## Como executar

```bash
git clone https://github.com/uliguimaraes/tde02bce.git
cd tde02bce
dotnet run
```

## Sugestões de evolução

Uma próxima versão poderia tratar divisão por zero, aceitar operações em menu, repetir cálculos até o usuário sair e separar cada operação em uma função.

## Referências

[1]: https://learn.microsoft.com/dotnet/csharp/ "C# documentation"
