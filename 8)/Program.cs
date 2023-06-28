using System;

class Monitoria8
{
    public static void Main(string[] args)
    {
        int numero = 0;
        Console.WriteLine("Digite o numero: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i < valor; i++)//CONSULTAR DIVISORES
        {
            if (valor % i == 0)//DIVISIVEL
            {
                numero = i + i;         
            }
        }

        if (numero == valor)
        {
            Console.WriteLine("Este numero é perfeito!");

        }
        else
        {
            Console.WriteLine("Este numero nao é perfeito!");
        }
    }
}