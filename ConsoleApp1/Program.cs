using System;

class monitoria
{
    static void Main(string[] args)
    {
        Console.WriteLine("Coloque o primeiro valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Coloque o segundo valor: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Coloque o terceiro valor: ");
        double valor3 = Convert.ToDouble(Console.ReadLine());

        if (valor1 > valor2 && valor1 > valor3)
        {
            if (valor2 > valor3)
            {
                Console.WriteLine(valor3 + "\n" + valor2 + "\n" + valor1);
            }
            else if (valor2 < valor3)
            {
                Console.WriteLine(valor2 + "\n" + valor3 + "\n" + valor1);
            }
        }
        else if (valor2 > valor1 && valor2 > valor3)
        {
            if (valor1 > valor3)
            {
                Console.WriteLine(valor3 + "\n" + valor1 + "\n" + valor2);
            }
            else if (valor1 < valor3)
            {
                Console.WriteLine(valor1 + "\n" + valor3 + "\n" + valor2);
            }
        }
        else if (valor3 > valor1 && valor3 > valor2)
        {
            if (valor1 > valor2)
            {
                Console.WriteLine(valor2 + "\n" + valor1 + "\n" + valor3);
            }
            else if (valor1 < valor2)
            {
                Console.WriteLine(valor1 + "\n" + valor2 + "\n" + valor3);
            }
        }
    }
}