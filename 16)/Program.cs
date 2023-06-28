using System;

class Monitoria16
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma opção: ");
        Console.WriteLine("1 - de Celsius para Fahrenheit.");
        Console.WriteLine("2 - de Celsius para Kelvin.");
        Console.WriteLine("3 - de Fahrenheit para Celsius.");
        Console.WriteLine("4 - de Fahrenheit para Kelvin.");
        Console.WriteLine("5 - de Kelvin para Celsius");
        Console.WriteLine("6 - de Kelvin para Fahrenheit.");
        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite uma temperatura em Celsius: ");
                double temperatura1 = Convert.ToDouble(Console.ReadLine());
                double formula1 = (temperatura1 * 1.8) + 32;
                Console.WriteLine("Esta temperatura para Fahrenheit ficara: " + formula1);
                break;

            case 2:
                Console.WriteLine("Digite uma temperatura em Celsius: ");
                double temperatura2 = Convert.ToDouble(Console.ReadLine());
                double formula2 = temperatura2 + 273;
                Console.WriteLine("Esta temperatura para Kelvin ficara: " + formula2);
                break;

            case 3:
                Console.WriteLine("Digite uma temperatura em Farehrenheit: ");
                double temperatura3 = Convert.ToDouble(Console.ReadLine());
                double formula3 = (temperatura3 - 32) / 1.8;
                Console.WriteLine("Esta temperatura para Celsius ficara: " + formula3);
                break;

            case 4:
                Console.WriteLine("Digite uma temperatura em Farehrenheit: ");
                double temperatura4 = Convert.ToDouble(Console.ReadLine());
                double formula4 = (temperatura4 - 32) * (5 / 9) + 273;
                Console.WriteLine("Esta temperatura para Kelvin ficara: " + formula4);
                break;

            case 5:
                Console.WriteLine("Digite uma temperatura em Kelvin: ");
                double temperatura5 = Convert.ToDouble(Console.ReadLine());
                double formula5 = temperatura5 - 273;
                Console.WriteLine("Esta temperatura para Celsius ficara: " + formula5);
                break;

            case 6:
                Console.WriteLine("Digite uma temperatura em Kelvin: ");
                double temperatura6 = Convert.ToDouble(Console.ReadLine());
                double formula6 = (temperatura6 - 273) * 1.8 + 32;
                Console.WriteLine("Esta temperatura para Fahrenheit ficara: " + formula6);
                break;
        }


    }
}