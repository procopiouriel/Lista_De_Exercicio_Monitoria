using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());


        int a = 0;
        int b = 1;

        while (a <= numero)
        {
            Console.WriteLine(a);

            int auxiliar = a;
            a = b;
            b = auxiliar + b;
        }
    }
}
 
