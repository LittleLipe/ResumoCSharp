// Uma stringvariável contém uma coleção de caracteres entre aspas duplas:
// Crie uma variável do tipo stringe atribua um valor a ela: string greeting = "Hello";
// Uma string em C# é na verdade um objeto, que contém propriedades e métodos que podem realizar certas operações em strings. Por exemplo, o comprimento de uma string pode ser encontrado com a Lengthpropriedade:
// string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
// Console.WriteLine("The length of the txt string is: " + txt.Length);



using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string firstName = "John ";
      string lastName = "Doe";
      string name = string.Concat(firstName, lastName);
      Console.WriteLine(name);
    }
  }
}
