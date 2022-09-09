using System;

namespace TypeCasting;

class Program
{
    static void Main()
    {
        
       int n = 10;
       double nd = n;

        Console.WriteLine(n);
        Console.WriteLine(nd);


        double mydouble = 9.78;
        int myint = (int) mydouble; 

        // trocar o double para inteiro e modificar o seu valor 
       Console.WriteLine(mydouble);
       Console.WriteLine(myint);

        Console.WriteLine(Convert.ToString(myint));
        Console.WriteLine(Convert.ToDouble(myint));
      

    }
}