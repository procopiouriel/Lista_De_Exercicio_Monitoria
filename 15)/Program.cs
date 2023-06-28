using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Monitoria15
{
    public static void Main(string[] args)
    {
        int fatorial = 0;

        Console.WriteLine("Informe o número");
        int numero = Convert.ToInt32(Console.ReadLine());

        fatorial = numero;

        for (int i = numero - 1; i >= 1; i--)
        {
            fatorial = fatorial * i;
        }
        Console.WriteLine(numero + "! = " + fatorial);
    }
}