//Criar uma matriz
//Arrays são usados ​​para armazenar vários valores em uma única variável, em vez de declarar variáveis ​​separadas para cada valor.
//Para declarar um array, defina o tipo de variável com colchetes:

// string[] cars;
// Agora declaramos uma variável que contém um array de strings.
//Para inserir valores nele, podemos usar um literal de array - coloque os valores em uma lista separada por vírgulas, entre chaves:

//string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};


namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine(cars[1]);
    }
  }
}

