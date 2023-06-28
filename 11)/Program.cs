using System;

class Monitoria11
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite sua data de nascimento: ");
        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
        DateTime dataAtual = DateTime.Today;

        int dataNascimento1 = Convert.ToInt32(dataNascimento.ToString("yyyyMMdd"));
        int dataAtual1 = Convert.ToInt32(dataAtual.ToString("yyyyMMdd"));

        int idade = (dataAtual1 - dataNascimento1) / 10000;
        Console.WriteLine("Idade = " + idade);
    }
}