using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Monitoria18
{
    public static void Main(string[] args)
    {
        int[] arrayIdades = new int[10];
        double média = 0;
        int maior = 0;
        int menor = 0;

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            arrayIdades[i] = idade;
            média += idade;
        }

        int maiorNumero = arrayIdades[0]; // Suponha que o primeiro número é o maior inicialmente
        int menorNumero = arrayIdades[0]; // Suponha que o primeiro número é o maior inicialmente

        for (int i = 1; i < arrayIdades.Length; i++)
        {
            if (arrayIdades[i] > maiorNumero)
            {
                maiorNumero = arrayIdades[i];
            }
 
            else if (arrayIdades[i] < menorNumero)
            {
                menorNumero = arrayIdades[i];
            }
        }
        Console.WriteLine("Média: " + média / 10);
        Console.WriteLine("Maior numero: " + maiorNumero);
        Console.WriteLine("Menor numero: " + menorNumero);
    }
}