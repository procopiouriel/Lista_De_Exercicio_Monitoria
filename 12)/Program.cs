using System;

class Monitoria12
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor inteiro: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(valor + " * " + i + " = " + valor * i);
        }
    }
}