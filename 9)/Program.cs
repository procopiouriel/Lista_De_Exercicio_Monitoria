using System;

class Monitoria9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual o peso do peixe?: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        if (peso > 50)
        {
            double excedente = peso - 50;
            double multa = excedente * 4;
            Console.WriteLine("Foi ultrapassado " + excedente + "kg do permitido");
            Console.WriteLine("Valor multa: " + multa.ToString("C2"));

        }
        else
        {
            Console.WriteLine("Nao precisara pagar a multa!");
        }
    }
}