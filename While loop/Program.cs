//Os loops podem executar um bloco de código desde que uma condição especificada seja alcançada.

//Os loops são úteis porque economizam tempo, reduzem erros e tornam o código mais legível.


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      do 
      {
        Console.WriteLine(i);
        i++;
      }
      while (i < 5);
    }
  }
}