// Você já viu a breakinstrução usada em um capítulo anterior deste tutorial. Foi usado para "saltar" de uma switchdeclaração.

// A breakinstrução também pode ser usada para sair de um loop .

// Este exemplo salta para fora do loop quando ié igual a 4:



namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++) 
      {
        if (i == 4) 
        {
          break;
        }
        Console.WriteLine(i);
      }    
    }
  }
}