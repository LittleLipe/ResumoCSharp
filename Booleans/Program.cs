//Muitas vezes, na programação, você precisará de um tipo de dados que só pode ter um de dois valores, como:
//SIM NÃO
//LIGADO DESLIGADO
//VERDADEIRO FALSO

//Para isso, o C# possui um booltipo de dados, que pode assumir os valores trueou false.

// Um tipo booleano é declarado com a palavra- boolchave e só pode receber os valores trueou false:

// Uma expressão booleana é uma expressão C# que retorna um valor booleano: Trueou False.

//Você pode usar um operador de comparação, como o operador maior que ( >) para descobrir se uma expressão (ou uma variável) é verdadeira:

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 10;
      int y = 9;
      Console.WriteLine(x > y); // returns True, because 10 is higher than 9
    }
  }
}