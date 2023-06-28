using System;

class monitoria4
{
    public static void Main(string[] args)
    {
        int soma = 0;
        Console.WriteLine("Insira um numero inteiro: ");
        string valor = Convert.ToString(Console.ReadLine());

        for(int i = 0; i < valor.Length; i++)
        {
        
            soma += Convert.ToInt32(valor[i].ToString());
        }
        Console.WriteLine("Soma: " + soma);
    }
}