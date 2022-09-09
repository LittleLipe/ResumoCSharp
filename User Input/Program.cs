using System; 

namespace UserInput;

class Program 
{
    static void Main()
    {
        string nome;
        int idade;

        Console.WriteLine("Diga seu sobre nome Bill: \n");
        nome = Console.ReadLine();

        Console.WriteLine("Qual a sua idade filho do Bill? \n");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sobrenome do Bill " + nome + " e a idade do filho do Bill: " + idade);

    }
}