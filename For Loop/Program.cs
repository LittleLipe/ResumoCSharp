//Quando você souber exatamente quantas vezes deseja percorrer um bloco de código, use o forloop em vez de um whileloop:
//for (statement 1; statement 2; statement 3) 
//{
  // code block to be executed
//}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 2; i < 5; i++) 
      {
        Console.WriteLine(i);
      }    
    }
  }
}