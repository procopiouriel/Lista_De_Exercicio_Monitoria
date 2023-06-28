using System;

class Monitoria14
{
    public static void Main(string[] args)
    {
        int contador = 0;
        Console.WriteLine("Digite um valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= valor; i++)
        {
            if (valor % i == 0)//DIVISIVEL
            {
                contador++;
                Console.WriteLine(valor + " é divisivel por " + i);
            }
        }
        Console.WriteLine("Quantidade de divisores: " + contador);

    }
}