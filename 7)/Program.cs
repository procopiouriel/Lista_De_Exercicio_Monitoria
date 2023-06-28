using System;

class Monitoria7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor total do notebook: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        double desconto = (valor * 6) / 100;
        double vista2 = valor - desconto;
        Console.WriteLine(vista2.ToString("C2") +  " a vista");

        double parcelado2 = valor / 2;
        double parcelado3 = valor / 3;

        double juros = (valor * 5) / 100;
        double juros2 = valor + juros;
        double parcelado4 = juros2 / 4;
        double parcelado5 = juros2 / 5;
        double parcelado6 = juros2 / 6;
        double parcelado7 = juros2 / 7;
        double parcelado8 = juros2 / 8;
        double parcelado9 = juros2 / 9;
        double parcelado10 = juros2 / 10;
        double parcelado11 = juros2 / 11;
        double parcelado12 = juros2 / 12;

        Console.WriteLine(" 2 vezes de " + parcelado2.ToString("C2") + " Total: " + valor.ToString("C2"));
        Console.WriteLine(" 3 vezes de " + parcelado3.ToString("C2") + " Total: " + valor.ToString("C2"));
        Console.WriteLine(" 4 vezes de " + parcelado4.ToString("C2") + " Total: " + juros2.ToString("C2"));
        Console.WriteLine(" 5 vezes de " + parcelado5.ToString("C2") + " Total: " + juros2.ToString("C2"));
        Console.WriteLine(" 6 vezes de " + parcelado6.ToString("C2") + " Total: " + juros2.ToString("C2"));
        Console.WriteLine(" 7 vezes de " + parcelado7.ToString("C2") + " Total: " + juros2.ToString("C2"));
        Console.WriteLine(" 8 vezes de " + parcelado8.ToString("C2") + " Total: " + juros2.ToString("C2"));
        Console.WriteLine(" 9 vezes de " + parcelado9.ToString("C2") + " Total: " + juros2.ToString("C2"));
        Console.WriteLine(" 10 vezes de " + parcelado10.ToString("C2") + " Total: " + juros2.ToString("C2"));
        Console.WriteLine(" 11 vezes de " + parcelado11.ToString("C2") + " Total: " + juros2.ToString("C2"));
        Console.WriteLine(" 12 vezes de " + parcelado12.ToString("C2") + " Total: " + juros2.ToString("C2"));
    }
}