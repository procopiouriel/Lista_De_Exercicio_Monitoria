using System;

class Monitoria10
{
    public static void Main(string[] args)
    {
        int par = 0;
        int impar = 0;

        Console.WriteLine("Digite 10 numeros inteiros: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int number3 = Convert.ToInt32(Console.ReadLine());
        int number4 = Convert.ToInt32(Console.ReadLine());
        int number5 = Convert.ToInt32(Console.ReadLine());
        int number6 = Convert.ToInt32(Console.ReadLine());
        int number7 = Convert.ToInt32(Console.ReadLine());
        int number8 = Convert.ToInt32(Console.ReadLine());
        int number9 = Convert.ToInt32(Console.ReadLine());
        int number10 = Convert.ToInt32(Console.ReadLine());

        if (number1 % 2 == 1)//IMPAR
        {
            impar++;
        }
        else
        {
            par++;
        }

        if (number2 % 2 == 1)
        {
            impar++;
        }
        else
        {
            par++;
        }

        if (number3 % 2 == 1)
        {
            impar++;
        }
        else
        {
            par++;
        }

        if (number4 % 2 == 1)
        {
            impar++;
        }
        else
        {
            par++;
        }

        if (number5 % 2 == 1)
        {
            impar++;
        }
        else
        {
            par++;
        }

        if (number6 % 2 == 1)
        {
            impar++;
        }
        else
        {
            par++;
        }

        if (number7 % 2 == 1)
        {
            impar++;
        }
        else
        {
            par++;
        }

        if (number8 % 2 == 1)
        {
            impar++;
        }
        else
        {
            par++;
        }

        if (number9 % 2 == 1)
        {
            impar++;
        }
        else
        {
            par++;
        }

        if (number10 % 2 == 1)
        {
            impar++;
        }
        else
        {
            par++;
        }
        Console.WriteLine("Possuem " + impar + " numeros impares!");
        Console.WriteLine("Possuem " + par + " numeros pares!");
    }
}